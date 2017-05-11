namespace CookBook_1_0_1
{
    partial class TestRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestRecipe));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnAgain = new System.Windows.Forms.Button();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.labRecipeName = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbWords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Peru;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(12, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 40);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "отменить игру";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.Color.Peru;
            this.btnExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitGame.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitGame.Location = new System.Drawing.Point(167, 310);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(140, 40);
            this.btnExitGame.TabIndex = 1;
            this.btnExitGame.Text = "Выйти из игры";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.Peru;
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer.Location = new System.Drawing.Point(571, 310);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(140, 40);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "Ответить";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAgain
            // 
            this.btnAgain.BackColor = System.Drawing.Color.Peru;
            this.btnAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgain.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAgain.Location = new System.Drawing.Point(571, 51);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(140, 40);
            this.btnAgain.TabIndex = 3;
            this.btnAgain.Text = "Сбросить";
            this.btnAgain.UseVisualStyleBackColor = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstruction.Location = new System.Drawing.Point(12, 18);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(658, 25);
            this.labelInstruction.TabIndex = 4;
            this.labelInstruction.Text = "Выберите пропущенные ингредиенты из списка  ключевых слов";
            // 
            // labRecipeName
            // 
            this.labRecipeName.AutoSize = true;
            this.labRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labRecipeName.Location = new System.Drawing.Point(12, 56);
            this.labRecipeName.Name = "labRecipeName";
            this.labRecipeName.Size = new System.Drawing.Size(90, 25);
            this.labRecipeName.TabIndex = 5;
            this.labRecipeName.Text = "Блюдо:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(17, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(384, 206);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lbWords
            // 
            this.lbWords.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbWords.FormattingEnabled = true;
            this.lbWords.Location = new System.Drawing.Point(407, 97);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(304, 208);
            this.lbWords.TabIndex = 7;
            this.lbWords.SelectedIndexChanged += new System.EventHandler(this.lbWords_SelectedIndexChanged);
            // 
            // TestRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(714, 362);
            this.Controls.Add(this.lbWords);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labRecipeName);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestRecipe";
            this.Text = "TestRecipe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestRecipe_FormClosing);
            this.Load += new System.EventHandler(this.TestRecipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Label labRecipeName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox lbWords;
    }
}