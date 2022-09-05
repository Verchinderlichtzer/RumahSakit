using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class FRegistrasi : Form
    {
        bool dataBaru;
        Perawatan perawatan;
        Kamar kamar;
        Pasien pasien;

        public FRegistrasi()
        {
            InitializeComponent();
        }

        #region Form
        void Notis()
        {
            dataBaru = true;
            panel2.Visible = false;
            string id = (from a in daftarPerawatan
                         orderby a.TanggalMasuk descending, a.IdPerawatan descending
                         select a.IdPerawatan).FirstOrDefault();
            if (id != null && id.Mid(1, 6) == SVal(DateTime.Today, "ddMMyy"))
            {
                tIdPerawatan.Text = $"P{SVal(DateTime.Today, "ddMMyy")}{SVal(IVal(id.Right(3)) + 1, "000")}";
            }
            else
            {
                tIdPerawatan.Text = $"P{SVal(DateTime.Today, "ddMMyy")}001";
            }
        }

        void Clear()
        {
            locked = true;
            Notis();
            Tampil();
            tPasien.SelectedIndex = -1;
            tKamar.SelectedIndex = -1;
            btnSimpan.Enabled = false;
            tTglMasuk.Text = SVal(DateTime.Today, "dd MMMM yyyy");
            tDiagnosis.Clear();
            tStatus.Clear();
            tTglKeluar.Clear();
            tTotalBiaya.Clear();
            tTerbayar.Clear();
            tCariData.Clear();
            tPasien.Enabled = true;
            tKamar.Enabled = true;
            TampilDGV();
            locked = false;
        }

        void Tampil()
        {
            tPasien.DataSource = null;
            tKamar.DataSource = null;
            var p = from x in daftarPasien where x.Status == "-" orderby x.Nama select new { x.IdPasien, x.Nama };
            var k = from x in daftarKamar where x.Isi < x.Kapasitas orderby x.Nama select new { x.NoKamar, x.Nama };

            if (p.Any())
            {
                Dictionary<string, string> dicPasien = new Dictionary<string, string>();
                foreach (var hasil in p) dicPasien.Add(hasil.IdPasien, isShowingId ? hasil.IdPasien + " - " + hasil.Nama : hasil.Nama);
                tPasien.DataSource = new BindingSource(dicPasien, null);
                tPasien.ValueMember = "Key";
                tPasien.DisplayMember = "Value";
            }

            if (k.Any())
            {
                Dictionary<string, string> dicKamar = new Dictionary<string, string>();
                foreach (var hasil in k) dicKamar.Add(hasil.NoKamar, isShowingId ? hasil.NoKamar + " - " + hasil.Nama : hasil.Nama);
                tKamar.DataSource = new BindingSource(dicKamar, null);
                tKamar.ValueMember = "Key";
                tKamar.DisplayMember = "Value";
            }
        }

        void FRegistrasi_Load(object sender, EventArgs e)
        {
            Clear();
        }

        void FRegistrasi_Resize(object sender, EventArgs e)
        {
            panelDGVPagination.Location = new Point(3 + (dgv.Width / 2) - 100, 3 + dgv.Height);
        }

        void Validasi(object sender, EventArgs e)
        {
            if (locked) return;
            btnSimpan.Enabled = tPasien.SelectedIndex >= 0 && tKamar.SelectedIndex >= 0;
            if (tPasien.SelectedIndex >= 0) pasien = daftarPasien.Find(x => x.IdPasien == ((KeyValuePair<string, string>)tPasien.SelectedItem).Key);
            if (tKamar.SelectedIndex >= 0) kamar = daftarKamar.Find(x => x.NoKamar == ((KeyValuePair<string, string>)tKamar.SelectedItem).Key);
        }
        #endregion

        #region CRUD
        void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (dataBaru)
            {
                QN($"INSERT INTO Perawatan VALUES('{tIdPerawatan.Text}','{pasien.IdPasien}',DATE(),NULL,'{tDiagnosis.Text}',0,0,'Terdaftar')");
                daftarPerawatan.Add(new Perawatan { IdPerawatan = tIdPerawatan.Text, IdPasien = pasien.IdPasien, TanggalMasuk = DateTime.Today, Diagnosis = tDiagnosis.Text, Status = "Terdaftar" });

                QN($"INSERT INTO KamarDetail VALUES('{tIdPerawatan.Text}','{kamar.NoKamar}',{kamar.Tarif})");
                daftarKamarDetail.Add(new KamarDetail { IdPerawatan = tIdPerawatan.Text, NoKamar = kamar.NoKamar, Tarif = kamar.Tarif });

                QN($"UPDATE Kamar SET Isi = Isi + 1 WHERE NoKamar = '{kamar.NoKamar}'");
                kamar.Isi++;

                QN($"UPDATE Pasien SET Status = 'Daftar' WHERE IdPasien = '{pasien.IdPasien}'");
                pasien.Status = "Daftar";

                QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Menambah registrasi {tIdPerawatan.Text} - {pasien.Nama}')");
                daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Menambah registrasi {tIdPerawatan.Text} - {pasien.Nama}" });

                Pesan("Registrasi berhasil", Notifikasi.Jenis.Berhasil);
            }
            else if (perawatan.Status == "Dirawat")
            {
                Pesan("Sedang dirawat", Notifikasi.Jenis.Gagal);
            }
            else if (perawatan.Status == "Selesai")
            {
                Pesan("Sudah selesai", Notifikasi.Jenis.Gagal);
            }
            Clear();
        }

        void BTNHapus_Click(object sender, EventArgs e)
        {
            if (perawatan.Status == "Dirawat")
            {
                Pesan("Sedang dirawat", Notifikasi.Jenis.Gagal);
            }
            else if (perawatan.Status == "Selesai")
            {
                Pesan("Sudah selesai", Notifikasi.Jenis.Gagal);
            }
            else if (!daftarPerawatan.Any(x => x.IdPerawatan == tIdPerawatan.Text))
            {
                Pesan("Id tidak ditemukan", Notifikasi.Jenis.Gagal);
            }
            else
            {
                var konfirmasi = new Konfirmasi("Konfirmasi Hapus", $"Hapus {perawatan.IdPerawatan}?", 0);
                if (konfirmasi.ShowDialog() == DialogResult.Yes)
                {
                    QN($"DELETE FROM Perawatan WHERE IdPerawatan = '{perawatan.IdPerawatan}'");
                    daftarKamarDetail.RemoveAll(x => x.IdPerawatan == tIdPerawatan.Text);
                    daftarPerawatan.Remove(perawatan);
                    QN($"UPDATE Kamar SET Isi = Isi - 1 WHERE NoKamar = '{kamar.NoKamar}'");
                    kamar.Isi--;
                    QN($"UPDATE Pasien SET Status = '-' WHERE IdPasien = '{pasien.IdPasien}'");
                    pasien.Status = "-";
                    QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Menghapus registrasi {tIdPerawatan.Text}')");
                    daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Menghapus registrasi {tIdPerawatan.Text}" });
                    Pesan("Registrasi dibatalkan", Notifikasi.Jenis.Berhasil);
                    Clear();
                }
            }
        }

        void BTNRefresh_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            Clear();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys koentji)
        {
            if (koentji == Keys.Enter)
            {
                btnSimpan.PerformClick();
                return true;
            }
            else if (koentji == Keys.Escape)
            {
                btnHapus.PerformClick();
                return true;
            }
            else if (koentji == Keys.Oemtilde)
            {
                btnRefresh.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, koentji);
        }
        #endregion

        #region DGV
        int currentPage = 1;
        List<object[]> rows;
        const int maxRows = 14;

        void TCariData_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            TampilDGV();
        }

        void TampilDGV()
        {
            rows = (from v in daftarPerawatan
                    join w in daftarPasien on v.IdPasien equals w.IdPasien
                    join x in daftarKamarDetail on v.IdPerawatan equals x.IdPerawatan
                    join y in daftarKamar on x.NoKamar equals y.NoKamar
                    where v.IdPerawatan.Cari(tCariData.Text) || w.Nama.Cari(tCariData.Text) || y.Nama.Cari(tCariData.Text) || SVal(v.TanggalMasuk, "dd/MM/yyyy").Cari(tCariData.Text) || SVal(v.TanggalKeluar, "dd/MM/yyyy").Cari(tCariData.Text) || v.Diagnosis.Cari(tCariData.Text) || SVal(v.TotalBiaya).Cari(tCariData.Text) || SVal(v.Terbayar).Cari(tCariData.Text) || v.Status.Cari(tCariData.Text)
                    orderby v.TanggalMasuk descending
                    select new object[]
                    {
                           v.IdPerawatan,
                           w.Nama,
                           y.Nama,
                           v.TanggalMasuk,
                           v.TanggalKeluar,
                           v.Diagnosis,
                           v.TotalBiaya,
                           v.Terbayar,
                           v.Status
                    }).ToList();
            Paging();
        }

        void Paging()
        {
            dgv.Rows.Clear();
            dgvPageCounter.Text = $"{currentPage} / {(rows.Count <= maxRows ? 1 : Math.Ceiling(rows.Count / DVal(maxRows)))}";
            if (currentPage == 1)
            {
                dgvPrev.Enabled = false;
                dgvFirst.Enabled = false;
            }
            else
            {
                dgvPrev.Enabled = true;
                dgvFirst.Enabled = true;
            }
            if (currentPage >= Math.Ceiling(rows.Count / DVal(maxRows)))
            {
                dgvNext.Enabled = false;
                dgvLast.Enabled = false;
            }
            else
            {
                dgvNext.Enabled = true;
                dgvLast.Enabled = true;
            }
            if (rows.Count == 0) return;
            if (rows.Count % maxRows == 0 && currentPage > 1 && currentPage > Math.Ceiling(rows.Count / DVal(maxRows))) dgvPrev.PerformClick();
            int i = 0;
            i += (currentPage - 1) * maxRows;
            foreach (object[] x in rows.Skip((currentPage - 1) * maxRows).Take(maxRows)) dgv.Rows.Add(++i, x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7], x[8]);
        }

        void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dataBaru = false;
            panel2.Visible = true;
            perawatan = daftarPerawatan.Find(x => x.IdPerawatan == SVal(dgv.Rows[e.RowIndex].Cells[1].Value));
            tIdPerawatan.Text = perawatan.IdPerawatan;
            locked = true;
            tPasien.DataSource = null;
            tKamar.DataSource = null;
            tPasien.Items.Clear();
            tKamar.Items.Clear();
            tPasien.Items.Add(dgv.Rows[e.RowIndex].Cells[2].Value);
            tKamar.Items.Add(dgv.Rows[e.RowIndex].Cells[3].Value);
            tPasien.SelectedIndex = 0;
            tKamar.SelectedIndex = 0;
            tPasien.Enabled = false;
            tKamar.Enabled = false;
            btnSimpan.Enabled = false;
            locked = false;
            tTglMasuk.Text = SVal(perawatan.TanggalMasuk, "dd MMMM yyyy");
            tDiagnosis.Text = perawatan.Diagnosis;
            tStatus.Text = perawatan.Status;
            tTglKeluar.Text = SVal(perawatan.TanggalKeluar, "dd MMMM yyyy");
            tTotalBiaya.Text = SVal(perawatan.TotalBiaya, "n0");
            tTerbayar.Text = SVal(perawatan.Terbayar, "n0");
        }

        void DGVFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            Paging();
        }

        void DGVPrev_Click(object sender, EventArgs e)
        {
            currentPage--;
            Paging();
        }

        void DGVPageCounter_Click(object sender, EventArgs e)
        {
            if (Math.Ceiling(rows.Count / DVal(maxRows)) <= 1d) return;
            GoToPageNumber(rows.Count, maxRows, ref currentPage);
            Paging();
        }

        void DGVNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            Paging();
        }

        void DGVLast_Click(object sender, EventArgs e)
        {
            currentPage = IVal(Math.Ceiling(rows.Count / DVal(maxRows)));
            Paging();
        }
        #endregion
    }
}
