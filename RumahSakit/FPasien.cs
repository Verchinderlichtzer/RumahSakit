using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class FPasien : Form
    {
        bool dataBaru;
        Pasien pasien;

        public FPasien()
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
            tStatus.Clear();
            tCariData.Clear();
            TampilDGV();
            tId.Focus();
        }

        void FPasien_Load(object sender, EventArgs e)
        {
            HakAksesEdit(6, btnSimpan, btnHapus);
            Clear();
        }

        void FPasien_Resize(object sender, EventArgs e)
        {
            panelDGVPagination.Location = new Point(3 + (dgv.Width / 2) - 100, 3 + dgv.Height);
        }

        void Validasi(object sender, EventArgs e)
        {
            btnSimpan.Enabled = !string.IsNullOrEmpty(tId.Text) && !string.IsNullOrEmpty(tNama.Text) && (rbLakiLaki.Checked ^ rbPerempuan.Checked);
        }
        #endregion

        #region CRUD
        void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (dataBaru && daftarPasien.Any(x => x.IdPasien == tId.Text))
            {
                Pesan("Id sudah terdaftar", Notifikasi.Jenis.Gagal);
                return;
            }
            if (dataBaru)
            {
                QN($"INSERT INTO Pasien VALUES('{tId.Text}','{tNama.Text}','{(rbLakiLaki.Checked ? "Laki-laki" : "Perempuan")}','{SVal(tTglLahir.Value, "M/d/yyyy")}','{tAlamat.Text}','{tNoTelepon.Text}','-')");
                daftarPasien.Add(new Pasien { IdPasien = tId.Text, Nama = tNama.Text, JenisKelamin = rbLakiLaki.Checked ? "Laki-laki" : "Perempuan", TanggalLahir = tTglLahir.Value, Alamat = tAlamat.Text, NoTelepon = tNoTelepon.Text, Status = "-" });
                QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Menambah {tId.Text} - {tNama.Text}')");
                daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Menambah {tId.Text} - {tNama.Text}" });
                Pesan("Pasien berhasil ditambah", Notifikasi.Jenis.Berhasil);
            }
            else
            {
                pasien.Nama = tNama.Text;
                pasien.JenisKelamin = rbLakiLaki.Checked ? "Laki-laki" : "Perempuan";
                pasien.TanggalLahir = tTglLahir.Value;
                pasien.Alamat = tAlamat.Text;
                pasien.NoTelepon = tNoTelepon.Text;
                QN($"UPDATE Pasien SET Nama = '{pasien.Nama}', JenisKelamin = '{pasien.JenisKelamin}', TanggalLahir = '{SVal(pasien.TanggalLahir, "M/d/yyyy")}', Alamat = '{pasien.Alamat}', NoTelepon = '{pasien.NoTelepon}' WHERE IdPasien = '{pasien.IdPasien}'");
                QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Mengubah {tId.Text} - {tNama.Text}')");
                daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Mengubah {tId.Text} - {tNama.Text}" });
                Pesan("Pasien berhasil diubah", Notifikasi.Jenis.Berhasil);
            }
            Clear();
        }

        void BTNHapus_Click(object sender, EventArgs e)
        {
            if (daftarPerawatan.Any(x => x.IdPasien == tId.Text))
            {
                Pesan("Pasien pernah dirawat", Notifikasi.Jenis.Gagal);
            }
            else if (!daftarPasien.Any(x => x.IdPasien == tId.Text))
            {
                Pesan("Id tidak ditemukan", Notifikasi.Jenis.Gagal);
            }
            else
            {
                var konfirmasi = new Konfirmasi("Konfirmasi Hapus", $"Hapus {pasien.Nama}?", 0);
                if (konfirmasi.ShowDialog() == DialogResult.Yes)
                {
                    QN($"DELETE FROM Pasien WHERE IdPasien = '{tId.Text}'");
                    daftarPasien.Remove(pasien);
                    QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Menghapus {tId.Text} - {tNama.Text}')");
                    daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Menghapus {tId.Text} - {tNama.Text}" });
                    Pesan("Pasien berhasil dihapus", Notifikasi.Jenis.Berhasil);
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
        IEnumerable<Pasien> rows;
        int currentPage = 1;
        const int maxRows = 14;

        void TCariData_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            TampilDGV();
        }

        void TampilDGV()
        {
            rows = from x in daftarPasien
                   where x.IdPasien.Cari(tCariData.Text) || x.Nama.Cari(tCariData.Text) || x.JenisKelamin.Cari(tCariData.Text) || SVal(x.TanggalLahir, "dd/MMMM/yyyy").Cari(tCariData.Text) || x.Alamat.Cari(tCariData.Text) || x.NoTelepon.Cari(tCariData.Text) || x.Status.Cari(tCariData.Text)
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
            foreach (Pasien x in rows.Skip((currentPage - 1) * maxRows).Take(maxRows)) dgv.Rows.Add(++i, x.IdPasien, x.Nama, x.JenisKelamin, x.TanggalLahir, x.Alamat, x.NoTelepon, x.Status);

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (SVal(row.Cells[7].Value) == "Daftar")
                {
                    row.Cells[7].Style.ForeColor = Color.FromArgb(212, 161, 5);
                    row.Cells[7].Style.SelectionForeColor = Color.FromArgb(212, 161, 5);
                }
                else if (SVal(row.Cells[7].Value) == "Dirawat")
                {
                    row.Cells[7].Style.ForeColor = Color.FromArgb(220, 53, 69);
                    row.Cells[7].Style.SelectionForeColor = Color.FromArgb(220, 53, 69);
                }
            }
        }

        void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            pasien = daftarPasien.Find(x => x.IdPasien == SVal(dgv.Rows[e.RowIndex].Cells[1].Value));
            dataBaru = false;
            tId.Enabled = false;
            tId.Text = SVal(pasien.IdPasien);
            tNama.Text = SVal(pasien.Nama);
            rbLakiLaki.Checked = SVal(pasien.JenisKelamin) == "Laki-laki";
            rbPerempuan.Checked = SVal(pasien.JenisKelamin) == "Perempuan";
            tTglLahir.Value = DtVal(pasien.TanggalLahir);
            tAlamat.Text = SVal(pasien.Alamat);
            tNoTelepon.Text = SVal(pasien.NoTelepon);
            tStatus.Text = SVal(pasien.Status);
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
