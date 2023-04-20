using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace STUDENTFILE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            //=C:\Users\Asus\Desktop\STUDENTFILE\STUDENTFILE\bin\Debug
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ currentDirectory +@"\Database\StudentDataBase.mdf;Integrated Security=True;Connect Timeout=30";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO StudentDataBase (IDNo, LastName, FirstName, Course, YearLevel) VALUES (@value1, @value2, @value3, @value4, @value5)", connection))
                {
                    command.Parameters.AddWithValue("@value1", int.Parse(IdNumberTextbox.Text));
                    command.Parameters.AddWithValue("@value2", StudentLastNameTextBox.Text);
                    command.Parameters.AddWithValue("@value3", StudentFirstNameTextBox.Text);
                    command.Parameters.AddWithValue("@value4", courseComboBox.SelectedItem.ToString());                    
                    command.Parameters.AddWithValue("@value5", int.Parse(yearLevelComboBox.SelectedItem.ToString()));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Entries Recorded!!!");
                }

                connection.Close();
            }
        }
    }
}
