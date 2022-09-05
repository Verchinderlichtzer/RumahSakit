using Krypton.Toolkit;
using System;
using System.Linq;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class FMain : Form
    {
        Panel panelMenu;
        bool isCollapsed;
        public FMain()
        {
            InitializeComponent();
        }

        void TampilMenu(object sender, EventArgs e)
        {
            KryptonLabel label = sender as KryptonLabel;
            if (label.Name == "lblFile")
            {
                panelMenu = panelFile;
            }
            else if (label.Name == "lblTransaksi")
            {
                panelMenu = panelTransaksi;
            }
            else if (label.Name == "lblLainnya")
            {
                panelMenu = panelLainnya;
            }
            if (panelMenu.Size == panelMenu.MinimumSize)
            {
                isCollapsed = true;
                label.Values.Image = Properties.Resources.menu_hide;
            }
            else if (panelMenu.Size == panelMenu.MaximumSize)
            {
                isCollapsed = false;
                label.Values.Image = Properties.Resources.menu_show;
            }
            timer1.Start();
        }

        void Timer1_Tick(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                panelMenu.Height -= 16;
                if (panelMenu.Size == panelMenu.MinimumSize) timer1.Stop();
            }
            else if (isCollapsed)
            {
                panelMenu.Height += 16;
                if (panelMenu.Size == panelMenu.MaximumSize) timer1.Stop();
            }
        }

        void FormTerpilih(Form ChildForm)
        {
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            panelForm.Controls.Clear();
            panelForm.Controls.Add(ChildForm);
            panelForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        void PilihMenu(object sender, EventArgs e)
        {
            foreach (KryptonCheckButton x in new KryptonCheckButton[] { thumbnail, btnUser, btnAlat, btnTindakan, btnKamar, btnObat, btnDokter, btnPasien, btnRegistrasi, btnPerawatan, btnPembayaran, btnCatatan, btnLaporan }) x.Checked = ReferenceEquals(x, sender);
            if (sender == thumbnail)
            {
                FormTerpilih(new FDashboard());
            }
            else if (sender == btnUser)
            {
                FormTerpilih(new FUser());
            }
            else if (sender == btnAlat)
            {
                FormTerpilih(new FAlat());
            }
            else if (sender == btnTindakan)
            {
                FormTerpilih(new FTindakan());
            }
            else if (sender == btnKamar)
            {
                FormTerpilih(new FKamar());
            }
            else if (sender == btnObat)
            {
                FormTerpilih(new FObat());
            }
            else if (sender == btnDokter)
            {
                FormTerpilih(new FDokter());
            }
            else if (sender == btnPasien)
            {
                FormTerpilih(new FPasien());
            }
            else if (sender == btnRegistrasi)
            {
                FormTerpilih(new FRegistrasi());
            }
            else if (sender == btnPerawatan)
            {
                FormTerpilih(new FPerawatan());
            }
            else if (sender == btnPembayaran)
            {
                FormTerpilih(new FPembayaran());
            }
            else if (sender == btnCatatan)
            {
                FormTerpilih(new FCatatan());
            }
            else if (sender == btnLaporan)
            {
                FormTerpilih(new FLaporan());
            }
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

        void FMain_Load(object sender, EventArgs e)
        {
            fmain = this;
            if (IVal(GetReg("IsSavingResolution")) == 1)
            {
                Size = new System.Drawing.Size(IVal(GetReg("CurResolution").Left(GetReg("CurResolution").IndexOf('x'))), IVal(GetReg("CurResolution").Mid(GetReg("CurResolution").IndexOf('x') + 1)));
                WindowState = GetReg("CurState") == "Maximized" ? FormWindowState.Maximized : FormWindowState.Normal;
                CenterToScreen();
            }
        }

        void FMain_VisibleChanged(object sender, EventArgs e)
        {
            thumbnail.PerformClick();
            int kolom = 0;
            btnUser.Enabled = userAktif.Equals("admin", StringComparison.OrdinalIgnoreCase);
            QR("SELECT HakUser, HakAlat, HakTindakan, HakKamar, HakObat, HakDokter, HakPasien, HakRegistrasi, HakPerawatan, HakPembayaran FROM Users WHERE Username = '" + userAktif + "'");
            hakAkses = new[] { BVal(dr[0]), BVal(dr[1]), BVal(dr[2]), BVal(dr[3]), BVal(dr[4]), BVal(dr[5]), BVal(dr[6]), BVal(dr[7]), BVal(dr[8]), BVal(dr[9]) };
            // Semua BTNMenu, kecuali User dan Kategori Lain
            //foreach (KryptonCheckButton btn in (new object[] { btnUser, btnAlat, btnTindakan, btnKamar, btnObat, btnDokter, btnPasien, btnRegistrasi, btnPerawatan, btnPembayaran }).Cast<KryptonCheckButton>()) btn.Enabled = hakAkses[kolom++];
            foreach (KryptonCheckButton btn in (new object[] { btnUser, btnRegistrasi, btnPerawatan, btnPembayaran }).Cast<KryptonCheckButton>()) btn.Enabled = hakAkses[kolom++];
        }

        void BTNLogout_Click(object sender, EventArgs e)
        {
            SetReg("LoggedIn", string.Empty);
            Visible = false;
            (login ?? (login = new Login())).Show();
        }

        void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IVal(GetReg("IsSavingResolution")) == 1)
            {
                if (WindowState != FormWindowState.Maximized) SetReg("CurResolution", Size.Width + "x" + Size.Height);
                SetReg("CurState", SVal(WindowState));
            }
            Application.ExitThread();
        }
    }
}
