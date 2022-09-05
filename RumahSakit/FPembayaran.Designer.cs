namespace RumahSakit
{
    partial class FPembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPembayaran));
            this.palet = new Krypton.Toolkit.KryptonPalette(this.components);
            this.tCariData = new Krypton.Toolkit.KryptonTextBox();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.dgv = new Krypton.Toolkit.KryptonDataGridView();
            this.cNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBiaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnSimpan = new Krypton.Toolkit.KryptonButton();
            this.btnRefresh = new Krypton.Toolkit.KryptonButton();
            this.grupBayar = new Krypton.Toolkit.KryptonGroup();
            this.lblBayar = new Krypton.Toolkit.KryptonLabel();
            this.tBayar = new Krypton.Toolkit.KryptonTextBox();
            this.tBalance = new Krypton.Toolkit.KryptonTextBox();
            this.lblBalance = new Krypton.Toolkit.KryptonLabel();
            this.pemisah1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.lblIdPerawatan = new Krypton.Toolkit.KryptonLabel();
            this.tTotalBiaya = new Krypton.Toolkit.KryptonTextBox();
            this.lblTotalBiaya = new Krypton.Toolkit.KryptonLabel();
            this.tSisa = new Krypton.Toolkit.KryptonTextBox();
            this.lblNamaKamar = new Krypton.Toolkit.KryptonLabel();
            this.tTglMasuk = new Krypton.Toolkit.KryptonTextBox();
            this.lblNamaPasien = new Krypton.Toolkit.KryptonLabel();
            this.lblSisa = new Krypton.Toolkit.KryptonLabel();
            this.lblTerbayar = new Krypton.Toolkit.KryptonLabel();
            this.tNamaKamar = new Krypton.Toolkit.KryptonTextBox();
            this.lblTglMasuk = new Krypton.Toolkit.KryptonLabel();
            this.tDiagnosis = new Krypton.Toolkit.KryptonTextBox();
            this.tTerbayar = new Krypton.Toolkit.KryptonTextBox();
            this.lblDiagnosis = new Krypton.Toolkit.KryptonLabel();
            this.tIdPerawatan = new Krypton.Toolkit.KryptonComboBox();
            this.tNamaPasien = new Krypton.Toolkit.KryptonTextBox();
            this.panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupBayar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupBayar.Panel)).BeginInit();
            this.grupBayar.Panel.SuspendLayout();
            this.grupBayar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIdPerawatan)).BeginInit();
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
            // tCariData
            // 
            this.tCariData.AlwaysActive = false;
            this.tCariData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tCariData.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tCariData.CueHint.CueHintText = "Cari data...";
            this.tCariData.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tCariData.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tCariData.Location = new System.Drawing.Point(3, 3);
            this.tCariData.MaxLength = 100;
            this.tCariData.Name = "tCariData";
            this.tCariData.Palette = this.palet;
            this.tCariData.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tCariData.Size = new System.Drawing.Size(603, 29);
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
            // panelDGV
            // 
            this.panelDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDGV.BackColor = System.Drawing.Color.White;
            this.panelDGV.Controls.Add(this.tCariData);
            this.panelDGV.Controls.Add(this.dgv);
            this.panelDGV.Location = new System.Drawing.Point(477, 8);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(609, 624);
            this.panelDGV.TabIndex = 1;
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
            this.cNama,
            this.cKategori,
            this.cBiaya});
            this.dgv.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv.HideOuterBorders = true;
            this.dgv.Location = new System.Drawing.Point(3, 35);
            this.dgv.Name = "dgv";
            this.dgv.Palette = this.palet;
            this.dgv.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(603, 567);
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
            // cNama
            // 
            this.cNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNama.HeaderText = "Nama";
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            this.cNama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cKategori
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cKategori.DefaultCellStyle = dataGridViewCellStyle3;
            this.cKategori.HeaderText = "Kategori";
            this.cKategori.Name = "cKategori";
            this.cKategori.ReadOnly = true;
            this.cKategori.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cKategori.Width = 80;
            // 
            // cBiaya
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n0";
            this.cBiaya.DefaultCellStyle = dataGridViewCellStyle4;
            this.cBiaya.HeaderText = "Biaya";
            this.cBiaya.Name = "cBiaya";
            this.cBiaya.ReadOnly = true;
            this.cBiaya.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cBiaya.Width = 113;
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.btnSimpan);
            this.panelForm.Controls.Add(this.btnRefresh);
            this.panelForm.Controls.Add(this.grupBayar);
            this.panelForm.Controls.Add(this.pemisah1);
            this.panelForm.Controls.Add(this.lblIdPerawatan);
            this.panelForm.Controls.Add(this.tTotalBiaya);
            this.panelForm.Controls.Add(this.lblTotalBiaya);
            this.panelForm.Controls.Add(this.tSisa);
            this.panelForm.Controls.Add(this.lblNamaKamar);
            this.panelForm.Controls.Add(this.tTglMasuk);
            this.panelForm.Controls.Add(this.lblNamaPasien);
            this.panelForm.Controls.Add(this.lblSisa);
            this.panelForm.Controls.Add(this.lblTerbayar);
            this.panelForm.Controls.Add(this.tNamaKamar);
            this.panelForm.Controls.Add(this.lblTglMasuk);
            this.panelForm.Controls.Add(this.tDiagnosis);
            this.panelForm.Controls.Add(this.tTerbayar);
            this.panelForm.Controls.Add(this.lblDiagnosis);
            this.panelForm.Controls.Add(this.tIdPerawatan);
            this.panelForm.Controls.Add(this.tNamaPasien);
            this.panelForm.Location = new System.Drawing.Point(8, 8);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(463, 624);
            this.panelForm.TabIndex = 0;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.Enabled = false;
            this.btnSimpan.Location = new System.Drawing.Point(294, 591);
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
            this.btnSimpan.TabIndex = 946;
            this.btnSimpan.Values.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.BTNSimpan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(380, 591);
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
            this.btnRefresh.TabIndex = 948;
            this.btnRefresh.Values.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.BTNRefresh_Click);
            // 
            // grupBayar
            // 
            this.grupBayar.Location = new System.Drawing.Point(248, 184);
            this.grupBayar.Name = "grupBayar";
            this.grupBayar.Palette = this.palet;
            this.grupBayar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            // 
            // grupBayar.Panel
            // 
            this.grupBayar.Panel.Controls.Add(this.lblBayar);
            this.grupBayar.Panel.Controls.Add(this.tBayar);
            this.grupBayar.Panel.Controls.Add(this.tBalance);
            this.grupBayar.Panel.Controls.Add(this.lblBalance);
            this.grupBayar.Size = new System.Drawing.Size(186, 70);
            this.grupBayar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.grupBayar.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.grupBayar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.grupBayar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grupBayar.StateCommon.Border.Width = 3;
            this.grupBayar.TabIndex = 0;
            // 
            // lblBayar
            // 
            this.lblBayar.AutoSize = false;
            this.lblBayar.Location = new System.Drawing.Point(3, 3);
            this.lblBayar.Name = "lblBayar";
            this.lblBayar.Palette = this.palet;
            this.lblBayar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblBayar.Size = new System.Drawing.Size(74, 26);
            this.lblBayar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBayar.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblBayar.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblBayar.TabIndex = 939;
            this.lblBayar.Values.Text = "Bayar";
            // 
            // tBayar
            // 
            this.tBayar.AlwaysActive = false;
            this.tBayar.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tBayar.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tBayar.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tBayar.Enabled = false;
            this.tBayar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tBayar.Location = new System.Drawing.Point(83, 3);
            this.tBayar.MaxLength = 9;
            this.tBayar.Name = "tBayar";
            this.tBayar.Palette = this.palet;
            this.tBayar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tBayar.Size = new System.Drawing.Size(93, 29);
            this.tBayar.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tBayar.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tBayar.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tBayar.StateActive.Border.Rounding = 0F;
            this.tBayar.StateActive.Border.Width = 1;
            this.tBayar.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tBayar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tBayar.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tBayar.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tBayar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tBayar.StateCommon.Border.Rounding = 0F;
            this.tBayar.StateCommon.Border.Width = 1;
            this.tBayar.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tBayar.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tBayar.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tBayar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tBayar.StateDisabled.Border.Rounding = 0F;
            this.tBayar.StateDisabled.Border.Width = 0;
            this.tBayar.TabIndex = 0;
            this.tBayar.TextChanged += new System.EventHandler(this.TBayar_TextChanged);
            this.tBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputAngka);
            // 
            // tBalance
            // 
            this.tBalance.AlwaysActive = false;
            this.tBalance.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tBalance.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tBalance.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tBalance.Enabled = false;
            this.tBalance.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tBalance.Location = new System.Drawing.Point(83, 35);
            this.tBalance.MaxLength = 11;
            this.tBalance.Name = "tBalance";
            this.tBalance.Palette = this.palet;
            this.tBalance.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tBalance.Size = new System.Drawing.Size(93, 29);
            this.tBalance.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tBalance.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tBalance.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tBalance.StateActive.Border.Rounding = 0F;
            this.tBalance.StateActive.Border.Width = 1;
            this.tBalance.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tBalance.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tBalance.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tBalance.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tBalance.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tBalance.StateCommon.Border.Rounding = 0F;
            this.tBalance.StateCommon.Border.Width = 1;
            this.tBalance.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tBalance.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tBalance.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tBalance.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tBalance.StateDisabled.Border.Rounding = 0F;
            this.tBalance.StateDisabled.Border.Width = 0;
            this.tBalance.TabIndex = 940;
            this.tBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = false;
            this.lblBalance.Location = new System.Drawing.Point(3, 35);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Palette = this.palet;
            this.lblBalance.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblBalance.Size = new System.Drawing.Size(74, 26);
            this.lblBalance.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBalance.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblBalance.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblBalance.TabIndex = 941;
            this.lblBalance.Values.Text = "Kurang";
            // 
            // pemisah1
            // 
            this.pemisah1.Location = new System.Drawing.Point(3, 163);
            this.pemisah1.Name = "pemisah1";
            this.pemisah1.Palette = this.palet;
            this.pemisah1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.pemisah1.Size = new System.Drawing.Size(457, 3);
            this.pemisah1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.pemisah1.StateCommon.Width = 3;
            this.pemisah1.Text = "KryptonBorderEdge1";
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
            // tTotalBiaya
            // 
            this.tTotalBiaya.AlwaysActive = false;
            this.tTotalBiaya.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tTotalBiaya.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tTotalBiaya.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tTotalBiaya.Enabled = false;
            this.tTotalBiaya.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tTotalBiaya.Location = new System.Drawing.Point(121, 172);
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
            this.tTotalBiaya.TabIndex = 4;
            this.tTotalBiaya.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalBiaya
            // 
            this.lblTotalBiaya.AutoSize = false;
            this.lblTotalBiaya.Location = new System.Drawing.Point(3, 172);
            this.lblTotalBiaya.Name = "lblTotalBiaya";
            this.lblTotalBiaya.Palette = this.palet;
            this.lblTotalBiaya.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTotalBiaya.Size = new System.Drawing.Size(112, 26);
            this.lblTotalBiaya.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalBiaya.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTotalBiaya.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblTotalBiaya.TabIndex = 931;
            this.lblTotalBiaya.Values.Text = "Total Biaya";
            // 
            // tSisa
            // 
            this.tSisa.AlwaysActive = false;
            this.tSisa.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tSisa.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tSisa.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tSisa.Enabled = false;
            this.tSisa.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tSisa.Location = new System.Drawing.Point(121, 236);
            this.tSisa.MaxLength = 11;
            this.tSisa.Name = "tSisa";
            this.tSisa.Palette = this.palet;
            this.tSisa.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tSisa.Size = new System.Drawing.Size(93, 29);
            this.tSisa.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tSisa.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tSisa.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tSisa.StateActive.Border.Rounding = 0F;
            this.tSisa.StateActive.Border.Width = 1;
            this.tSisa.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tSisa.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tSisa.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tSisa.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tSisa.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tSisa.StateCommon.Border.Rounding = 0F;
            this.tSisa.StateCommon.Border.Width = 1;
            this.tSisa.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tSisa.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tSisa.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tSisa.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tSisa.StateDisabled.Border.Rounding = 0F;
            this.tSisa.StateDisabled.Border.Width = 0;
            this.tSisa.TabIndex = 936;
            this.tSisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNamaKamar
            // 
            this.lblNamaKamar.AutoSize = false;
            this.lblNamaKamar.Location = new System.Drawing.Point(3, 67);
            this.lblNamaKamar.Name = "lblNamaKamar";
            this.lblNamaKamar.Palette = this.palet;
            this.lblNamaKamar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblNamaKamar.Size = new System.Drawing.Size(112, 26);
            this.lblNamaKamar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNamaKamar.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblNamaKamar.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblNamaKamar.TabIndex = 924;
            this.lblNamaKamar.Values.Text = "Nama Kamar";
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
            this.tTglMasuk.MaxLength = 200;
            this.tTglMasuk.Name = "tTglMasuk";
            this.tTglMasuk.Palette = this.palet;
            this.tTglMasuk.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tTglMasuk.Size = new System.Drawing.Size(339, 29);
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
            this.tTglMasuk.TabIndex = 3;
            // 
            // lblNamaPasien
            // 
            this.lblNamaPasien.AutoSize = false;
            this.lblNamaPasien.Location = new System.Drawing.Point(3, 35);
            this.lblNamaPasien.Name = "lblNamaPasien";
            this.lblNamaPasien.Palette = this.palet;
            this.lblNamaPasien.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblNamaPasien.Size = new System.Drawing.Size(112, 26);
            this.lblNamaPasien.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNamaPasien.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblNamaPasien.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblNamaPasien.TabIndex = 921;
            this.lblNamaPasien.Values.Text = "Nama Pasien";
            // 
            // lblSisa
            // 
            this.lblSisa.AutoSize = false;
            this.lblSisa.Location = new System.Drawing.Point(3, 236);
            this.lblSisa.Name = "lblSisa";
            this.lblSisa.Palette = this.palet;
            this.lblSisa.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblSisa.Size = new System.Drawing.Size(112, 26);
            this.lblSisa.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSisa.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblSisa.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblSisa.TabIndex = 938;
            this.lblSisa.Values.Text = "Sisa";
            // 
            // lblTerbayar
            // 
            this.lblTerbayar.AutoSize = false;
            this.lblTerbayar.Location = new System.Drawing.Point(3, 204);
            this.lblTerbayar.Name = "lblTerbayar";
            this.lblTerbayar.Palette = this.palet;
            this.lblTerbayar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTerbayar.Size = new System.Drawing.Size(112, 26);
            this.lblTerbayar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTerbayar.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTerbayar.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblTerbayar.TabIndex = 933;
            this.lblTerbayar.Values.Text = "Terbayar";
            // 
            // tNamaKamar
            // 
            this.tNamaKamar.AlwaysActive = false;
            this.tNamaKamar.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tNamaKamar.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tNamaKamar.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tNamaKamar.Enabled = false;
            this.tNamaKamar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tNamaKamar.Location = new System.Drawing.Point(121, 67);
            this.tNamaKamar.MaxLength = 200;
            this.tNamaKamar.Name = "tNamaKamar";
            this.tNamaKamar.Palette = this.palet;
            this.tNamaKamar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tNamaKamar.Size = new System.Drawing.Size(339, 29);
            this.tNamaKamar.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tNamaKamar.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tNamaKamar.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNamaKamar.StateActive.Border.Rounding = 0F;
            this.tNamaKamar.StateActive.Border.Width = 1;
            this.tNamaKamar.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tNamaKamar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tNamaKamar.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tNamaKamar.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tNamaKamar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNamaKamar.StateCommon.Border.Rounding = 0F;
            this.tNamaKamar.StateCommon.Border.Width = 1;
            this.tNamaKamar.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tNamaKamar.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tNamaKamar.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tNamaKamar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNamaKamar.StateDisabled.Border.Rounding = 0F;
            this.tNamaKamar.StateDisabled.Border.Width = 0;
            this.tNamaKamar.TabIndex = 2;
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
            // tDiagnosis
            // 
            this.tDiagnosis.AlwaysActive = false;
            this.tDiagnosis.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tDiagnosis.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tDiagnosis.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tDiagnosis.Enabled = false;
            this.tDiagnosis.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tDiagnosis.Location = new System.Drawing.Point(121, 131);
            this.tDiagnosis.MaxLength = 200;
            this.tDiagnosis.Name = "tDiagnosis";
            this.tDiagnosis.Palette = this.palet;
            this.tDiagnosis.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tDiagnosis.Size = new System.Drawing.Size(339, 29);
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
            // tTerbayar
            // 
            this.tTerbayar.AlwaysActive = false;
            this.tTerbayar.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tTerbayar.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tTerbayar.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tTerbayar.Enabled = false;
            this.tTerbayar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tTerbayar.Location = new System.Drawing.Point(121, 204);
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
            this.tTerbayar.TabIndex = 932;
            this.tTerbayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = false;
            this.lblDiagnosis.Location = new System.Drawing.Point(3, 131);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Palette = this.palet;
            this.lblDiagnosis.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblDiagnosis.Size = new System.Drawing.Size(112, 26);
            this.lblDiagnosis.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiagnosis.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblDiagnosis.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblDiagnosis.TabIndex = 931;
            this.lblDiagnosis.Values.Text = "Diagnosis";
            // 
            // tIdPerawatan
            // 
            this.tIdPerawatan.AlwaysActive = false;
            this.tIdPerawatan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.tIdPerawatan.DropDownHeight = 327;
            this.tIdPerawatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tIdPerawatan.DropDownWidth = 119;
            this.tIdPerawatan.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tIdPerawatan.IntegralHeight = false;
            this.tIdPerawatan.Location = new System.Drawing.Point(121, 3);
            this.tIdPerawatan.MaxDropDownItems = 13;
            this.tIdPerawatan.Name = "tIdPerawatan";
            this.tIdPerawatan.Palette = this.palet;
            this.tIdPerawatan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tIdPerawatan.Size = new System.Drawing.Size(180, 26);
            this.tIdPerawatan.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tIdPerawatan.StateActive.ComboBox.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tIdPerawatan.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tIdPerawatan.StateActive.ComboBox.Border.Width = 1;
            this.tIdPerawatan.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tIdPerawatan.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIdPerawatan.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.tIdPerawatan.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.tIdPerawatan.StateCommon.Item.Back.Color1 = System.Drawing.Color.Green;
            this.tIdPerawatan.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tIdPerawatan.StateCommon.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tIdPerawatan.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tIdPerawatan.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tIdPerawatan.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tIdPerawatan.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.tIdPerawatan.TabIndex = 0;
            this.tIdPerawatan.SelectedIndexChanged += new System.EventHandler(this.TIdPerawatan_SelectedIndexChanged);
            // 
            // tNamaPasien
            // 
            this.tNamaPasien.AlwaysActive = false;
            this.tNamaPasien.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tNamaPasien.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tNamaPasien.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tNamaPasien.Enabled = false;
            this.tNamaPasien.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tNamaPasien.Location = new System.Drawing.Point(121, 35);
            this.tNamaPasien.MaxLength = 200;
            this.tNamaPasien.Name = "tNamaPasien";
            this.tNamaPasien.Palette = this.palet;
            this.tNamaPasien.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tNamaPasien.Size = new System.Drawing.Size(339, 29);
            this.tNamaPasien.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tNamaPasien.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tNamaPasien.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNamaPasien.StateActive.Border.Rounding = 0F;
            this.tNamaPasien.StateActive.Border.Width = 1;
            this.tNamaPasien.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tNamaPasien.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tNamaPasien.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tNamaPasien.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tNamaPasien.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNamaPasien.StateCommon.Border.Rounding = 0F;
            this.tNamaPasien.StateCommon.Border.Width = 1;
            this.tNamaPasien.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tNamaPasien.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tNamaPasien.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tNamaPasien.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNamaPasien.StateDisabled.Border.Rounding = 0F;
            this.tNamaPasien.StateDisabled.Border.Width = 0;
            this.tNamaPasien.TabIndex = 1;
            // 
            // FPembayaran
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1094, 640);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelDGV);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FPembayaran";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "FPembayaran";
            this.Load += new System.EventHandler(this.FPembayaran_Load);
            this.panelDGV.ResumeLayout(false);
            this.panelDGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupBayar.Panel)).EndInit();
            this.grupBayar.Panel.ResumeLayout(false);
            this.grupBayar.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupBayar)).EndInit();
            this.grupBayar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tIdPerawatan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Krypton.Toolkit.KryptonPalette palet;
        internal Krypton.Toolkit.KryptonTextBox tCariData;
        private System.Windows.Forms.Panel panelDGV;
        internal Krypton.Toolkit.KryptonDataGridView dgv;
        private System.Windows.Forms.Panel panelForm;
        internal Krypton.Toolkit.KryptonTextBox tTotalBiaya;
        internal Krypton.Toolkit.KryptonTextBox tDiagnosis;
        internal Krypton.Toolkit.KryptonLabel lblTotalBiaya;
        internal Krypton.Toolkit.KryptonLabel lblDiagnosis;
        internal Krypton.Toolkit.KryptonTextBox tTglMasuk;
        internal Krypton.Toolkit.KryptonTextBox tNamaKamar;
        internal Krypton.Toolkit.KryptonTextBox tNamaPasien;
        internal Krypton.Toolkit.KryptonComboBox tIdPerawatan;
        internal Krypton.Toolkit.KryptonLabel lblIdPerawatan;
        internal Krypton.Toolkit.KryptonLabel lblTglMasuk;
        internal Krypton.Toolkit.KryptonLabel lblNamaPasien;
        internal Krypton.Toolkit.KryptonLabel lblNamaKamar;
        internal Krypton.Toolkit.KryptonTextBox tTerbayar;
        internal Krypton.Toolkit.KryptonLabel lblTerbayar;
        internal Krypton.Toolkit.KryptonTextBox tBalance;
        internal Krypton.Toolkit.KryptonLabel lblBalance;
        internal Krypton.Toolkit.KryptonTextBox tSisa;
        internal Krypton.Toolkit.KryptonLabel lblSisa;
        internal Krypton.Toolkit.KryptonTextBox tBayar;
        internal Krypton.Toolkit.KryptonLabel lblBayar;
        internal Krypton.Toolkit.KryptonGroup grupBayar;
        internal Krypton.Toolkit.KryptonBorderEdge pemisah1;
        internal Krypton.Toolkit.KryptonButton btnSimpan;
        internal Krypton.Toolkit.KryptonButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBiaya;
    }
}