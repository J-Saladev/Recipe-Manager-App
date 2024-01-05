using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Manager
{
    public partial class Ingredients : Form
    {
        public Ingredients()
        {
            InitializeComponent();
        }
        public int ?recipeid;
        public Ingredients(int pagerecipeid)
        {
            InitializeComponent();
            recipeid = pagerecipeid;

        }
        Queries query = new Queries("localhost\\SQLEXPRESS", "Recipe Management");
        private void Ingredients_Load(object sender, EventArgs e)
        {
            string findingredients = "SELECT i.Name, i.Quantity FROM Recipe Ingredients AS ri " +
                "INNER JOIN Ingredients AS WHERE ri.Ingredient_ID = i.Ingredient_ID" +
                $"INNER JOIN Recipes AS r WHERE ri.Recipe_ID = r.{recipeid} ";
            dataGridView1.DataSource =  query.ExecuteQuery(findingredients);

            

        }
        
    }
}
