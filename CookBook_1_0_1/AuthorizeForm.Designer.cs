namespace CookBook_1_0_1
{
    partial class AuthorizeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizeForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSvernut = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::CookBook_1_0_1.Properties.Resources.crossclose;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(280, 88);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 43);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSvernut
            // 
            this.btnSvernut.BackColor = System.Drawing.Color.Transparent;
            this.btnSvernut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSvernut.FlatAppearance.BorderSize = 0;
            this.btnSvernut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSvernut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSvernut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSvernut.Location = new System.Drawing.Point(233, 82);
            this.btnSvernut.Name = "btnSvernut";
            this.btnSvernut.Size = new System.Drawing.Size(41, 43);
            this.btnSvernut.TabIndex = 1;
            this.btnSvernut.Text = "_";
            this.btnSvernut.UseVisualStyleBackColor = false;
            this.btnSvernut.Click += new System.EventHandler(this.btnSvernut_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistration.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegistration.Location = new System.Drawing.Point(252, 232);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(141, 37);
            this.btnRegistration.TabIndex = 2;
            this.btnRegistration.Text = "Регистрация";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Location = new System.Drawing.Point(153, 232);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 37);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbUsers
            // 
            this.cbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUsers.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsers.DropDownWidth = 300;
            this.cbUsers.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(153, 192);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(240, 31);
            this.cbUsers.TabIndex = 4;
            // 
            // AuthorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CookBook_1_0_1.Properties.Resources.plate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(516, 430);
            this.Controls.Add(this.cbUsers);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnSvernut);
            this.Controls.Add(this.btnExit);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CookBook";
            this.Load += new System.EventHandler(this.AuthorizeForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthorizeForm_MouseDown_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSvernut;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cbUsers;
    }
}

