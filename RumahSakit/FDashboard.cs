using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class FDashboard : Form
    {
        public FDashboard()
        {
            InitializeComponent();
        }

        void FDashboard_Load(object sender, EventArgs e)
        {
            locked = true;
            TampilIdPerawatan();
            TampilDGVLog();
            tNama.Text = info.Nama;
            tAlamat.Text = info.Alamat;
            tTelepon.Text = info.Telepon;
            tFax.Text = info.Fax;
            tEmail.Text = info.Email;
            tWebsite.Text = info.Website;
            tPengurus.Text = info.Pengurus;
            tJabatan.Text = info.Jabatan;
            lblUserAktif.Text = userAktif;
            cbTampilId.Checked = IVal(GetReg("IsShowingId")) == 1;
            cbSimpanResolusi.Checked = IVal(GetReg("IsSavingResolution")) == 1;
            if (userAktif.Cari("admin"))
            {
                btnBackupDatabase.Visible = true;
                btnHapusPerawatan.Visible = true;
                tNama.ReadOnly = false;
                tAlamat.ReadOnly = false;
                tTelepon.ReadOnly = false;
                tFax.ReadOnly = false;
                tEmail.ReadOnly = false;
                tWebsite.ReadOnly = false;
                tPengurus.ReadOnly = false;
                tJabatan.ReadOnly = false;
            }
            else
            {
                btnBackupDatabase.Visible = false;
                btnHapusPerawatan.Visible = false;
                tNama.ReadOnly = true;
                tAlamat.ReadOnly = true;
                tTelepon.ReadOnly = true;
                tFax.ReadOnly = true;
                tEmail.ReadOnly = true;
                tWebsite.ReadOnly = true;
                tPengurus.ReadOnly = true;
                tJabatan.ReadOnly = true;
            }
            chart1.DataSource = dSRumahSakit.Bagan;
            da = new OleDbDataAdapter("SELECT COUNT(TanggalMasuk) AS [Hitung], TanggalMasuk FROM Perawatan WHERE TanggalMasuk BETWEEN #" + SVal(DateTime.Today, "M/d/yyyy") + "# AND #" + SVal(DateTime.Today.AddDays(-6), "M/d/yyyy") + "# GROUP BY TanggalMasuk", conn);
            da.Fill(dSRumahSakit.Bagan);
            DateTime dasar = new DateTime(1899, 12, 30);
            chart1.ChartAreas[0].AxisX.Minimum = DVal(DateTime.Today.AddDays(-6).Subtract(dasar).Days);
            chart1.ChartAreas[0].AxisX.Maximum = DVal(DateTime.Today.Subtract(dasar).Days);
            locked = false;
        }

        void FDashboard_Resize(object sender, EventArgs e)
        {
            panelDGVLogPagination.Location = new Point(3 + (dgvLog.Width / 2) - 100, 32 + dgvLog.Height);
        }

        void TampilIdPerawatan()
        {
            tIdPerawatan.Items.Clear();
            tIdPerawatan.Items.AddRange((from x in daftarPerawatan orderby x.TanggalMasuk descending select x.IdPerawatan).ToArray());
        }

        void SimpanInfo(object sender, EventArgs e)
        {
            if (locked) return;
            QN("UPDATE Info SET Nama = '" + tNama.Text + "', Alamat = '" + tAlamat.Text + "', Telepon = '" + tTelepon.Text + "', Fax = '" + tFax.Text + "', Email = '" + tEmail.Text + "', Website = '" + tWebsite.Text + "', Pengurus = '" + tPengurus.Text + "', Jabatan = '" + tJabatan.Text + "'");
            info.Nama = tNama.Text;
            info.Alamat = tAlamat.Text;
            info.Telepon = tTelepon.Text;
            info.Fax = tFax.Text;
            info.Email = tEmail.Text;
            info.Website = tWebsite.Text;
            info.Pengurus = tPengurus.Text;
            info.Jabatan = tJabatan.Text;
        }

        void TampilRiwayat(object sender, EventArgs e)
        {
            if (locked) return;
            var result = (from v in daftarPerawatan
                          join w in daftarPasien on v.IdPasien equals w.IdPasien
                          join x in daftarKamarDetail on v.IdPerawatan equals x.IdPerawatan
                          join y in daftarKamar on x.NoKamar equals y.NoKamar
                          where v.IdPerawatan == tIdPerawatan.Text
                          select new
                          {
                              NamaPasien = w.Nama,
                              NamaKamar = y.Nama,
                              v.TanggalMasuk,
                              v.TanggalKeluar,
                              v.Diagnosis,
                              v.TotalBiaya
                          }).FirstOrDefault();
            tNamaPasien.Text = ": " + result.NamaPasien;
            tNamaKamar.Text = ": " + result.NamaKamar;
            tTanggal.Text = ": " + SVal(result.TanggalMasuk, "d MMMM yyyy") + " → " + SVal(result.TanggalKeluar, "d MMMM yyyy");
            tDiagnosis.Text = ": " + result.Diagnosis;
            tTotalBiaya.Text = ": " + SVal(result.TotalBiaya, "c0");
        }

        void BTNGantiPassword_Click(object sender, EventArgs e)
        {
            var Confirm = new Konfirmasi("Masukan password lama dan password baru.", string.Empty, 1, Konfirmasi.Jenis.ChangePassword);
            Confirm.ShowDialog();
        }

        void BTNBackupDatabase_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "RumahSakit" + SVal(DateTime.Today, "yyMMdd") + ".accdb";
            saveFileDialog1.Filter = "Microsoft Access 2007 - 2016(*.accdb)|*.accdb";
            saveFileDialog1.FilterIndex = 1;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Copy(Application.StartupPath + @"\RumahSakit.accdb", saveFileDialog1.FileName, true);
                Pesan("Database berhasil dibackup", Notifikasi.Jenis.Berhasil);
            }
        }

        void BTNHapusPerawatan_Click(object sender, EventArgs e)
        {
            var Confirm = new Konfirmasi("Konfirmasi", "Hapus semua data perawatan dan log user?", 1);
            if (userAktif.Cari("admin") && Confirm.ShowDialog() == DialogResult.Yes)
            {
                QN("DELETE FROM Perawatan");
                daftarPerawatan.Clear();
                daftarAlatDetail.Clear();
                daftarTindakanDetail.Clear();
                daftarKamarDetail.Clear();
                daftarObatDetail.Clear();
                daftarDokterDetail.Clear();
                daftarPembayaran.Clear();
                QN("DELETE FROM LogUser");
                daftarLogUser.Clear();
                QN("UPDATE Pasien SET Status = '-'");
                foreach (Pasien pasien in daftarPasien) pasien.Status = "-";
                QN("UPDATE Kamar SET Isi = 0");
                foreach (Kamar kamar in daftarKamar) kamar.Isi = 0;
                Pesan("Semua data perawatan berhasil dihapus", Notifikasi.Jenis.Berhasil);
                tIdPerawatan.Items.Clear();
                tNamaPasien.Clear();
                tNamaKamar.Clear();
                tTanggal.Clear();
                tDiagnosis.Clear();
                tTotalBiaya.Clear();
                TampilDGVLog();
                chart1.Dispose();
            }
        }

        void CBTampilId_CheckedChanged(object sender, EventArgs e)
        {
            SetReg("IsShowingId", cbTampilId.Checked ? 1 : 0);
            isShowingId = cbTampilId.Checked;
        }

        void CBSimpanResolusi_CheckedChanged(object sender, EventArgs e)
        {
            SetReg("IsSavingResolution", cbSimpanResolusi.Checked ? 1 : 0);
            isSavingResolution = cbSimpanResolusi.Checked;
        }

        void LBLAuthor_Click(object sender, EventArgs e)
        {
            Process.Start("https://api.whatsapp.com/send?phone=6285739194810");
        }

        #region DGVLog
        IEnumerable<LogUser> rowsLog;
        int currentPageLog = 1;
        const int maxRowsLog = 6;

        void TampilDGVLog()
        {
            rowsLog = from x in daftarLogUser orderby x.Tanggal descending select x;
            PagingLog();
        }

        void PagingLog()
        {
            dgvLog.Rows.Clear();
            dgvLogPageCounter.Text = $"{currentPageLog} / {(rowsLog.Count() <= maxRowsLog ? 1 : Math.Ceiling(rowsLog.Count() / DVal(maxRowsLog)))}";
            if (currentPageLog == 1)
            {
                dgvLogPrev.Enabled = false;
                dgvLogFirst.Enabled = false;
            }
            else
            {
                dgvLogPrev.Enabled = true;
                dgvLogFirst.Enabled = true;
            }
            if (currentPageLog >= Math.Ceiling(rowsLog.Count() / DVal(maxRowsLog)))
            {
                dgvLogNext.Enabled = false;
                dgvLogLast.Enabled = false;
            }
            else
            {
                dgvLogNext.Enabled = true;
                dgvLogLast.Enabled = true;
            }
            if (!rowsLog.Any()) return;
            if (rowsLog.Count() % maxRowsLog == 0 && currentPageLog > 1 && currentPageLog > Math.Ceiling(rowsLog.Count() / DVal(maxRowsLog))) dgvLogPrev.PerformClick();
            foreach (LogUser x in rowsLog.Skip((currentPageLog - 1) * maxRowsLog).Take(maxRowsLog)) dgvLog.Rows.Add(x.Username, x.Tanggal, x.Catatan);
        }

        void DGVLogFirst_Click(object sender, EventArgs e)
        {
            currentPageLog = 1;
            PagingLog();
        }

        void DGVLogPrev_Click(object sender, EventArgs e)
        {
            currentPageLog--;
            PagingLog();
        }

        void DGVLogPageCounter_Click(object sender, EventArgs e)
        {
            if (Math.Ceiling(rowsLog.Count() / DVal(maxRowsLog)) <= 1d) return;
            GoToPageNumber(rowsLog.Count(), maxRowsLog, ref currentPageLog);
            PagingLog();
        }

        void DGVLogNext_Click(object sender, EventArgs e)
        {
            currentPageLog++;
            PagingLog();
        }

        void DGVLogLast_Click(object sender, EventArgs e)
        {
            currentPageLog = IVal(Math.Ceiling(rowsLog.Count() / DVal(maxRowsLog)));
            PagingLog();
        }
        #endregion
    }
}
