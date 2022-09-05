using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32")]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        void Login_VisibleChanged(object sender, EventArgs e)
        {
            tUsername.Clear();
            tPassword.Clear();
            cbCookies.Checked = false;
            tUsername.Focus();
        }

        void Login_Load(object sender, EventArgs e)
        {
            login = this;
            if (IsKeyLocked(Keys.CapsLock))
            {
                keybd_event((byte)Keys.CapsLock, 0x14, 1, 0);
                keybd_event((byte)Keys.CapsLock, 0x14, 3, 0);
            }
        }

        void InputKarakter(object sender, KeyPressEventArgs e)
        {
            Characters(sender, e);
        }

        void Valid(object sender, EventArgs e)
        {
            btnOk.Enabled = !string.IsNullOrEmpty(tUsername.Text) && !string.IsNullOrEmpty(tPassword.Text);
        }

        void BTNOk_Click(object sender, EventArgs e)
        {
            QR("SELECT Username FROM Users WHERE Username = '" + tUsername.Text + "' AND Pw = '" + EncodePassword(tUsername.Text, tPassword.Text) + "'");
            if (!dr.HasRows)
            {
                Pesan("Username / password salah", Notifikasi.Jenis.Gagal);
            }
            else
            {
                if (cbCookies.Checked) SetReg("LoggedIn", EncodeUsername(tUsername.Text));
                userAktif = SVal(dr[0]);
                (fmain ?? (fmain = new FMain())).Show();
                Visible = false;
            }
        }

        void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys koentji)
        {
            if (koentji == Keys.Enter)
            {
                btnOk.PerformClick();
                return true;
            }
            else if (koentji == Keys.Escape)
            {
                Application.ExitThread();
                return true;
            }
            return base.ProcessCmdKey(ref msg, koentji);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var CP = base.CreateParams;
                // CP.Style = &HA0000
                CP.ExStyle |= 0x2000000;
                return CP;
            }
        }
    }
}