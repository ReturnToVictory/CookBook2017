namespace CookBook_1_0_1
{
    partial class TestIngredients
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
            this.btnClancel = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnAgain = new System.Windows.Forms.Button();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbRecipeIngreds = new System.Windows.Forms.ListBox();
            this.lbIngreds = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClancel
            // 
            this.btnClancel.BackColor = System.Drawing.Color.Peru;
            this.btnClancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClancel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClancel.Location = new System.Drawing.Point(12, 309);
            this.btnClancel.Name = "btnClancel";
            this.btnClancel.Size = new System.Drawing.Size(157, 41);
            this.btnClancel.TabIndex = 0;
            this.btnClancel.Text = "Отменить игру";
            this.btnClancel.UseVisualStyleBackColor = false;
            this.btnClancel.Click += new System.EventHandler(this.btnClancel_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.Color.Peru;
            this.btnExitGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitGame.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitGame.Location = new System.Drawing.Point(175, 309);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(157, 41);
            this.btnExitGame.TabIndex = 1;
            this.btnExitGame.Text = "Выйти из игры";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.Peru;
            this.btnAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer.Location = new System.Drawing.Point(583, 309);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(119, 41);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "Ответить";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAgain
            // 
            this.btnAgain.BackColor = System.Drawing.Color.Peru;
            this.btnAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgain.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAgain.Location = new System.Drawing.Point(571, 50);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(119, 41);
            this.btnAgain.TabIndex = 3;
            this.btnAgain.Text = "Сбросить";
            this.btnAgain.UseVisualStyleBackColor = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstruction.Location = new System.Drawing.Point(12, 21);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(595, 26);
            this.labelInstruction.TabIndex = 4;
            this.labelInstruction.Text = "Выберите пропущенные ингредиенты из списка ключевых слов";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(9, 47);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(80, 26);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Блюдо:";
            // 
            // lbRecipeIngreds
            // 
            this.lbRecipeIngreds.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbRecipeIngreds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRecipeIngreds.FormattingEnabled = true;
            this.lbRecipeIngreds.Location = new System.Drawing.Point(17, 79);
            this.lbRecipeIngreds.Name = "lbRecipeIngreds";
            this.lbRecipeIngreds.Size = new System.Drawing.Size(350, 208);
            this.lbRecipeIngreds.TabIndex = 6;
            // 
            // lbIngreds
            // 
            this.lbIngreds.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbIngreds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbIngreds.FormattingEnabled = true;
            this.lbIngreds.Location = new System.Drawing.Point(368, 92);
            this.lbIngreds.Name = "lbIngreds";
            this.lbIngreds.Size = new System.Drawing.Size(334, 195);
            this.lbIngreds.TabIndex = 7;
            // 
            // TestIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(714, 362);
            this.Controls.Add(this.lbIngreds);
            this.Controls.Add(this.lbRecipeIngreds);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnClancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TestIngredients";
            this.Text = "TestIngredients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestIngredients_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClancel;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ListBox lbRecipeIngreds;
        private System.Windows.Forms.ListBox lbIngreds;
    }
}