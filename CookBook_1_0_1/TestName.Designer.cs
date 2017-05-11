namespace CookBook_1_0_1
{
    partial class TestName
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVars = new System.Windows.Forms.ComboBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Peru;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(12, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 43);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отменить игру";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.Color.Peru;
            this.btnExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitGame.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitGame.Location = new System.Drawing.Point(183, 307);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(165, 43);
            this.btnExitGame.TabIndex = 1;
            this.btnExitGame.Text = "Выйти из игры";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.Peru;
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer.Location = new System.Drawing.Point(537, 307);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(165, 43);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "Ответить";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите правильное название блюда на картинке ";
            // 
            // cbVars
            // 
            this.cbVars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbVars.FormattingEnabled = true;
            this.cbVars.Location = new System.Drawing.Point(78, 253);
            this.cbVars.Name = "cbVars";
            this.cbVars.Size = new System.Drawing.Size(481, 28);
            this.cbVars.TabIndex = 5;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(242, 41);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(244, 206);
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // TestName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(714, 362);
            this.Controls.Add(this.cbVars);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnCancel);
            this.Name = "TestName";
            this.Text = "TestName";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestName_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ComboBox cbVars;
    }
}