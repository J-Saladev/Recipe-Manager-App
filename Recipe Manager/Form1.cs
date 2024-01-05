using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Recipe_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queries query = new Queries("localhost\\SQLEXPRESS", "Recipe Management");
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRecipes();

        }

        public void LoadRecipes()
        {

            string getrecipes = "SELECT r.Images, r.Name, c.Name, d.Name, r.Favorite FROM Recipes AS r " +
                "INNER JOIN Categories AS c WHERE r.Category_ID = c.Category_ID  " +
                "INNER JOIN Difficulties AS d WHERE r.Difficulty_ID = d.Difficulty_ID";
            DataTable recipes = query.ExecuteQuery(getrecipes);
            dataRecipes.DataSource = recipes;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataRecipes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                int recipeid = Convert.ToInt16(dataRecipes.Rows[e.RowIndex].Cells["Recipe_ID"]);

            }
        }

        private void viewIngredientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(e.ToString());

        }
    }
}
