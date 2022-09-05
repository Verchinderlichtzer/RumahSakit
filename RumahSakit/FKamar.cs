using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class FKamar : Form
    {
        bool dataBaru;
        Kamar kamar;

        public FKamar()
        {
            InitializeComponent();
        }

        #region Form
        void Clear()
        {
            dataBaru = true;
            tNo.Enabled = true;
            tNo.Clear();
            tNama.Clear();
            tTarif.Clear();
            tKapasitas.Clear();
            tCariData.Clear();
            TampilDGV();
            tNo.Focus();
        }

        void FKamar_Load(object sender, EventArgs e)
        {
            HakAksesEdit(3, btnSimpan, btnHapus);
            Clear();
        }

        void FKamar_Resize(object sender, EventArgs e)
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
            tKapasitas.Text = tKapasitas.Text.TrimStart('0');
            btnSimpan.Enabled = !string.IsNullOrEmpty(tNo.Text) && !string.IsNullOrEmpty(tNama.Text) && IVal(tKapasitas.Text) > 0;
        }
        #endregion

        #region CRUD
        void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (dataBaru && daftarKamar.Any(x => x.NoKamar == tNo.Text))
            {
                Pesan("Nomor sudah terdaftar", Notifikasi.Jenis.Gagal);
                return;
            }
            if (dataBaru)
            {
                QN($"INSERT INTO Kamar VALUES('{tNo.Text}','{tNama.Text}',{IVal(tTarif.Text)},{IVal(tKapasitas.Text)},0)");
                daftarKamar.Add(new Kamar { NoKamar = tNo.Text, Nama = tNama.Text, Tarif = IVal(tTarif.Text), Kapasitas = IVal(tKapasitas.Text) });
                QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Menambah {tNo.Text} - {tNama.Text}')");
                daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Menambah {tNo.Text} - {tNama.Text}" });
                Pesan("Kamar berhasil ditambah", Notifikasi.Jenis.Berhasil);
            }
            else
            {
                kamar.Nama = tNama.Text;
                kamar.Tarif = IVal(tTarif.Text);
                kamar.Kapasitas = IVal(tKapasitas.Text);
                QN($"UPDATE Kamar SET Nama = '{kamar.Nama}', Tarif = {kamar.Tarif}, Kapasitas = {kamar.Kapasitas} WHERE NoKamar = '{kamar.NoKamar}'");
                QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Mengubah {tNo.Text} - {tNama.Text}')");
                daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Mengubah {tNo.Text} - {tNama.Text}" });
                Pesan("Kamar berhasil diubah", Notifikasi.Jenis.Berhasil);
            }
            Clear();
        }

        void BTNHapus_Click(object sender, EventArgs e)
        {
            if (daftarKamarDetail.Any(x => x.NoKamar == tNo.Text))
            {
                Pesan("Kamar pernah ditempati", Notifikasi.Jenis.Gagal);
            }
            else if (!daftarKamar.Any(x => x.NoKamar == tNo.Text))
            {
                Pesan("Nomor tidak ditemukan", Notifikasi.Jenis.Gagal);
            }
            else
            {
                var konfirmasi = new Konfirmasi("Konfirmasi Hapus", $"Hapus {kamar.Nama}?", 0);
                if (konfirmasi.ShowDialog() == DialogResult.Yes)
                {
                    QN($"DELETE FROM Kamar WHERE NoKamar = '{tNo.Text}'");
                    daftarKamar.Remove(kamar);
                    QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Menghapus {tNo.Text} - {tNama.Text}')");
                    daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Menghapus {tNo.Text} - {tNama.Text}" });
                    Pesan("Kamar berhasil dihapus", Notifikasi.Jenis.Berhasil);
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
        IEnumerable<Kamar> rows;
        int currentPage = 1;
        const int maxRows = 15;

        void TCariData_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            TampilDGV();
        }

        void TampilDGV()
        {
            rows = from x in daftarKamar
                   where x.NoKamar.Cari(tCariData.Text) || x.Nama.Cari(tCariData.Text)
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
            foreach (Kamar x in rows.Skip((currentPage - 1) * maxRows).Take(maxRows)) dgv.Rows.Add(++i, x.NoKamar, x.Nama, x.Tarif, x.Kapasitas, x.Isi);

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (IVal(row.Cells[4].Value) == IVal(row.Cells[5].Value))
                {
                    row.Cells[4].Style.ForeColor = Color.FromArgb(220, 53, 69);
                    row.Cells[4].Style.SelectionForeColor = Color.FromArgb(220, 53, 69);
                    row.Cells[5].Style.ForeColor = Color.FromArgb(220, 53, 69);
                    row.Cells[5].Style.SelectionForeColor = Color.FromArgb(220, 53, 69);
                }
            }
        }

        void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            kamar = daftarKamar.Find(x => x.NoKamar == SVal(dgv.Rows[e.RowIndex].Cells[1].Value));
            dataBaru = false;
            tNo.Enabled = false;
            tNo.Text = SVal(kamar.NoKamar);
            tNama.Text = SVal(kamar.Nama);
            tTarif.Text = SVal(kamar.Tarif);
            tKapasitas.Text = SVal(kamar.Kapasitas);
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
