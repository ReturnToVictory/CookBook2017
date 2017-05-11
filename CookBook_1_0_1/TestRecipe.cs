using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookBook_1_0_1.Managers;
using CookBook_1_0_1.Models;

namespace CookBook_1_0_1
{
    public partial class TestRecipe : Form
    {
        public bool answer = false;
        public bool exitGame = false;
        public bool cancelGame = false;
        public bool right = false;
        bool volume;

        public List<string> UserWords = new List<string>();
        public int Counter;
        List<string> CorrectOrder = new List<string>();

        public TestRecipe(Recipe recipe , bool vol)
        {
            InitializeComponent();
            labRecipeName.Text = recipe.Name;
            labelInstruction.Text = "Выберите пропущенные слова в правильном порядке";
            volume = vol;
            TestManager testManager = new TestManager(false);
            richTextBox1.Text = testManager.GetDescreption(recipe);
            CorrectOrder = testManager.GetWordsFromDescription(recipe);
            Random rnd = new Random();
            List<string> words = CorrectOrder.OrderBy(i => rnd.Next()).ToList();
            for (int i = 0; i < words.Count; i++)
                lbWords.Items.Add(words[i]);
            lbWords.SelectedIndex = -1;
            if(lbWords.Items.Count ==0)
            {
                richTextBox1.Text = "Извините , но данный рецепт был неверно оформлен администратором";
                btnAgain.Enabled = false;
                btnCancel.Enabled = false;
                btnExitGame.Enabled = false;
                Counter = 100;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            TestManager testManager = new TestManager(false);
            if(Counter != CorrectOrder.Count && Counter != 100)
            {
                InfoForm iform = new InfoForm("Остались незаполненные слова!", volume);
                iform.Show();
                return;
            }
            else
            {
                answer = true;
                right = testManager.CheckIsUserRight(UserWords, CorrectOrder);
            }
            DialogResult = DialogResult.OK;
        }

        private void TestRecipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cancelGame && !exitGame && !answer)
                right = false;
            DialogResult = DialogResult.OK;
        }

        private void TestRecipe_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            string word = "";
            if(lbWords.SelectedIndex != -1)
            {
                word = lbWords.SelectedIndex.ToString();
                if (word.Contains(")"))
                    word = word.Split(' ')[1];
                if(!UserWords.Contains(word))
                {
                    int index = lbWords.SelectedIndex;
                    UserWords.Add(word);
                    Counter++;
                    lbWords.SelectedIndex = -1;
                    lbWords.Items[index] = Counter.ToString() + ") " + word;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            cancelGame = true;
            DialogResult = DialogResult.OK;
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            exitGame = true;
            DialogResult = DialogResult.OK;
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            Random rnd = new Random();
            List<string> words = CorrectOrder.OrderBy(i => rnd.Next()).ToList();
            UserWords.Clear();
            lbWords.Items.Clear();
            Counter = 0;
            for (int i = 0; i < words.Count; i++)
                lbWords.Items.Add(words[i]);
            lbWords.SelectedIndex = -1;
        }
    }
}
