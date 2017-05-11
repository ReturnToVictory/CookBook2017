namespace CookBook_1_0_1
{
    partial class RecipeBookForm
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbDown = new System.Windows.Forms.PictureBox();
            this.pbDown2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.bpForward = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.rtbRecipe = new CookBook_1_0_1.TransparentRTB_();
            this.rtbIngredients = new CookBook_1_0_1.TransparentRTB_();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpForward)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(52, 88);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(170, 166);
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.BackgroundImage = global::CookBook_1_0_1.Properties.Resources.back1;
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBack.Location = new System.Drawing.Point(64, 464);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(56, 50);
            this.pbBack.TabIndex = 2;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbDown
            // 
            this.pbDown.BackColor = System.Drawing.Color.Transparent;
            this.pbDown.BackgroundImage = global::CookBook_1_0_1.Properties.Resources.down;
            this.pbDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDown.Location = new System.Drawing.Point(319, 430);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(52, 50);
            this.pbDown.TabIndex = 3;
            this.pbDown.TabStop = false;
            this.pbDown.Click += new System.EventHandler(this.pbDown_Click);
            this.pbDown.MouseHover += new System.EventHandler(this.pbDown_MouseHover_1);
            // 
            // pbDown2
            // 
            this.pbDown2.BackColor = System.Drawing.Color.Transparent;
            this.pbDown2.BackgroundImage = global::CookBook_1_0_1.Properties.Resources.down;
            this.pbDown2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDown2.Location = new System.Drawing.Point(434, 430);
            this.pbDown2.Name = "pbDown2";
            this.pbDown2.Size = new System.Drawing.Size(58, 50);
            this.pbDown2.TabIndex = 4;
            this.pbDown2.TabStop = false;
            this.pbDown2.Click += new System.EventHandler(this.pbDown2_Click);
            this.pbDown2.MouseHover += new System.EventHandler(this.pbDown2_MouseHover_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::CookBook_1_0_1.Properties.Resources.crossclose;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(650, 464);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 50);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bpForward
            // 
            this.bpForward.BackColor = System.Drawing.Color.Transparent;
            this.bpForward.BackgroundImage = global::CookBook_1_0_1.Properties.Resources.forward1;
            this.bpForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bpForward.Location = new System.Drawing.Point(711, 464);
            this.bpForward.Name = "bpForward";
            this.bpForward.Size = new System.Drawing.Size(58, 50);
            this.bpForward.TabIndex = 7;
            this.bpForward.TabStop = false;
            this.bpForward.Click += new System.EventHandler(this.bpForward_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(59, 60);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 25);
            this.lbName.TabIndex = 10;
            // 
            // rtbRecipe
            // 
            this.rtbRecipe.BackColor = System.Drawing.SystemColors.Control;
            this.rtbRecipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRecipe.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbRecipe.Location = new System.Drawing.Point(434, 60);
            this.rtbRecipe.Name = "rtbRecipe";
            this.rtbRecipe.Size = new System.Drawing.Size(327, 364);
            this.rtbRecipe.TabIndex = 13;
            this.rtbRecipe.Text = "";
            this.rtbRecipe.TextChanged += new System.EventHandler(this.rtbRecipe_TextChanged);
            // 
            // rtbIngredients
            // 
            this.rtbIngredients.BackColor = System.Drawing.SystemColors.Control;
            this.rtbIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbIngredients.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbIngredients.Location = new System.Drawing.Point(52, 260);
            this.rtbIngredients.Name = "rtbIngredients";
            this.rtbIngredients.Size = new System.Drawing.Size(337, 164);
            this.rtbIngredients.TabIndex = 12;
            this.rtbIngredients.Text = "";
            this.rtbIngredients.TextChanged += new System.EventHandler(this.rtbIngredients_TextChanged);
            // 
            // RecipeBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CookBook_1_0_1.Properties.Resources.book4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 556);
            this.Controls.Add(this.rtbRecipe);
            this.Controls.Add(this.rtbIngredients);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.bpForward);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pbDown2);
            this.Controls.Add(this.pbDown);
            this.Controls.Add(this.pbBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecipeBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.RecipeBookForm_Deactivate);
            this.Load += new System.EventHandler(this.RecipeBookForm_Load);
            this.MouseHover += new System.EventHandler(this.RecipeBookForm_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpForward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbDown;
        private System.Windows.Forms.PictureBox pbDown2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox bpForward;
        private System.Windows.Forms.Label lbName;
        private TransparentRTB_ rtbIngredients;
        private TransparentRTB_ rtbRecipe;
    }
}