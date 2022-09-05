using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class FAlat : Form
    {
        bool dataBaru;
        Alat alat;

        public FAlat()
        {
            InitializeComponent();
        }

        #region Form
        void Notis()
        {
            dataBaru = true;
            IEnumerable<int> id = from a in daftarAlat select a.IdAlat;
            int hilang = Enumerable.Range(1, daftarAlat.Count).Except(id).FirstOrDefault();
            if (!id.Any() || id.Max() == daftarAlat.Count) hilang = daftarAlat.Count + 1;
            tId.Text = SVal(hilang);
        }

        void Clear()
        {
            dataBaru = true;
            Notis();
            tNama.Clear();
            tTarif.Clear();
            tCariData.Clear();
            TampilDGV();
            tNama.Focus();
        }

        void FAlat_Load(object sender, EventArgs e)
        {
            HakAksesEdit(1, btnSimpan, btnHapus);
            Clear();
        }

        void FAlat_Resize(object sender, EventArgs e)
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
            btnSimpan.Enabled = !string.IsNullOrEmpty(tNama.Text);
        }
        #endregion

        #region CRUD
        void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (dataBaru)
            {
                QN($"INSERT INTO Alat VALUES({tId.Text},'{tNama.Text}',{IVal(tTarif.Text)})");
                daftarAlat.Add(new Alat { IdAlat = IVal(tId.Text), Nama = tNama.Text, Tarif = IVal(tTarif.Text) });
                QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Menambah {tId.Text} - {tNama.Text}')");
                daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Menambah {tId.Text} - {tNama.Text}" });
                Pesan("Alat berhasil ditambah", Notifikasi.Jenis.Berhasil);
            }
            else
            {
                alat.Nama = tNama.Text;
                alat.Tarif = IVal(tTarif.Text);
                QN($"UPDATE Alat SET Nama = '{alat.Nama}', Tarif = {alat.Tarif} WHERE IdAlat = {alat.IdAlat}");
                QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Mengubah {tId.Text} - {tNama.Text}')");
                daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Mengubah {tId.Text} - {tNama.Text}" });
                Pesan("Alat berhasil diubah", Notifikasi.Jenis.Berhasil);
            }
            Clear();
        }

        void BTNHapus_Click(object sender, EventArgs e)
        {
            if (daftarAlatDetail.Any(x => x.IdAlat == IVal(tId.Text)))
            {
                Pesan("Alat pernah digunakan", Notifikasi.Jenis.Gagal);
            }
            else if (!daftarAlat.Any(x => x.IdAlat == IVal(tId.Text)))
            {
                Pesan("Id tidak ditemukan", Notifikasi.Jenis.Gagal);
            }
            else
            {
                var konfirmasi = new Konfirmasi("Konfirmasi Hapus", $"Hapus {alat.Nama}?", 0);
                if (konfirmasi.ShowDialog() == DialogResult.Yes)
                {
                    QN($"DELETE FROM Alat WHERE IdAlat = {tId.Text}");
                    daftarAlat.Remove(alat);
                    QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Menghapus {tId.Text} - {tNama.Text}')");
                    daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Menghapus {tId.Text} - {tNama.Text}" });
                    Pesan("Alat berhasil dihapus", Notifikasi.Jenis.Berhasil);
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
        IEnumerable<Alat> rows;
        int currentPage = 1;
        const int maxRows = 15;

        void TCariData_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            TampilDGV();
        }

        void TampilDGV()
        {
            rows = from x in daftarAlat
                   where x.Nama.Cari(tCariData.Text)
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
            foreach (Alat x in rows.Skip((currentPage - 1) * maxRows).Take(maxRows)) dgv.Rows.Add(++i, x.IdAlat, x.Nama, x.Tarif);
        }

        void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            alat = daftarAlat.Find(x => x.IdAlat == IVal(dgv.Rows[e.RowIndex].Cells[1].Value));
            dataBaru = false;
            tId.Text = SVal(alat.IdAlat);
            tNama.Text = SVal(alat.Nama);
            tTarif.Text = SVal(alat.Tarif);
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
