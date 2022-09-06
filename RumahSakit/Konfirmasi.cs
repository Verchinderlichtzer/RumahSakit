using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class Konfirmasi : Form
    {
        public enum Jenis
        {
            Confirmation,
            Pagination,
            ChangePassword
        }

        readonly Jenis jns;

        public Konfirmasi(string judul, string deskripsi, int gambar, Jenis jenis = Jenis.Confirmation)
        {
            InitializeComponent();
            jns = jenis;
            lblTitle.Text = judul;
            tDeskripsi.Text = deskripsi;
            if (gambar == 0)
            {
                pcIcon.Image = new Bitmap(Properties.Resources.question);
            }
            else if (gambar == 1)
            {
                pcIcon.Image = new Bitmap(Properties.Resources.exclamation);
            }
            if (jenis == Jenis.Confirmation) return;
            if (jenis == Jenis.Pagination) // Goto Page
            {
                t1.UseSystemPasswordChar = false;
                t1.PasswordChar = '\0';
            }
            else
            {
                t2.Visible = true;
            }
            btnYa.Text = "Ok";
            btnTidak.Text = "Batal";
            t1.Visible = true;
            t1.Focus();
        }

        void InputAngka(object sender, KeyPressEventArgs e)
        {
            if (jns == Jenis.Pagination)
            {
                t1.Text = t1.Text.TrimStart('0');
                Numbers(sender, e);
            }
        }

        void T1_TextChanged(object sender, EventArgs e)
        {
            if (jns == Jenis.Pagination && IVal(t1.Text) > IVal(lblTitle.Text.Mid(lblTitle.Text.IndexOf('~') + 2)))
            {
                t1.Text = lblTitle.Text.Mid(lblTitle.Text.IndexOf('~') + 2);
                t1.SelectionStart = t1.Text.Length;
            }
        }

        void BTNYa_Click(object sender, EventArgs e)
        {
            if (jns == Jenis.ChangePassword)
            {
                string result = (from x in daftarUser where x.Username == userAktif && x.Password == EncodePassword(userAktif, t1.Text) select x.Username).FirstOrDefault();
                if (string.IsNullOrEmpty(t1.Text) || string.IsNullOrEmpty(t2.Text))
                {
                    Pesan("Password kosong", Notifikasi.Jenis.Gagal);
                    return;
                }
                else if (result == null)
                {
                    Pesan("Password lama salah", Notifikasi.Jenis.Gagal);
                    return;
                }
                else if (t1.Text == t2.Text)
                {
                    Pesan("Password sama", Notifikasi.Jenis.Gagal);
                    return;
                }
                else
                {
                    QN("UPDATE Users SET Pw = '" + EncodePassword(userAktif, t2.Text) + "' WHERE Username = '" + userAktif + "'");
                    Pesan("Password berhasil diubah", Notifikasi.Jenis.Berhasil);
                }
            }
            else if (jns == Jenis.Pagination)
            {
                halamanTerpilih = IVal(t1.Text);
            }
            DialogResult = DialogResult.Yes;
        }

        void BTNTidak_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        protected override bool ProcessCmdKey(ref Message Msg, Keys Koentji)
        {
            if (Koentji == Keys.Enter)
            {
                btnYa.PerformClick();
                return true;
            }
            else if (Koentji == Keys.Escape)
            {
                btnTidak.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref Msg, Koentji);
        }
    }
}
