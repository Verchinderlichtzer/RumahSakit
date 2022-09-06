using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class FUser : Form
    {
        bool dataBaru;
        User user;

        public FUser()
        {
            InitializeComponent();
        }

        #region Form

        void Clear()
        {
            dataBaru = true;
            tUsername.Enabled = true;
            tUsername.Clear();
            tPassword.Clear();
            tCariData.Clear();
            TampilDGV();
            tUsername.Focus();
        }

        void FUser_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> indikator = new Dictionary<string, string>
            {
                { "A", "User" },
                { "B", "Alat" },
                { "C", "Tindakan" },
                { "D", "Kamar" },
                { "E", "Obat" },
                { "F", "Dokter" },
                { "G", "Pasien" },
                { "H", "Registrasi" },
                { "I", "Perawatan" },
                { "J", "Pembayaran" }
            };
            foreach (var x in indikator) dgvIndikator.Rows.Add(x.Key, x.Value);
            Clear();
        }

        void FUser_Resize(object sender, EventArgs e)
        {
            panelDGVPagination.Location = new Point(3 + (dgv.Width / 2) - 100, 3 + dgv.Height);
        }

        void InputKarakter(object sender, KeyPressEventArgs e)
        {
            Characters(sender, e);
        }

        void Validasi(object sender, EventArgs e)
        {
            btnSimpan.Enabled = !string.IsNullOrEmpty(tUsername.Text) && !string.IsNullOrEmpty(tPassword.Text);
        }
        #endregion

        #region CRUD
        void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (tUsername.Text.Cari("admin")) return;
            if (dataBaru)
            {
                QN($"INSERT INTO Users(Username, Pw) VALUES('{tUsername.Text}','{EncodePassword(tUsername.Text, tPassword.Text)}')");
                daftarUser.Add(new User { Username = tUsername.Text, Password = EncodePassword(tUsername.Text, tPassword.Text), HakUser = false, HakAlat = false, HakTindakan = false, HakKamar = false, HakObat = false, HakDokter = false, HakPasien = false, HakRegistrasi = false, HakPerawatan = false, HakPembayaran = false });
                Pesan("User berhasil ditambah", Notifikasi.Jenis.Berhasil);
            }
            else
            {
                user.Password = EncodePassword(tUsername.Text, tPassword.Text);
                QN($"UPDATE Users SET Pw = '{EncodePassword(tUsername.Text, tPassword.Text)}' WHERE Username = '{tUsername.Text}'");
                Pesan("User berhasil diubah", Notifikasi.Jenis.Berhasil);
            }
            Clear();
        }

        void BTNHapus_Click(object sender, EventArgs e)
        {
            if (daftarLogUser.Any(x => x.Username == tUsername.Text))
            {
                Pesan("User pernah menginput data", Notifikasi.Jenis.Gagal);
            }
            else if (!daftarUser.Any(x => x.Username == tUsername.Text))
            {
                Pesan("Id tidak ditemukan", Notifikasi.Jenis.Gagal);
            }
            else
            {
                var konfirmasi = new Konfirmasi("Konfirmasi Hapus", $"Hapus {tUsername.Text}", 0);
                if (konfirmasi.ShowDialog() == DialogResult.Yes)
                {
                    QN($"DELETE FROM Users WHERE Username = '{tUsername.Text}'");
                    daftarUser.Remove(user);
                    Pesan("User berhasil dihapus", Notifikasi.Jenis.Berhasil);
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
        IEnumerable<User> rows;
        int currentPage = 1;
        const int maxRows = 16;

        void TCariData_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            TampilDGV();
        }

        void TampilDGV()
        {
            rows = from x in daftarUser
                   where x.Username.Cari(tCariData.Text) && x.Username != "admin" && x.Username != userAktif
                   orderby x.Username
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
            foreach (User x in rows.Skip((currentPage - 1) * maxRows).Take(maxRows)) dgv.Rows.Add(++i, x.Username, x.Password, x.HakUser, x.HakAlat, x.HakTindakan, x.HakKamar, x.HakObat, x.HakDokter, x.HakPasien, x.HakRegistrasi, x.HakPerawatan, x.HakPembayaran);
        }

        void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex > 2) return;
            user = daftarUser.Find(x => x.Username == SVal(dgv.Rows[e.RowIndex].Cells[1].Value));
            dataBaru = false;
            tUsername.Enabled = false;
            tUsername.Text = user.Username;
        }

        void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 3) return;
            dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            QN($"UPDATE Users SET HakUser = {dgv.Rows[e.RowIndex].Cells[3].Value}, HakAlat = {dgv.Rows[e.RowIndex].Cells[4].Value}, HakTindakan = {dgv.Rows[e.RowIndex].Cells[5].Value}, HakKamar = {dgv.Rows[e.RowIndex].Cells[6].Value}, HakObat = {dgv.Rows[e.RowIndex].Cells[7].Value}, HakDokter = {dgv.Rows[e.RowIndex].Cells[8].Value}, HakPasien = {dgv.Rows[e.RowIndex].Cells[9].Value}, HakRegistrasi = {dgv.Rows[e.RowIndex].Cells[10].Value}, HakPerawatan = {dgv.Rows[e.RowIndex].Cells[11].Value}, HakPembayaran = {dgv.Rows[e.RowIndex].Cells[12].Value} WHERE Username = '{dgv.Rows[e.RowIndex].Cells[1].Value}'");
            user = daftarUser.Find(x => x.Username == SVal(dgv.Rows[e.RowIndex].Cells[1].Value));
            user.HakUser = BVal(dgv.Rows[e.RowIndex].Cells[3].Value);
            user.HakAlat = BVal(dgv.Rows[e.RowIndex].Cells[4].Value);
            user.HakTindakan = BVal(dgv.Rows[e.RowIndex].Cells[5].Value);
            user.HakKamar = BVal(dgv.Rows[e.RowIndex].Cells[6].Value);
            user.HakObat = BVal(dgv.Rows[e.RowIndex].Cells[7].Value);
            user.HakDokter = BVal(dgv.Rows[e.RowIndex].Cells[8].Value);
            user.HakPasien = BVal(dgv.Rows[e.RowIndex].Cells[9].Value);
            user.HakRegistrasi = BVal(dgv.Rows[e.RowIndex].Cells[10].Value);
            user.HakPerawatan = BVal(dgv.Rows[e.RowIndex].Cells[11].Value);
            user.HakPembayaran = BVal(dgv.Rows[e.RowIndex].Cells[12].Value);
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
