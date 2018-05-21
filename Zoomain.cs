using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace ZOO
{
    public partial class Zoomain : Form
    {
        SqlConnection connection;
        string connectionString;
        

        public Zoomain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["ZOO.Properties.Settings.ZooConnectionString"].ConnectionString;
            Populate_Tables();
        }

        private void Zoomain_Load(object sender, EventArgs e)
        {

        }

        private void Populate_Tables()
        {

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand com = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", connection))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        TablesList.Items.Clear();
                        while (reader.Read())
                        {
                            TablesList.Items.Add((string)reader["TABLE_NAME"]);
                        }
                    }
                }
            }
        }

        private void Fill_Grid()
        {
            string SelectedValue = TablesList.SelectedItem.ToString();
            string select = "SELECT * FROM " + SelectedValue;

            using (connection = new SqlConnection(connectionString))
            using(SqlDataAdapter adapter= new SqlDataAdapter(select,connection))
            {
                connection.Open();

                SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Fill_Grid_pom()
        {
            string SelectedValue = TableListAdv.SelectedItem.ToString();
            string select = "SELECT * FROM " + SelectedValue;

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(select, connection))
            {
                connection.Open();

                SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Fill_Grid_Insert()
        {
            string SelectedValue = TableInsertList.SelectedItem.ToString();
            string select = "SELECT * FROM " + SelectedValue;

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(select, connection))
            {
                connection.Open();

                SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Fill_Grid_Adv()
        {
            if (textBox1.Text != "")
            {
                string TextValue = textBox1.Text;
                string SelectedValue = TableListAdv.SelectedItem.ToString();
                string select = "SELECT * FROM " + SelectedValue +
                    " WHERE " + TextValue + " ;";

                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(select, connection))
                {
                    connection.Open();
                    SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapter);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void Fill_Grid_Insert_main()
        {
            if (textBox2.Text != "")
            {
                string TextValue = textBox2.Text;
                string SelectedValue = TableInsertList.SelectedItem.ToString();
                string select = "INSERT INTO " + SelectedValue +
                    " VALUES (" + TextValue + ") ;";

                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(select, connection))
                {
                    connection.Open();
                    SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapter);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                }
            }
        }

        private void Fill_Grid_Delete_main()
        {
            if (textBox3.Text != "")
            {
                string TextValue = textBox3.Text;
                string SelectedValue = TableDeleteList.SelectedItem.ToString();
                string select = "DELETE FROM " + SelectedValue +
                    " WHERE " + TextValue + " ;";

                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(select, connection))
                {
                    connection.Open();
                    SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapter);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                }
            }
        }

        private void Fill_Grid_Delete()
        {
            string SelectedValue = TableDeleteList.SelectedItem.ToString();
            string select = "SELECT * FROM " + SelectedValue;

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(select, connection))
            {
                connection.Open();

                SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void AdvancedOptions_Click(object sender, EventArgs e)
        {
            TableInsertList.Enabled = false;
            AdvancedOptions.Enabled = false;
            SimpleOptions.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = false;
            label7.Enabled = false;
            TableListAdv.Enabled = true;
            textBox1.Enabled = true;
            FindButton.Enabled = false;
            InsertButton.Enabled = true;
            TablesList.Enabled = false;
            TablesList.Items.Clear();
            TableInsertList.Items.Clear();
            InsertData.Enabled = false;
            label8.Enabled = false;
            label9.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            label10.Enabled = false;
            label11.Enabled = false;
            label12.Enabled = false;
            TableDeleteList.Enabled = false;
            TableDeleteList.Items.Clear();
            Button_Delete.Enabled = true;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand com = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", connection))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        TableListAdv.Items.Clear();
                        while (reader.Read())
                        {
                            TableListAdv.Items.Add((string)reader["TABLE_NAME"]);
                        }
                    }
                }
            }
        }

        private void SimpleOptions_Click(object sender, EventArgs e)
        {
            TablesList.Enabled = true;
            AdvancedOptions.Enabled = true;
            SimpleOptions.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            TableListAdv.Enabled = false;
            TableInsertList.Enabled = false;
            textBox1.Enabled = false;
            TableListAdv.Items.Clear();
            TableInsertList.Items.Clear();
            FindButtonAdv.Enabled = false;
            InsertButton.Enabled = true;
            InsertData.Enabled = false;
            label8.Enabled = false;
            label9.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            label10.Enabled = false;
            label11.Enabled = false;
            label12.Enabled = false;
            TableDeleteList.Enabled = false;
            TableDeleteList.Items.Clear();
            Button_Delete.Enabled = true;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand com = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", connection))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        TablesList.Items.Clear();
                        while (reader.Read())
                        {
                            TablesList.Items.Add((string)reader["TABLE_NAME"]);
                        }
                    }
                }
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            Fill_Grid();
        }

        private void FindButtonAdv_Click(object sender, EventArgs e)
        {
            Fill_Grid_Adv();
        }

        private void TableListAdv_SelectedValueChanged(object sender, EventArgs e)
        {
            FindButtonAdv.Enabled = true;
            Fill_Grid_pom();
        }

        private void TablesList_SelectedValueChanged(object sender, EventArgs e)
        {
            FindButton.Enabled = true;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {

            InsertButton.Enabled = false;
            label6.Enabled = true;
            label7.Enabled = true;
            TableInsertList.Enabled = true;
            SimpleOptions.Enabled = true;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            TableListAdv.Enabled = false;
            textBox1.Enabled = false;
            TableListAdv.Items.Clear();
            TablesList.Items.Clear();
            TablesList.Enabled = false;
            FindButtonAdv.Enabled = false;
            AdvancedOptions.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            label10.Enabled = false;
            label11.Enabled = false;
            label12.Enabled = false;
            TableDeleteList.Enabled = false;
            TableDeleteList.Items.Clear();
            Button_Delete.Enabled = true;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand com = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", connection))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        TableInsertList.Items.Clear();
                        while (reader.Read())
                        {
                            TableInsertList.Items.Add((string)reader["TABLE_NAME"]);
                        }
                    }
                }
            }

        }

        private void TableInsertList_SelectedValueChanged(object sender, EventArgs e)
        {
            InsertData.Enabled = true;
            Fill_Grid_Insert();
        }

        private void InsertData_Click(object sender, EventArgs e)
        {
            Fill_Grid_Insert_main();
        }

        private void TableDeleteList_SelectedValueChanged(object sender, EventArgs e)
        {
            Fill_Grid_Delete();
            DeleteButton.Enabled = true;
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            Button_Delete.Enabled = false;
            InsertButton.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            TableInsertList.Enabled = false;
            SimpleOptions.Enabled = true;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            TableListAdv.Enabled = false;
            textBox1.Enabled = false;
            TableListAdv.Items.Clear();
            TablesList.Items.Clear();
            TablesList.Enabled = false;
            FindButtonAdv.Enabled = false;
            AdvancedOptions.Enabled = true;
            label8.Enabled = false;
            label9.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = true;
            label10.Enabled = true;
            label11.Enabled = true;
            label12.Enabled = true;
            InsertButton.Enabled = true;
            TableInsertList.Items.Clear();
            TableDeleteList.Enabled = true;
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand com = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", connection))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        TableListAdv.Items.Clear();
                        while (reader.Read())
                        {
                            TableDeleteList.Items.Add((string)reader["TABLE_NAME"]);
                        }
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Fill_Grid_Delete_main();
        }
    }
}
