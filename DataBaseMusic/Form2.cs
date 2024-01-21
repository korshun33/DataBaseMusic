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
    
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form2 : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("album", "Альбом");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }


        private void RefreshDataGried(DataGridView dgw)
        {
            dgw.Rows.Clear();
            
                string querystring = $"select * from album_db";
       
            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGried(dataGridView1);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                if (e.RowIndex == 0)
                {
                    Evolve frm1 = new Evolve();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                }
                if (e.RowIndex == 1)
                {
                    Mercury frm1 = new Mercury();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                }
                if (e.RowIndex == 2)
                {
                    Origins frm1 = new Origins();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                }
                if (e.RowIndex == 3)
                {
                    JubileeRoad frm1 = new JubileeRoad();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                }
                if (e.RowIndex == 4)
                {
                    Wrongcrowd frm1 = new Wrongcrowd();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                }
                if (e.RowIndex == 5)
                {
                    Madeinheaven frm1 = new Madeinheaven();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                }
                if (e.RowIndex == 6)
                {
                    Innuendo frm1 = new Innuendo();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                }
            }
        }
    }
}
