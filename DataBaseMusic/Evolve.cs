﻿using System;
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
    enum RowState2
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Evolve : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public Evolve()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("album", "Треки");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }


        private void RefreshDataGried(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"select * from Evolve_db";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

       

        private void Evolve_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGried(dataGridView1);
        }
    }
}
