using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Ensure you have the correct using directive for Sql


namespace myCsharpSqlProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        void connectionSql()
        { 
            con = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=CsharpSqlDb;Integrated Security=True");
            da = new SqlDataAdapter("Select customerID,customerName,customerSurname,customerAge," +
                "CASE WHEN customerGender = 1 THEN 'Male' WHEN customerGender = 0 THEN 'Female' " +
                "END AS customerGender,customerBirthday,customerPhone from Customer", con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;   
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionSql();
        }

        private void add_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con .Open();    
            cmd.Connection = con;
            cmd.CommandText = "Insert into Customer (customerName,customerSurname,customerAge," +
                "customerGender,customerBirthday,customerPhone) " +
                "values (@name,@surname,@age,@gender,@birthday,@phone)";
            cmdİnformation();
            cmd.ExecuteNonQuery();  
            con.Close();    
            connectionSql(); // Refresh the DataGridView after insertion
        }


        private void delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Customer where customerID=@id";
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(IDtext.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            connectionSql(); // Refresh the DataGridView after deletion
        }

        private void update_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Update Customer set customerName=@name,customerSurname=@surname,customerAge=@age," +
                "customerGender=@gender,customerBirthday=@birthday,customerPhone=@phone where customerID=@id"; 
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(IDtext.Text));
            if (femaleRadio.Checked || maleRadio.Checked == true)
                genderİnformation();
            else
            {
                cmdİnformation();
                if ("@gender" == "true")
                    cmd.Parameters.AddWithValue("@gender", 1);
                else
                    cmd.Parameters.AddWithValue("@gender", 0);
            }

            cmd.ExecuteNonQuery();
            con.Close();
            connectionSql(); // Refresh the DataGridView after update
        }

        void cmdİnformation()
        {
            cmd.Parameters.AddWithValue("@name", nameText.Text);
            cmd.Parameters.AddWithValue("@surname", surnameText.Text);
            cmd.Parameters.AddWithValue("@age", ageText.Text);
            cmd.Parameters.AddWithValue("@birthday", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@phone", phoneNumber.Text);
        }

        void genderİnformation()
        {
            if (femaleRadio.Checked == true)
            {
                cmd.Parameters.AddWithValue("@gender", 0);
            }
            else if (maleRadio.Checked == true)
            {
                cmd.Parameters.AddWithValue("@gender", 1);
            }
            else
            {
                MessageBox.Show("Please choose your Gender");
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            IDtext.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameText.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            surnameText.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            ageText.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == 1.ToString())
            {
                maleRadio.Checked = true;
            }
            else if(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == 0.ToString())
            {
                femaleRadio.Checked = true;
            }
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            phoneNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}