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
        private int count = -1;

        List<Category> CategoryList = new List<Category>();
        Category category = new Category();

        public int Count(MySqlConnection conn)
        {
            CountString = "SELECT COUNT(*) FROM category";
            MySqlCommand Command = new MySqlCommand(CountString, conn);
            count = Convert.ToInt32(Command.ExecuteScalar());
            return count;
        }

        public List<Category> ListAllCategories(MySqlConnection Conn)
        {
            Retrieve = "SELECT * FROM category ORDER BY category";

            MySqlCommand Cmd = new MySqlCommand(Retrieve, Conn);
            SetCategoryData(Cmd);
            return CategoryList;
        }

        private void SetCategoryData(MySqlCommand Cmd)
        {
            MySqlDataReader DataRead = Cmd.ExecuteReader();
            CategoryList.Clear();

            while (DataRead.Read())
            {
                category = new Category()
                {
                    Category_Id = Convert.IsDBNull(DataRead["category_id"]) ? -1 : Convert.ToInt32(DataRead["category_id"]),
                    CategoryName = Convert.IsDBNull(DataRead["category"]) ? "" : DataRead["category"].ToString(),
                    Description = Convert.IsDBNull(DataRead["description"]) ? "" : DataRead["description"].ToString()
                };

                CategoryList.Add(category);
            }

            DataRead.Close();
        }
    }
}
