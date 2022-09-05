namespace RumahSakit
{
    partial class FLaporan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLaporan));
            this.palet = new Krypton.Toolkit.KryptonPalette(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnTampil = new Krypton.Toolkit.KryptonButton();
            this.btnRefresh = new Krypton.Toolkit.KryptonButton();
            this.lblFilter = new Krypton.Toolkit.KryptonLabel();
            this.tCariData = new Krypton.Toolkit.KryptonTextBox();
            this.panelKanan = new System.Windows.Forms.Panel();
            this.lblDetailPerEntitas = new Krypton.Toolkit.KryptonLabel();
            this.tEntitas = new Krypton.Toolkit.KryptonComboBox();
            this.panelDGVPagination = new System.Windows.Forms.Panel();
            this.dgvPageCounter = new Krypton.Toolkit.KryptonLabel();
            this.dgvPrev = new Krypton.Toolkit.KryptonButton();
            this.dgvFirst = new Krypton.Toolkit.KryptonButton();
            this.dgvNext = new Krypton.Toolkit.KryptonButton();
            this.dgvLast = new Krypton.Toolkit.KryptonButton();
            this.dgv = new Krypton.Toolkit.KryptonDataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDaftar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTahun = new Krypton.Toolkit.KryptonComboBox();
            this.tDari = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblDari = new Krypton.Toolkit.KryptonLabel();
            this.lblTahun = new Krypton.Toolkit.KryptonLabel();
            this.panelTanggal = new System.Windows.Forms.Panel();
            this.panelBulanan = new System.Windows.Forms.Panel();
            this.tBulan = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblBulanan = new Krypton.Toolkit.KryptonLabel();
            this.lblBulan = new Krypton.Toolkit.KryptonLabel();
            this.panelTahunan = new System.Windows.Forms.Panel();
            this.lblTahunan = new Krypton.Toolkit.KryptonLabel();
            this.panelPeriodik = new System.Windows.Forms.Panel();
            this.lblPeriodik = new Krypton.Toolkit.KryptonLabel();
            this.tSampai = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblSampai = new Krypton.Toolkit.KryptonLabel();
            this.cbKeluar = new Krypton.Toolkit.KryptonCheckBox();
            this.cbMasuk = new Krypton.Toolkit.KryptonCheckBox();
            this.lblTanggal = new Krypton.Toolkit.KryptonLabel();
            this.panelKiri = new System.Windows.Forms.Panel();
            this.rbGrafik = new Krypton.Toolkit.KryptonRadioButton();
            this.rbPasien = new Krypton.Toolkit.KryptonRadioButton();
            this.rbPerawatan = new Krypton.Toolkit.KryptonRadioButton();
            this.rbDokter = new Krypton.Toolkit.KryptonRadioButton();
            this.lblPerawatanGrafik = new Krypton.Toolkit.KryptonLabel();
            this.rbObat = new Krypton.Toolkit.KryptonRadioButton();
            this.rbKamar = new Krypton.Toolkit.KryptonRadioButton();
            this.rbTindakan = new Krypton.Toolkit.KryptonRadioButton();
            this.lblFile = new Krypton.Toolkit.KryptonLabel();
            this.rbAlat = new Krypton.Toolkit.KryptonRadioButton();
            this.cbTerdaftar = new Krypton.Toolkit.KryptonCheckBox();
            this.panelStatusPerawatan = new System.Windows.Forms.Panel();
            this.cbSelesai = new Krypton.Toolkit.KryptonCheckBox();
            this.cbDirawat = new Krypton.Toolkit.KryptonCheckBox();
            this.lblStatusPerawatan = new Krypton.Toolkit.KryptonLabel();
            this.panelBentukLaporan = new System.Windows.Forms.Panel();
            this.rbDetail = new Krypton.Toolkit.KryptonRadioButton();
            this.rbRingkasan = new Krypton.Toolkit.KryptonRadioButton();
            this.lblBentukLaporan = new Krypton.Toolkit.KryptonLabel();
            this.dSRumahSakit = new RumahSakit.DSRumahSakit();
            this.panelControl.SuspendLayout();
            this.panelKanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEntitas)).BeginInit();
            this.panelDGVPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTahun)).BeginInit();
            this.panelTanggal.SuspendLayout();
            this.panelBulanan.SuspendLayout();
            this.panelTahunan.SuspendLayout();
            this.panelPeriodik.SuspendLayout();
            this.panelKiri.SuspendLayout();
            this.panelStatusPerawatan.SuspendLayout();
            this.panelBentukLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSRumahSakit)).BeginInit();
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
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.Controls.Add(this.btnTampil);
            this.panelControl.Controls.Add(this.btnRefresh);
            this.panelControl.Controls.Add(this.lblFilter);
            this.panelControl.Location = new System.Drawing.Point(8, 596);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1078, 36);
            this.panelControl.TabIndex = 7;
            // 
            // btnTampil
            // 
            this.btnTampil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTampil.Enabled = false;
            this.btnTampil.Location = new System.Drawing.Point(909, 3);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnTampil.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTampil.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnTampil.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnTampil.Size = new System.Drawing.Size(80, 30);
            this.btnTampil.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnTampil.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTampil.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnTampil.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnTampil.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnTampil.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampil.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnTampil.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnTampil.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTampil.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnTampil.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnTampil.TabIndex = 2;
            this.btnTampil.Values.Text = "Tampil";
            this.btnTampil.Click += new System.EventHandler(this.BTNTampil_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(995, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnRefresh.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRefresh.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnRefresh.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnRefresh.Palette = this.palet;
            this.btnRefresh.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnRefresh.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRefresh.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnRefresh.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnRefresh.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRefresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnRefresh.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnRefresh.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRefresh.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnRefresh.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Values.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.BTNRefresh_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = false;
            this.lblFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilter.Location = new System.Drawing.Point(0, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Palette = this.palet;
            this.lblFilter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblFilter.Size = new System.Drawing.Size(1078, 36);
            this.lblFilter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFilter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblFilter.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblFilter.TabIndex = 931;
            this.lblFilter.Values.Text = "";
            // 
            // tCariData
            // 
            this.tCariData.AlwaysActive = false;
            this.tCariData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tCariData.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tCariData.CueHint.CueHintText = "Cari data...";
            this.tCariData.CueHint.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCariData.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tCariData.Location = new System.Drawing.Point(3, 62);
            this.tCariData.MaxLength = 100;
            this.tCariData.Name = "tCariData";
            this.tCariData.Palette = this.palet;
            this.tCariData.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tCariData.Size = new System.Drawing.Size(349, 29);
            this.tCariData.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tCariData.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tCariData.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tCariData.StateActive.Border.Rounding = 0F;
            this.tCariData.StateActive.Border.Width = 1;
            this.tCariData.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tCariData.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tCariData.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tCariData.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tCariData.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tCariData.StateCommon.Border.Rounding = 0F;
            this.tCariData.StateCommon.Border.Width = 1;
            this.tCariData.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tCariData.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tCariData.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tCariData.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tCariData.StateDisabled.Border.Rounding = 0F;
            this.tCariData.StateDisabled.Border.Width = 0;
            this.tCariData.TabIndex = 0;
            this.tCariData.TextChanged += new System.EventHandler(this.TCariData_TextChanged);
            // 
            // panelKanan
            // 
            this.panelKanan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelKanan.BackColor = System.Drawing.Color.White;
            this.panelKanan.Controls.Add(this.lblDetailPerEntitas);
            this.panelKanan.Controls.Add(this.tEntitas);
            this.panelKanan.Controls.Add(this.tCariData);
            this.panelKanan.Controls.Add(this.panelDGVPagination);
            this.panelKanan.Controls.Add(this.dgv);
            this.panelKanan.Location = new System.Drawing.Point(731, 8);
            this.panelKanan.Name = "panelKanan";
            this.panelKanan.Size = new System.Drawing.Size(355, 582);
            this.panelKanan.TabIndex = 6;
            // 
            // lblDetailPerEntitas
            // 
            this.lblDetailPerEntitas.AutoSize = false;
            this.lblDetailPerEntitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailPerEntitas.Location = new System.Drawing.Point(0, 0);
            this.lblDetailPerEntitas.Name = "lblDetailPerEntitas";
            this.lblDetailPerEntitas.Palette = this.palet;
            this.lblDetailPerEntitas.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblDetailPerEntitas.Size = new System.Drawing.Size(355, 26);
            this.lblDetailPerEntitas.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDetailPerEntitas.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblDetailPerEntitas.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailPerEntitas.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblDetailPerEntitas.TabIndex = 939;
            this.lblDetailPerEntitas.Values.Text = "Detail Per Entitas";
            // 
            // tEntitas
            // 
            this.tEntitas.AlwaysActive = false;
            this.tEntitas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tEntitas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.tEntitas.DropDownHeight = 327;
            this.tEntitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tEntitas.DropDownWidth = 119;
            this.tEntitas.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tEntitas.IntegralHeight = false;
            this.tEntitas.Items.AddRange(new object[] {
            "Rawat Inap",
            "Alat",
            "Tindakan",
            "Kamar",
            "Obat",
            "Dokter",
            "Pasien"});
            this.tEntitas.Location = new System.Drawing.Point(3, 30);
            this.tEntitas.MaxDropDownItems = 13;
            this.tEntitas.Name = "tEntitas";
            this.tEntitas.Palette = this.palet;
            this.tEntitas.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tEntitas.Size = new System.Drawing.Size(349, 26);
            this.tEntitas.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tEntitas.StateActive.ComboBox.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tEntitas.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tEntitas.StateActive.ComboBox.Border.Width = 1;
            this.tEntitas.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tEntitas.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEntitas.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.tEntitas.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.tEntitas.StateCommon.Item.Back.Color1 = System.Drawing.Color.Green;
            this.tEntitas.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tEntitas.StateCommon.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tEntitas.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tEntitas.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tEntitas.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tEntitas.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.tEntitas.TabIndex = 928;
            this.tEntitas.SelectedIndexChanged += new System.EventHandler(this.TEntitas_SelectedIndexChanged);
            // 
            // panelDGVPagination
            // 
            this.panelDGVPagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDGVPagination.Controls.Add(this.dgvPageCounter);
            this.panelDGVPagination.Controls.Add(this.dgvPrev);
            this.panelDGVPagination.Controls.Add(this.dgvFirst);
            this.panelDGVPagination.Controls.Add(this.dgvNext);
            this.panelDGVPagination.Controls.Add(this.dgvLast);
            this.panelDGVPagination.Location = new System.Drawing.Point(77, 556);
            this.panelDGVPagination.Name = "panelDGVPagination";
            this.panelDGVPagination.Size = new System.Drawing.Size(200, 24);
            this.panelDGVPagination.TabIndex = 927;
            // 
            // dgvPageCounter
            // 
            this.dgvPageCounter.AutoSize = false;
            this.dgvPageCounter.Cursor = System.Windows.Forms.Cursors.Help;
            this.dgvPageCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPageCounter.Location = new System.Drawing.Point(48, 0);
            this.dgvPageCounter.Name = "dgvPageCounter";
            this.dgvPageCounter.Palette = this.palet;
            this.dgvPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvPageCounter.Size = new System.Drawing.Size(104, 24);
            this.dgvPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvPageCounter.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F);
            this.dgvPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvPageCounter.TabIndex = 2;
            this.dgvPageCounter.Values.Text = "1 / 1";
            // 
            // dgvPrev
            // 
            this.dgvPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPrev.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvPrev.Enabled = false;
            this.dgvPrev.Location = new System.Drawing.Point(24, 0);
            this.dgvPrev.Name = "dgvPrev";
            this.dgvPrev.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvPrev.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvPrev.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvPrev.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvPrev.Palette = this.palet;
            this.dgvPrev.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvPrev.Size = new System.Drawing.Size(24, 24);
            this.dgvPrev.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvPrev.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvPrev.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvPrev.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvPrev.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvPrev.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.dgvPrev.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrev.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvPrev.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.dgvPrev.TabIndex = 1;
            this.dgvPrev.Values.Text = "‹";
            // 
            // dgvFirst
            // 
            this.dgvFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvFirst.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvFirst.Enabled = false;
            this.dgvFirst.Location = new System.Drawing.Point(0, 0);
            this.dgvFirst.Name = "dgvFirst";
            this.dgvFirst.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvFirst.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvFirst.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvFirst.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvFirst.Palette = this.palet;
            this.dgvFirst.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvFirst.Size = new System.Drawing.Size(24, 24);
            this.dgvFirst.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvFirst.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvFirst.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvFirst.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvFirst.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvFirst.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.dgvFirst.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFirst.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvFirst.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.dgvFirst.TabIndex = 0;
            this.dgvFirst.Values.Text = "«";
            // 
            // dgvNext
            // 
            this.dgvNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvNext.Enabled = false;
            this.dgvNext.Location = new System.Drawing.Point(152, 0);
            this.dgvNext.Name = "dgvNext";
            this.dgvNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvNext.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvNext.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvNext.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvNext.Palette = this.palet;
            this.dgvNext.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvNext.Size = new System.Drawing.Size(24, 24);
            this.dgvNext.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvNext.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvNext.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvNext.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvNext.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.dgvNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvNext.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.dgvNext.TabIndex = 3;
            this.dgvNext.Values.Text = "›";
            // 
            // dgvLast
            // 
            this.dgvLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLast.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvLast.Enabled = false;
            this.dgvLast.Location = new System.Drawing.Point(176, 0);
            this.dgvLast.Name = "dgvLast";
            this.dgvLast.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvLast.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvLast.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvLast.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvLast.Palette = this.palet;
            this.dgvLast.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvLast.Size = new System.Drawing.Size(24, 24);
            this.dgvLast.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvLast.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvLast.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvLast.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvLast.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvLast.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.dgvLast.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLast.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvLast.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.dgvLast.TabIndex = 4;
            this.dgvLast.Values.Text = "»";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeight = 27;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cDaftar});
            this.dgv.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv.HideOuterBorders = true;
            this.dgv.Location = new System.Drawing.Point(3, 94);
            this.dgv.Name = "dgv";
            this.dgv.Palette = this.palet;
            this.dgv.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.Size = new System.Drawing.Size(349, 459);
            this.dgv.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgv.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgv.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgv.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgv.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgv.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgv.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgv.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgv.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgv.TabIndex = 0;
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseClick);
            // 
            // cId
            // 
            this.cId.HeaderText = "Id";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            // 
            // cDaftar
            // 
            this.cDaftar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cDaftar.HeaderText = "Daftar";
            this.cDaftar.Name = "cDaftar";
            this.cDaftar.ReadOnly = true;
            this.cDaftar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tTahun
            // 
            this.tTahun.AlwaysActive = false;
            this.tTahun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tTahun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.tTahun.DropDownHeight = 327;
            this.tTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tTahun.DropDownWidth = 119;
            this.tTahun.Enabled = false;
            this.tTahun.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tTahun.IntegralHeight = false;
            this.tTahun.Location = new System.Drawing.Point(78, 29);
            this.tTahun.MaxDropDownItems = 13;
            this.tTahun.Name = "tTahun";
            this.tTahun.Palette = this.palet;
            this.tTahun.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tTahun.Size = new System.Drawing.Size(119, 26);
            this.tTahun.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tTahun.StateActive.ComboBox.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTahun.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTahun.StateActive.ComboBox.Border.Width = 1;
            this.tTahun.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tTahun.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTahun.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.tTahun.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.tTahun.StateCommon.Item.Back.Color1 = System.Drawing.Color.Green;
            this.tTahun.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tTahun.StateCommon.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tTahun.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tTahun.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tTahun.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tTahun.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.tTahun.TabIndex = 1;
            this.tTahun.SelectedIndexChanged += new System.EventHandler(this.FilterTanggal);
            // 
            // tDari
            // 
            this.tDari.AlwaysActive = false;
            this.tDari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tDari.CustomFormat = "dd MMMM yyyy";
            this.tDari.Enabled = false;
            this.tDari.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tDari.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tDari.Location = new System.Drawing.Point(78, 29);
            this.tDari.Name = "tDari";
            this.tDari.Palette = this.palet;
            this.tDari.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tDari.Size = new System.Drawing.Size(162, 26);
            this.tDari.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tDari.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tDari.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tDari.StateActive.Border.Width = 1;
            this.tDari.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDari.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.tDari.TabIndex = 2;
            this.tDari.ValueNullable = new System.DateTime(2022, 9, 14, 0, 0, 0, 0);
            this.tDari.ValueChanged += new System.EventHandler(this.FilterTanggal);
            // 
            // lblDari
            // 
            this.lblDari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDari.AutoSize = false;
            this.lblDari.Location = new System.Drawing.Point(3, 29);
            this.lblDari.Name = "lblDari";
            this.lblDari.Palette = this.palet;
            this.lblDari.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblDari.Size = new System.Drawing.Size(69, 26);
            this.lblDari.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDari.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblDari.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblDari.TabIndex = 926;
            this.lblDari.Values.Text = "Dari";
            // 
            // lblTahun
            // 
            this.lblTahun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTahun.AutoSize = false;
            this.lblTahun.Location = new System.Drawing.Point(3, 29);
            this.lblTahun.Name = "lblTahun";
            this.lblTahun.Palette = this.palet;
            this.lblTahun.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTahun.Size = new System.Drawing.Size(69, 26);
            this.lblTahun.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTahun.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTahun.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblTahun.TabIndex = 924;
            this.lblTahun.Values.Text = "Tahun";
            // 
            // panelTanggal
            // 
            this.panelTanggal.BackColor = System.Drawing.Color.White;
            this.panelTanggal.Controls.Add(this.panelBulanan);
            this.panelTanggal.Controls.Add(this.panelTahunan);
            this.panelTanggal.Controls.Add(this.panelPeriodik);
            this.panelTanggal.Controls.Add(this.cbKeluar);
            this.panelTanggal.Controls.Add(this.cbMasuk);
            this.panelTanggal.Controls.Add(this.lblTanggal);
            this.panelTanggal.Location = new System.Drawing.Point(369, 8);
            this.panelTanggal.Name = "panelTanggal";
            this.panelTanggal.Size = new System.Drawing.Size(356, 288);
            this.panelTanggal.TabIndex = 8;
            // 
            // panelBulanan
            // 
            this.panelBulanan.BackColor = System.Drawing.Color.White;
            this.panelBulanan.Controls.Add(this.tBulan);
            this.panelBulanan.Controls.Add(this.lblBulanan);
            this.panelBulanan.Controls.Add(this.lblBulan);
            this.panelBulanan.Location = new System.Drawing.Point(57, 161);
            this.panelBulanan.Name = "panelBulanan";
            this.panelBulanan.Size = new System.Drawing.Size(243, 58);
            this.panelBulanan.TabIndex = 946;
            // 
            // tBulan
            // 
            this.tBulan.AlwaysActive = false;
            this.tBulan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBulan.CustomFormat = "MMMM yyyy";
            this.tBulan.Enabled = false;
            this.tBulan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tBulan.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tBulan.Location = new System.Drawing.Point(78, 29);
            this.tBulan.Name = "tBulan";
            this.tBulan.Palette = this.palet;
            this.tBulan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tBulan.Size = new System.Drawing.Size(162, 26);
            this.tBulan.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tBulan.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tBulan.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tBulan.StateActive.Border.Width = 1;
            this.tBulan.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBulan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.tBulan.TabIndex = 948;
            this.tBulan.ValueNullable = new System.DateTime(2022, 9, 14, 0, 0, 0, 0);
            this.tBulan.ValueChanged += new System.EventHandler(this.FilterTanggal);
            // 
            // lblBulanan
            // 
            this.lblBulanan.AutoSize = false;
            this.lblBulanan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBulanan.Location = new System.Drawing.Point(0, 0);
            this.lblBulanan.Name = "lblBulanan";
            this.lblBulanan.Palette = this.palet;
            this.lblBulanan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblBulanan.Size = new System.Drawing.Size(243, 26);
            this.lblBulanan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBulanan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblBulanan.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBulanan.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBulanan.TabIndex = 939;
            this.lblBulanan.Values.Text = "Bulanan";
            // 
            // lblBulan
            // 
            this.lblBulan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBulan.AutoSize = false;
            this.lblBulan.Location = new System.Drawing.Point(3, 29);
            this.lblBulan.Name = "lblBulan";
            this.lblBulan.Palette = this.palet;
            this.lblBulan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblBulan.Size = new System.Drawing.Size(69, 26);
            this.lblBulan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBulan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblBulan.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblBulan.TabIndex = 924;
            this.lblBulan.Values.Text = "Bulan";
            // 
            // panelTahunan
            // 
            this.panelTahunan.BackColor = System.Drawing.Color.White;
            this.panelTahunan.Controls.Add(this.lblTahunan);
            this.panelTahunan.Controls.Add(this.lblTahun);
            this.panelTahunan.Controls.Add(this.tTahun);
            this.panelTahunan.Location = new System.Drawing.Point(78, 225);
            this.panelTahunan.Name = "panelTahunan";
            this.panelTahunan.Size = new System.Drawing.Size(200, 58);
            this.panelTahunan.TabIndex = 945;
            // 
            // lblTahunan
            // 
            this.lblTahunan.AutoSize = false;
            this.lblTahunan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTahunan.Location = new System.Drawing.Point(0, 0);
            this.lblTahunan.Name = "lblTahunan";
            this.lblTahunan.Palette = this.palet;
            this.lblTahunan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTahunan.Size = new System.Drawing.Size(200, 26);
            this.lblTahunan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTahunan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTahunan.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTahunan.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTahunan.TabIndex = 939;
            this.lblTahunan.Values.Text = "Tahunan";
            // 
            // panelPeriodik
            // 
            this.panelPeriodik.BackColor = System.Drawing.Color.White;
            this.panelPeriodik.Controls.Add(this.lblPeriodik);
            this.panelPeriodik.Controls.Add(this.lblDari);
            this.panelPeriodik.Controls.Add(this.tSampai);
            this.panelPeriodik.Controls.Add(this.tDari);
            this.panelPeriodik.Controls.Add(this.lblSampai);
            this.panelPeriodik.Location = new System.Drawing.Point(57, 65);
            this.panelPeriodik.Name = "panelPeriodik";
            this.panelPeriodik.Size = new System.Drawing.Size(243, 90);
            this.panelPeriodik.TabIndex = 943;
            // 
            // lblPeriodik
            // 
            this.lblPeriodik.AutoSize = false;
            this.lblPeriodik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPeriodik.Location = new System.Drawing.Point(0, 0);
            this.lblPeriodik.Name = "lblPeriodik";
            this.lblPeriodik.Palette = this.palet;
            this.lblPeriodik.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblPeriodik.Size = new System.Drawing.Size(243, 26);
            this.lblPeriodik.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPeriodik.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblPeriodik.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodik.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblPeriodik.TabIndex = 949;
            this.lblPeriodik.Values.Text = "Periodik";
            // 
            // tSampai
            // 
            this.tSampai.AlwaysActive = false;
            this.tSampai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tSampai.CustomFormat = "dd MMMM yyyy";
            this.tSampai.Enabled = false;
            this.tSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tSampai.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tSampai.Location = new System.Drawing.Point(78, 61);
            this.tSampai.Name = "tSampai";
            this.tSampai.Palette = this.palet;
            this.tSampai.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tSampai.Size = new System.Drawing.Size(162, 26);
            this.tSampai.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tSampai.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tSampai.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tSampai.StateActive.Border.Width = 1;
            this.tSampai.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSampai.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.tSampai.TabIndex = 947;
            this.tSampai.ValueNullable = new System.DateTime(2022, 9, 14, 0, 0, 0, 0);
            this.tSampai.ValueChanged += new System.EventHandler(this.FilterTanggal);
            // 
            // lblSampai
            // 
            this.lblSampai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSampai.AutoSize = false;
            this.lblSampai.Location = new System.Drawing.Point(3, 61);
            this.lblSampai.Name = "lblSampai";
            this.lblSampai.Palette = this.palet;
            this.lblSampai.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblSampai.Size = new System.Drawing.Size(69, 26);
            this.lblSampai.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSampai.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblSampai.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblSampai.TabIndex = 948;
            this.lblSampai.Values.Text = "Sampai";
            // 
            // cbKeluar
            // 
            this.cbKeluar.Enabled = false;
            this.cbKeluar.Location = new System.Drawing.Point(204, 32);
            this.cbKeluar.Name = "cbKeluar";
            this.cbKeluar.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbKeluar.Palette = this.palet;
            this.cbKeluar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.cbKeluar.Size = new System.Drawing.Size(73, 28);
            this.cbKeluar.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbKeluar.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKeluar.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.cbKeluar.TabIndex = 944;
            this.cbKeluar.Values.Text = "Keluar";
            this.cbKeluar.CheckedChanged += new System.EventHandler(this.FilterTanggal);
            // 
            // cbMasuk
            // 
            this.cbMasuk.Enabled = false;
            this.cbMasuk.Location = new System.Drawing.Point(84, 32);
            this.cbMasuk.Name = "cbMasuk";
            this.cbMasuk.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbMasuk.Palette = this.palet;
            this.cbMasuk.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.cbMasuk.Size = new System.Drawing.Size(76, 28);
            this.cbMasuk.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbMasuk.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMasuk.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.cbMasuk.TabIndex = 943;
            this.cbMasuk.Values.Text = "Masuk";
            this.cbMasuk.CheckedChanged += new System.EventHandler(this.FilterTanggal);
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = false;
            this.lblTanggal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTanggal.Location = new System.Drawing.Point(0, 0);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Palette = this.palet;
            this.lblTanggal.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTanggal.Size = new System.Drawing.Size(356, 26);
            this.lblTanggal.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTanggal.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTanggal.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTanggal.TabIndex = 938;
            this.lblTanggal.Values.Text = "Tanggal";
            // 
            // panelKiri
            // 
            this.panelKiri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelKiri.BackColor = System.Drawing.Color.White;
            this.panelKiri.Controls.Add(this.rbGrafik);
            this.panelKiri.Controls.Add(this.rbPasien);
            this.panelKiri.Controls.Add(this.rbPerawatan);
            this.panelKiri.Controls.Add(this.rbDokter);
            this.panelKiri.Controls.Add(this.lblPerawatanGrafik);
            this.panelKiri.Controls.Add(this.rbObat);
            this.panelKiri.Controls.Add(this.rbKamar);
            this.panelKiri.Controls.Add(this.rbTindakan);
            this.panelKiri.Controls.Add(this.lblFile);
            this.panelKiri.Controls.Add(this.rbAlat);
            this.panelKiri.Location = new System.Drawing.Point(8, 8);
            this.panelKiri.Name = "panelKiri";
            this.panelKiri.Size = new System.Drawing.Size(355, 582);
            this.panelKiri.TabIndex = 928;
            // 
            // rbGrafik
            // 
            this.rbGrafik.Location = new System.Drawing.Point(8, 360);
            this.rbGrafik.Name = "rbGrafik";
            this.rbGrafik.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbGrafik.Palette = this.palet;
            this.rbGrafik.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.rbGrafik.Size = new System.Drawing.Size(150, 28);
            this.rbGrafik.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbGrafik.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGrafik.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rbGrafik.TabIndex = 944;
            this.rbGrafik.Tag = "Grafik";
            this.rbGrafik.Values.Text = "Grafik (Tahunan)";
            this.rbGrafik.Click += new System.EventHandler(this.LaporanKiri);
            // 
            // rbPasien
            // 
            this.rbPasien.Location = new System.Drawing.Point(8, 202);
            this.rbPasien.Name = "rbPasien";
            this.rbPasien.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbPasien.Palette = this.palet;
            this.rbPasien.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.rbPasien.Size = new System.Drawing.Size(76, 28);
            this.rbPasien.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbPasien.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPasien.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rbPasien.TabIndex = 942;
            this.rbPasien.Tag = "Pasien";
            this.rbPasien.Values.Text = "Pasien";
            this.rbPasien.Click += new System.EventHandler(this.LaporanKiri);
            // 
            // rbPerawatan
            // 
            this.rbPerawatan.Location = new System.Drawing.Point(8, 326);
            this.rbPerawatan.Name = "rbPerawatan";
            this.rbPerawatan.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbPerawatan.Palette = this.palet;
            this.rbPerawatan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.rbPerawatan.Size = new System.Drawing.Size(105, 28);
            this.rbPerawatan.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbPerawatan.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerawatan.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rbPerawatan.TabIndex = 943;
            this.rbPerawatan.Tag = "Perawatan";
            this.rbPerawatan.Values.Text = "Perawatan";
            this.rbPerawatan.Click += new System.EventHandler(this.LaporanKiri);
            // 
            // rbDokter
            // 
            this.rbDokter.Location = new System.Drawing.Point(8, 168);
            this.rbDokter.Name = "rbDokter";
            this.rbDokter.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbDokter.Palette = this.palet;
            this.rbDokter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.rbDokter.Size = new System.Drawing.Size(79, 28);
            this.rbDokter.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbDokter.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDokter.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rbDokter.TabIndex = 941;
            this.rbDokter.Tag = "Dokter";
            this.rbDokter.Values.Text = "Dokter";
            this.rbDokter.Click += new System.EventHandler(this.LaporanKiri);
            // 
            // lblPerawatanGrafik
            // 
            this.lblPerawatanGrafik.AutoSize = false;
            this.lblPerawatanGrafik.Location = new System.Drawing.Point(0, 294);
            this.lblPerawatanGrafik.Name = "lblPerawatanGrafik";
            this.lblPerawatanGrafik.Palette = this.palet;
            this.lblPerawatanGrafik.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblPerawatanGrafik.Size = new System.Drawing.Size(355, 26);
            this.lblPerawatanGrafik.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPerawatanGrafik.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblPerawatanGrafik.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerawatanGrafik.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblPerawatanGrafik.TabIndex = 937;
            this.lblPerawatanGrafik.Values.Text = "Perawatan / Grafik";
            // 
            // rbObat
            // 
            this.rbObat.Location = new System.Drawing.Point(8, 134);
            this.rbObat.Name = "rbObat";
            this.rbObat.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbObat.Palette = this.palet;
            this.rbObat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.rbObat.Size = new System.Drawing.Size(66, 28);
            this.rbObat.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbObat.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbObat.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rbObat.TabIndex = 940;
            this.rbObat.Tag = "Obat";
            this.rbObat.Values.Text = "Obat";
            this.rbObat.Click += new System.EventHandler(this.LaporanKiri);
            // 
            // rbKamar
            // 
            this.rbKamar.Location = new System.Drawing.Point(8, 100);
            this.rbKamar.Name = "rbKamar";
            this.rbKamar.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbKamar.Palette = this.palet;
            this.rbKamar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.rbKamar.Size = new System.Drawing.Size(76, 28);
            this.rbKamar.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbKamar.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKamar.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rbKamar.TabIndex = 939;
            this.rbKamar.Tag = "Kamar";
            this.rbKamar.Values.Text = "Kamar";
            this.rbKamar.Click += new System.EventHandler(this.LaporanKiri);
            // 
            // rbTindakan
            // 
            this.rbTindakan.Location = new System.Drawing.Point(8, 66);
            this.rbTindakan.Name = "rbTindakan";
            this.rbTindakan.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbTindakan.Palette = this.palet;
            this.rbTindakan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.rbTindakan.Size = new System.Drawing.Size(96, 28);
            this.rbTindakan.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbTindakan.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTindakan.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rbTindakan.TabIndex = 938;
            this.rbTindakan.Tag = "Tindakan";
            this.rbTindakan.Values.Text = "Tindakan";
            this.rbTindakan.Click += new System.EventHandler(this.LaporanKiri);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = false;
            this.lblFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFile.Location = new System.Drawing.Point(0, 0);
            this.lblFile.Name = "lblFile";
            this.lblFile.Palette = this.palet;
            this.lblFile.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblFile.Size = new System.Drawing.Size(355, 26);
            this.lblFile.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFile.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblFile.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblFile.TabIndex = 937;
            this.lblFile.Values.Text = "File";
            // 
            // rbAlat
            // 
            this.rbAlat.Location = new System.Drawing.Point(8, 32);
            this.rbAlat.Name = "rbAlat";
            this.rbAlat.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbAlat.Palette = this.palet;
            this.rbAlat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.rbAlat.Size = new System.Drawing.Size(58, 28);
            this.rbAlat.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbAlat.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlat.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rbAlat.TabIndex = 935;
            this.rbAlat.Tag = "Alat";
            this.rbAlat.Values.Text = "Alat";
            this.rbAlat.Click += new System.EventHandler(this.LaporanKiri);
            // 
            // cbTerdaftar
            // 
            this.cbTerdaftar.Enabled = false;
            this.cbTerdaftar.Location = new System.Drawing.Point(8, 32);
            this.cbTerdaftar.Name = "cbTerdaftar";
            this.cbTerdaftar.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbTerdaftar.Palette = this.palet;
            this.cbTerdaftar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.cbTerdaftar.Size = new System.Drawing.Size(94, 28);
            this.cbTerdaftar.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbTerdaftar.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTerdaftar.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.cbTerdaftar.TabIndex = 936;
            this.cbTerdaftar.Values.Text = "Terdaftar";
            this.cbTerdaftar.CheckedChanged += new System.EventHandler(this.FilterStatus);
            // 
            // panelStatusPerawatan
            // 
            this.panelStatusPerawatan.BackColor = System.Drawing.Color.White;
            this.panelStatusPerawatan.Controls.Add(this.cbSelesai);
            this.panelStatusPerawatan.Controls.Add(this.cbDirawat);
            this.panelStatusPerawatan.Controls.Add(this.lblStatusPerawatan);
            this.panelStatusPerawatan.Controls.Add(this.cbTerdaftar);
            this.panelStatusPerawatan.Location = new System.Drawing.Point(369, 302);
            this.panelStatusPerawatan.Name = "panelStatusPerawatan";
            this.panelStatusPerawatan.Size = new System.Drawing.Size(356, 141);
            this.panelStatusPerawatan.TabIndex = 930;
            // 
            // cbSelesai
            // 
            this.cbSelesai.Enabled = false;
            this.cbSelesai.Location = new System.Drawing.Point(8, 100);
            this.cbSelesai.Name = "cbSelesai";
            this.cbSelesai.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbSelesai.Palette = this.palet;
            this.cbSelesai.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.cbSelesai.Size = new System.Drawing.Size(77, 28);
            this.cbSelesai.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbSelesai.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelesai.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.cbSelesai.TabIndex = 940;
            this.cbSelesai.Values.Text = "Selesai";
            this.cbSelesai.CheckedChanged += new System.EventHandler(this.FilterStatus);
            // 
            // cbDirawat
            // 
            this.cbDirawat.Enabled = false;
            this.cbDirawat.Location = new System.Drawing.Point(8, 66);
            this.cbDirawat.Name = "cbDirawat";
            this.cbDirawat.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbDirawat.Palette = this.palet;
            this.cbDirawat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.cbDirawat.Size = new System.Drawing.Size(83, 28);
            this.cbDirawat.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbDirawat.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDirawat.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.cbDirawat.TabIndex = 939;
            this.cbDirawat.Values.Text = "Dirawat";
            this.cbDirawat.CheckedChanged += new System.EventHandler(this.FilterStatus);
            // 
            // lblStatusPerawatan
            // 
            this.lblStatusPerawatan.AutoSize = false;
            this.lblStatusPerawatan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatusPerawatan.Location = new System.Drawing.Point(0, 0);
            this.lblStatusPerawatan.Name = "lblStatusPerawatan";
            this.lblStatusPerawatan.Palette = this.palet;
            this.lblStatusPerawatan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblStatusPerawatan.Size = new System.Drawing.Size(356, 26);
            this.lblStatusPerawatan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatusPerawatan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblStatusPerawatan.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPerawatan.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblStatusPerawatan.TabIndex = 938;
            this.lblStatusPerawatan.Values.Text = "Status Perawatan";
            // 
            // panelBentukLaporan
            // 
            this.panelBentukLaporan.BackColor = System.Drawing.Color.White;
            this.panelBentukLaporan.Controls.Add(this.rbDetail);
            this.panelBentukLaporan.Controls.Add(this.rbRingkasan);
            this.panelBentukLaporan.Controls.Add(this.lblBentukLaporan);
            this.panelBentukLaporan.Location = new System.Drawing.Point(369, 449);
            this.panelBentukLaporan.Name = "panelBentukLaporan";
            this.panelBentukLaporan.Size = new System.Drawing.Size(356, 141);
            this.panelBentukLaporan.TabIndex = 931;
            // 
            // rbDetail
            // 
            this.rbDetail.Enabled = false;
            this.rbDetail.Location = new System.Drawing.Point(8, 66);
            this.rbDetail.Name = "rbDetail";
            this.rbDetail.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbDetail.Palette = this.palet;
            this.rbDetail.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.rbDetail.Size = new System.Drawing.Size(72, 28);
            this.rbDetail.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbDetail.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDetail.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rbDetail.TabIndex = 946;
            this.rbDetail.Values.Text = "Detail";
            // 
            // rbRingkasan
            // 
            this.rbRingkasan.Checked = true;
            this.rbRingkasan.Enabled = false;
            this.rbRingkasan.Location = new System.Drawing.Point(8, 32);
            this.rbRingkasan.Name = "rbRingkasan";
            this.rbRingkasan.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbRingkasan.Palette = this.palet;
            this.rbRingkasan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.rbRingkasan.Size = new System.Drawing.Size(104, 28);
            this.rbRingkasan.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbRingkasan.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRingkasan.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rbRingkasan.TabIndex = 945;
            this.rbRingkasan.Values.Text = "Ringkasan";
            // 
            // lblBentukLaporan
            // 
            this.lblBentukLaporan.AutoSize = false;
            this.lblBentukLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBentukLaporan.Location = new System.Drawing.Point(0, 0);
            this.lblBentukLaporan.Name = "lblBentukLaporan";
            this.lblBentukLaporan.Palette = this.palet;
            this.lblBentukLaporan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblBentukLaporan.Size = new System.Drawing.Size(356, 26);
            this.lblBentukLaporan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBentukLaporan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblBentukLaporan.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBentukLaporan.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBentukLaporan.TabIndex = 938;
            this.lblBentukLaporan.Values.Text = "Bentuk Laporan";
            // 
            // dSRumahSakit
            // 
            this.dSRumahSakit.DataSetName = "DSRumahSakit";
            this.dSRumahSakit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FLaporan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1094, 640);
            this.Controls.Add(this.panelBentukLaporan);
            this.Controls.Add(this.panelStatusPerawatan);
            this.Controls.Add(this.panelKiri);
            this.Controls.Add(this.panelTanggal);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelKanan);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FLaporan";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "FLaporan";
            this.Load += new System.EventHandler(this.FLaporan_Load);
            this.Resize += new System.EventHandler(this.FLaporan_Resize);
            this.panelControl.ResumeLayout(false);
            this.panelKanan.ResumeLayout(false);
            this.panelKanan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEntitas)).EndInit();
            this.panelDGVPagination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTahun)).EndInit();
            this.panelTanggal.ResumeLayout(false);
            this.panelTanggal.PerformLayout();
            this.panelBulanan.ResumeLayout(false);
            this.panelTahunan.ResumeLayout(false);
            this.panelPeriodik.ResumeLayout(false);
            this.panelKiri.ResumeLayout(false);
            this.panelKiri.PerformLayout();
            this.panelStatusPerawatan.ResumeLayout(false);
            this.panelStatusPerawatan.PerformLayout();
            this.panelBentukLaporan.ResumeLayout(false);
            this.panelBentukLaporan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSRumahSakit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Krypton.Toolkit.KryptonPalette palet;
        private System.Windows.Forms.Panel panelControl;
        internal Krypton.Toolkit.KryptonTextBox tCariData;
        internal Krypton.Toolkit.KryptonButton btnTampil;
        internal Krypton.Toolkit.KryptonButton btnRefresh;
        private System.Windows.Forms.Panel panelKanan;
        private System.Windows.Forms.Panel panelDGVPagination;
        internal Krypton.Toolkit.KryptonLabel dgvPageCounter;
        internal Krypton.Toolkit.KryptonButton dgvPrev;
        internal Krypton.Toolkit.KryptonButton dgvFirst;
        internal Krypton.Toolkit.KryptonButton dgvNext;
        internal Krypton.Toolkit.KryptonButton dgvLast;
        internal Krypton.Toolkit.KryptonDataGridView dgv;
        internal Krypton.Toolkit.KryptonComboBox tTahun;
        internal Krypton.Toolkit.KryptonDateTimePicker tDari;
        internal Krypton.Toolkit.KryptonLabel lblDari;
        internal Krypton.Toolkit.KryptonLabel lblTahun;
        private System.Windows.Forms.Panel panelTanggal;
        private System.Windows.Forms.Panel panelKiri;
        internal Krypton.Toolkit.KryptonComboBox tEntitas;
        internal Krypton.Toolkit.KryptonLabel lblFilter;
        internal Krypton.Toolkit.KryptonRadioButton rbAlat;
        internal Krypton.Toolkit.KryptonCheckBox cbTerdaftar;
        internal Krypton.Toolkit.KryptonLabel lblTanggal;
        internal Krypton.Toolkit.KryptonLabel lblFile;
        internal Krypton.Toolkit.KryptonLabel lblPerawatanGrafik;
        private System.Windows.Forms.Panel panelStatusPerawatan;
        internal Krypton.Toolkit.KryptonLabel lblStatusPerawatan;
        internal Krypton.Toolkit.KryptonLabel lblDetailPerEntitas;
        internal Krypton.Toolkit.KryptonRadioButton rbPasien;
        internal Krypton.Toolkit.KryptonRadioButton rbDokter;
        internal Krypton.Toolkit.KryptonRadioButton rbObat;
        internal Krypton.Toolkit.KryptonRadioButton rbKamar;
        internal Krypton.Toolkit.KryptonRadioButton rbTindakan;
        private System.Windows.Forms.Panel panelTahunan;
        internal Krypton.Toolkit.KryptonLabel lblTahunan;
        private System.Windows.Forms.Panel panelPeriodik;
        internal Krypton.Toolkit.KryptonLabel lblPeriodik;
        internal Krypton.Toolkit.KryptonDateTimePicker tSampai;
        internal Krypton.Toolkit.KryptonLabel lblSampai;
        internal Krypton.Toolkit.KryptonCheckBox cbKeluar;
        internal Krypton.Toolkit.KryptonCheckBox cbMasuk;
        internal Krypton.Toolkit.KryptonRadioButton rbGrafik;
        internal Krypton.Toolkit.KryptonRadioButton rbPerawatan;
        internal Krypton.Toolkit.KryptonCheckBox cbSelesai;
        internal Krypton.Toolkit.KryptonCheckBox cbDirawat;
        private System.Windows.Forms.Panel panelBentukLaporan;
        internal Krypton.Toolkit.KryptonRadioButton rbDetail;
        internal Krypton.Toolkit.KryptonRadioButton rbRingkasan;
        internal Krypton.Toolkit.KryptonLabel lblBentukLaporan;
        private System.Windows.Forms.Panel panelBulanan;
        internal Krypton.Toolkit.KryptonDateTimePicker tBulan;
        internal Krypton.Toolkit.KryptonLabel lblBulanan;
        internal Krypton.Toolkit.KryptonLabel lblBulan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDaftar;
        private DSRumahSakit dSRumahSakit;
    }
}