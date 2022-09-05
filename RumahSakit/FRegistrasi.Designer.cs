namespace RumahSakit
{
    partial class FRegistrasi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRegistrasi));
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
            this.cIdPerawatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNamaPasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNamaKamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTglMasuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTglKeluar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDiagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotalBiaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTerbayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tTglKeluar = new Krypton.Toolkit.KryptonTextBox();
            this.pemisah2 = new Krypton.Toolkit.KryptonBorderEdge();
            this.pemisah1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.tStatus = new Krypton.Toolkit.KryptonTextBox();
            this.lblStatus = new Krypton.Toolkit.KryptonLabel();
            this.tTotalBiaya = new Krypton.Toolkit.KryptonTextBox();
            this.lblTglKeluar = new Krypton.Toolkit.KryptonLabel();
            this.lblTotalBiaya = new Krypton.Toolkit.KryptonLabel();
            this.tTerbayar = new Krypton.Toolkit.KryptonTextBox();
            this.tDiagnosis = new Krypton.Toolkit.KryptonTextBox();
            this.lblTerbayar = new Krypton.Toolkit.KryptonLabel();
            this.lblDiagnosis = new Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tTglMasuk = new Krypton.Toolkit.KryptonTextBox();
            this.tPasien = new Krypton.Toolkit.KryptonComboBox();
            this.tKamar = new Krypton.Toolkit.KryptonComboBox();
            this.lblIdPerawatan = new Krypton.Toolkit.KryptonLabel();
            this.tIdPerawatan = new Krypton.Toolkit.KryptonTextBox();
            this.lblTglMasuk = new Krypton.Toolkit.KryptonLabel();
            this.lblPasien = new Krypton.Toolkit.KryptonLabel();
            this.lblKamar = new Krypton.Toolkit.KryptonLabel();
            this.panelControl.SuspendLayout();
            this.panelDGV.SuspendLayout();
            this.panelDGVPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelForm.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tPasien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKamar)).BeginInit();
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
            this.panelControl.TabIndex = 4;
            // 
            // tCariData
            // 
            this.tCariData.AlwaysActive = false;
            this.tCariData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tCariData.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tCariData.CueHint.CueHintText = "Cari perawatan...";
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
            this.panelDGV.TabIndex = 3;
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
            this.cIdPerawatan,
            this.cNamaPasien,
            this.cNamaKamar,
            this.cTglMasuk,
            this.cTglKeluar,
            this.cDiagnosis,
            this.cTotalBiaya,
            this.cTerbayar,
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
            // cIdPerawatan
            // 
            this.cIdPerawatan.HeaderText = "Id Perawatan";
            this.cIdPerawatan.Name = "cIdPerawatan";
            this.cIdPerawatan.ReadOnly = true;
            this.cIdPerawatan.Visible = false;
            // 
            // cNamaPasien
            // 
            this.cNamaPasien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNamaPasien.HeaderText = "Nama Pasien";
            this.cNamaPasien.Name = "cNamaPasien";
            this.cNamaPasien.ReadOnly = true;
            this.cNamaPasien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cNamaKamar
            // 
            this.cNamaKamar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cNamaKamar.DefaultCellStyle = dataGridViewCellStyle3;
            this.cNamaKamar.HeaderText = "Nama Kamar";
            this.cNamaKamar.Name = "cNamaKamar";
            this.cNamaKamar.ReadOnly = true;
            this.cNamaKamar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cTglMasuk
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.cTglMasuk.DefaultCellStyle = dataGridViewCellStyle4;
            this.cTglMasuk.HeaderText = "Tgl Masuk";
            this.cTglMasuk.Name = "cTglMasuk";
            this.cTglMasuk.ReadOnly = true;
            this.cTglMasuk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cTglMasuk.Width = 107;
            // 
            // cTglKeluar
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.cTglKeluar.DefaultCellStyle = dataGridViewCellStyle5;
            this.cTglKeluar.HeaderText = "Tgl Keluar";
            this.cTglKeluar.Name = "cTglKeluar";
            this.cTglKeluar.ReadOnly = true;
            this.cTglKeluar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cTglKeluar.Width = 107;
            // 
            // cDiagnosis
            // 
            this.cDiagnosis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cDiagnosis.HeaderText = "Diagnosis";
            this.cDiagnosis.Name = "cDiagnosis";
            this.cDiagnosis.ReadOnly = true;
            this.cDiagnosis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cTotalBiaya
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n0";
            this.cTotalBiaya.DefaultCellStyle = dataGridViewCellStyle6;
            this.cTotalBiaya.HeaderText = "Total Biaya";
            this.cTotalBiaya.Name = "cTotalBiaya";
            this.cTotalBiaya.ReadOnly = true;
            this.cTotalBiaya.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cTotalBiaya.Width = 113;
            // 
            // cTerbayar
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "n0";
            this.cTerbayar.DefaultCellStyle = dataGridViewCellStyle7;
            this.cTerbayar.HeaderText = "Terbayar";
            this.cTerbayar.Name = "cTerbayar";
            this.cTerbayar.ReadOnly = true;
            this.cTerbayar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cTerbayar.Width = 113;
            // 
            // cStatus
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cStatus.DefaultCellStyle = dataGridViewCellStyle8;
            this.cStatus.HeaderText = "Status";
            this.cStatus.Name = "cStatus";
            this.cStatus.ReadOnly = true;
            this.cStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cStatus.Width = 82;
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
            this.panelForm.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tTglKeluar);
            this.panel2.Controls.Add(this.pemisah2);
            this.panel2.Controls.Add(this.pemisah1);
            this.panel2.Controls.Add(this.tStatus);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.tTotalBiaya);
            this.panel2.Controls.Add(this.lblTglKeluar);
            this.panel2.Controls.Add(this.lblTotalBiaya);
            this.panel2.Controls.Add(this.tTerbayar);
            this.panel2.Controls.Add(this.tDiagnosis);
            this.panel2.Controls.Add(this.lblTerbayar);
            this.panel2.Controls.Add(this.lblDiagnosis);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(307, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 128);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // tTglKeluar
            // 
            this.tTglKeluar.AlwaysActive = false;
            this.tTglKeluar.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tTglKeluar.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tTglKeluar.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tTglKeluar.Enabled = false;
            this.tTglKeluar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tTglKeluar.Location = new System.Drawing.Point(112, 99);
            this.tTglKeluar.MaxLength = 50;
            this.tTglKeluar.Name = "tTglKeluar";
            this.tTglKeluar.Palette = this.palet;
            this.tTglKeluar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tTglKeluar.Size = new System.Drawing.Size(162, 29);
            this.tTglKeluar.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tTglKeluar.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTglKeluar.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTglKeluar.StateActive.Border.Rounding = 0F;
            this.tTglKeluar.StateActive.Border.Width = 1;
            this.tTglKeluar.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tTglKeluar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tTglKeluar.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tTglKeluar.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTglKeluar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTglKeluar.StateCommon.Border.Rounding = 0F;
            this.tTglKeluar.StateCommon.Border.Width = 1;
            this.tTglKeluar.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tTglKeluar.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tTglKeluar.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tTglKeluar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTglKeluar.StateDisabled.Border.Rounding = 0F;
            this.tTglKeluar.StateDisabled.Border.Width = 0;
            this.tTglKeluar.TabIndex = 2;
            // 
            // pemisah2
            // 
            this.pemisah2.Location = new System.Drawing.Point(284, 67);
            this.pemisah2.Name = "pemisah2";
            this.pemisah2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.pemisah2.Size = new System.Drawing.Size(3, 58);
            this.pemisah2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.pemisah2.StateCommon.Width = 3;
            this.pemisah2.Text = "KryptonBorderEdge1";
            // 
            // pemisah1
            // 
            this.pemisah1.Location = new System.Drawing.Point(1, 35);
            this.pemisah1.Name = "pemisah1";
            this.pemisah1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.pemisah1.Size = new System.Drawing.Size(3, 90);
            this.pemisah1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.pemisah1.StateCommon.Width = 3;
            this.pemisah1.Text = "KryptonBorderEdge1";
            // 
            // tStatus
            // 
            this.tStatus.AlwaysActive = false;
            this.tStatus.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tStatus.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tStatus.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tStatus.Enabled = false;
            this.tStatus.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tStatus.Location = new System.Drawing.Point(112, 67);
            this.tStatus.MaxLength = 50;
            this.tStatus.Name = "tStatus";
            this.tStatus.Palette = this.palet;
            this.tStatus.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tStatus.Size = new System.Drawing.Size(162, 29);
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
            this.tStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.Location = new System.Drawing.Point(10, 67);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Palette = this.palet;
            this.lblStatus.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblStatus.Size = new System.Drawing.Size(96, 26);
            this.lblStatus.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatus.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblStatus.TabIndex = 934;
            this.lblStatus.Values.Text = "Status";
            // 
            // tTotalBiaya
            // 
            this.tTotalBiaya.AlwaysActive = false;
            this.tTotalBiaya.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tTotalBiaya.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tTotalBiaya.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tTotalBiaya.Enabled = false;
            this.tTotalBiaya.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tTotalBiaya.Location = new System.Drawing.Point(395, 67);
            this.tTotalBiaya.MaxLength = 11;
            this.tTotalBiaya.Name = "tTotalBiaya";
            this.tTotalBiaya.Palette = this.palet;
            this.tTotalBiaya.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tTotalBiaya.Size = new System.Drawing.Size(93, 29);
            this.tTotalBiaya.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tTotalBiaya.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTotalBiaya.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTotalBiaya.StateActive.Border.Rounding = 0F;
            this.tTotalBiaya.StateActive.Border.Width = 1;
            this.tTotalBiaya.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tTotalBiaya.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tTotalBiaya.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tTotalBiaya.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTotalBiaya.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTotalBiaya.StateCommon.Border.Rounding = 0F;
            this.tTotalBiaya.StateCommon.Border.Width = 1;
            this.tTotalBiaya.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tTotalBiaya.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tTotalBiaya.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tTotalBiaya.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTotalBiaya.StateDisabled.Border.Rounding = 0F;
            this.tTotalBiaya.StateDisabled.Border.Width = 0;
            this.tTotalBiaya.TabIndex = 3;
            this.tTotalBiaya.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTglKeluar
            // 
            this.lblTglKeluar.AutoSize = false;
            this.lblTglKeluar.Location = new System.Drawing.Point(10, 99);
            this.lblTglKeluar.Name = "lblTglKeluar";
            this.lblTglKeluar.Palette = this.palet;
            this.lblTglKeluar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTglKeluar.Size = new System.Drawing.Size(96, 26);
            this.lblTglKeluar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTglKeluar.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTglKeluar.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblTglKeluar.TabIndex = 930;
            this.lblTglKeluar.Values.Text = "Tgl Keluar";
            // 
            // lblTotalBiaya
            // 
            this.lblTotalBiaya.AutoSize = false;
            this.lblTotalBiaya.Location = new System.Drawing.Point(293, 67);
            this.lblTotalBiaya.Name = "lblTotalBiaya";
            this.lblTotalBiaya.Palette = this.palet;
            this.lblTotalBiaya.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTotalBiaya.Size = new System.Drawing.Size(96, 26);
            this.lblTotalBiaya.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalBiaya.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTotalBiaya.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblTotalBiaya.TabIndex = 931;
            this.lblTotalBiaya.Values.Text = "Total Biaya";
            // 
            // tTerbayar
            // 
            this.tTerbayar.AlwaysActive = false;
            this.tTerbayar.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tTerbayar.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tTerbayar.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tTerbayar.Enabled = false;
            this.tTerbayar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tTerbayar.Location = new System.Drawing.Point(395, 99);
            this.tTerbayar.MaxLength = 11;
            this.tTerbayar.Name = "tTerbayar";
            this.tTerbayar.Palette = this.palet;
            this.tTerbayar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tTerbayar.Size = new System.Drawing.Size(93, 29);
            this.tTerbayar.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tTerbayar.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTerbayar.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTerbayar.StateActive.Border.Rounding = 0F;
            this.tTerbayar.StateActive.Border.Width = 1;
            this.tTerbayar.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tTerbayar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tTerbayar.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tTerbayar.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTerbayar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTerbayar.StateCommon.Border.Rounding = 0F;
            this.tTerbayar.StateCommon.Border.Width = 1;
            this.tTerbayar.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tTerbayar.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tTerbayar.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tTerbayar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTerbayar.StateDisabled.Border.Rounding = 0F;
            this.tTerbayar.StateDisabled.Border.Width = 0;
            this.tTerbayar.TabIndex = 4;
            this.tTerbayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tDiagnosis
            // 
            this.tDiagnosis.AlwaysActive = false;
            this.tDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tDiagnosis.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tDiagnosis.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tDiagnosis.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tDiagnosis.Enabled = false;
            this.tDiagnosis.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tDiagnosis.Location = new System.Drawing.Point(112, 35);
            this.tDiagnosis.MaxLength = 100;
            this.tDiagnosis.Name = "tDiagnosis";
            this.tDiagnosis.Palette = this.palet;
            this.tDiagnosis.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tDiagnosis.Size = new System.Drawing.Size(656, 29);
            this.tDiagnosis.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tDiagnosis.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tDiagnosis.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tDiagnosis.StateActive.Border.Rounding = 0F;
            this.tDiagnosis.StateActive.Border.Width = 1;
            this.tDiagnosis.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tDiagnosis.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tDiagnosis.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tDiagnosis.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tDiagnosis.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tDiagnosis.StateCommon.Border.Rounding = 0F;
            this.tDiagnosis.StateCommon.Border.Width = 1;
            this.tDiagnosis.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tDiagnosis.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tDiagnosis.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tDiagnosis.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tDiagnosis.StateDisabled.Border.Rounding = 0F;
            this.tDiagnosis.StateDisabled.Border.Width = 0;
            this.tDiagnosis.TabIndex = 0;
            // 
            // lblTerbayar
            // 
            this.lblTerbayar.AutoSize = false;
            this.lblTerbayar.Location = new System.Drawing.Point(293, 99);
            this.lblTerbayar.Name = "lblTerbayar";
            this.lblTerbayar.Palette = this.palet;
            this.lblTerbayar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTerbayar.Size = new System.Drawing.Size(96, 26);
            this.lblTerbayar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTerbayar.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTerbayar.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblTerbayar.TabIndex = 931;
            this.lblTerbayar.Values.Text = "Terbayar";
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = false;
            this.lblDiagnosis.Location = new System.Drawing.Point(10, 35);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Palette = this.palet;
            this.lblDiagnosis.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblDiagnosis.Size = new System.Drawing.Size(96, 26);
            this.lblDiagnosis.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiagnosis.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblDiagnosis.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblDiagnosis.TabIndex = 931;
            this.lblDiagnosis.Values.Text = "Diagnosis";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tTglMasuk);
            this.panel1.Controls.Add(this.tPasien);
            this.panel1.Controls.Add(this.tKamar);
            this.panel1.Controls.Add(this.lblIdPerawatan);
            this.panel1.Controls.Add(this.tIdPerawatan);
            this.panel1.Controls.Add(this.lblTglMasuk);
            this.panel1.Controls.Add(this.lblPasien);
            this.panel1.Controls.Add(this.lblKamar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 128);
            this.panel1.TabIndex = 1;
            // 
            // tTglMasuk
            // 
            this.tTglMasuk.AlwaysActive = false;
            this.tTglMasuk.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tTglMasuk.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tTglMasuk.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tTglMasuk.Enabled = false;
            this.tTglMasuk.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tTglMasuk.Location = new System.Drawing.Point(121, 99);
            this.tTglMasuk.MaxLength = 50;
            this.tTglMasuk.Name = "tTglMasuk";
            this.tTglMasuk.Palette = this.palet;
            this.tTglMasuk.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tTglMasuk.Size = new System.Drawing.Size(162, 29);
            this.tTglMasuk.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tTglMasuk.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTglMasuk.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTglMasuk.StateActive.Border.Rounding = 0F;
            this.tTglMasuk.StateActive.Border.Width = 1;
            this.tTglMasuk.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tTglMasuk.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tTglMasuk.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tTglMasuk.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTglMasuk.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTglMasuk.StateCommon.Border.Rounding = 0F;
            this.tTglMasuk.StateCommon.Border.Width = 1;
            this.tTglMasuk.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tTglMasuk.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tTglMasuk.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tTglMasuk.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTglMasuk.StateDisabled.Border.Rounding = 0F;
            this.tTglMasuk.StateDisabled.Border.Width = 0;
            this.tTglMasuk.TabIndex = 927;
            // 
            // tPasien
            // 
            this.tPasien.AlwaysActive = false;
            this.tPasien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.tPasien.DropDownHeight = 327;
            this.tPasien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tPasien.DropDownWidth = 119;
            this.tPasien.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tPasien.IntegralHeight = false;
            this.tPasien.Location = new System.Drawing.Point(121, 35);
            this.tPasien.MaxDropDownItems = 13;
            this.tPasien.Name = "tPasien";
            this.tPasien.Palette = this.palet;
            this.tPasien.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tPasien.Size = new System.Drawing.Size(180, 26);
            this.tPasien.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tPasien.StateActive.ComboBox.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tPasien.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tPasien.StateActive.ComboBox.Border.Width = 1;
            this.tPasien.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tPasien.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPasien.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.tPasien.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.tPasien.StateCommon.Item.Back.Color1 = System.Drawing.Color.Green;
            this.tPasien.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tPasien.StateCommon.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tPasien.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tPasien.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tPasien.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tPasien.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.tPasien.TabIndex = 0;
            this.tPasien.SelectedIndexChanged += new System.EventHandler(this.Validasi);
            // 
            // tKamar
            // 
            this.tKamar.AlwaysActive = false;
            this.tKamar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.tKamar.DropDownHeight = 327;
            this.tKamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tKamar.DropDownWidth = 119;
            this.tKamar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tKamar.IntegralHeight = false;
            this.tKamar.Location = new System.Drawing.Point(121, 67);
            this.tKamar.MaxDropDownItems = 13;
            this.tKamar.Name = "tKamar";
            this.tKamar.Palette = this.palet;
            this.tKamar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tKamar.Size = new System.Drawing.Size(180, 26);
            this.tKamar.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tKamar.StateActive.ComboBox.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tKamar.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tKamar.StateActive.ComboBox.Border.Width = 1;
            this.tKamar.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tKamar.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tKamar.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.tKamar.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.tKamar.StateCommon.Item.Back.Color1 = System.Drawing.Color.Green;
            this.tKamar.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tKamar.StateCommon.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tKamar.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tKamar.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tKamar.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tKamar.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.tKamar.TabIndex = 1;
            this.tKamar.SelectedIndexChanged += new System.EventHandler(this.Validasi);
            // 
            // lblIdPerawatan
            // 
            this.lblIdPerawatan.AutoSize = false;
            this.lblIdPerawatan.Location = new System.Drawing.Point(3, 3);
            this.lblIdPerawatan.Name = "lblIdPerawatan";
            this.lblIdPerawatan.Palette = this.palet;
            this.lblIdPerawatan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblIdPerawatan.Size = new System.Drawing.Size(112, 26);
            this.lblIdPerawatan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdPerawatan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblIdPerawatan.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblIdPerawatan.TabIndex = 919;
            this.lblIdPerawatan.Values.Text = "Id Perawatan";
            // 
            // tIdPerawatan
            // 
            this.tIdPerawatan.AlwaysActive = false;
            this.tIdPerawatan.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tIdPerawatan.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tIdPerawatan.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tIdPerawatan.Enabled = false;
            this.tIdPerawatan.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tIdPerawatan.Location = new System.Drawing.Point(121, 3);
            this.tIdPerawatan.MaxLength = 50;
            this.tIdPerawatan.Name = "tIdPerawatan";
            this.tIdPerawatan.Palette = this.palet;
            this.tIdPerawatan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tIdPerawatan.Size = new System.Drawing.Size(150, 29);
            this.tIdPerawatan.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tIdPerawatan.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tIdPerawatan.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tIdPerawatan.StateActive.Border.Rounding = 0F;
            this.tIdPerawatan.StateActive.Border.Width = 1;
            this.tIdPerawatan.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tIdPerawatan.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tIdPerawatan.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tIdPerawatan.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tIdPerawatan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tIdPerawatan.StateCommon.Border.Rounding = 0F;
            this.tIdPerawatan.StateCommon.Border.Width = 1;
            this.tIdPerawatan.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tIdPerawatan.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tIdPerawatan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tIdPerawatan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tIdPerawatan.StateDisabled.Border.Rounding = 0F;
            this.tIdPerawatan.StateDisabled.Border.Width = 0;
            this.tIdPerawatan.TabIndex = 3;
            // 
            // lblTglMasuk
            // 
            this.lblTglMasuk.AutoSize = false;
            this.lblTglMasuk.Location = new System.Drawing.Point(3, 99);
            this.lblTglMasuk.Name = "lblTglMasuk";
            this.lblTglMasuk.Palette = this.palet;
            this.lblTglMasuk.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTglMasuk.Size = new System.Drawing.Size(112, 26);
            this.lblTglMasuk.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTglMasuk.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTglMasuk.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblTglMasuk.TabIndex = 926;
            this.lblTglMasuk.Values.Text = "Tgl Masuk";
            // 
            // lblPasien
            // 
            this.lblPasien.AutoSize = false;
            this.lblPasien.Location = new System.Drawing.Point(3, 35);
            this.lblPasien.Name = "lblPasien";
            this.lblPasien.Palette = this.palet;
            this.lblPasien.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblPasien.Size = new System.Drawing.Size(112, 26);
            this.lblPasien.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPasien.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblPasien.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblPasien.TabIndex = 921;
            this.lblPasien.Values.Text = "Pasien";
            // 
            // lblKamar
            // 
            this.lblKamar.AutoSize = false;
            this.lblKamar.Location = new System.Drawing.Point(3, 67);
            this.lblKamar.Name = "lblKamar";
            this.lblKamar.Palette = this.palet;
            this.lblKamar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblKamar.Size = new System.Drawing.Size(112, 26);
            this.lblKamar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblKamar.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblKamar.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblKamar.TabIndex = 924;
            this.lblKamar.Values.Text = "Kamar";
            // 
            // FRegistrasi
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
            this.Name = "FRegistrasi";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "FRegistrasi";
            this.Load += new System.EventHandler(this.FRegistrasi_Load);
            this.Resize += new System.EventHandler(this.FRegistrasi_Resize);
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
            ((System.ComponentModel.ISupportInitialize)(this.tPasien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKamar)).EndInit();
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
        internal Krypton.Toolkit.KryptonLabel lblTglKeluar;
        internal Krypton.Toolkit.KryptonTextBox tDiagnosis;
        internal Krypton.Toolkit.KryptonLabel lblDiagnosis;
        private System.Windows.Forms.Panel panel1;
        internal Krypton.Toolkit.KryptonLabel lblIdPerawatan;
        internal Krypton.Toolkit.KryptonTextBox tIdPerawatan;
        internal Krypton.Toolkit.KryptonLabel lblPasien;
        internal Krypton.Toolkit.KryptonLabel lblKamar;
        internal Krypton.Toolkit.KryptonLabel lblTglMasuk;
        internal Krypton.Toolkit.KryptonComboBox tKamar;
        internal Krypton.Toolkit.KryptonComboBox tPasien;
        internal Krypton.Toolkit.KryptonTextBox tTotalBiaya;
        internal Krypton.Toolkit.KryptonLabel lblTotalBiaya;
        internal Krypton.Toolkit.KryptonTextBox tTerbayar;
        internal Krypton.Toolkit.KryptonLabel lblTerbayar;
        internal Krypton.Toolkit.KryptonTextBox tStatus;
        internal Krypton.Toolkit.KryptonLabel lblStatus;
        internal Krypton.Toolkit.KryptonBorderEdge pemisah1;
        internal Krypton.Toolkit.KryptonBorderEdge pemisah2;
        internal Krypton.Toolkit.KryptonTextBox tTglKeluar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdPerawatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNamaPasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNamaKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTglMasuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTglKeluar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotalBiaya;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTerbayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
        internal Krypton.Toolkit.KryptonTextBox tTglMasuk;
    }
}