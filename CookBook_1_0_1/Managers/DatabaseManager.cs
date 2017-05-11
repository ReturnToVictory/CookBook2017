using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using CookBook_1_0_1.Models;
using System.Drawing;

namespace CookBook_1_0_1.Managers
{
    public class DatabaseManager
    {
        SQLiteConnection sql;

        public DatabaseManager()
        {

            sql = new SQLiteConnection("Data Source=Database.sqlite;Version=3");
            CreateDataBase();


        }

        public void CreateDataBase()
        {

            if (!File.Exists(@"Database.sqlite") )
            {
                SQLiteConnection.CreateFile(@"Database.sqlite");


                SQLiteCommand user = new SQLiteCommand("CREATE TABLE User (Login TEXXT PRIMARY KEY , Pass TEXT , IsAdmin BOOL , Points int);", sql);
               
                SQLiteCommand category = new SQLiteCommand("CREATE TABLE Category (id INTEGER PRIMARY KEY , Name TEXT , Level INTEGER);", sql);
                SQLiteCommand recipe = new SQLiteCommand("CREATE TABLE Recipe (id INTEGER PRIMARY KEY,Image BLOB , Name TEXT , Ingredients TEXT , Descreption TEXT , Level INTEGER , Points INTEGER , CONSTRAINT recipe_cat_fk FOREIGN KEY (Category) references Category(id) on delete cascade);", sql);
                SQLiteCommand userrecipe = new SQLiteCommand("CREATE TABLE UserRecipe(User TEXT , Recipe INTEGER);", sql);
                SQLiteCommand ingredients = new SQLiteCommand("CREATE TABLE Ingrediants(id INTEGER PRIMARY KEY , Name TEXT);", sql);
                sql.Open();
                user.ExecuteNonQuery();
                category.ExecuteNonQuery();
                recipe.ExecuteNonQuery();
                userrecipe.ExecuteNonQuery();
                ingredients.ExecuteNonQuery();
                sql.Close();
            }
        }
        public DataTable GetFullList(string tableName)
        {
            SQLiteCommand command = new SQLiteCommand(String.Format("select * from {0}", tableName), sql);
            sql.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            DataTable FullList = new DataTable();
            FullList.Load(reader);
            sql.Close();
            return FullList;
        }
        public void AddUser(User user)
        {
            string sqlCommand = String.Format("insert into User values (\'{0}\' ,\'{1}\' , \'{2}\' , {3})", user.Login, user.Pass, user.IsAdmin, user.Points);
            SQLiteCommand command = new SQLiteCommand(sqlCommand, sql);
            sql.Open();
            command.ExecuteNonQuery();
            sql.Close();
        }
        public void AddCategory(Category cat)
        {
            string sqlCommand = String.Format("insert into Category values ({0} , \'{1}\' , {2})", cat.Id, cat.Name, cat.Level);
            SQLiteCommand command = new SQLiteCommand(sqlCommand, sql);
            sql.Open();
            command.ExecuteNonQuery();
            sql.Close();
        }
        public void AddIngred(string id , string name)
        {
            string sqlCommand = String.Format("insert into Ingredients values ({0}, \'{1}\')", id, name);
            SQLiteCommand command = new SQLiteCommand(sqlCommand, sql);
            sql.Open();
            command.ExecuteNonQuery();
            sql.Close();
        }
        public void AddRecipe(Recipe recipe)
        {
            Image photo = recipe.Image;
            byte[] pic;
            using (MemoryStream ms = new MemoryStream())
            {
                photo.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                pic = ms.ToArray();
            }
            string ingreds = "";
            for(int i=0; i < recipe.Ingredients.Count; i++)
            {
                if (i != recipe.Ingredients.Count - 1)
                    ingreds += recipe.Ingredients[i] + ",";
                else
                    ingreds += recipe.Ingredients[i];
            }
            string sqlCommand = String.Format("insert into Recipe values ({0} , (@0), \'{1}\' , \'{2}\' , \'{3}\' , {4} , {5} , {6} )", recipe.Id, recipe.Name, ingreds, recipe.Descreption, recipe.Level, recipe.Points, recipe.CategoryId);
            SQLiteCommand cmd = new SQLiteCommand(sqlCommand, sql);
            SQLiteParameter param = new SQLiteParameter("@0", System.Data.DbType.Binary);
            param.Value = pic;
            cmd.Parameters.Add(param);
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();




        }
        public void Delete (string tableName , string query )
        {
            SQLiteCommand command = new SQLiteCommand(String.Format("delete from {0} where {1}", tableName, query));
            sql.Open();
            command.ExecuteNonQuery();
            sql.Close();
            if (tableName == "Category")
                Delete("Recipe", "Category = " + query.Substring(query.IndexOf('=') + 1));
        }
        public void Update(string table , string nameOfLine , string value , string key , string keyValue)
        {
            SQLiteCommand command = new SQLiteCommand(String.Format("update {0} set {1} = \'{2}\' where {3} = \'{4}\'", table, nameOfLine, value, key, keyValue), sql);
            sql.Open();
            command.ExecuteNonQuery();
            sql.Clone();
        }
        public DataTable Request(string table , string query)
        {
            SQLiteCommand command = new SQLiteCommand(String.Format("select * from {0} where {1}", table, query), sql);
            sql.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            DataTable TableForResult = new DataTable();
            TableForResult.Load(reader);
            sql.Close();
            return TableForResult;
        }
        public bool CheckId(string query , string table)
        {
            DataTable data = Request(table, query);
            if (data.Rows.Count == 0)
                return false;
            else
                return true;
        }
    }
    
}
