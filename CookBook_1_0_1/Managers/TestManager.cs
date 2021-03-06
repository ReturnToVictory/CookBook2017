﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBook_1_0_1.Managers;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using CookBook_1_0_1.Managers;
using CookBook_1_0_1.Models;

namespace CookBook_1_0_1.Managers
{
    public class TestManager
    {
        bool Volume = false;
        public TestManager(bool volume)
        {
            Volume = volume;
        }

        public int CreateTestName(List<Recipe> recipes, int index)
        {
            TestName tn = new TestName(recipes[index].Image, recipes[index].Name, recipes, Volume);
            if (tn.ShowDialog() == DialogResult.OK)
            {
                if (tn.cancelGame)
                {
                    tn.Close();
                    return -1;
                }
                if (tn.exitGame)
                {
                    tn.Close();
                    return -2;
                }
                if (tn.right)
                {
                    tn.Close();
                    return 1;
                }
                else
                {
                    tn.Close();
                    return 0;
                }
            }
            else
                return 0;
        }
        public List<string> GetIngreds()
        {
            List<string> ingreds = new List<string>();
            DatabaseManager dbManager = new DatabaseManager();
            DataTable ings = dbManager.GetFullList("Ingredients");
            for (int i = 0; i < ings.Rows.Count; i++)
                ingreds.Add(ings.Rows[i][1].ToString());
            return ingreds;
        }
        public List<string> GetWrongIngreds(Recipe recipe, int count)
        {
            List<string> wrongIngreds = new List<string>();
            List<string> ingreds = GetIngreds();
            wrongIngreds.AddRange(ingreds.Where(i => !recipe.Ingredients.Contains(i)).OrderBy(i => Guid.NewGuid()).Take(count));
            return wrongIngreds;
        }
        public List<int> GetIndexesForDelete(List<string> ingreds, int count)
        {
            List<int> indexes = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int num = rnd.Next(ingreds.Count);
                if (!indexes.Contains(num))
                    indexes.Add(num);
                else
                    i--;
            }
            return indexes;
        }
        public int CreateTestIngred(Recipe recipe)
        {
            TestIngredients ti = new TestIngredients(recipe, Volume);
            if (ti.ShowDialog() == DialogResult.OK)
            {
                if (ti.cancelGame)
                {
                    ti.Close();
                    return -1;
                }
                if (ti.exitGame)
                {
                    ti.Close();
                    return -2;
                }
                int result = ti.countWrong;
                ti.Close();
                return result;
            }
            else
                return 0;
        }
        public string GetDescreption(Recipe recipe)
        {
            string pattern = "#[а-яА-ЯёЁ]+#";
            Regex rgx = new Regex(pattern);
            string description = rgx.Replace(recipe.Descreption, "____");
            return description;
        }
        public bool CheckIsUserRight(List<string> answers, List<string> list)
        {
            for (int i = 0; i < answers.Count; i++)
                if (answers[i] != list[i])
                    return false;
            return true;
        }
        public List<string> GetWordsFromDescription(Recipe recipe)
        {
            List<string> words = new List<string>();
            string[] array = recipe.Descreption.Split(' ');
            for (int i = 0; i < array.Length; i++)
                if (array[i] != String.Empty)
                    if (array[i][0] == '#')
                        words.Add(array[i].Trim('#', '!', '.', ','));
            return words;
        }
        public int CreateTestRecipe(Recipe recipe)
        {
            TestRecipe tr = new TestRecipe(recipe, Volume);
            if (tr.ShowDialog() == DialogResult.OK)
            {
                if (tr.cancelGame)
                {
                    tr.Close();
                    return -1;
                }
                if (tr.exitGame)
                {
                    tr.Close();
                    return -2;
                }
                if (tr.right)
                {
                    tr.Close();
                    return 1;
                }
                else
                {
                    tr.Close();
                    return 0;
                }
            }
            else
                return 0;
        }

        public bool StartGame(List<Recipe> recipes, List<int> indexes, string User)
        {
            int count = 0;
            double allPoints = 0;
            List<int> DoneRecipes = new List<int>();
            List<string> Results = new List<string>();
            int test = recipes.Count;
            if (test > 10)
                test = 10;
            for (int i = 0; i < test; i++)
            {
                Random rand = new Random();
                int index = rand.Next(0, indexes.Count);
                Random TestType = new Random();
                int Type = TestType.Next(1, 4);
                if (Type == 1)
                {
                    //Подсчет очков для 1 типа
                    #region
                    int result = CreateTestIngred(recipes[indexes[index]]);
                    if (result == -2)
                        break;
                    if (result == -1)
                        return false;
                    if (result == 0)
                    {
                        count += recipes[indexes[index]].Points;
                        allPoints += recipes[indexes[index]].Points;
                        DoneRecipes.Add(recipes[indexes[index]].Id);
                        Results.Add(recipes[indexes[index]].Name + "," + recipes[indexes[index]].Points.ToString());
                    }
                    if (result == 1)
                    {
                        count += recipes[indexes[index]].Points * 2 / 3;
                        allPoints += recipes[indexes[index]].Points;
                        DoneRecipes.Add(recipes[indexes[index]].Id);
                        Results.Add(recipes[indexes[index]].Name + "," + (recipes[indexes[index]].Points * 2 / 3).ToString());
                    }
                    if (result == 2)
                    {
                        count += recipes[indexes[index]].Points / 3;
                        allPoints += recipes[indexes[index]].Points;
                        DoneRecipes.Add(recipes[indexes[index]].Id);
                        Results.Add(recipes[indexes[index]].Name + "," + (recipes[indexes[index]].Points / 3).ToString());
                    }
                    if (result == 3)
                    {
                        allPoints += recipes[indexes[index]].Points;
                        Results.Add(recipes[indexes[index]].Name + ",0");
                    }
                    #endregion
                }
                if (Type == 2)
                {
                    #region
                    int result = CreateTestName(recipes, indexes[index]);
                    if (result == -1)
                        return false;
                    if (result == -2)
                        break;
                    if (result == 1)
                    {
                        count += recipes[indexes[index]].Points;
                        allPoints += recipes[indexes[index]].Points;
                        DoneRecipes.Add(recipes[indexes[index]].Id);
                        Results.Add(recipes[indexes[index]].Name + "," + recipes[indexes[index]].Points.ToString());
                    }
                    if (result == 0)
                    {
                        allPoints += recipes[indexes[index]].Points;
                        Results.Add(recipes[indexes[index]].Name + ",0");
                    }
                    #endregion
                }
                if (Type == 3)
                {
                    #region
                    int result = CreateTestRecipe(recipes[indexes[index]]);
                    if (result == -1)
                        return false;
                    if (result == -2)
                        break;
                    if (result == -1)
                    {
                        count += recipes[indexes[index]].Points;
                        allPoints += recipes[indexes[index]].Points;
                        DoneRecipes.Add(recipes[indexes[index]].Id);
                        Results.Add(recipes[indexes[index]].Name + "," + recipes[indexes[index]].Points.ToString());
                    }
                    if (result == 0)
                    {
                        allPoints += recipes[indexes[index]].Points;
                        Results.Add(recipes[indexes[index]].Name + ",0");
                    }
                    #endregion
                }
                indexes.RemoveAt(index);
            }
            return true;
        }
            
    }
}
