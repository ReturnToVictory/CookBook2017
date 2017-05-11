namespace CookBook_1_0_1
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnLevel = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnCBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategory.Location = new System.Drawing.Point(12, 90);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(316, 65);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Выбрать Категорию";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnLevel
            // 
            this.btnLevel.BackColor = System.Drawing.Color.Transparent;
            this.btnLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel.FlatAppearance.BorderSize = 0;
            this.btnLevel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLevel.Location = new System.Drawing.Point(12, 161);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Size = new System.Drawing.Size(316, 65);
            this.btnLevel.TabIndex = 1;
            this.btnLevel.Text = "Выбрать уровень";
            this.btnLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLevel.UseVisualStyleBackColor = false;
            this.btnLevel.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.Transparent;
            this.btnRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandom.FlatAppearance.BorderSize = 0;
            this.btnRandom.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRandom.Location = new System.Drawing.Point(12, 232);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(316, 65);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Случайная игра";
            this.btnRandom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnCBack
            // 
            this.btnCBack.BackColor = System.Drawing.Color.Transparent;
            this.btnCBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCBack.FlatAppearance.BorderSize = 0;
            this.btnCBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCBack.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCBack.Location = new System.Drawing.Point(12, 382);
            this.btnCBack.Name = "btnCBack";
            this.btnCBack.Size = new System.Drawing.Size(114, 53);
            this.btnCBack.TabIndex = 3;
            this.btnCBack.Text = "Назад";
            this.btnCBack.UseVisualStyleBackColor = false;
            this.btnCBack.Click += new System.EventHandler(this.btnCBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CookBook_1_0_1.Properties.Resources.food_drink_03_64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 72);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CookBook_1_0_1.Properties.Resources.background11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(340, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCBack);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnLevel);
            this.Controls.Add(this.btnCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начать играть";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnLevel;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnCBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}