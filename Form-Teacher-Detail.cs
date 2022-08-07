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
    public partial class Form_Teacher_Detail : Form
    {
        public Form_Teacher_Detail()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7MQ2UGV\SQLEXPRESS;Initial Catalog=DbRecordNotes;Integrated Security=True");


        private void Form_Teacher_Detail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbRecordNotesDataSet.LESSONTABLE' table. You can move, or remove it, as needed.
            this.lESSONTABLETableAdapter.Fill(this.dbRecordNotesDataSet.LESSONTABLE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into LESSONTABLE (STDNO,STDNAME,STDLASTNAME) values (@P1, @P2,@P3)", connection);
            command.Parameters.AddWithValue("@P1", MaskNumber.Text);
            command.Parameters.AddWithValue("@P2", TextName.Text);
            command.Parameters.AddWithValue("@P3", TextSurname.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Student saved succesfully!");
            this.lESSONTABLETableAdapter.Fill(this.dbRecordNotesDataSet.LESSONTABLE);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            MaskNumber.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            TextName.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            TextSurname.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();

            TextExam1.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            TextExam2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            TextExam3.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double average, e1, e2, e3;
            string state;
            e1 = Convert.ToDouble(TextExam1.Text);
            e2 = Convert.ToDouble(TextExam2.Text);
            e3 = Convert.ToDouble(TextExam3.Text);

            average = (e1 + e2 + e3) / 3;
            LblAverage.Text = average.ToString();

            if(average >= 50)
            {
                state = "True";
            }
            else
            {
                state = "False";
            }


            connection.Open();
            SqlCommand command = new SqlCommand("update LESSONTABLE set STDEXAM1=@P1,STDEXAM2=@P2,STDEXAM3=@P3,AVERAGE=@P4,STATE=@P5 WHERE STDNO=@P6", connection);
            command.Parameters.AddWithValue("@P1", TextExam1.Text);
            command.Parameters.AddWithValue("@P2", TextExam2.Text);
            command.Parameters.AddWithValue("@P3", TextExam3.Text);
            command.Parameters.AddWithValue("@P4", decimal.Parse(LblAverage.Text));
            command.Parameters.AddWithValue("@P5", state);
            command.Parameters.AddWithValue("@P6", MaskNumber.Text);
            command.ExecuteNonQuery();
            connection.Close();
            if(state == "True")
            {
                LblPassed.Text = "\u2713";
                LblFailed.Text = "";
            }
            else
            {
                LblPassed.Text = "";
                LblFailed.Text = "X";
            }

            MessageBox.Show("Student's Note Updated!");
            this.lESSONTABLETableAdapter.Fill(this.dbRecordNotesDataSet.LESSONTABLE);


        }
    }
}
