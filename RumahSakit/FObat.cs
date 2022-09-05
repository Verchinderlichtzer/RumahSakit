using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class FObat : Form
    {
        bool dataBaru;
        Obat obat;

        public FObat()
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
            tHarga.Clear();
            tCariData.Clear();
            TampilDGV();
            tId.Focus();
        }

        void FObat_Load(object sender, EventArgs e)
        {
            HakAksesEdit(4, btnSimpan, btnHapus);
            Clear();
        }

        void FObat_Resize(object sender, EventArgs e)
        {
            panelDGVPagination.Location = new Point(3 + (dgv.Width / 2) - 100, 3 + dgv.Height);
        }

        void InputAngka(object sender, KeyPressEventArgs e)
        {
            Numbers(sender, e);
        }

        void Validasi(object sender, EventArgs e)
        {
            tHarga.Text = tHarga.Text.TrimStart('0');
            btnSimpan.Enabled = !string.IsNullOrEmpty(tId.Text) && !string.IsNullOrEmpty(tNama.Text);
        }
        #endregion

        #region CRUD
        void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (dataBaru && daftarObat.Any(x => x.IdObat == tId.Text))
            {
                Pesan("Id sudah terdaftar", Notifikasi.Jenis.Gagal);
                return;
            }
            if (dataBaru)
            {
                QN($"INSERT INTO Obat VALUES('{tId.Text}','{tNama.Text}',{IVal(tHarga.Text)})");
                daftarObat.Add(new Obat { IdObat = tId.Text, Nama = tNama.Text, Harga = IVal(tHarga.Text) });
                QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Menambah {tId.Text} - {tNama.Text}')");
                daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Menambah {tId.Text} - {tNama.Text}" });
                Pesan("Obat berhasil ditambah", Notifikasi.Jenis.Berhasil);
            }
            else
            {
                obat.Nama = tNama.Text;
                obat.Harga = IVal(tHarga.Text);
                QN($"UPDATE Obat SET Nama = '{obat.Nama}', Harga = {obat.Harga} WHERE IdObat = '{obat.IdObat}'");
                QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Mengubah {tId.Text} - {tNama.Text}')");
                daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Mengubah {tId.Text} - {tNama.Text}" });
                Pesan("Obat berhasil diubah", Notifikasi.Jenis.Berhasil);
            }
            Clear();
        }

        void BTNHapus_Click(object sender, EventArgs e)
        {
            if (daftarObatDetail.Any(x => x.IdObat == tId.Text))
            {
                Pesan("Obat pernah dipakai", Notifikasi.Jenis.Gagal);
            }
            else if (!daftarObat.Any(x => x.IdObat == tId.Text))
            {
                Pesan("Id tidak ditemukan", Notifikasi.Jenis.Gagal);
            }
            else
            {
                var konfirmasi = new Konfirmasi("Konfirmasi Hapus", $"Hapus {obat.Nama}?", 0);
                if (konfirmasi.ShowDialog() == DialogResult.Yes)
                {
                    QN($"DELETE FROM Obat WHERE IdObat = '{tId.Text}'");
                    daftarObat.Remove(obat);
                    QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Menghapus {tId.Text} - {tNama.Text}')");
                    daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Menghapus {tId.Text} - {tNama.Text}" });
                    Pesan("Obat berhasil dihapus", Notifikasi.Jenis.Berhasil);
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
        IEnumerable<Obat> rows;
        int currentPage = 1;
        const int maxRows = 15;

        void TCariData_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            TampilDGV();
        }

        void TampilDGV()
        {
            rows = from x in daftarObat
                   where x.IdObat.Cari(tCariData.Text) || x.Nama.Cari(tCariData.Text)
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
            foreach (Obat x in rows.Skip((currentPage - 1) * maxRows).Take(maxRows)) dgv.Rows.Add(++i, x.IdObat, x.Nama, x.Harga);
        }

        void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            obat = daftarObat.Find(x => x.IdObat == SVal(dgv.Rows[e.RowIndex].Cells[1].Value));
            dataBaru = false;
            tId.Enabled = false;
            tId.Text = SVal(obat.IdObat);
            tNama.Text = SVal(obat.Nama);
            tHarga.Text = SVal(obat.Harga);
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
