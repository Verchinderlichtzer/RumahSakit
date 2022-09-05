namespace RumahSakit
{
    partial class Notifikasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifikasi));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notif = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1250;
            this.timer1.Tick += new System.EventHandler(this.Waktu);
            // 
            // notif
            // 
            this.notif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notif.Location = new System.Drawing.Point(0, 0);
            this.notif.Name = "notif";
            this.notif.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.notif.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.notif.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.notif.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.notif.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.notif.Size = new System.Drawing.Size(400, 70);
            this.notif.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.notif.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.notif.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.notif.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.notif.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.notif.StateCommon.Border.Width = 3;
            this.notif.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.notif.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.notif.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.notif.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.notif.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notif.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.notif.TabIndex = 5;
            this.notif.Values.Text = "Notifikasi";
            // 
            // Notifikasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 70);
            this.Controls.Add(this.notif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notifikasi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notifikasi";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        internal Krypton.Toolkit.KryptonButton notif;
    }
}