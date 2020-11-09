using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exercises_50_2018
{
    public partial class Form1 : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        List<ExerciseResult> studenti = new List<ExerciseResult>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con = new SqlConnection("Integrated Security=true;Initial Catalog=FacultyDB;Data Source = (localdb)\\MSSQLLocalDB");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM ExerciseResults";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ExerciseResult er = new ExerciseResult();
                er.GetSetID = dr.GetInt32(0);
                er.GetSetStudentName = dr.GetString(1);
                er.GetSetStudentIndex = dr.GetString(2);
                er.GetSetPoints = dr.GetInt32(3);
                studenti.Add(er);
   
            }

            for (int i = 0; i < studenti.Count; i++)
            {
                listBoxExerciseResult.Items.Add(studenti[i]);
            }
            con.Close();
        }
    }
}
