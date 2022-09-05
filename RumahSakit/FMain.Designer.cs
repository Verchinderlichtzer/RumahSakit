namespace RumahSakit
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.palet = new Krypton.Toolkit.KryptonPalette(this.components);
            this.sidebar = new Krypton.Toolkit.KryptonPanel();
            this.panelLainnya = new System.Windows.Forms.Panel();
            this.btnLogout = new Krypton.Toolkit.KryptonButton();
            this.btnLaporan = new Krypton.Toolkit.KryptonCheckButton();
            this.btnCatatan = new Krypton.Toolkit.KryptonCheckButton();
            this.lblLainnya = new Krypton.Toolkit.KryptonLabel();
            this.panelTransaksi = new System.Windows.Forms.Panel();
            this.btnPembayaran = new Krypton.Toolkit.KryptonCheckButton();
            this.btnPerawatan = new Krypton.Toolkit.KryptonCheckButton();
            this.btnRegistrasi = new Krypton.Toolkit.KryptonCheckButton();
            this.lblTransaksi = new Krypton.Toolkit.KryptonLabel();
            this.panelFile = new System.Windows.Forms.Panel();
            this.btnPasien = new Krypton.Toolkit.KryptonCheckButton();
            this.btnDokter = new Krypton.Toolkit.KryptonCheckButton();
            this.btnObat = new Krypton.Toolkit.KryptonCheckButton();
            this.btnKamar = new Krypton.Toolkit.KryptonCheckButton();
            this.btnTindakan = new Krypton.Toolkit.KryptonCheckButton();
            this.btnAlat = new Krypton.Toolkit.KryptonCheckButton();
            this.btnUser = new Krypton.Toolkit.KryptonCheckButton();
            this.lblFile = new Krypton.Toolkit.KryptonLabel();
            this.thumbnail = new Krypton.Toolkit.KryptonCheckButton();
            this.panelForm = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sidebar)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panelLainnya.SuspendLayout();
            this.panelTransaksi.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // palet
            // 
            this.palet.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.palet.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.palet.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.palet.GridStyles.GridCommon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.palet.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.palet.GridStyles.GridCommon.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.palet.Images.CheckBox.CheckedDisabled = global::RumahSakit.Properties.Resources.check_true_disable;
            this.palet.Images.CheckBox.CheckedNormal = global::RumahSakit.Properties.Resources.check_true;
            this.palet.Images.CheckBox.CheckedPressed = global::RumahSakit.Properties.Resources.check_true;
            this.palet.Images.CheckBox.CheckedTracking = global::RumahSakit.Properties.Resources.check_true;
            this.palet.Images.CheckBox.Common = global::RumahSakit.Properties.Resources.check_false;
            this.palet.Images.CheckBox.UncheckedDisabled = global::RumahSakit.Properties.Resources.check_false_disable;
            this.palet.Images.RadioButton.CheckedDisabled = global::RumahSakit.Properties.Resources.radio_true_disable;
            this.palet.Images.RadioButton.CheckedNormal = global::RumahSakit.Properties.Resources.radio_true;
            this.palet.Images.RadioButton.CheckedPressed = global::RumahSakit.Properties.Resources.radio_true;
            this.palet.Images.RadioButton.CheckedTracking = global::RumahSakit.Properties.Resources.radio_true;
            this.palet.Images.RadioButton.Common = global::RumahSakit.Properties.Resources.radio_false;
            this.palet.Images.RadioButton.UncheckedDisabled = global::RumahSakit.Properties.Resources.radio_false_disable;
            this.palet.InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.palet.InputControlStyles.InputControlCustom3.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.palet.InputControlStyles.InputControlCustom3.StateActive.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.palet.InputControlStyles.InputControlCustom3.StateActive.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.palet.InputControlStyles.InputControlCustom3.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.palet.InputControlStyles.InputControlCustom3.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.palet.InputControlStyles.InputControlCustom3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.palet.InputControlStyles.InputControlCustom3.StateCommon.Border.Rounding = 0F;
            this.palet.InputControlStyles.InputControlCustom3.StateCommon.Border.Width = 1;
            this.palet.InputControlStyles.InputControlCustom3.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.palet.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.palet.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.palet.InputControlStyles.InputControlCustom3.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.palet.InputControlStyles.InputControlCustom3.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.palet.InputControlStyles.InputControlCustom3.StateDisabled.Border.Rounding = 0F;
            this.palet.InputControlStyles.InputControlCustom3.StateDisabled.Border.Width = 1;
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.panelLainnya);
            this.sidebar.Controls.Add(this.panelTransaksi);
            this.sidebar.Controls.Add(this.panelFile);
            this.sidebar.Controls.Add(this.thumbnail);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Palette = this.palet;
            this.sidebar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.sidebar.Size = new System.Drawing.Size(160, 640);
            this.sidebar.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.sidebar.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.sidebar.TabIndex = 890;
            // 
            // panelLainnya
            // 
            this.panelLainnya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.panelLainnya.Controls.Add(this.btnLogout);
            this.panelLainnya.Controls.Add(this.btnLaporan);
            this.panelLainnya.Controls.Add(this.btnCatatan);
            this.panelLainnya.Controls.Add(this.lblLainnya);
            this.panelLainnya.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLainnya.Location = new System.Drawing.Point(0, 508);
            this.panelLainnya.MaximumSize = new System.Drawing.Size(160, 128);
            this.panelLainnya.MinimumSize = new System.Drawing.Size(160, 32);
            this.panelLainnya.Name = "panelLainnya";
            this.panelLainnya.Size = new System.Drawing.Size(160, 128);
            this.panelLainnya.TabIndex = 937;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.Location = new System.Drawing.Point(0, 96);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnLogout.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnLogout.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnLogout.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnLogout.Palette = this.palet;
            this.btnLogout.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnLogout.Size = new System.Drawing.Size(160, 32);
            this.btnLogout.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnLogout.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnLogout.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnLogout.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnLogout.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnLogout.StateCommon.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnLogout.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLogout.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnLogout.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnLogout.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnLogout.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnLogout.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.btnLogout.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnLogout.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnLogout.TabIndex = 77;
            this.btnLogout.Values.Image = global::RumahSakit.Properties.Resources.menu_logout_default;
            this.btnLogout.Values.ImageStates.ImageCheckedNormal = null;
            this.btnLogout.Values.ImageStates.ImageCheckedPressed = null;
            this.btnLogout.Values.ImageStates.ImageCheckedTracking = null;
            this.btnLogout.Values.ImageStates.ImagePressed = global::RumahSakit.Properties.Resources.menu_logout;
            this.btnLogout.Values.ImageStates.ImageTracking = global::RumahSakit.Properties.Resources.menu_logout_tracking;
            this.btnLogout.Values.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.BTNLogout_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaporan.Location = new System.Drawing.Point(0, 64);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnLaporan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnLaporan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnLaporan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnLaporan.Palette = this.palet;
            this.btnLaporan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnLaporan.Size = new System.Drawing.Size(160, 32);
            this.btnLaporan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnLaporan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnLaporan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnLaporan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnLaporan.StateCommon.Border.Rounding = 0F;
            this.btnLaporan.StateCommon.Border.Width = 2;
            this.btnLaporan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnLaporan.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnLaporan.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.btnLaporan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnLaporan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnLaporan.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnLaporan.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnLaporan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnLaporan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnLaporan.StateDisabled.Border.Rounding = 0F;
            this.btnLaporan.StateDisabled.Border.Width = 2;
            this.btnLaporan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnLaporan.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnLaporan.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnLaporan.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnLaporan.StateNormal.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnLaporan.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLaporan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnLaporan.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnLaporan.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnLaporan.StatePressed.Border.Rounding = 0F;
            this.btnLaporan.StatePressed.Border.Width = 2;
            this.btnLaporan.StatePressed.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnLaporan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.btnLaporan.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnLaporan.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnLaporan.StateTracking.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnLaporan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnLaporan.TabIndex = 75;
            this.btnLaporan.Values.Image = global::RumahSakit.Properties.Resources.menu_laporan;
            this.btnLaporan.Values.ImageStates.ImageNormal = global::RumahSakit.Properties.Resources.menu_laporan_default;
            this.btnLaporan.Values.ImageStates.ImageTracking = global::RumahSakit.Properties.Resources.menu_laporan_tracking;
            this.btnLaporan.Values.Text = "Laporan";
            this.btnLaporan.Click += new System.EventHandler(this.PilihMenu);
            // 
            // btnCatatan
            // 
            this.btnCatatan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatatan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatatan.Location = new System.Drawing.Point(0, 32);
            this.btnCatatan.Name = "btnCatatan";
            this.btnCatatan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnCatatan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCatatan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnCatatan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnCatatan.Palette = this.palet;
            this.btnCatatan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnCatatan.Size = new System.Drawing.Size(160, 32);
            this.btnCatatan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnCatatan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCatatan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnCatatan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnCatatan.StateCommon.Border.Rounding = 0F;
            this.btnCatatan.StateCommon.Border.Width = 2;
            this.btnCatatan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnCatatan.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnCatatan.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.btnCatatan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnCatatan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatatan.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnCatatan.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnCatatan.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCatatan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnCatatan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnCatatan.StateDisabled.Border.Rounding = 0F;
            this.btnCatatan.StateDisabled.Border.Width = 2;
            this.btnCatatan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnCatatan.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnCatatan.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCatatan.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnCatatan.StateNormal.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnCatatan.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCatatan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnCatatan.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCatatan.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnCatatan.StatePressed.Border.Rounding = 0F;
            this.btnCatatan.StatePressed.Border.Width = 2;
            this.btnCatatan.StatePressed.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnCatatan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.btnCatatan.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCatatan.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnCatatan.StateTracking.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnCatatan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnCatatan.TabIndex = 74;
            this.btnCatatan.Values.Image = global::RumahSakit.Properties.Resources.menu_catatan;
            this.btnCatatan.Values.ImageStates.ImageNormal = global::RumahSakit.Properties.Resources.menu_catatan_default;
            this.btnCatatan.Values.ImageStates.ImageTracking = global::RumahSakit.Properties.Resources.menu_catatan_tracking;
            this.btnCatatan.Values.Text = "Catatan";
            this.btnCatatan.Click += new System.EventHandler(this.PilihMenu);
            // 
            // lblLainnya
            // 
            this.lblLainnya.AutoSize = false;
            this.lblLainnya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLainnya.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLainnya.Location = new System.Drawing.Point(0, 0);
            this.lblLainnya.Name = "lblLainnya";
            this.lblLainnya.Palette = this.palet;
            this.lblLainnya.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblLainnya.Size = new System.Drawing.Size(160, 32);
            this.lblLainnya.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblLainnya.StateCommon.Padding = new System.Windows.Forms.Padding(24, -1, -1, -1);
            this.lblLainnya.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblLainnya.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblLainnya.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLainnya.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblLainnya.TabIndex = 76;
            this.lblLainnya.Values.Image = global::RumahSakit.Properties.Resources.menu_hide;
            this.lblLainnya.Values.Text = "Lainnya";
            this.lblLainnya.Click += new System.EventHandler(this.TampilMenu);
            // 
            // panelTransaksi
            // 
            this.panelTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.panelTransaksi.Controls.Add(this.btnPembayaran);
            this.panelTransaksi.Controls.Add(this.btnPerawatan);
            this.panelTransaksi.Controls.Add(this.btnRegistrasi);
            this.panelTransaksi.Controls.Add(this.lblTransaksi);
            this.panelTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTransaksi.Location = new System.Drawing.Point(0, 380);
            this.panelTransaksi.MaximumSize = new System.Drawing.Size(160, 128);
            this.panelTransaksi.MinimumSize = new System.Drawing.Size(160, 32);
            this.panelTransaksi.Name = "panelTransaksi";
            this.panelTransaksi.Size = new System.Drawing.Size(160, 128);
            this.panelTransaksi.TabIndex = 936;
            // 
            // btnPembayaran
            // 
            this.btnPembayaran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPembayaran.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPembayaran.Location = new System.Drawing.Point(0, 96);
            this.btnPembayaran.Name = "btnPembayaran";
            this.btnPembayaran.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnPembayaran.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPembayaran.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnPembayaran.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnPembayaran.Palette = this.palet;
            this.btnPembayaran.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnPembayaran.Size = new System.Drawing.Size(160, 32);
            this.btnPembayaran.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnPembayaran.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPembayaran.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnPembayaran.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnPembayaran.StateCommon.Border.Rounding = 0F;
            this.btnPembayaran.StateCommon.Border.Width = 2;
            this.btnPembayaran.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnPembayaran.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnPembayaran.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.btnPembayaran.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnPembayaran.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPembayaran.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnPembayaran.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnPembayaran.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPembayaran.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnPembayaran.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnPembayaran.StateDisabled.Border.Rounding = 0F;
            this.btnPembayaran.StateDisabled.Border.Width = 2;
            this.btnPembayaran.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnPembayaran.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnPembayaran.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPembayaran.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnPembayaran.StateNormal.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnPembayaran.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPembayaran.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnPembayaran.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPembayaran.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnPembayaran.StatePressed.Border.Rounding = 0F;
            this.btnPembayaran.StatePressed.Border.Width = 2;
            this.btnPembayaran.StatePressed.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnPembayaran.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.btnPembayaran.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPembayaran.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnPembayaran.StateTracking.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnPembayaran.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnPembayaran.TabIndex = 72;
            this.btnPembayaran.Values.Image = global::RumahSakit.Properties.Resources.menu_pembayaran;
            this.btnPembayaran.Values.ImageStates.ImageNormal = global::RumahSakit.Properties.Resources.menu_pembayaran_default;
            this.btnPembayaran.Values.ImageStates.ImageTracking = global::RumahSakit.Properties.Resources.menu_pembayaran_tracking;
            this.btnPembayaran.Values.Text = "Pembayaran";
            this.btnPembayaran.Click += new System.EventHandler(this.PilihMenu);
            // 
            // btnPerawatan
            // 
            this.btnPerawatan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerawatan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerawatan.Location = new System.Drawing.Point(0, 64);
            this.btnPerawatan.Name = "btnPerawatan";
            this.btnPerawatan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnPerawatan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPerawatan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnPerawatan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnPerawatan.Palette = this.palet;
            this.btnPerawatan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnPerawatan.Size = new System.Drawing.Size(160, 32);
            this.btnPerawatan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnPerawatan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPerawatan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnPerawatan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnPerawatan.StateCommon.Border.Rounding = 0F;
            this.btnPerawatan.StateCommon.Border.Width = 2;
            this.btnPerawatan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnPerawatan.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnPerawatan.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.btnPerawatan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnPerawatan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerawatan.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnPerawatan.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnPerawatan.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPerawatan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnPerawatan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnPerawatan.StateDisabled.Border.Rounding = 0F;
            this.btnPerawatan.StateDisabled.Border.Width = 2;
            this.btnPerawatan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnPerawatan.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnPerawatan.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPerawatan.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnPerawatan.StateNormal.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnPerawatan.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPerawatan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnPerawatan.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPerawatan.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnPerawatan.StatePressed.Border.Rounding = 0F;
            this.btnPerawatan.StatePressed.Border.Width = 2;
            this.btnPerawatan.StatePressed.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnPerawatan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.btnPerawatan.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPerawatan.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnPerawatan.StateTracking.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnPerawatan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnPerawatan.TabIndex = 71;
            this.btnPerawatan.Values.Image = global::RumahSakit.Properties.Resources.menu_perawatan;
            this.btnPerawatan.Values.ImageStates.ImageNormal = global::RumahSakit.Properties.Resources.menu_perawatan_default;
            this.btnPerawatan.Values.ImageStates.ImageTracking = global::RumahSakit.Properties.Resources.menu_perawatan_tracking;
            this.btnPerawatan.Values.Text = "Perawatan";
            this.btnPerawatan.Click += new System.EventHandler(this.PilihMenu);
            // 
            // btnRegistrasi
            // 
            this.btnRegistrasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrasi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrasi.Location = new System.Drawing.Point(0, 32);
            this.btnRegistrasi.Name = "btnRegistrasi";
            this.btnRegistrasi.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnRegistrasi.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegistrasi.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnRegistrasi.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnRegistrasi.Palette = this.palet;
            this.btnRegistrasi.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnRegistrasi.Size = new System.Drawing.Size(160, 32);
            this.btnRegistrasi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnRegistrasi.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegistrasi.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnRegistrasi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnRegistrasi.StateCommon.Border.Rounding = 0F;
            this.btnRegistrasi.StateCommon.Border.Width = 2;
            this.btnRegistrasi.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnRegistrasi.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnRegistrasi.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.btnRegistrasi.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnRegistrasi.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrasi.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnRegistrasi.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnRegistrasi.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegistrasi.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnRegistrasi.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnRegistrasi.StateDisabled.Border.Rounding = 0F;
            this.btnRegistrasi.StateDisabled.Border.Width = 2;
            this.btnRegistrasi.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnRegistrasi.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnRegistrasi.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegistrasi.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnRegistrasi.StateNormal.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnRegistrasi.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRegistrasi.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnRegistrasi.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegistrasi.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnRegistrasi.StatePressed.Border.Rounding = 0F;
            this.btnRegistrasi.StatePressed.Border.Width = 2;
            this.btnRegistrasi.StatePressed.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnRegistrasi.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.btnRegistrasi.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegistrasi.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnRegistrasi.StateTracking.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnRegistrasi.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnRegistrasi.TabIndex = 69;
            this.btnRegistrasi.Values.Image = global::RumahSakit.Properties.Resources.menu_registrasi;
            this.btnRegistrasi.Values.ImageStates.ImageNormal = global::RumahSakit.Properties.Resources.menu_registrasi_default;
            this.btnRegistrasi.Values.ImageStates.ImageTracking = global::RumahSakit.Properties.Resources.menu_registrasi_tracking;
            this.btnRegistrasi.Values.Text = "Registrasi";
            this.btnRegistrasi.Click += new System.EventHandler(this.PilihMenu);
            // 
            // lblTransaksi
            // 
            this.lblTransaksi.AutoSize = false;
            this.lblTransaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTransaksi.Location = new System.Drawing.Point(0, 0);
            this.lblTransaksi.Name = "lblTransaksi";
            this.lblTransaksi.Palette = this.palet;
            this.lblTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTransaksi.Size = new System.Drawing.Size(160, 32);
            this.lblTransaksi.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblTransaksi.StateCommon.Padding = new System.Windows.Forms.Padding(24, -1, -1, -1);
            this.lblTransaksi.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblTransaksi.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTransaksi.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaksi.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTransaksi.TabIndex = 70;
            this.lblTransaksi.Values.Image = global::RumahSakit.Properties.Resources.menu_hide;
            this.lblTransaksi.Values.Text = "Transaksi";
            this.lblTransaksi.Click += new System.EventHandler(this.TampilMenu);
            // 
            // panelFile
            // 
            this.panelFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.panelFile.Controls.Add(this.btnPasien);
            this.panelFile.Controls.Add(this.btnDokter);
            this.panelFile.Controls.Add(this.btnObat);
            this.panelFile.Controls.Add(this.btnKamar);
            this.panelFile.Controls.Add(this.btnTindakan);
            this.panelFile.Controls.Add(this.btnAlat);
            this.panelFile.Controls.Add(this.btnUser);
            this.panelFile.Controls.Add(this.lblFile);
            this.panelFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFile.Location = new System.Drawing.Point(0, 124);
            this.panelFile.MaximumSize = new System.Drawing.Size(160, 256);
            this.panelFile.MinimumSize = new System.Drawing.Size(160, 32);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(160, 256);
            this.panelFile.TabIndex = 935;
            // 
            // btnPasien
            // 
            this.btnPasien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPasien.Location = new System.Drawing.Point(0, 224);
            this.btnPasien.Name = "btnPasien";
            this.btnPasien.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnPasien.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPasien.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnPasien.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnPasien.Palette = this.palet;
            this.btnPasien.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnPasien.Size = new System.Drawing.Size(160, 32);
            this.btnPasien.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnPasien.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPasien.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnPasien.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnPasien.StateCommon.Border.Rounding = 0F;
            this.btnPasien.StateCommon.Border.Width = 2;
            this.btnPasien.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnPasien.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnPasien.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.btnPasien.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnPasien.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasien.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnPasien.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnPasien.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPasien.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnPasien.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnPasien.StateDisabled.Border.Rounding = 0F;
            this.btnPasien.StateDisabled.Border.Width = 2;
            this.btnPasien.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnPasien.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnPasien.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPasien.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnPasien.StateNormal.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnPasien.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPasien.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnPasien.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPasien.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnPasien.StatePressed.Border.Rounding = 0F;
            this.btnPasien.StatePressed.Border.Width = 2;
            this.btnPasien.StatePressed.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnPasien.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.btnPasien.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnPasien.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnPasien.StateTracking.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnPasien.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnPasien.TabIndex = 72;
            this.btnPasien.Values.Image = global::RumahSakit.Properties.Resources.menu_pasien;
            this.btnPasien.Values.ImageStates.ImageNormal = global::RumahSakit.Properties.Resources.menu_pasien_default;
            this.btnPasien.Values.ImageStates.ImageTracking = global::RumahSakit.Properties.Resources.menu_pasien_tracking;
            this.btnPasien.Values.Text = "Pasien";
            this.btnPasien.Click += new System.EventHandler(this.PilihMenu);
            // 
            // btnDokter
            // 
            this.btnDokter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDokter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDokter.Location = new System.Drawing.Point(0, 192);
            this.btnDokter.Name = "btnDokter";
            this.btnDokter.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnDokter.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDokter.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnDokter.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnDokter.Palette = this.palet;
            this.btnDokter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnDokter.Size = new System.Drawing.Size(160, 32);
            this.btnDokter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnDokter.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDokter.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnDokter.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnDokter.StateCommon.Border.Rounding = 0F;
            this.btnDokter.StateCommon.Border.Width = 2;
            this.btnDokter.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnDokter.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnDokter.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.btnDokter.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnDokter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDokter.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnDokter.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnDokter.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDokter.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnDokter.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnDokter.StateDisabled.Border.Rounding = 0F;
            this.btnDokter.StateDisabled.Border.Width = 2;
            this.btnDokter.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnDokter.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnDokter.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDokter.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnDokter.StateNormal.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnDokter.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDokter.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnDokter.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDokter.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnDokter.StatePressed.Border.Rounding = 0F;
            this.btnDokter.StatePressed.Border.Width = 2;
            this.btnDokter.StatePressed.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnDokter.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.btnDokter.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDokter.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnDokter.StateTracking.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnDokter.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnDokter.TabIndex = 71;
            this.btnDokter.Values.Image = global::RumahSakit.Properties.Resources.menu_dokter;
            this.btnDokter.Values.ImageStates.ImageNormal = global::RumahSakit.Properties.Resources.menu_dokter_default;
            this.btnDokter.Values.ImageStates.ImageTracking = global::RumahSakit.Properties.Resources.menu_dokter_tracking;
            this.btnDokter.Values.Text = "Dokter";
            this.btnDokter.Click += new System.EventHandler(this.PilihMenu);
            // 
            // btnObat
            // 
            this.btnObat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnObat.Location = new System.Drawing.Point(0, 160);
            this.btnObat.Name = "btnObat";
            this.btnObat.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnObat.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnObat.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnObat.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnObat.Palette = this.palet;
            this.btnObat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnObat.Size = new System.Drawing.Size(160, 32);
            this.btnObat.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnObat.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnObat.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnObat.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnObat.StateCommon.Border.Rounding = 0F;
            this.btnObat.StateCommon.Border.Width = 2;
            this.btnObat.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnObat.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnObat.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.btnObat.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnObat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObat.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnObat.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnObat.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnObat.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnObat.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnObat.StateDisabled.Border.Rounding = 0F;
            this.btnObat.StateDisabled.Border.Width = 2;
            this.btnObat.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnObat.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnObat.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnObat.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnObat.StateNormal.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnObat.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnObat.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnObat.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnObat.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnObat.StatePressed.Border.Rounding = 0F;
            this.btnObat.StatePressed.Border.Width = 2;
            this.btnObat.StatePressed.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnObat.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.btnObat.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnObat.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnObat.StateTracking.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnObat.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnObat.TabIndex = 70;
            this.btnObat.Values.Image = global::RumahSakit.Properties.Resources.menu_obat;
            this.btnObat.Values.ImageStates.ImageNormal = global::RumahSakit.Properties.Resources.menu_obat_default;
            this.btnObat.Values.ImageStates.ImageTracking = global::RumahSakit.Properties.Resources.menu_obat_tracking;
            this.btnObat.Values.Text = "Obat";
            this.btnObat.Click += new System.EventHandler(this.PilihMenu);
            // 
            // btnKamar
            // 
            this.btnKamar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKamar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKamar.Location = new System.Drawing.Point(0, 128);
            this.btnKamar.Name = "btnKamar";
            this.btnKamar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnKamar.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnKamar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnKamar.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnKamar.Palette = this.palet;
            this.btnKamar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnKamar.Size = new System.Drawing.Size(160, 32);
            this.btnKamar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnKamar.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnKamar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnKamar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnKamar.StateCommon.Border.Rounding = 0F;
            this.btnKamar.StateCommon.Border.Width = 2;
            this.btnKamar.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnKamar.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnKamar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.btnKamar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnKamar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKamar.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnKamar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnKamar.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnKamar.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnKamar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnKamar.StateDisabled.Border.Rounding = 0F;
            this.btnKamar.StateDisabled.Border.Width = 2;
            this.btnKamar.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnKamar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnKamar.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnKamar.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnKamar.StateNormal.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnKamar.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnKamar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnKamar.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnKamar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnKamar.StatePressed.Border.Rounding = 0F;
            this.btnKamar.StatePressed.Border.Width = 2;
            this.btnKamar.StatePressed.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnKamar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.btnKamar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnKamar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnKamar.StateTracking.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnKamar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnKamar.TabIndex = 69;
            this.btnKamar.Values.Image = global::RumahSakit.Properties.Resources.menu_kamar;
            this.btnKamar.Values.ImageStates.ImageNormal = global::RumahSakit.Properties.Resources.menu_kamar_default;
            this.btnKamar.Values.ImageStates.ImageTracking = global::RumahSakit.Properties.Resources.menu_kamar_tracking;
            this.btnKamar.Values.Text = "Kamar";
            this.btnKamar.Click += new System.EventHandler(this.PilihMenu);
            // 
            // btnTindakan
            // 
            this.btnTindakan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTindakan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTindakan.Location = new System.Drawing.Point(0, 96);
            this.btnTindakan.Name = "btnTindakan";
            this.btnTindakan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnTindakan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTindakan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnTindakan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnTindakan.Palette = this.palet;
            this.btnTindakan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnTindakan.Size = new System.Drawing.Size(160, 32);
            this.btnTindakan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnTindakan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTindakan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnTindakan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnTindakan.StateCommon.Border.Rounding = 0F;
            this.btnTindakan.StateCommon.Border.Width = 2;
            this.btnTindakan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnTindakan.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnTindakan.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.btnTindakan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnTindakan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTindakan.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnTindakan.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnTindakan.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTindakan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnTindakan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnTindakan.StateDisabled.Border.Rounding = 0F;
            this.btnTindakan.StateDisabled.Border.Width = 2;
            this.btnTindakan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnTindakan.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnTindakan.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTindakan.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnTindakan.StateNormal.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnTindakan.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTindakan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnTindakan.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTindakan.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnTindakan.StatePressed.Border.Rounding = 0F;
            this.btnTindakan.StatePressed.Border.Width = 2;
            this.btnTindakan.StatePressed.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnTindakan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.btnTindakan.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTindakan.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnTindakan.StateTracking.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnTindakan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnTindakan.TabIndex = 68;
            this.btnTindakan.Values.Image = global::RumahSakit.Properties.Resources.menu_tindakan;
            this.btnTindakan.Values.ImageStates.ImageNormal = global::RumahSakit.Properties.Resources.menu_tindakan_default;
            this.btnTindakan.Values.ImageStates.ImageTracking = global::RumahSakit.Properties.Resources.menu_tindakan_tracking;
            this.btnTindakan.Values.Text = "Tindakan";
            this.btnTindakan.Click += new System.EventHandler(this.PilihMenu);
            // 
            // btnAlat
            // 
            this.btnAlat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlat.Location = new System.Drawing.Point(0, 64);
            this.btnAlat.Name = "btnAlat";
            this.btnAlat.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnAlat.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAlat.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnAlat.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnAlat.Palette = this.palet;
            this.btnAlat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnAlat.Size = new System.Drawing.Size(160, 32);
            this.btnAlat.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnAlat.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAlat.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnAlat.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnAlat.StateCommon.Border.Rounding = 0F;
            this.btnAlat.StateCommon.Border.Width = 2;
            this.btnAlat.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnAlat.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnAlat.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.btnAlat.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnAlat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlat.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnAlat.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnAlat.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAlat.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnAlat.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnAlat.StateDisabled.Border.Rounding = 0F;
            this.btnAlat.StateDisabled.Border.Width = 2;
            this.btnAlat.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnAlat.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnAlat.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAlat.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnAlat.StateNormal.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnAlat.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAlat.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnAlat.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAlat.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnAlat.StatePressed.Border.Rounding = 0F;
            this.btnAlat.StatePressed.Border.Width = 2;
            this.btnAlat.StatePressed.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnAlat.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.btnAlat.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAlat.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnAlat.StateTracking.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnAlat.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnAlat.TabIndex = 62;
            this.btnAlat.Values.Image = global::RumahSakit.Properties.Resources.menu_alat;
            this.btnAlat.Values.ImageStates.ImageNormal = global::RumahSakit.Properties.Resources.menu_alat_default;
            this.btnAlat.Values.ImageStates.ImageTracking = global::RumahSakit.Properties.Resources.menu_alat_tracking;
            this.btnAlat.Values.Text = "Alat";
            this.btnAlat.Click += new System.EventHandler(this.PilihMenu);
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.Location = new System.Drawing.Point(0, 32);
            this.btnUser.Name = "btnUser";
            this.btnUser.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnUser.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnUser.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnUser.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnUser.Palette = this.palet;
            this.btnUser.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnUser.Size = new System.Drawing.Size(160, 32);
            this.btnUser.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnUser.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnUser.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnUser.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnUser.StateCommon.Border.Rounding = 0F;
            this.btnUser.StateCommon.Border.Width = 2;
            this.btnUser.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnUser.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnUser.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.btnUser.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnUser.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnUser.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnUser.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnUser.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnUser.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnUser.StateDisabled.Border.Rounding = 0F;
            this.btnUser.StateDisabled.Border.Width = 2;
            this.btnUser.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnUser.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnUser.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnUser.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnUser.StateNormal.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnUser.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUser.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnUser.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnUser.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnUser.StatePressed.Border.Rounding = 0F;
            this.btnUser.StatePressed.Border.Width = 2;
            this.btnUser.StatePressed.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnUser.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.btnUser.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnUser.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnUser.StateTracking.Content.Padding = new System.Windows.Forms.Padding(6, -1, -1, -1);
            this.btnUser.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.btnUser.TabIndex = 61;
            this.btnUser.Values.Image = global::RumahSakit.Properties.Resources.menu_user;
            this.btnUser.Values.ImageStates.ImageNormal = global::RumahSakit.Properties.Resources.menu_user_default;
            this.btnUser.Values.ImageStates.ImageTracking = global::RumahSakit.Properties.Resources.menu_user_tracking;
            this.btnUser.Values.Text = "User";
            this.btnUser.Click += new System.EventHandler(this.PilihMenu);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = false;
            this.lblFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFile.Location = new System.Drawing.Point(0, 0);
            this.lblFile.Name = "lblFile";
            this.lblFile.Palette = this.palet;
            this.lblFile.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblFile.Size = new System.Drawing.Size(160, 32);
            this.lblFile.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblFile.StateCommon.Padding = new System.Windows.Forms.Padding(24, -1, -1, -1);
            this.lblFile.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblFile.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblFile.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblFile.TabIndex = 64;
            this.lblFile.Values.Image = global::RumahSakit.Properties.Resources.menu_hide;
            this.lblFile.Values.Text = "File";
            this.lblFile.Click += new System.EventHandler(this.TampilMenu);
            // 
            // thumbnail
            // 
            this.thumbnail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thumbnail.Dock = System.Windows.Forms.DockStyle.Top;
            this.thumbnail.Location = new System.Drawing.Point(0, 0);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.thumbnail.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.thumbnail.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.thumbnail.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.thumbnail.Palette = this.palet;
            this.thumbnail.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.thumbnail.Size = new System.Drawing.Size(160, 124);
            this.thumbnail.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.thumbnail.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.thumbnail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.thumbnail.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.thumbnail.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.thumbnail.TabIndex = 934;
            this.thumbnail.Values.Image = global::RumahSakit.Properties.Resources.thumbnail_checked;
            this.thumbnail.Values.ImageStates.ImageNormal = global::RumahSakit.Properties.Resources.thumbnail;
            this.thumbnail.Values.Text = "";
            this.thumbnail.Click += new System.EventHandler(this.PilihMenu);
            // 
            // panelForm
            // 
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(160, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1094, 640);
            this.panelForm.TabIndex = 892;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1254, 640);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.sidebar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1150, 679);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rumah Sakit (Rawat Inap)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Load += new System.EventHandler(this.FMain_Load);
            this.VisibleChanged += new System.EventHandler(this.FMain_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.sidebar)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panelLainnya.ResumeLayout(false);
            this.panelTransaksi.ResumeLayout(false);
            this.panelFile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal Krypton.Toolkit.KryptonPalette palet;
        internal Krypton.Toolkit.KryptonPanel sidebar;
        internal System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelLainnya;
        internal Krypton.Toolkit.KryptonButton btnLogout;
        internal Krypton.Toolkit.KryptonCheckButton btnLaporan;
        internal Krypton.Toolkit.KryptonCheckButton btnCatatan;
        internal Krypton.Toolkit.KryptonLabel lblLainnya;
        private System.Windows.Forms.Panel panelTransaksi;
        internal Krypton.Toolkit.KryptonCheckButton btnPembayaran;
        internal Krypton.Toolkit.KryptonCheckButton btnPerawatan;
        internal Krypton.Toolkit.KryptonCheckButton btnRegistrasi;
        internal Krypton.Toolkit.KryptonLabel lblTransaksi;
        private System.Windows.Forms.Panel panelFile;
        internal Krypton.Toolkit.KryptonCheckButton btnAlat;
        internal Krypton.Toolkit.KryptonCheckButton btnUser;
        internal Krypton.Toolkit.KryptonLabel lblFile;
        internal Krypton.Toolkit.KryptonCheckButton thumbnail;
        private System.Windows.Forms.Timer timer1;
        internal Krypton.Toolkit.KryptonCheckButton btnPasien;
        internal Krypton.Toolkit.KryptonCheckButton btnDokter;
        internal Krypton.Toolkit.KryptonCheckButton btnObat;
        internal Krypton.Toolkit.KryptonCheckButton btnKamar;
        internal Krypton.Toolkit.KryptonCheckButton btnTindakan;
    }
}