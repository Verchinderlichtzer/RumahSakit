namespace RumahSakit
{
    partial class FPasien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPasien));
            this.palet = new Krypton.Toolkit.KryptonPalette(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.tCariData = new Krypton.Toolkit.KryptonTextBox();
            this.btnHapus = new Krypton.Toolkit.KryptonButton();
            this.btnSimpan = new Krypton.Toolkit.KryptonButton();
            this.btnRefresh = new Krypton.Toolkit.KryptonButton();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.panelDGVPagination = new System.Windows.Forms.Panel();
            this.dgvPageCounter = new Krypton.Toolkit.KryptonLabel();
            this.dgvPrev = new Krypton.Toolkit.KryptonButton();
            this.dgvFirst = new Krypton.Toolkit.KryptonButton();
            this.dgvNext = new Krypton.Toolkit.KryptonButton();
            this.dgvLast = new Krypton.Toolkit.KryptonButton();
            this.dgv = new Krypton.Toolkit.KryptonDataGridView();
            this.cNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdPasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cJenisKelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTanggalLahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNoTelepon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tStatus = new Krypton.Toolkit.KryptonTextBox();
            this.lblStatus = new Krypton.Toolkit.KryptonLabel();
            this.lblAlamat = new Krypton.Toolkit.KryptonLabel();
            this.tAlamat = new Krypton.Toolkit.KryptonTextBox();
            this.tNoTelepon = new Krypton.Toolkit.KryptonTextBox();
            this.lblNoTelepon = new Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblId = new Krypton.Toolkit.KryptonLabel();
            this.tId = new Krypton.Toolkit.KryptonTextBox();
            this.rbPerempuan = new Krypton.Toolkit.KryptonRadioButton();
            this.tNama = new Krypton.Toolkit.KryptonTextBox();
            this.rbLakiLaki = new Krypton.Toolkit.KryptonRadioButton();
            this.lblNama = new Krypton.Toolkit.KryptonLabel();
            this.tTglLahir = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblJenisKelamin = new Krypton.Toolkit.KryptonLabel();
            this.lblTglLahir = new Krypton.Toolkit.KryptonLabel();
            this.panelControl.SuspendLayout();
            this.panelDGV.SuspendLayout();
            this.panelDGVPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelForm.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panelControl.Controls.Add(this.tCariData);
            this.panelControl.Controls.Add(this.btnHapus);
            this.panelControl.Controls.Add(this.btnSimpan);
            this.panelControl.Controls.Add(this.btnRefresh);
            this.panelControl.Location = new System.Drawing.Point(8, 596);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1078, 36);
            this.panelControl.TabIndex = 7;
            // 
            // tCariData
            // 
            this.tCariData.AlwaysActive = false;
            this.tCariData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tCariData.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tCariData.CueHint.CueHintText = "Cari pasien...";
            this.tCariData.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tCariData.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tCariData.Location = new System.Drawing.Point(3, 3);
            this.tCariData.MaxLength = 100;
            this.tCariData.Name = "tCariData";
            this.tCariData.Palette = this.palet;
            this.tCariData.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tCariData.Size = new System.Drawing.Size(814, 29);
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
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHapus.Location = new System.Drawing.Point(909, 3);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnHapus.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnHapus.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnHapus.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnHapus.Size = new System.Drawing.Size(80, 30);
            this.btnHapus.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnHapus.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnHapus.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnHapus.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnHapus.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnHapus.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnHapus.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnHapus.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHapus.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnHapus.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Values.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.BTNHapus_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.Enabled = false;
            this.btnSimpan.Location = new System.Drawing.Point(823, 3);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnSimpan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnSimpan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnSimpan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnSimpan.Palette = this.palet;
            this.btnSimpan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnSimpan.Size = new System.Drawing.Size(80, 30);
            this.btnSimpan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnSimpan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnSimpan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnSimpan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnSimpan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSimpan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnSimpan.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnSimpan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSimpan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnSimpan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Values.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.BTNSimpan_Click);
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
            // panelDGV
            // 
            this.panelDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDGV.BackColor = System.Drawing.Color.White;
            this.panelDGV.Controls.Add(this.panelDGVPagination);
            this.panelDGV.Controls.Add(this.dgv);
            this.panelDGV.Location = new System.Drawing.Point(8, 142);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(1078, 448);
            this.panelDGV.TabIndex = 6;
            // 
            // panelDGVPagination
            // 
            this.panelDGVPagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDGVPagination.Controls.Add(this.dgvPageCounter);
            this.panelDGVPagination.Controls.Add(this.dgvPrev);
            this.panelDGVPagination.Controls.Add(this.dgvFirst);
            this.panelDGVPagination.Controls.Add(this.dgvNext);
            this.panelDGVPagination.Controls.Add(this.dgvLast);
            this.panelDGVPagination.Location = new System.Drawing.Point(439, 411);
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
            this.dgvPageCounter.Click += new System.EventHandler(this.DGVPageCounter_Click);
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
            this.dgvPrev.Click += new System.EventHandler(this.DGVPrev_Click);
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
            this.dgvFirst.Click += new System.EventHandler(this.DGVFirst_Click);
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
            this.dgvNext.Click += new System.EventHandler(this.DGVNext_Click);
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
            this.dgvLast.Click += new System.EventHandler(this.DGVLast_Click);
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
            this.cNo,
            this.cIdPasien,
            this.cNama,
            this.cJenisKelamin,
            this.cTanggalLahir,
            this.cAlamat,
            this.cNoTelepon,
            this.cStatus});
            this.dgv.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv.HideOuterBorders = true;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.Palette = this.palet;
            this.dgv.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.Size = new System.Drawing.Size(1072, 405);
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
            // cNo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.cNo.HeaderText = "No";
            this.cNo.Name = "cNo";
            this.cNo.ReadOnly = true;
            this.cNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNo.Width = 73;
            // 
            // cIdPasien
            // 
            this.cIdPasien.HeaderText = "Id Pasien";
            this.cIdPasien.Name = "cIdPasien";
            this.cIdPasien.ReadOnly = true;
            this.cIdPasien.Visible = false;
            // 
            // cNama
            // 
            this.cNama.HeaderText = "Nama Pasien";
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            this.cNama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNama.Width = 200;
            // 
            // cJenisKelamin
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cJenisKelamin.DefaultCellStyle = dataGridViewCellStyle3;
            this.cJenisKelamin.HeaderText = "Jenis Kelamin";
            this.cJenisKelamin.Name = "cJenisKelamin";
            this.cJenisKelamin.ReadOnly = true;
            this.cJenisKelamin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cJenisKelamin.Width = 120;
            // 
            // cTanggalLahir
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.cTanggalLahir.DefaultCellStyle = dataGridViewCellStyle4;
            this.cTanggalLahir.HeaderText = "Tanggal Lahir";
            this.cTanggalLahir.Name = "cTanggalLahir";
            this.cTanggalLahir.ReadOnly = true;
            this.cTanggalLahir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cTanggalLahir.Width = 120;
            // 
            // cAlamat
            // 
            this.cAlamat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cAlamat.HeaderText = "Alamat";
            this.cAlamat.Name = "cAlamat";
            this.cAlamat.ReadOnly = true;
            this.cAlamat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cNoTelepon
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cNoTelepon.DefaultCellStyle = dataGridViewCellStyle5;
            this.cNoTelepon.HeaderText = "No Telepon";
            this.cNoTelepon.Name = "cNoTelepon";
            this.cNoTelepon.ReadOnly = true;
            this.cNoTelepon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNoTelepon.Width = 150;
            // 
            // cStatus
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cStatus.DefaultCellStyle = dataGridViewCellStyle6;
            this.cStatus.HeaderText = "Status";
            this.cStatus.Name = "cStatus";
            this.cStatus.ReadOnly = true;
            this.cStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.panel2);
            this.panelForm.Controls.Add(this.panel1);
            this.panelForm.Location = new System.Drawing.Point(8, 8);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1078, 128);
            this.panelForm.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tStatus);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lblAlamat);
            this.panel2.Controls.Add(this.tAlamat);
            this.panel2.Controls.Add(this.tNoTelepon);
            this.panel2.Controls.Add(this.lblNoTelepon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(435, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 128);
            this.panel2.TabIndex = 2;
            // 
            // tStatus
            // 
            this.tStatus.AlwaysActive = false;
            this.tStatus.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tStatus.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tStatus.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tStatus.Enabled = false;
            this.tStatus.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tStatus.Location = new System.Drawing.Point(112, 99);
            this.tStatus.MaxLength = 19;
            this.tStatus.Name = "tStatus";
            this.tStatus.Palette = this.palet;
            this.tStatus.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tStatus.Size = new System.Drawing.Size(166, 29);
            this.tStatus.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tStatus.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tStatus.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tStatus.StateActive.Border.Rounding = 0F;
            this.tStatus.StateActive.Border.Width = 1;
            this.tStatus.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tStatus.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tStatus.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tStatus.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tStatus.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tStatus.StateCommon.Border.Rounding = 0F;
            this.tStatus.StateCommon.Border.Width = 1;
            this.tStatus.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tStatus.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tStatus.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tStatus.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tStatus.StateDisabled.Border.Rounding = 0F;
            this.tStatus.StateDisabled.Border.Width = 0;
            this.tStatus.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.Location = new System.Drawing.Point(3, 99);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Palette = this.palet;
            this.lblStatus.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblStatus.Size = new System.Drawing.Size(103, 26);
            this.lblStatus.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatus.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblStatus.TabIndex = 933;
            this.lblStatus.Values.Text = "Status";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = false;
            this.lblAlamat.Location = new System.Drawing.Point(3, 35);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Palette = this.palet;
            this.lblAlamat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblAlamat.Size = new System.Drawing.Size(103, 26);
            this.lblAlamat.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAlamat.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblAlamat.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblAlamat.TabIndex = 930;
            this.lblAlamat.Values.Text = "Alamat";
            // 
            // tAlamat
            // 
            this.tAlamat.AlwaysActive = false;
            this.tAlamat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tAlamat.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tAlamat.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tAlamat.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tAlamat.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tAlamat.Location = new System.Drawing.Point(112, 35);
            this.tAlamat.MaxLength = 200;
            this.tAlamat.Name = "tAlamat";
            this.tAlamat.Palette = this.palet;
            this.tAlamat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tAlamat.Size = new System.Drawing.Size(528, 29);
            this.tAlamat.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tAlamat.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tAlamat.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tAlamat.StateActive.Border.Rounding = 0F;
            this.tAlamat.StateActive.Border.Width = 1;
            this.tAlamat.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tAlamat.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tAlamat.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tAlamat.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tAlamat.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tAlamat.StateCommon.Border.Rounding = 0F;
            this.tAlamat.StateCommon.Border.Width = 1;
            this.tAlamat.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tAlamat.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tAlamat.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tAlamat.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tAlamat.StateDisabled.Border.Rounding = 0F;
            this.tAlamat.StateDisabled.Border.Width = 0;
            this.tAlamat.TabIndex = 0;
            // 
            // tNoTelepon
            // 
            this.tNoTelepon.AlwaysActive = false;
            this.tNoTelepon.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tNoTelepon.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tNoTelepon.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tNoTelepon.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tNoTelepon.Location = new System.Drawing.Point(112, 67);
            this.tNoTelepon.MaxLength = 19;
            this.tNoTelepon.Name = "tNoTelepon";
            this.tNoTelepon.Palette = this.palet;
            this.tNoTelepon.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tNoTelepon.Size = new System.Drawing.Size(166, 29);
            this.tNoTelepon.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tNoTelepon.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tNoTelepon.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNoTelepon.StateActive.Border.Rounding = 0F;
            this.tNoTelepon.StateActive.Border.Width = 1;
            this.tNoTelepon.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tNoTelepon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tNoTelepon.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tNoTelepon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tNoTelepon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNoTelepon.StateCommon.Border.Rounding = 0F;
            this.tNoTelepon.StateCommon.Border.Width = 1;
            this.tNoTelepon.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tNoTelepon.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tNoTelepon.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tNoTelepon.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNoTelepon.StateDisabled.Border.Rounding = 0F;
            this.tNoTelepon.StateDisabled.Border.Width = 0;
            this.tNoTelepon.TabIndex = 1;
            // 
            // lblNoTelepon
            // 
            this.lblNoTelepon.AutoSize = false;
            this.lblNoTelepon.Location = new System.Drawing.Point(3, 67);
            this.lblNoTelepon.Name = "lblNoTelepon";
            this.lblNoTelepon.Palette = this.palet;
            this.lblNoTelepon.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblNoTelepon.Size = new System.Drawing.Size(103, 26);
            this.lblNoTelepon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNoTelepon.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblNoTelepon.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblNoTelepon.TabIndex = 931;
            this.lblNoTelepon.Values.Text = "No Telepon";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.tId);
            this.panel1.Controls.Add(this.rbPerempuan);
            this.panel1.Controls.Add(this.tNama);
            this.panel1.Controls.Add(this.rbLakiLaki);
            this.panel1.Controls.Add(this.lblNama);
            this.panel1.Controls.Add(this.tTglLahir);
            this.panel1.Controls.Add(this.lblJenisKelamin);
            this.panel1.Controls.Add(this.lblTglLahir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 128);
            this.panel1.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = false;
            this.lblId.Location = new System.Drawing.Point(3, 3);
            this.lblId.Name = "lblId";
            this.lblId.Palette = this.palet;
            this.lblId.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblId.Size = new System.Drawing.Size(116, 26);
            this.lblId.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblId.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblId.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblId.TabIndex = 919;
            this.lblId.Values.Text = "Id Pasien";
            // 
            // tId
            // 
            this.tId.AlwaysActive = false;
            this.tId.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tId.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tId.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tId.Location = new System.Drawing.Point(125, 3);
            this.tId.MaxLength = 50;
            this.tId.Name = "tId";
            this.tId.Palette = this.palet;
            this.tId.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tId.Size = new System.Drawing.Size(150, 29);
            this.tId.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tId.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tId.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tId.StateActive.Border.Rounding = 0F;
            this.tId.StateActive.Border.Width = 1;
            this.tId.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tId.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tId.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tId.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tId.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tId.StateCommon.Border.Rounding = 0F;
            this.tId.StateCommon.Border.Width = 1;
            this.tId.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tId.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tId.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tId.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tId.StateDisabled.Border.Rounding = 0F;
            this.tId.StateDisabled.Border.Width = 0;
            this.tId.TabIndex = 0;
            this.tId.TextChanged += new System.EventHandler(this.Validasi);
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.Location = new System.Drawing.Point(220, 66);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbPerempuan.Palette = this.palet;
            this.rbPerempuan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.rbPerempuan.Size = new System.Drawing.Size(113, 28);
            this.rbPerempuan.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbPerempuan.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerempuan.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rbPerempuan.TabIndex = 2;
            this.rbPerempuan.Values.Text = "Perempuan";
            this.rbPerempuan.CheckedChanged += new System.EventHandler(this.Validasi);
            // 
            // tNama
            // 
            this.tNama.AlwaysActive = false;
            this.tNama.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tNama.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tNama.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tNama.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tNama.Location = new System.Drawing.Point(125, 35);
            this.tNama.MaxLength = 100;
            this.tNama.Name = "tNama";
            this.tNama.Palette = this.palet;
            this.tNama.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tNama.Size = new System.Drawing.Size(300, 29);
            this.tNama.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tNama.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tNama.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNama.StateActive.Border.Rounding = 0F;
            this.tNama.StateActive.Border.Width = 1;
            this.tNama.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tNama.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tNama.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tNama.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tNama.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNama.StateCommon.Border.Rounding = 0F;
            this.tNama.StateCommon.Border.Width = 1;
            this.tNama.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tNama.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tNama.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tNama.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNama.StateDisabled.Border.Rounding = 0F;
            this.tNama.StateDisabled.Border.Width = 0;
            this.tNama.TabIndex = 0;
            this.tNama.TextChanged += new System.EventHandler(this.Validasi);
            // 
            // rbLakiLaki
            // 
            this.rbLakiLaki.Location = new System.Drawing.Point(125, 66);
            this.rbLakiLaki.Name = "rbLakiLaki";
            this.rbLakiLaki.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbLakiLaki.Palette = this.palet;
            this.rbLakiLaki.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.rbLakiLaki.Size = new System.Drawing.Size(89, 28);
            this.rbLakiLaki.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.rbLakiLaki.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLakiLaki.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rbLakiLaki.TabIndex = 1;
            this.rbLakiLaki.Values.Text = "Laki-laki";
            this.rbLakiLaki.CheckedChanged += new System.EventHandler(this.Validasi);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = false;
            this.lblNama.Location = new System.Drawing.Point(3, 35);
            this.lblNama.Name = "lblNama";
            this.lblNama.Palette = this.palet;
            this.lblNama.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblNama.Size = new System.Drawing.Size(116, 26);
            this.lblNama.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNama.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblNama.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblNama.TabIndex = 921;
            this.lblNama.Values.Text = "Nama";
            // 
            // tTglLahir
            // 
            this.tTglLahir.AlwaysActive = false;
            this.tTglLahir.CustomFormat = "dd MMMM yyyy";
            this.tTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tTglLahir.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tTglLahir.Location = new System.Drawing.Point(125, 99);
            this.tTglLahir.Name = "tTglLahir";
            this.tTglLahir.Palette = this.palet;
            this.tTglLahir.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tTglLahir.Size = new System.Drawing.Size(162, 26);
            this.tTglLahir.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tTglLahir.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTglLahir.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTglLahir.StateActive.Border.Width = 1;
            this.tTglLahir.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTglLahir.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.tTglLahir.TabIndex = 3;
            this.tTglLahir.ValueNullable = new System.DateTime(2022, 9, 14, 0, 0, 0, 0);
            // 
            // lblJenisKelamin
            // 
            this.lblJenisKelamin.AutoSize = false;
            this.lblJenisKelamin.Location = new System.Drawing.Point(3, 67);
            this.lblJenisKelamin.Name = "lblJenisKelamin";
            this.lblJenisKelamin.Palette = this.palet;
            this.lblJenisKelamin.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblJenisKelamin.Size = new System.Drawing.Size(116, 26);
            this.lblJenisKelamin.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblJenisKelamin.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblJenisKelamin.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblJenisKelamin.TabIndex = 924;
            this.lblJenisKelamin.Values.Text = "Jenis Kelamin";
            // 
            // lblTglLahir
            // 
            this.lblTglLahir.AutoSize = false;
            this.lblTglLahir.Location = new System.Drawing.Point(3, 99);
            this.lblTglLahir.Name = "lblTglLahir";
            this.lblTglLahir.Palette = this.palet;
            this.lblTglLahir.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTglLahir.Size = new System.Drawing.Size(116, 26);
            this.lblTglLahir.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTglLahir.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTglLahir.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblTglLahir.TabIndex = 926;
            this.lblTglLahir.Values.Text = "Tgl Lahir";
            // 
            // FPasien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1094, 640);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelDGV);
            this.Controls.Add(this.panelForm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FPasien";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "FPasien";
            this.Load += new System.EventHandler(this.FPasien_Load);
            this.Resize += new System.EventHandler(this.FPasien_Resize);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelDGV.ResumeLayout(false);
            this.panelDGVPagination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Krypton.Toolkit.KryptonPalette palet;
        private System.Windows.Forms.Panel panelControl;
        internal Krypton.Toolkit.KryptonTextBox tCariData;
        internal Krypton.Toolkit.KryptonButton btnHapus;
        internal Krypton.Toolkit.KryptonButton btnSimpan;
        internal Krypton.Toolkit.KryptonButton btnRefresh;
        private System.Windows.Forms.Panel panelDGV;
        private System.Windows.Forms.Panel panelDGVPagination;
        internal Krypton.Toolkit.KryptonLabel dgvPageCounter;
        internal Krypton.Toolkit.KryptonButton dgvPrev;
        internal Krypton.Toolkit.KryptonButton dgvFirst;
        internal Krypton.Toolkit.KryptonButton dgvNext;
        internal Krypton.Toolkit.KryptonButton dgvLast;
        internal Krypton.Toolkit.KryptonDataGridView dgv;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panel2;
        internal Krypton.Toolkit.KryptonLabel lblAlamat;
        internal Krypton.Toolkit.KryptonTextBox tAlamat;
        internal Krypton.Toolkit.KryptonTextBox tNoTelepon;
        internal Krypton.Toolkit.KryptonLabel lblNoTelepon;
        private System.Windows.Forms.Panel panel1;
        internal Krypton.Toolkit.KryptonLabel lblId;
        internal Krypton.Toolkit.KryptonTextBox tId;
        internal Krypton.Toolkit.KryptonRadioButton rbPerempuan;
        internal Krypton.Toolkit.KryptonTextBox tNama;
        internal Krypton.Toolkit.KryptonRadioButton rbLakiLaki;
        internal Krypton.Toolkit.KryptonLabel lblNama;
        internal Krypton.Toolkit.KryptonDateTimePicker tTglLahir;
        internal Krypton.Toolkit.KryptonLabel lblJenisKelamin;
        internal Krypton.Toolkit.KryptonLabel lblTglLahir;
        internal Krypton.Toolkit.KryptonTextBox tStatus;
        internal Krypton.Toolkit.KryptonLabel lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdPasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn cJenisKelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTanggalLahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoTelepon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
    }
}