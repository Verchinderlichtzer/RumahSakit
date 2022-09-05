namespace RumahSakit
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblPassword = new Krypton.Toolkit.KryptonLabel();
            this.tPassword = new Krypton.Toolkit.KryptonTextBox();
            this.lblUsername = new Krypton.Toolkit.KryptonLabel();
            this.tUsername = new Krypton.Toolkit.KryptonTextBox();
            this.btnOk = new Krypton.Toolkit.KryptonButton();
            this.lblLogin = new Krypton.Toolkit.KryptonLabel();
            this.palet = new Krypton.Toolkit.KryptonPalette(this.components);
            this.cbCookies = new Krypton.Toolkit.KryptonCheckBox();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = false;
            this.lblPassword.Location = new System.Drawing.Point(8, 119);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 26);
            this.lblPassword.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPassword.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblPassword.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblPassword.TabIndex = 925;
            this.lblPassword.Values.Text = "Password";
            // 
            // tPassword
            // 
            this.tPassword.AlwaysActive = false;
            this.tPassword.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tPassword.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tPassword.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tPassword.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tPassword.Location = new System.Drawing.Point(12, 148);
            this.tPassword.MaxLength = 32;
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '●';
            this.tPassword.Size = new System.Drawing.Size(300, 29);
            this.tPassword.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tPassword.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tPassword.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tPassword.StateActive.Border.Rounding = 0F;
            this.tPassword.StateActive.Border.Width = 1;
            this.tPassword.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tPassword.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tPassword.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tPassword.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tPassword.StateCommon.Border.Rounding = 0F;
            this.tPassword.StateCommon.Border.Width = 1;
            this.tPassword.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tPassword.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tPassword.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tPassword.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tPassword.StateDisabled.Border.Rounding = 0F;
            this.tPassword.StateDisabled.Border.Width = 0;
            this.tPassword.TabIndex = 1;
            this.tPassword.UseSystemPasswordChar = true;
            this.tPassword.TextChanged += new System.EventHandler(this.Valid);
            this.tPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputKarakter);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = false;
            this.lblUsername.Location = new System.Drawing.Point(8, 52);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(92, 26);
            this.lblUsername.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsername.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblUsername.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.lblUsername.TabIndex = 924;
            this.lblUsername.Values.Text = "Username";
            // 
            // tUsername
            // 
            this.tUsername.AlwaysActive = false;
            this.tUsername.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tUsername.CueHint.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tUsername.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tUsername.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tUsername.Location = new System.Drawing.Point(12, 81);
            this.tUsername.MaxLength = 32;
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(300, 29);
            this.tUsername.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tUsername.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tUsername.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tUsername.StateActive.Border.Rounding = 0F;
            this.tUsername.StateActive.Border.Width = 1;
            this.tUsername.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tUsername.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tUsername.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tUsername.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tUsername.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tUsername.StateCommon.Border.Rounding = 0F;
            this.tUsername.StateCommon.Border.Width = 1;
            this.tUsername.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tUsername.StateCommon.Content.Font = new System.Drawing.Font("Gadugi", 12.75F);
            this.tUsername.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tUsername.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tUsername.StateDisabled.Border.Rounding = 0F;
            this.tUsername.StateDisabled.Border.Width = 0;
            this.tUsername.TabIndex = 0;
            this.tUsername.TextChanged += new System.EventHandler(this.Valid);
            this.tUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputKarakter);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(8, 218);
            this.btnOk.Name = "btnOk";
            this.btnOk.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnOk.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnOk.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnOk.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnOk.Size = new System.Drawing.Size(308, 30);
            this.btnOk.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnOk.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnOk.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnOk.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnOk.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnOk.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnOk.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnOk.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnOk.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.btnOk.TabIndex = 3;
            this.btnOk.Values.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.BTNOk_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = false;
            this.lblLogin.Location = new System.Drawing.Point(8, 8);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(308, 38);
            this.lblLogin.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLogin.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblLogin.StateCommon.ShortText.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblLogin.TabIndex = 929;
            this.lblLogin.Values.Text = "Login";
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
            // cbCookies
            // 
            this.cbCookies.Location = new System.Drawing.Point(8, 183);
            this.cbCookies.Name = "cbCookies";
            this.cbCookies.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbCookies.Palette = this.palet;
            this.cbCookies.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.cbCookies.Size = new System.Drawing.Size(120, 28);
            this.cbCookies.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cbCookies.StateCommon.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCookies.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.cbCookies.TabIndex = 2;
            this.cbCookies.Values.Text = "Tetap Log-in";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 256);
            this.Controls.Add(this.cbCookies);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tUsername);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rumah Sakit - Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.VisibleChanged += new System.EventHandler(this.Login_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Krypton.Toolkit.KryptonLabel lblPassword;
        internal Krypton.Toolkit.KryptonTextBox tPassword;
        internal Krypton.Toolkit.KryptonLabel lblUsername;
        internal Krypton.Toolkit.KryptonTextBox tUsername;
        internal Krypton.Toolkit.KryptonButton btnOk;
        internal Krypton.Toolkit.KryptonLabel lblLogin;
        internal Krypton.Toolkit.KryptonPalette palet;
        internal Krypton.Toolkit.KryptonCheckBox cbCookies;
    }
}