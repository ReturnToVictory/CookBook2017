namespace CookBook_1_0_1
{
    partial class Registration
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите имя пользователя";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistration.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistration.FlatAppearance.BorderSize = 0;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistration.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegistration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistration.Location = new System.Drawing.Point(77, 119);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(191, 43);
            this.btnRegistration.TabIndex = 2;
            this.btnRegistration.Text = "Зарегистрироваться";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserName.Location = new System.Drawing.Point(34, 66);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(290, 29);
            this.tbUserName.TabIndex = 3;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CookBook_1_0_1.Properties.Resources.background11;
            this.ClientSize = new System.Drawing.Size(362, 174);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.label2);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.TextBox tbUserName;
    }
}