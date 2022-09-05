using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class FTindakan : Form
    {
        bool dataBaru;
        Tindakan tindakan;

        public FTindakan()
        {
            InitializeComponent();
        }

        #region Form
        void Notis()
        {
            dataBaru = true;
            IEnumerable<int> id = from a in daftarTindakan select a.IdTindakan;
            int hilang = Enumerable.Range(1, daftarTindakan.Count).Except(id).FirstOrDefault();
            if (!id.Any() || id.Max() == daftarTindakan.Count) hilang = daftarTindakan.Count + 1;
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

        void FTindakan_Load(object sender, EventArgs e)
        {
            HakAksesEdit(2, btnSimpan, btnHapus);
            Clear();
        }

        void FTindakan_Resize(object sender, EventArgs e)
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
                QN($"INSERT INTO Tindakan VALUES({tId.Text},'{tNama.Text}',{IVal(tTarif.Text)})");
                daftarTindakan.Add(new Tindakan { IdTindakan = IVal(tId.Text), Nama = tNama.Text, Tarif = IVal(tTarif.Text) });
                QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Menambah {tId.Text} - {tNama.Text}')");
                daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Menambah {tId.Text} - {tNama.Text}" });
                Pesan("Tindakan berhasil ditambah", Notifikasi.Jenis.Berhasil);
            }
            else
            {
                tindakan.Nama = tNama.Text;
                tindakan.Tarif = IVal(tTarif.Text);
                QN($"UPDATE Tindakan SET Nama = '{tindakan.Nama}', Tarif = {tindakan.Tarif} WHERE IdTindakan = {tindakan.IdTindakan}");
                QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Mengubah {tId.Text} - {tNama.Text}')");
                daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Mengubah {tId.Text} - {tNama.Text}" });
                Pesan("Tindakan berhasil diubah", Notifikasi.Jenis.Berhasil);
            }
            Clear();
        }

        void BTNHapus_Click(object sender, EventArgs e)
        {
            if (daftarTindakanDetail.Any(x => x.IdTindakan == IVal(tId.Text)))
            {
                Pesan("Tindakan pernah dilakukan", Notifikasi.Jenis.Gagal);
            }
            else if (!daftarTindakan.Any(x => x.IdTindakan == IVal(tId.Text)))
            {
                Pesan("Id tidak ditemukan", Notifikasi.Jenis.Gagal);
            }
            else
            {
                var konfirmasi = new Konfirmasi("Konfirmasi Hapus", $"Hapus {tindakan.Nama}?", 0);
                if (konfirmasi.ShowDialog() == DialogResult.Yes)
                {
                    QN($"DELETE FROM Tindakan WHERE IdTindakan = {tId.Text}");
                    daftarTindakan.Remove(tindakan);
                    QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Menghapus {tId.Text} - {tNama.Text}')");
                    daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Menghapus {tId.Text} - {tNama.Text}" });
                    Pesan("Tindakan berhasil dihapus", Notifikasi.Jenis.Berhasil);
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
        IEnumerable<Tindakan> rows;
        int currentPage = 1;
        const int maxRows = 15;

        void TCariData_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            TampilDGV();
        }

        void TampilDGV()
        {
            rows = from x in daftarTindakan
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
            foreach (Tindakan x in rows.Skip((currentPage - 1) * maxRows).Take(maxRows)) dgv.Rows.Add(++i, x.IdTindakan, x.Nama, x.Tarif);
        }

        void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            tindakan = daftarTindakan.Find(x => x.IdTindakan == IVal(dgv.Rows[e.RowIndex].Cells[1].Value));
            dataBaru = false;
            tId.Text = SVal(tindakan.IdTindakan);
            tNama.Text = SVal(tindakan.Nama);
            tTarif.Text = SVal(tindakan.Tarif);
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
