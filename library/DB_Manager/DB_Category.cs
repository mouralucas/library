using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Library.Entities;

namespace Library.DB_Manager
{
    class DB_Category
    {
        /*----- Strings that defines the queries -----*/
        private string Insert;
        private string RemoveById;
        private string Retrieve;
        private string CountString;

        /*----- Others Variables -----*/
        private int Count = -1;

        List<Category> CategoryList = new List<Category>();
        Category Category = new Category();

        public int CountRows(MySqlConnection conn)
        {
            CountString = "SELECT COUNT(*) FROM category";
            MySqlCommand Command = new MySqlCommand(CountString, conn);
            Count = Convert.ToInt32(Command.ExecuteScalar());
            return Count;
        }

        public List<Category> ListAll(MySqlConnection Conn)
        {
            Retrieve = "SELECT * FROM category ORDER BY category";

            MySqlCommand Cmd = new MySqlCommand(Retrieve, Conn);
            SetCategoryData(Cmd);
            return CategoryList;
        }

        private void SetCategoryData(MySqlCommand Cmd)
        {
            MySqlDataReader DataReader = Cmd.ExecuteReader();
            CategoryList.Clear();

            while (DataReader.Read())
            {
                Category = new Category()
                {
                    Category_Id = Convert.IsDBNull(DataReader["category_id"]) ? -1 : Convert.ToInt32(DataReader["category_id"]),
                    CategoryName = Convert.IsDBNull(DataReader["category"]) ? "" : DataReader["category"].ToString(),
                    Description = Convert.IsDBNull(DataReader["description"]) ? "" : DataReader["description"].ToString()
                };

                CategoryList.Add(Category);
            }

            DataReader.Close();
        }
    }
}
