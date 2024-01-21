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

namespace DataBaseMusic
{
    enum RowState1
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;


        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns() {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("track", "Трек");
            dataGridView1.Columns.Add("diskgr", "Альбом");
            dataGridView1.Columns.Add("performer", "Исполнитель");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record) 
        {
        dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState1.ModifiedNew);
        }


        private void RefreshDataGried(DataGridView dgw)
        { 
        dgw.Rows.Clear();
            string querystring = $"select * from listmus_db";
            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGried(dataGridView1);
        }


        private void Search(DataGridView dgw) {
            dgw.Rows.Clear();
            string searchString = $"select * from listmus_db where concat (id, track, diskgr, performer) like '%" + textBox_search.Text + "%' ";
            SqlCommand com= new SqlCommand(searchString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }




        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void buttonalb_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDataGried(dataGridView1);
            ClearFields();
        }
        private void ClearFields() {
            textBox_search.Text = "";
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
