using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class FDokter : Form
    {
        bool dataBaru;
        Dokter dokter;

        public FDokter()
        {
            InitializeComponent();
        }

        #region Form
        void Clear()
        {
            dataBaru = true;
            tId.Enabled = true;
            tId.Clear();
            tNama.Clear();
            rbLakiLaki.Checked = false;
            rbPerempuan.Checked = false;
            tTglLahir.Value = DateTime.Today;
            tAlamat.Clear();
            tNoTelepon.Clear();
            tSpesialis.Clear();
            tTarif.Clear();
            tCariData.Clear();
            TampilDGV();
            tId.Focus();
        }

        void FDokter_Load(object sender, EventArgs e)
        {
            HakAksesEdit(5, btnSimpan, btnHapus);
            Clear();
        }

        void FDokter_Resize(object sender, EventArgs e)
        {
            panelDGVPagination.Location = new Point(3 + (dgv.Width / 2) - 100, 3 + dgv.Height);
        }

        void InputAngka(object sender, KeyPressEventArgs e)
        {
            Numbers(sender, e);
        }

        void Validasi(object sender, EventArgs e)
        {
            tTarif.Text = tTarif.Text.TrimStart('0');
            btnSimpan.Enabled = !string.IsNullOrEmpty(tId.Text) && !string.IsNullOrEmpty(tNama.Text) && (rbLakiLaki.Checked ^ rbPerempuan.Checked);
        }
        #endregion

        #region CRUD
        void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (dataBaru && daftarDokter.Any(x => x.IdDokter == tId.Text))
            {
                Pesan("Id sudah terdaftar", Notifikasi.Jenis.Gagal);
                return;
            }
            if (dataBaru)
            {
                QN($"INSERT INTO Dokter VALUES('{tId.Text}','{tNama.Text}','{(rbLakiLaki.Checked ? "Laki-laki" : "Perempuan")}','{SVal(tTglLahir.Value, "M/d/yyyy")}','{tAlamat.Text}','{tNoTelepon.Text}','{tSpesialis.Text}',{IVal(tTarif.Text)})");
                daftarDokter.Add(new Dokter { IdDokter = tId.Text, Nama = tNama.Text, JenisKelamin = rbLakiLaki.Checked ? "Laki-laki" : "Perempuan", TanggalLahir = tTglLahir.Value, Alamat = tAlamat.Text, NoTelepon = tNoTelepon.Text, Spesialis = tSpesialis.Text, Tarif = IVal(tTarif.Text) });
                QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Menambah dokter {tId.Text} - {tNama.Text}')");
                daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Menambah dokter {tId.Text} - {tNama.Text}" });
                Pesan("Dokter berhasil ditambah", Notifikasi.Jenis.Berhasil);
            }
            else
            {
                dokter.Nama = tNama.Text;
                dokter.JenisKelamin = rbLakiLaki.Checked ? "Laki-laki" : "Perempuan";
                dokter.TanggalLahir = tTglLahir.Value;
                dokter.Alamat = tAlamat.Text;
                dokter.NoTelepon = tNoTelepon.Text;
                dokter.Spesialis = tSpesialis.Text;
                dokter.Tarif = IVal(tTarif.Text);
                QN($"UPDATE Dokter SET Nama = '{dokter.Nama}', JenisKelamin = '{dokter.JenisKelamin}', TanggalLahir = '{SVal(dokter.TanggalLahir, "M/d/yyyy")}', Alamat = '{dokter.Alamat}', NoTelepon = '{dokter.NoTelepon}', Spesialis = '{dokter.Spesialis}', Tarif = {dokter.Tarif} WHERE IdDokter = '{dokter.IdDokter}'");
                QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Mengubah dokter {tId.Text} - {tNama.Text}')");
                daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Mengubah dokter {tId.Text} - {tNama.Text}" });
                Pesan("Dokter berhasil diubah", Notifikasi.Jenis.Berhasil);
            }
            Clear();
        }

        void BTNHapus_Click(object sender, EventArgs e)
        {
            if (daftarDokterDetail.Any(x => x.IdDokter == tId.Text))
            {
                Pesan("Dokter pernah merawat", Notifikasi.Jenis.Gagal);
            }
            else if (!daftarDokter.Any(x => x.IdDokter == tId.Text))
            {
                Pesan("Id tidak ditemukan", Notifikasi.Jenis.Gagal);
            }
            else
            {
                var konfirmasi = new Konfirmasi("Konfirmasi Hapus", $"Hapus {dokter.Nama}?", 0);
                if (konfirmasi.ShowDialog() == DialogResult.Yes)
                {
                    QN($"DELETE FROM Dokter WHERE IdDokter = '{tId.Text}'");
                    daftarDokter.Remove(dokter);
                    QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Menghapus dokter {tId.Text} - {tNama.Text}')");
                    daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Menghapus dokter {tId.Text} - {tNama.Text}" });
                    Pesan("Dokter berhasil dihapus", Notifikasi.Jenis.Berhasil);
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
        IEnumerable<Dokter> rows;
        int currentPage = 1;
        const int maxRows = 14;

        void TCariData_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            TampilDGV();
        }

        void TampilDGV()
        {
            rows = from x in daftarDokter
                   where x.IdDokter.Cari(tCariData.Text) || x.Nama.Cari(tCariData.Text) || x.JenisKelamin.Cari(tCariData.Text) || SVal(x.TanggalLahir, "dd/MM/yyyy").Cari(tCariData.Text) || x.Alamat.Cari(tCariData.Text) || x.NoTelepon.Cari(tCariData.Text) || x.Spesialis.Cari(tCariData.Text)
                   orderby x.Nama
                   select x;
            Paging();
        }

        void Paging()
        {
            dgv.Rows.Clear();
            dgvPageCounter.Text = $"{currentPage} / {(rows.Count() <= maxRows ? 1 : Math.Ceiling(rows.Count() / DVal(maxRows)))}";
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
            if (currentPage >= Math.Ceiling(rows.Count() / DVal(maxRows)))
            {
                dgvNext.Enabled = false;
                dgvLast.Enabled = false;
            }
            else
            {
                dgvNext.Enabled = true;
                dgvLast.Enabled = true;
            }
            if (!rows.Any()) return;
            if (rows.Count() % maxRows == 0 && currentPage > 1 && currentPage > Math.Ceiling(rows.Count() / DVal(maxRows))) dgvPrev.PerformClick();
            int i = 0;
            i += (currentPage - 1) * maxRows;
            foreach (Dokter x in rows.Skip((currentPage - 1) * maxRows).Take(maxRows)) dgv.Rows.Add(++i, x.IdDokter, x.Nama, x.JenisKelamin, x.TanggalLahir, x.Alamat, x.NoTelepon, x.Spesialis, x.Tarif);
        }

        void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dokter = daftarDokter.Find(x => x.IdDokter == SVal(dgv.Rows[e.RowIndex].Cells[1].Value));
            dataBaru = false;
            tId.Enabled = false;
            tId.Text = SVal(dokter.IdDokter);
            tNama.Text = SVal(dokter.Nama);
            rbLakiLaki.Checked = SVal(dokter.JenisKelamin) == "Laki-laki";
            rbPerempuan.Checked = SVal(dokter.JenisKelamin) == "Perempuan";
            tTglLahir.Value = DtVal(dokter.TanggalLahir);
            tAlamat.Text = SVal(dokter.Alamat);
            tNoTelepon.Text = SVal(dokter.NoTelepon);
            tSpesialis.Text = SVal(dokter.Spesialis);
            tTarif.Text = SVal(dokter.Tarif);
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
            if (Math.Ceiling(rows.Count() / DVal(maxRows)) <= 1d) return;
            GoToPageNumber(rows.Count(), maxRows, ref currentPage);
            Paging();
        }

        void DGVNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            Paging();
        }

        void DGVLast_Click(object sender, EventArgs e)
        {
            currentPage = IVal(Math.Ceiling(rows.Count() / DVal(maxRows)));
            Paging();
        }
        #endregion
    }
}
