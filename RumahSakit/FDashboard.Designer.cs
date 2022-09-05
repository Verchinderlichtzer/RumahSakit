namespace RumahSakit
{
    partial class FDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDashboard));
            this.palet = new Krypton.Toolkit.KryptonPalette(this.components);
            this.panelProfil = new System.Windows.Forms.Panel();
            this.lblJabatan = new Krypton.Toolkit.KryptonLabel();
            this.tJabatan = new Krypton.Toolkit.KryptonTextBox();
            this.tFax = new Krypton.Toolkit.KryptonTextBox();
            this.lblPengurus = new Krypton.Toolkit.KryptonLabel();
            this.lblTelepon = new Krypton.Toolkit.KryptonLabel();
            this.tPengurus = new Krypton.Toolkit.KryptonTextBox();
            this.tTelepon = new Krypton.Toolkit.KryptonTextBox();
            this.lblAlamat = new Krypton.Toolkit.KryptonLabel();
            this.tWebsite = new Krypton.Toolkit.KryptonTextBox();
            this.tAlamat = new Krypton.Toolkit.KryptonTextBox();
            this.lblProfil = new Krypton.Toolkit.KryptonLabel();
            this.lblEmail = new Krypton.Toolkit.KryptonLabel();
            this.lblNama = new Krypton.Toolkit.KryptonLabel();
            this.tEmail = new Krypton.Toolkit.KryptonTextBox();
            this.tNama = new Krypton.Toolkit.KryptonTextBox();
            this.panelLogUser = new System.Windows.Forms.Panel();
            this.panelDGVLogPagination = new System.Windows.Forms.Panel();
            this.dgvLogPageCounter = new Krypton.Toolkit.KryptonLabel();
            this.dgvLogPrev = new Krypton.Toolkit.KryptonButton();
            this.dgvLogFirst = new Krypton.Toolkit.KryptonButton();
            this.dgvLogNext = new Krypton.Toolkit.KryptonButton();
            this.dgvLogLast = new Krypton.Toolkit.KryptonButton();
            this.dgvLog = new Krypton.Toolkit.KryptonDataGridView();
            this.cUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKeterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLogUser = new Krypton.Toolkit.KryptonLabel();
            this.panelFootbar = new System.Windows.Forms.Panel();
            this.lblUserAktif = new Krypton.Toolkit.KryptonLabel();
            this.lblAuthor = new Krypton.Toolkit.KryptonLabel();
            this.panelGrafik = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.baganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRumahSakit = new RumahSakit.DSRumahSakit();
            this.lblGrafik = new Krypton.Toolkit.KryptonLabel();
            this.panelRiwayat = new System.Windows.Forms.Panel();
            this.lblTotalBiaya = new Krypton.Toolkit.KryptonLabel();
            this.tTotalBiaya = new Krypton.Toolkit.KryptonTextBox();
            this.lblDiagnosis = new Krypton.Toolkit.KryptonLabel();
            this.tDiagnosis = new Krypton.Toolkit.KryptonTextBox();
            this.lblTanggal = new Krypton.Toolkit.KryptonLabel();
            this.tTanggal = new Krypton.Toolkit.KryptonTextBox();
            this.lblNamaKamar = new Krypton.Toolkit.KryptonLabel();
            this.tNamaKamar = new Krypton.Toolkit.KryptonTextBox();
            this.lblIdPerawatan = new Krypton.Toolkit.KryptonLabel();
            this.tIdPerawatan = new Krypton.Toolkit.KryptonComboBox();
            this.lblRiwayat = new Krypton.Toolkit.KryptonLabel();
            this.lblNamaPasien = new Krypton.Toolkit.KryptonLabel();
            this.tNamaPasien = new Krypton.Toolkit.KryptonTextBox();
            this.panelPengaturan = new System.Windows.Forms.Panel();
            this.btnHapusPerawatan = new Krypton.Toolkit.KryptonButton();
            this.btnBackupDatabase = new Krypton.Toolkit.KryptonButton();
            this.btnGantiPassword = new Krypton.Toolkit.KryptonButton();
            this.cbSimpanResolusi = new Krypton.Toolkit.KryptonCheckBox();
            this.cbTampilId = new Krypton.Toolkit.KryptonCheckBox();
            this.lblPengaturan = new Krypton.Toolkit.KryptonLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.baganTableAdapter = new RumahSakit.DSRumahSakitTableAdapters.BaganTableAdapter();
            this.panelProfil.SuspendLayout();
            this.panelLogUser.SuspendLayout();
            this.panelDGVLogPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.panelFootbar.SuspendLayout();
            this.panelGrafik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRumahSakit)).BeginInit();
            this.panelRiwayat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIdPerawatan)).BeginInit();
            this.panelPengaturan.SuspendLayout();
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
            // panelProfil
            // 
            this.panelProfil.BackColor = System.Drawing.Color.White;
            this.panelProfil.Controls.Add(this.lblJabatan);
            this.panelProfil.Controls.Add(this.tJabatan);
            this.panelProfil.Controls.Add(this.tFax);
            this.panelProfil.Controls.Add(this.lblPengurus);
            this.panelProfil.Controls.Add(this.lblTelepon);
            this.panelProfil.Controls.Add(this.tPengurus);
            this.panelProfil.Controls.Add(this.tTelepon);
            this.panelProfil.Controls.Add(this.lblAlamat);
            this.panelProfil.Controls.Add(this.tWebsite);
            this.panelProfil.Controls.Add(this.tAlamat);
            this.panelProfil.Controls.Add(this.lblProfil);
            this.panelProfil.Controls.Add(this.lblEmail);
            this.panelProfil.Controls.Add(this.lblNama);
            this.panelProfil.Controls.Add(this.tEmail);
            this.panelProfil.Controls.Add(this.tNama);
            this.panelProfil.Location = new System.Drawing.Point(8, 8);
            this.panelProfil.Name = "panelProfil";
            this.panelProfil.Size = new System.Drawing.Size(536, 221);
            this.panelProfil.TabIndex = 0;
            // 
            // lblJabatan
            // 
            this.lblJabatan.AutoSize = false;
            this.lblJabatan.Location = new System.Drawing.Point(3, 192);
            this.lblJabatan.Name = "lblJabatan";
            this.lblJabatan.Size = new System.Drawing.Size(132, 26);
            this.lblJabatan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblJabatan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblJabatan.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblJabatan.TabIndex = 945;
            this.lblJabatan.Values.Text = "Jabatan";
            // 
            // tJabatan
            // 
            this.tJabatan.AlwaysActive = false;
            this.tJabatan.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tJabatan.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tJabatan.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tJabatan.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tJabatan.Location = new System.Drawing.Point(141, 192);
            this.tJabatan.MaxLength = 100;
            this.tJabatan.Name = "tJabatan";
            this.tJabatan.Size = new System.Drawing.Size(392, 29);
            this.tJabatan.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tJabatan.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tJabatan.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tJabatan.StateActive.Border.Rounding = 0F;
            this.tJabatan.StateActive.Border.Width = 1;
            this.tJabatan.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tJabatan.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tJabatan.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tJabatan.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tJabatan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tJabatan.StateCommon.Border.Rounding = 0F;
            this.tJabatan.StateCommon.Border.Width = 1;
            this.tJabatan.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tJabatan.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tJabatan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tJabatan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tJabatan.StateDisabled.Border.Rounding = 0F;
            this.tJabatan.StateDisabled.Border.Width = 0;
            this.tJabatan.TabIndex = 7;
            this.tJabatan.TextChanged += new System.EventHandler(this.SimpanInfo);
            // 
            // tFax
            // 
            this.tFax.AlwaysActive = false;
            this.tFax.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tFax.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tFax.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tFax.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tFax.Location = new System.Drawing.Point(340, 96);
            this.tFax.MaxLength = 100;
            this.tFax.Name = "tFax";
            this.tFax.Palette = this.palet;
            this.tFax.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tFax.Size = new System.Drawing.Size(193, 29);
            this.tFax.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tFax.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tFax.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tFax.StateActive.Border.Rounding = 0F;
            this.tFax.StateActive.Border.Width = 1;
            this.tFax.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tFax.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tFax.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tFax.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tFax.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tFax.StateCommon.Border.Rounding = 0F;
            this.tFax.StateCommon.Border.Width = 1;
            this.tFax.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tFax.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tFax.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tFax.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tFax.StateDisabled.Border.Rounding = 0F;
            this.tFax.StateDisabled.Border.Width = 0;
            this.tFax.TabIndex = 3;
            this.tFax.TextChanged += new System.EventHandler(this.SimpanInfo);
            // 
            // lblPengurus
            // 
            this.lblPengurus.AutoSize = false;
            this.lblPengurus.Location = new System.Drawing.Point(3, 160);
            this.lblPengurus.Name = "lblPengurus";
            this.lblPengurus.Size = new System.Drawing.Size(132, 26);
            this.lblPengurus.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPengurus.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblPengurus.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblPengurus.TabIndex = 943;
            this.lblPengurus.Values.Text = "Pengurus";
            // 
            // lblTelepon
            // 
            this.lblTelepon.AutoSize = false;
            this.lblTelepon.Location = new System.Drawing.Point(3, 96);
            this.lblTelepon.Name = "lblTelepon";
            this.lblTelepon.Palette = this.palet;
            this.lblTelepon.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTelepon.Size = new System.Drawing.Size(132, 26);
            this.lblTelepon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelepon.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTelepon.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblTelepon.TabIndex = 943;
            this.lblTelepon.Values.Text = "Telepon / Fax";
            // 
            // tPengurus
            // 
            this.tPengurus.AlwaysActive = false;
            this.tPengurus.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tPengurus.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tPengurus.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tPengurus.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tPengurus.Location = new System.Drawing.Point(141, 160);
            this.tPengurus.MaxLength = 100;
            this.tPengurus.Name = "tPengurus";
            this.tPengurus.Size = new System.Drawing.Size(392, 29);
            this.tPengurus.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tPengurus.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tPengurus.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tPengurus.StateActive.Border.Rounding = 0F;
            this.tPengurus.StateActive.Border.Width = 1;
            this.tPengurus.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tPengurus.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tPengurus.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tPengurus.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tPengurus.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tPengurus.StateCommon.Border.Rounding = 0F;
            this.tPengurus.StateCommon.Border.Width = 1;
            this.tPengurus.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tPengurus.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tPengurus.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tPengurus.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tPengurus.StateDisabled.Border.Rounding = 0F;
            this.tPengurus.StateDisabled.Border.Width = 0;
            this.tPengurus.TabIndex = 6;
            this.tPengurus.TextChanged += new System.EventHandler(this.SimpanInfo);
            // 
            // tTelepon
            // 
            this.tTelepon.AlwaysActive = false;
            this.tTelepon.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tTelepon.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tTelepon.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tTelepon.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tTelepon.Location = new System.Drawing.Point(141, 96);
            this.tTelepon.MaxLength = 100;
            this.tTelepon.Name = "tTelepon";
            this.tTelepon.Palette = this.palet;
            this.tTelepon.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tTelepon.Size = new System.Drawing.Size(193, 29);
            this.tTelepon.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tTelepon.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTelepon.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTelepon.StateActive.Border.Rounding = 0F;
            this.tTelepon.StateActive.Border.Width = 1;
            this.tTelepon.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tTelepon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tTelepon.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tTelepon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTelepon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTelepon.StateCommon.Border.Rounding = 0F;
            this.tTelepon.StateCommon.Border.Width = 1;
            this.tTelepon.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tTelepon.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tTelepon.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tTelepon.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTelepon.StateDisabled.Border.Rounding = 0F;
            this.tTelepon.StateDisabled.Border.Width = 0;
            this.tTelepon.TabIndex = 2;
            this.tTelepon.TextChanged += new System.EventHandler(this.SimpanInfo);
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = false;
            this.lblAlamat.Location = new System.Drawing.Point(3, 64);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Palette = this.palet;
            this.lblAlamat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblAlamat.Size = new System.Drawing.Size(132, 26);
            this.lblAlamat.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAlamat.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblAlamat.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblAlamat.TabIndex = 941;
            this.lblAlamat.Values.Text = "Alamat";
            // 
            // tWebsite
            // 
            this.tWebsite.AlwaysActive = false;
            this.tWebsite.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tWebsite.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tWebsite.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tWebsite.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tWebsite.Location = new System.Drawing.Point(340, 128);
            this.tWebsite.MaxLength = 100;
            this.tWebsite.Name = "tWebsite";
            this.tWebsite.Size = new System.Drawing.Size(193, 29);
            this.tWebsite.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tWebsite.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tWebsite.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tWebsite.StateActive.Border.Rounding = 0F;
            this.tWebsite.StateActive.Border.Width = 1;
            this.tWebsite.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tWebsite.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tWebsite.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tWebsite.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tWebsite.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tWebsite.StateCommon.Border.Rounding = 0F;
            this.tWebsite.StateCommon.Border.Width = 1;
            this.tWebsite.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tWebsite.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tWebsite.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tWebsite.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tWebsite.StateDisabled.Border.Rounding = 0F;
            this.tWebsite.StateDisabled.Border.Width = 0;
            this.tWebsite.TabIndex = 5;
            this.tWebsite.TextChanged += new System.EventHandler(this.SimpanInfo);
            // 
            // tAlamat
            // 
            this.tAlamat.AlwaysActive = false;
            this.tAlamat.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tAlamat.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tAlamat.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tAlamat.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tAlamat.Location = new System.Drawing.Point(141, 64);
            this.tAlamat.MaxLength = 100;
            this.tAlamat.Name = "tAlamat";
            this.tAlamat.Palette = this.palet;
            this.tAlamat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tAlamat.Size = new System.Drawing.Size(392, 29);
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
            this.tAlamat.TabIndex = 1;
            this.tAlamat.TextChanged += new System.EventHandler(this.SimpanInfo);
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = false;
            this.lblProfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProfil.Location = new System.Drawing.Point(0, 0);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Palette = this.palet;
            this.lblProfil.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblProfil.Size = new System.Drawing.Size(536, 26);
            this.lblProfil.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProfil.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblProfil.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfil.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblProfil.TabIndex = 939;
            this.lblProfil.Values.Text = "Profil";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = false;
            this.lblEmail.Location = new System.Drawing.Point(3, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(132, 26);
            this.lblEmail.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmail.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblEmail.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblEmail.TabIndex = 923;
            this.lblEmail.Values.Text = "Email / Website";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = false;
            this.lblNama.Location = new System.Drawing.Point(3, 32);
            this.lblNama.Name = "lblNama";
            this.lblNama.Palette = this.palet;
            this.lblNama.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblNama.Size = new System.Drawing.Size(132, 26);
            this.lblNama.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNama.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblNama.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblNama.TabIndex = 923;
            this.lblNama.Values.Text = "Nama";
            // 
            // tEmail
            // 
            this.tEmail.AlwaysActive = false;
            this.tEmail.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tEmail.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tEmail.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tEmail.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tEmail.Location = new System.Drawing.Point(141, 128);
            this.tEmail.MaxLength = 100;
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(193, 29);
            this.tEmail.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tEmail.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tEmail.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tEmail.StateActive.Border.Rounding = 0F;
            this.tEmail.StateActive.Border.Width = 1;
            this.tEmail.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tEmail.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tEmail.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tEmail.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tEmail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tEmail.StateCommon.Border.Rounding = 0F;
            this.tEmail.StateCommon.Border.Width = 1;
            this.tEmail.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tEmail.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tEmail.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tEmail.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tEmail.StateDisabled.Border.Rounding = 0F;
            this.tEmail.StateDisabled.Border.Width = 0;
            this.tEmail.TabIndex = 4;
            this.tEmail.TextChanged += new System.EventHandler(this.SimpanInfo);
            // 
            // tNama
            // 
            this.tNama.AlwaysActive = false;
            this.tNama.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tNama.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tNama.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tNama.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tNama.Location = new System.Drawing.Point(141, 32);
            this.tNama.MaxLength = 100;
            this.tNama.Name = "tNama";
            this.tNama.Palette = this.palet;
            this.tNama.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tNama.Size = new System.Drawing.Size(392, 29);
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
            this.tNama.TextChanged += new System.EventHandler(this.SimpanInfo);
            // 
            // panelLogUser
            // 
            this.panelLogUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogUser.BackColor = System.Drawing.Color.White;
            this.panelLogUser.Controls.Add(this.panelDGVLogPagination);
            this.panelLogUser.Controls.Add(this.dgvLog);
            this.panelLogUser.Controls.Add(this.lblLogUser);
            this.panelLogUser.Location = new System.Drawing.Point(550, 8);
            this.panelLogUser.Name = "panelLogUser";
            this.panelLogUser.Size = new System.Drawing.Size(536, 251);
            this.panelLogUser.TabIndex = 4;
            // 
            // panelDGVLogPagination
            // 
            this.panelDGVLogPagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDGVLogPagination.Controls.Add(this.dgvLogPageCounter);
            this.panelDGVLogPagination.Controls.Add(this.dgvLogPrev);
            this.panelDGVLogPagination.Controls.Add(this.dgvLogFirst);
            this.panelDGVLogPagination.Controls.Add(this.dgvLogNext);
            this.panelDGVLogPagination.Controls.Add(this.dgvLogLast);
            this.panelDGVLogPagination.Location = new System.Drawing.Point(168, 224);
            this.panelDGVLogPagination.Name = "panelDGVLogPagination";
            this.panelDGVLogPagination.Size = new System.Drawing.Size(200, 24);
            this.panelDGVLogPagination.TabIndex = 941;
            // 
            // dgvLogPageCounter
            // 
            this.dgvLogPageCounter.AutoSize = false;
            this.dgvLogPageCounter.Cursor = System.Windows.Forms.Cursors.Help;
            this.dgvLogPageCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogPageCounter.Location = new System.Drawing.Point(48, 0);
            this.dgvLogPageCounter.Name = "dgvLogPageCounter";
            this.dgvLogPageCounter.Palette = this.palet;
            this.dgvLogPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvLogPageCounter.Size = new System.Drawing.Size(104, 24);
            this.dgvLogPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvLogPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvLogPageCounter.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F);
            this.dgvLogPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvLogPageCounter.TabIndex = 2;
            this.dgvLogPageCounter.Values.Text = "1 / 1";
            this.dgvLogPageCounter.Click += new System.EventHandler(this.DGVLogPageCounter_Click);
            // 
            // dgvLogPrev
            // 
            this.dgvLogPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLogPrev.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvLogPrev.Enabled = false;
            this.dgvLogPrev.Location = new System.Drawing.Point(24, 0);
            this.dgvLogPrev.Name = "dgvLogPrev";
            this.dgvLogPrev.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvLogPrev.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvLogPrev.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvLogPrev.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvLogPrev.Palette = this.palet;
            this.dgvLogPrev.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvLogPrev.Size = new System.Drawing.Size(24, 24);
            this.dgvLogPrev.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvLogPrev.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvLogPrev.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvLogPrev.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvLogPrev.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvLogPrev.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.dgvLogPrev.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLogPrev.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvLogPrev.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.dgvLogPrev.TabIndex = 1;
            this.dgvLogPrev.Values.Text = "‹";
            this.dgvLogPrev.Click += new System.EventHandler(this.DGVLogPrev_Click);
            // 
            // dgvLogFirst
            // 
            this.dgvLogFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLogFirst.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvLogFirst.Enabled = false;
            this.dgvLogFirst.Location = new System.Drawing.Point(0, 0);
            this.dgvLogFirst.Name = "dgvLogFirst";
            this.dgvLogFirst.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvLogFirst.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvLogFirst.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvLogFirst.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvLogFirst.Palette = this.palet;
            this.dgvLogFirst.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvLogFirst.Size = new System.Drawing.Size(24, 24);
            this.dgvLogFirst.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvLogFirst.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvLogFirst.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvLogFirst.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvLogFirst.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvLogFirst.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.dgvLogFirst.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLogFirst.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvLogFirst.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.dgvLogFirst.TabIndex = 0;
            this.dgvLogFirst.Values.Text = "«";
            this.dgvLogFirst.Click += new System.EventHandler(this.DGVLogFirst_Click);
            // 
            // dgvLogNext
            // 
            this.dgvLogNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLogNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvLogNext.Enabled = false;
            this.dgvLogNext.Location = new System.Drawing.Point(152, 0);
            this.dgvLogNext.Name = "dgvLogNext";
            this.dgvLogNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvLogNext.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvLogNext.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvLogNext.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvLogNext.Palette = this.palet;
            this.dgvLogNext.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvLogNext.Size = new System.Drawing.Size(24, 24);
            this.dgvLogNext.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvLogNext.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvLogNext.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvLogNext.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvLogNext.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvLogNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.dgvLogNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLogNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvLogNext.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.dgvLogNext.TabIndex = 3;
            this.dgvLogNext.Values.Text = "›";
            this.dgvLogNext.Click += new System.EventHandler(this.DGVLogNext_Click);
            // 
            // dgvLogLast
            // 
            this.dgvLogLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLogLast.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvLogLast.Enabled = false;
            this.dgvLogLast.Location = new System.Drawing.Point(176, 0);
            this.dgvLogLast.Name = "dgvLogLast";
            this.dgvLogLast.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvLogLast.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvLogLast.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvLogLast.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvLogLast.Palette = this.palet;
            this.dgvLogLast.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvLogLast.Size = new System.Drawing.Size(24, 24);
            this.dgvLogLast.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvLogLast.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvLogLast.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvLogLast.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvLogLast.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvLogLast.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.dgvLogLast.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLogLast.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvLogLast.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.dgvLogLast.TabIndex = 4;
            this.dgvLogLast.Values.Text = "»";
            this.dgvLogLast.Click += new System.EventHandler(this.DGVLogLast_Click);
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AllowUserToResizeColumns = false;
            this.dgvLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLog.ColumnHeadersHeight = 27;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUsername,
            this.cTanggal,
            this.cKeterangan});
            this.dgvLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvLog.HideOuterBorders = true;
            this.dgvLog.Location = new System.Drawing.Point(3, 32);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.Palette = this.palet;
            this.dgvLog.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.RowTemplate.Height = 27;
            this.dgvLog.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvLog.Size = new System.Drawing.Size(530, 189);
            this.dgvLog.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvLog.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvLog.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvLog.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvLog.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvLog.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvLog.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLog.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvLog.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvLog.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgvLog.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLog.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvLog.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvLog.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvLog.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvLog.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvLog.TabIndex = 0;
            // 
            // cUsername
            // 
            this.cUsername.HeaderText = "Username";
            this.cUsername.Name = "cUsername";
            this.cUsername.ReadOnly = true;
            this.cUsername.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cUsername.Width = 94;
            // 
            // cTanggal
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.cTanggal.DefaultCellStyle = dataGridViewCellStyle2;
            this.cTanggal.HeaderText = "Tanggal";
            this.cTanggal.Name = "cTanggal";
            this.cTanggal.ReadOnly = true;
            this.cTanggal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cTanggal.Width = 107;
            // 
            // cKeterangan
            // 
            this.cKeterangan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cKeterangan.HeaderText = "Keterangan";
            this.cKeterangan.Name = "cKeterangan";
            this.cKeterangan.ReadOnly = true;
            this.cKeterangan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblLogUser
            // 
            this.lblLogUser.AutoSize = false;
            this.lblLogUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogUser.Location = new System.Drawing.Point(0, 0);
            this.lblLogUser.Name = "lblLogUser";
            this.lblLogUser.Palette = this.palet;
            this.lblLogUser.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblLogUser.Size = new System.Drawing.Size(536, 26);
            this.lblLogUser.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLogUser.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblLogUser.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogUser.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblLogUser.TabIndex = 939;
            this.lblLogUser.Values.Text = "Log User";
            // 
            // panelFootbar
            // 
            this.panelFootbar.BackColor = System.Drawing.Color.White;
            this.panelFootbar.Controls.Add(this.lblUserAktif);
            this.panelFootbar.Controls.Add(this.lblAuthor);
            this.panelFootbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFootbar.Location = new System.Drawing.Point(0, 614);
            this.panelFootbar.Name = "panelFootbar";
            this.panelFootbar.Size = new System.Drawing.Size(1094, 26);
            this.panelFootbar.TabIndex = 5;
            // 
            // lblUserAktif
            // 
            this.lblUserAktif.AutoSize = false;
            this.lblUserAktif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserAktif.Location = new System.Drawing.Point(373, 0);
            this.lblUserAktif.Name = "lblUserAktif";
            this.lblUserAktif.Palette = this.palet;
            this.lblUserAktif.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblUserAktif.Size = new System.Drawing.Size(721, 26);
            this.lblUserAktif.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserAktif.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblUserAktif.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblUserAktif.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblUserAktif.TabIndex = 925;
            this.lblUserAktif.Values.Text = "Nama";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = false;
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAuthor.Location = new System.Drawing.Point(0, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Palette = this.palet;
            this.lblAuthor.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblAuthor.Size = new System.Drawing.Size(373, 26);
            this.lblAuthor.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAuthor.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblAuthor.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblAuthor.TabIndex = 924;
            this.lblAuthor.Values.Text = "Aplikasi Rumah Sakit Rawat Inap (Sujudi Hanif)";
            this.lblAuthor.Click += new System.EventHandler(this.LBLAuthor_Click);
            // 
            // panelGrafik
            // 
            this.panelGrafik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrafik.BackColor = System.Drawing.Color.White;
            this.panelGrafik.Controls.Add(this.chart1);
            this.panelGrafik.Controls.Add(this.lblGrafik);
            this.panelGrafik.Location = new System.Drawing.Point(550, 265);
            this.panelGrafik.Name = "panelGrafik";
            this.panelGrafik.Size = new System.Drawing.Size(536, 343);
            this.panelGrafik.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.LabelStyle.Format = "n0";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.baganBindingSource;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 26);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            series1.Name = "Series1";
            series1.XValueMember = "TanggalMasuk";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueMembers = "Hitung";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(536, 317);
            this.chart1.TabIndex = 940;
            this.chart1.Text = "chart1";
            // 
            // baganBindingSource
            // 
            this.baganBindingSource.DataMember = "Bagan";
            this.baganBindingSource.DataSource = this.dSRumahSakit;
            // 
            // dSRumahSakit
            // 
            this.dSRumahSakit.DataSetName = "DSRumahSakit";
            this.dSRumahSakit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblGrafik
            // 
            this.lblGrafik.AutoSize = false;
            this.lblGrafik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGrafik.Location = new System.Drawing.Point(0, 0);
            this.lblGrafik.Name = "lblGrafik";
            this.lblGrafik.Palette = this.palet;
            this.lblGrafik.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblGrafik.Size = new System.Drawing.Size(536, 26);
            this.lblGrafik.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGrafik.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblGrafik.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafik.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblGrafik.TabIndex = 939;
            this.lblGrafik.Values.Text = "Jumlah Pasien Masuk";
            // 
            // panelRiwayat
            // 
            this.panelRiwayat.BackColor = System.Drawing.Color.White;
            this.panelRiwayat.Controls.Add(this.lblTotalBiaya);
            this.panelRiwayat.Controls.Add(this.tTotalBiaya);
            this.panelRiwayat.Controls.Add(this.lblDiagnosis);
            this.panelRiwayat.Controls.Add(this.tDiagnosis);
            this.panelRiwayat.Controls.Add(this.lblTanggal);
            this.panelRiwayat.Controls.Add(this.tTanggal);
            this.panelRiwayat.Controls.Add(this.lblNamaKamar);
            this.panelRiwayat.Controls.Add(this.tNamaKamar);
            this.panelRiwayat.Controls.Add(this.lblIdPerawatan);
            this.panelRiwayat.Controls.Add(this.tIdPerawatan);
            this.panelRiwayat.Controls.Add(this.lblRiwayat);
            this.panelRiwayat.Controls.Add(this.lblNamaPasien);
            this.panelRiwayat.Controls.Add(this.tNamaPasien);
            this.panelRiwayat.Location = new System.Drawing.Point(8, 235);
            this.panelRiwayat.Name = "panelRiwayat";
            this.panelRiwayat.Size = new System.Drawing.Size(536, 221);
            this.panelRiwayat.TabIndex = 1;
            // 
            // lblTotalBiaya
            // 
            this.lblTotalBiaya.AutoSize = false;
            this.lblTotalBiaya.Location = new System.Drawing.Point(3, 192);
            this.lblTotalBiaya.Name = "lblTotalBiaya";
            this.lblTotalBiaya.Palette = this.palet;
            this.lblTotalBiaya.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTotalBiaya.Size = new System.Drawing.Size(112, 26);
            this.lblTotalBiaya.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalBiaya.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTotalBiaya.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblTotalBiaya.TabIndex = 949;
            this.lblTotalBiaya.Values.Text = "Total Biaya";
            // 
            // tTotalBiaya
            // 
            this.tTotalBiaya.AlwaysActive = false;
            this.tTotalBiaya.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tTotalBiaya.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tTotalBiaya.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tTotalBiaya.Enabled = false;
            this.tTotalBiaya.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tTotalBiaya.Location = new System.Drawing.Point(121, 192);
            this.tTotalBiaya.MaxLength = 100;
            this.tTotalBiaya.Name = "tTotalBiaya";
            this.tTotalBiaya.Palette = this.palet;
            this.tTotalBiaya.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tTotalBiaya.Size = new System.Drawing.Size(412, 29);
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
            this.tTotalBiaya.TabIndex = 5;
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = false;
            this.lblDiagnosis.Location = new System.Drawing.Point(3, 160);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Palette = this.palet;
            this.lblDiagnosis.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblDiagnosis.Size = new System.Drawing.Size(112, 26);
            this.lblDiagnosis.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiagnosis.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblDiagnosis.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblDiagnosis.TabIndex = 947;
            this.lblDiagnosis.Values.Text = "Diagnosis";
            // 
            // tDiagnosis
            // 
            this.tDiagnosis.AlwaysActive = false;
            this.tDiagnosis.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tDiagnosis.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tDiagnosis.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tDiagnosis.Enabled = false;
            this.tDiagnosis.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tDiagnosis.Location = new System.Drawing.Point(121, 160);
            this.tDiagnosis.MaxLength = 100;
            this.tDiagnosis.Name = "tDiagnosis";
            this.tDiagnosis.Palette = this.palet;
            this.tDiagnosis.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tDiagnosis.Size = new System.Drawing.Size(412, 29);
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
            this.tDiagnosis.TabIndex = 4;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = false;
            this.lblTanggal.Location = new System.Drawing.Point(3, 128);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Palette = this.palet;
            this.lblTanggal.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTanggal.Size = new System.Drawing.Size(112, 26);
            this.lblTanggal.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTanggal.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTanggal.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblTanggal.TabIndex = 945;
            this.lblTanggal.Values.Text = "Tanggal";
            // 
            // tTanggal
            // 
            this.tTanggal.AlwaysActive = false;
            this.tTanggal.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tTanggal.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tTanggal.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tTanggal.Enabled = false;
            this.tTanggal.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tTanggal.Location = new System.Drawing.Point(121, 128);
            this.tTanggal.MaxLength = 100;
            this.tTanggal.Name = "tTanggal";
            this.tTanggal.Palette = this.palet;
            this.tTanggal.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tTanggal.Size = new System.Drawing.Size(412, 29);
            this.tTanggal.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tTanggal.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTanggal.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTanggal.StateActive.Border.Rounding = 0F;
            this.tTanggal.StateActive.Border.Width = 1;
            this.tTanggal.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tTanggal.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tTanggal.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tTanggal.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTanggal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTanggal.StateCommon.Border.Rounding = 0F;
            this.tTanggal.StateCommon.Border.Width = 1;
            this.tTanggal.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tTanggal.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tTanggal.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tTanggal.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTanggal.StateDisabled.Border.Rounding = 0F;
            this.tTanggal.StateDisabled.Border.Width = 0;
            this.tTanggal.TabIndex = 3;
            // 
            // lblNamaKamar
            // 
            this.lblNamaKamar.AutoSize = false;
            this.lblNamaKamar.Location = new System.Drawing.Point(3, 96);
            this.lblNamaKamar.Name = "lblNamaKamar";
            this.lblNamaKamar.Palette = this.palet;
            this.lblNamaKamar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblNamaKamar.Size = new System.Drawing.Size(112, 26);
            this.lblNamaKamar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNamaKamar.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblNamaKamar.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblNamaKamar.TabIndex = 943;
            this.lblNamaKamar.Values.Text = "Nama Kamar";
            // 
            // tNamaKamar
            // 
            this.tNamaKamar.AlwaysActive = false;
            this.tNamaKamar.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tNamaKamar.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tNamaKamar.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tNamaKamar.Enabled = false;
            this.tNamaKamar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tNamaKamar.Location = new System.Drawing.Point(121, 96);
            this.tNamaKamar.MaxLength = 100;
            this.tNamaKamar.Name = "tNamaKamar";
            this.tNamaKamar.Palette = this.palet;
            this.tNamaKamar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tNamaKamar.Size = new System.Drawing.Size(412, 29);
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
            // lblIdPerawatan
            // 
            this.lblIdPerawatan.AutoSize = false;
            this.lblIdPerawatan.Location = new System.Drawing.Point(3, 32);
            this.lblIdPerawatan.Name = "lblIdPerawatan";
            this.lblIdPerawatan.Palette = this.palet;
            this.lblIdPerawatan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblIdPerawatan.Size = new System.Drawing.Size(112, 26);
            this.lblIdPerawatan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdPerawatan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblIdPerawatan.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblIdPerawatan.TabIndex = 941;
            this.lblIdPerawatan.Values.Text = "Id Perawatan";
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
            this.tIdPerawatan.Location = new System.Drawing.Point(134, 32);
            this.tIdPerawatan.MaxDropDownItems = 13;
            this.tIdPerawatan.Name = "tIdPerawatan";
            this.tIdPerawatan.Palette = this.palet;
            this.tIdPerawatan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tIdPerawatan.Size = new System.Drawing.Size(119, 26);
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
            this.tIdPerawatan.SelectedIndexChanged += new System.EventHandler(this.TampilRiwayat);
            // 
            // lblRiwayat
            // 
            this.lblRiwayat.AutoSize = false;
            this.lblRiwayat.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRiwayat.Location = new System.Drawing.Point(0, 0);
            this.lblRiwayat.Name = "lblRiwayat";
            this.lblRiwayat.Palette = this.palet;
            this.lblRiwayat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblRiwayat.Size = new System.Drawing.Size(536, 26);
            this.lblRiwayat.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRiwayat.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblRiwayat.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiwayat.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRiwayat.TabIndex = 939;
            this.lblRiwayat.Values.Text = "Riwayat";
            // 
            // lblNamaPasien
            // 
            this.lblNamaPasien.AutoSize = false;
            this.lblNamaPasien.Location = new System.Drawing.Point(3, 64);
            this.lblNamaPasien.Name = "lblNamaPasien";
            this.lblNamaPasien.Palette = this.palet;
            this.lblNamaPasien.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblNamaPasien.Size = new System.Drawing.Size(112, 26);
            this.lblNamaPasien.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNamaPasien.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblNamaPasien.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblNamaPasien.TabIndex = 923;
            this.lblNamaPasien.Values.Text = "Nama Pasien";
            // 
            // tNamaPasien
            // 
            this.tNamaPasien.AlwaysActive = false;
            this.tNamaPasien.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tNamaPasien.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tNamaPasien.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tNamaPasien.Enabled = false;
            this.tNamaPasien.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tNamaPasien.Location = new System.Drawing.Point(121, 64);
            this.tNamaPasien.MaxLength = 100;
            this.tNamaPasien.Name = "tNamaPasien";
            this.tNamaPasien.Palette = this.palet;
            this.tNamaPasien.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tNamaPasien.Size = new System.Drawing.Size(412, 29);
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
            // panelPengaturan
            // 
            this.panelPengaturan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelPengaturan.BackColor = System.Drawing.Color.White;
            this.panelPengaturan.Controls.Add(this.btnHapusPerawatan);
            this.panelPengaturan.Controls.Add(this.btnBackupDatabase);
            this.panelPengaturan.Controls.Add(this.btnGantiPassword);
            this.panelPengaturan.Controls.Add(this.cbSimpanResolusi);
            this.panelPengaturan.Controls.Add(this.cbTampilId);
            this.panelPengaturan.Controls.Add(this.lblPengaturan);
            this.panelPengaturan.Location = new System.Drawing.Point(8, 462);
            this.panelPengaturan.Name = "panelPengaturan";
            this.panelPengaturan.Size = new System.Drawing.Size(536, 146);
            this.panelPengaturan.TabIndex = 2;
            // 
            // btnHapusPerawatan
            // 
            this.btnHapusPerawatan.Location = new System.Drawing.Point(14, 104);
            this.btnHapusPerawatan.Name = "btnHapusPerawatan";
            this.btnHapusPerawatan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnHapusPerawatan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnHapusPerawatan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnHapusPerawatan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnHapusPerawatan.Palette = this.palet;
            this.btnHapusPerawatan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnHapusPerawatan.Size = new System.Drawing.Size(148, 30);
            this.btnHapusPerawatan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnHapusPerawatan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnHapusPerawatan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnHapusPerawatan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnHapusPerawatan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnHapusPerawatan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusPerawatan.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnHapusPerawatan.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnHapusPerawatan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHapusPerawatan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnHapusPerawatan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnHapusPerawatan.TabIndex = 2;
            this.btnHapusPerawatan.Values.Text = "Hapus Perawatan";
            this.btnHapusPerawatan.Click += new System.EventHandler(this.BTNHapusPerawatan_Click);
            // 
            // btnBackupDatabase
            // 
            this.btnBackupDatabase.Location = new System.Drawing.Point(14, 68);
            this.btnBackupDatabase.Name = "btnBackupDatabase";
            this.btnBackupDatabase.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnBackupDatabase.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnBackupDatabase.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnBackupDatabase.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnBackupDatabase.Palette = this.palet;
            this.btnBackupDatabase.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnBackupDatabase.Size = new System.Drawing.Size(148, 30);
            this.btnBackupDatabase.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnBackupDatabase.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnBackupDatabase.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnBackupDatabase.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnBackupDatabase.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnBackupDatabase.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupDatabase.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnBackupDatabase.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnBackupDatabase.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBackupDatabase.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnBackupDatabase.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnBackupDatabase.TabIndex = 1;
            this.btnBackupDatabase.Values.Text = "Backup Database";
            this.btnBackupDatabase.Click += new System.EventHandler(this.BTNBackupDatabase_Click);
            // 
            // btnGantiPassword
            // 
            this.btnGantiPassword.Location = new System.Drawing.Point(14, 32);
            this.btnGantiPassword.Name = "btnGantiPassword";
            this.btnGantiPassword.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnGantiPassword.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnGantiPassword.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnGantiPassword.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnGantiPassword.Palette = this.palet;
            this.btnGantiPassword.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnGantiPassword.Size = new System.Drawing.Size(148, 30);
            this.btnGantiPassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnGantiPassword.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnGantiPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnGantiPassword.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnGantiPassword.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnGantiPassword.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGantiPassword.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnGantiPassword.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnGantiPassword.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGantiPassword.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnGantiPassword.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnGantiPassword.TabIndex = 0;
            this.btnGantiPassword.Values.Text = "Ganti Password";
            this.btnGantiPassword.Click += new System.EventHandler(this.BTNGantiPassword_Click);
            // 
            // cbSimpanResolusi
            // 
            this.cbSimpanResolusi.Location = new System.Drawing.Point(313, 66);
            this.cbSimpanResolusi.Name = "cbSimpanResolusi";
            this.cbSimpanResolusi.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbSimpanResolusi.Palette = this.palet;
            this.cbSimpanResolusi.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.cbSimpanResolusi.Size = new System.Drawing.Size(200, 28);
            this.cbSimpanResolusi.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbSimpanResolusi.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSimpanResolusi.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.cbSimpanResolusi.TabIndex = 4;
            this.cbSimpanResolusi.Values.Text = "Simpan resolusi aplikasi";
            this.cbSimpanResolusi.CheckedChanged += new System.EventHandler(this.CBSimpanResolusi_CheckedChanged);
            // 
            // cbTampilId
            // 
            this.cbTampilId.Location = new System.Drawing.Point(313, 32);
            this.cbTampilId.Name = "cbTampilId";
            this.cbTampilId.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbTampilId.Palette = this.palet;
            this.cbTampilId.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.cbTampilId.Size = new System.Drawing.Size(220, 28);
            this.cbTampilId.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbTampilId.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTampilId.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.cbTampilId.TabIndex = 3;
            this.cbTampilId.Values.Text = "Tampil ID pada combobox";
            this.cbTampilId.CheckedChanged += new System.EventHandler(this.CBTampilId_CheckedChanged);
            // 
            // lblPengaturan
            // 
            this.lblPengaturan.AutoSize = false;
            this.lblPengaturan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPengaturan.Location = new System.Drawing.Point(0, 0);
            this.lblPengaturan.Name = "lblPengaturan";
            this.lblPengaturan.Palette = this.palet;
            this.lblPengaturan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblPengaturan.Size = new System.Drawing.Size(536, 26);
            this.lblPengaturan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPengaturan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblPengaturan.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPengaturan.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblPengaturan.TabIndex = 939;
            this.lblPengaturan.Values.Text = "Pengaturan";
            // 
            // baganTableAdapter
            // 
            this.baganTableAdapter.ClearBeforeFill = true;
            // 
            // FDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1094, 640);
            this.Controls.Add(this.panelPengaturan);
            this.Controls.Add(this.panelGrafik);
            this.Controls.Add(this.panelRiwayat);
            this.Controls.Add(this.panelFootbar);
            this.Controls.Add(this.panelLogUser);
            this.Controls.Add(this.panelProfil);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FDashboard";
            this.Text = "FDashboard";
            this.Load += new System.EventHandler(this.FDashboard_Load);
            this.Resize += new System.EventHandler(this.FDashboard_Resize);
            this.panelProfil.ResumeLayout(false);
            this.panelProfil.PerformLayout();
            this.panelLogUser.ResumeLayout(false);
            this.panelDGVLogPagination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.panelFootbar.ResumeLayout(false);
            this.panelGrafik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRumahSakit)).EndInit();
            this.panelRiwayat.ResumeLayout(false);
            this.panelRiwayat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIdPerawatan)).EndInit();
            this.panelPengaturan.ResumeLayout(false);
            this.panelPengaturan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Krypton.Toolkit.KryptonPalette palet;
        private System.Windows.Forms.Panel panelProfil;
        private System.Windows.Forms.Panel panelLogUser;
        private System.Windows.Forms.Panel panelFootbar;
        internal Krypton.Toolkit.KryptonLabel lblNama;
        internal Krypton.Toolkit.KryptonTextBox tNama;
        internal Krypton.Toolkit.KryptonLabel lblUserAktif;
        internal Krypton.Toolkit.KryptonLabel lblAuthor;
        private System.Windows.Forms.Panel panelGrafik;
        private System.Windows.Forms.Panel panelRiwayat;
        internal Krypton.Toolkit.KryptonLabel lblNamaPasien;
        internal Krypton.Toolkit.KryptonTextBox tNamaPasien;
        private System.Windows.Forms.Panel panelPengaturan;
        internal Krypton.Toolkit.KryptonLabel lblProfil;
        internal Krypton.Toolkit.KryptonLabel lblLogUser;
        internal Krypton.Toolkit.KryptonLabel lblGrafik;
        internal Krypton.Toolkit.KryptonLabel lblRiwayat;
        internal Krypton.Toolkit.KryptonLabel lblPengaturan;
        internal Krypton.Toolkit.KryptonLabel lblJabatan;
        internal Krypton.Toolkit.KryptonTextBox tJabatan;
        internal Krypton.Toolkit.KryptonTextBox tFax;
        internal Krypton.Toolkit.KryptonLabel lblPengurus;
        internal Krypton.Toolkit.KryptonLabel lblTelepon;
        internal Krypton.Toolkit.KryptonTextBox tPengurus;
        internal Krypton.Toolkit.KryptonTextBox tTelepon;
        internal Krypton.Toolkit.KryptonLabel lblAlamat;
        internal Krypton.Toolkit.KryptonTextBox tWebsite;
        internal Krypton.Toolkit.KryptonTextBox tAlamat;
        internal Krypton.Toolkit.KryptonLabel lblEmail;
        internal Krypton.Toolkit.KryptonTextBox tEmail;
        internal Krypton.Toolkit.KryptonDataGridView dgvLog;
        internal Krypton.Toolkit.KryptonLabel lblTotalBiaya;
        internal Krypton.Toolkit.KryptonTextBox tTotalBiaya;
        internal Krypton.Toolkit.KryptonLabel lblDiagnosis;
        internal Krypton.Toolkit.KryptonTextBox tDiagnosis;
        internal Krypton.Toolkit.KryptonLabel lblTanggal;
        internal Krypton.Toolkit.KryptonTextBox tTanggal;
        internal Krypton.Toolkit.KryptonLabel lblNamaKamar;
        internal Krypton.Toolkit.KryptonTextBox tNamaKamar;
        internal Krypton.Toolkit.KryptonLabel lblIdPerawatan;
        internal Krypton.Toolkit.KryptonComboBox tIdPerawatan;
        internal Krypton.Toolkit.KryptonCheckBox cbSimpanResolusi;
        internal Krypton.Toolkit.KryptonCheckBox cbTampilId;
        internal Krypton.Toolkit.KryptonButton btnHapusPerawatan;
        internal Krypton.Toolkit.KryptonButton btnBackupDatabase;
        internal Krypton.Toolkit.KryptonButton btnGantiPassword;
        private System.Windows.Forms.Panel panelDGVLogPagination;
        internal Krypton.Toolkit.KryptonLabel dgvLogPageCounter;
        internal Krypton.Toolkit.KryptonButton dgvLogPrev;
        internal Krypton.Toolkit.KryptonButton dgvLogFirst;
        internal Krypton.Toolkit.KryptonButton dgvLogNext;
        internal Krypton.Toolkit.KryptonButton dgvLogLast;
        private DSRumahSakit dSRumahSakit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKeterangan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource baganBindingSource;
        private DSRumahSakitTableAdapters.BaganTableAdapter baganTableAdapter;
    }
}