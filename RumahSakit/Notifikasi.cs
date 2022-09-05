using System;
using System.Drawing;
using System.Windows.Forms;

namespace RumahSakit
{
    public partial class Notifikasi : Form
    {
        int x, y;

        public Notifikasi()
        {
            InitializeComponent();
        }

        public enum Jenis
        {
            Gagal,
            Berhasil
        }

        public void SetAlert(string msg, Jenis type)
        {
            Opacity = 0d;
            StartPosition = FormStartPosition.Manual;
            const string fname = "Peringatan";
            Notifikasi f = (Notifikasi)Application.OpenForms[fname];
            if (f is null)
            {
                Name = fname;
                x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                y = Screen.PrimaryScreen.WorkingArea.Height - Height - 5;
                Location = new Point(x, y);
            }
            x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;
            switch (type)
            {
                case Jenis.Berhasil:
                    {
                        notif.Values.Image = new Bitmap(Properties.Resources.berhasil);
                        notif.OverrideDefault.Border.Color1 = Color.FromArgb(2, 147, 125);
                        notif.StateCommon.Border.Color1 = Color.FromArgb(2, 147, 125);
                        notif.StateCommon.Content.ShortText.Color1 = Color.FromArgb(1, 110, 93);
                        break;
                    }
                case Jenis.Gagal:
                    {
                        notif.Values.Image = new Bitmap(Properties.Resources.gagal);
                        notif.OverrideDefault.Border.Color1 = Color.FromArgb(254, 55, 83);
                        notif.StateCommon.Border.Color1 = Color.FromArgb(254, 55, 83);
                        notif.StateCommon.Content.ShortText.Color1 = Color.FromArgb(190, 41, 62);
                        break;
                    }
            }
            notif.Text = msg;
            Show();
            timer1.Interval = 1;
            timer1.Start();
        }

        enum ActionEnum
        {
            Wait,
            Start,
            Close
        }

        ActionEnum Action = ActionEnum.Start;

        void Waktu(object sender, EventArgs e)
        {
            switch (Action)
            {
                case ActionEnum.Start:
                    {
                        timer1.Interval = 1;
                        Opacity += 0.1d;
                        if (x < Location.X)
                        {
                            Left--;
                        }
                        else if (Opacity == 1d)
                        {
                            Action = ActionEnum.Wait;
                        }
                        break;
                    }
                case ActionEnum.Wait:
                    {
                        timer1.Interval = 1250;
                        Action = ActionEnum.Close;
                        break;
                    }
                case ActionEnum.Close:
                    {
                        timer1.Interval = 1;
                        Opacity -= 0.1d;
                        Left -= 3;
                        if (Opacity == 0d) Close();
                        break;
                    }
            }
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }
    }
}
