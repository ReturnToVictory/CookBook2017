namespace CookBook_1_0_1
{
    partial class CategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCategories
            // 
            this.lbCategories.BackColor = System.Drawing.SystemColors.Menu;
            this.lbCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCategories.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.ItemHeight = 29;
            this.lbCategories.Location = new System.Drawing.Point(12, 12);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(336, 261);
            this.lbCategories.TabIndex = 0;
            this.lbCategories.SelectedIndexChanged += new System.EventHandler(this.lbCategories_SelectedIndexChanged);
            this.lbCategories.DoubleClick += new System.EventHandler(this.lbCategories_DoubleClick_1);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(12, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(336, 68);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Назад";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CookBook_1_0_1.Properties.Resources.background11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(360, 514);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Категории блюд";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCategories;
        private System.Windows.Forms.Button btnClose;
    }
}