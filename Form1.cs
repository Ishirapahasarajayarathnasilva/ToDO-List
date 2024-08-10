using System.Data;

namespace Todolist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        DataTable todoList = new DataTable();
        bool isEditing = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create Columns 
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            //Point our datagrid view  to our data source
            todoListView.DataSource = todoList;

        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            title.Text = "";
            description.Text = "";
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // Fill text fields with data form table
            title.Text = todoList.Rows[todoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            description.Text = todoList.Rows[todoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[todoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[todoListView.CurrentCell.RowIndex]["Title"] = title.Text;

                todoList.Rows[todoListView.CurrentCell.RowIndex]["Description"] = description.Text;

            }
            else
            {
                todoList.Rows.Add(title.Text, description.Text);
            }

            // Clear Fields
            title.Text = "";
            description.Text = "";
            isEditing = false;

        }
    }
}

