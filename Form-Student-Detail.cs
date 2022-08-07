using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Note_Recording_System
{
    public partial class Form_Student_Detail : Form
    {
        public Form_Student_Detail()
        {
            InitializeComponent();
            LblNumber.Text = number;
        }

        public string number;
        public string state;
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7MQ2UGV\SQLEXPRESS;Initial Catalog=DbRecordNotes;Integrated Security=True");


        private void Form_Student_Detail_Load(object sender, EventArgs e)
        {
            LblNumber.Text = number;

            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * From LESSONTABLE where STDNO=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", number);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[2].ToString() + " " + dr[3].ToString();
                LblExam1.Text = dr[4].ToString();
                LblExam2.Text = dr[5].ToString();
                LblExam3.Text = dr[6].ToString();
                LblAverage.Text = dr[7].ToString();
                LblState.Text = dr[8].ToString();
                state = dr[8].ToString();

            }
            connection.Close();

            if( state == "True")
            {
                LblState.Text = "Passed!";
            }else if( state == "False")
            {
                LblState.Text = "Failed!";
            }

        }

    }
}
