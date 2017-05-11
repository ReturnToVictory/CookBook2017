namespace CookBook_1_0_1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserLevel = new System.Windows.Forms.Label();
            this.lbUserPoint = new System.Windows.Forms.Label();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnCookBook = new System.Windows.Forms.Button();
            this.btnUserChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pbVolume = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbUserName.Location = new System.Drawing.Point(14, 9);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(107, 45);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "label1";
            // 
            // lbUserLevel
            // 
            this.lbUserLevel.AutoSize = true;
            this.lbUserLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbUserLevel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserLevel.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbUserLevel.Location = new System.Drawing.Point(18, 65);
            this.lbUserLevel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbUserLevel.Name = "lbUserLevel";
            this.lbUserLevel.Size = new System.Drawing.Size(57, 23);
            this.lbUserLevel.TabIndex = 1;
            this.lbUserLevel.Text = "label2";
            // 
            // lbUserPoint
            // 
            this.lbUserPoint.AutoSize = true;
            this.lbUserPoint.BackColor = System.Drawing.Color.Transparent;
            this.lbUserPoint.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserPoint.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbUserPoint.Location = new System.Drawing.Point(151, 65);
            this.lbUserPoint.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbUserPoint.Name = "lbUserPoint";
            this.lbUserPoint.Size = new System.Drawing.Size(57, 23);
            this.lbUserPoint.TabIndex = 2;
            this.lbUserPoint.Text = "label3";
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.Transparent;
            this.btnGame.FlatAppearance.BorderSize = 0;
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGame.Image = global::CookBook_1_0_1.Properties.Resources.food_drink_03_64;
            this.btnGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGame.Location = new System.Drawing.Point(12, 121);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(344, 62);
            this.btnGame.TabIndex = 3;
            this.btnGame.Text = "Начать играть";
            this.btnGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnCookBook
            // 
            this.btnCookBook.BackColor = System.Drawing.Color.Transparent;
            this.btnCookBook.FlatAppearance.BorderSize = 0;
            this.btnCookBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCookBook.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCookBook.Image = global::CookBook_1_0_1.Properties.Resources.book;
            this.btnCookBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCookBook.Location = new System.Drawing.Point(12, 181);
            this.btnCookBook.Name = "btnCookBook";
            this.btnCookBook.Size = new System.Drawing.Size(344, 62);
            this.btnCookBook.TabIndex = 4;
            this.btnCookBook.Text = "Посмотреть книгу рецептов";
            this.btnCookBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCookBook.UseVisualStyleBackColor = false;
            this.btnCookBook.Click += new System.EventHandler(this.btnCookBook_Click);
            // 
            // btnUserChange
            // 
            this.btnUserChange.BackColor = System.Drawing.Color.Transparent;
            this.btnUserChange.FlatAppearance.BorderSize = 0;
            this.btnUserChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserChange.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUserChange.Image = global::CookBook_1_0_1.Properties.Resources._return;
            this.btnUserChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserChange.Location = new System.Drawing.Point(12, 237);
            this.btnUserChange.Name = "btnUserChange";
            this.btnUserChange.Size = new System.Drawing.Size(344, 62);
            this.btnUserChange.TabIndex = 5;
            this.btnUserChange.Text = "Сменить пользователя";
            this.btnUserChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserChange.UseVisualStyleBackColor = false;
            this.btnUserChange.Click += new System.EventHandler(this.btnUserChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Image = global::CookBook_1_0_1.Properties.Resources.logout;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(12, 297);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(344, 62);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Выход";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdmin.Image = global::CookBook_1_0_1.Properties.Resources.admin;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(12, 357);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(344, 62);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Администрирование";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pbVolume
            // 
            this.pbVolume.BackColor = System.Drawing.Color.Transparent;
            this.pbVolume.BackgroundImage = global::CookBook_1_0_1.Properties.Resources.volumeon;
            this.pbVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVolume.Location = new System.Drawing.Point(299, 467);
            this.pbVolume.Name = "pbVolume";
            this.pbVolume.Size = new System.Drawing.Size(50, 50);
            this.pbVolume.TabIndex = 8;
            this.pbVolume.TabStop = false;
            this.pbVolume.Click += new System.EventHandler(this.bpVolume_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::CookBook_1_0_1.Properties.Resources.backmenu2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(361, 529);
            this.Controls.Add(this.pbVolume);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUserChange);
            this.Controls.Add(this.btnCookBook);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.lbUserPoint);
            this.Controls.Add(this.lbUserLevel);
            this.Controls.Add(this.lbUserName);
            this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing_1);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserLevel;
        private System.Windows.Forms.Label lbUserPoint;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnCookBook;
        private System.Windows.Forms.Button btnUserChange;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.PictureBox pbVolume;
    }
}