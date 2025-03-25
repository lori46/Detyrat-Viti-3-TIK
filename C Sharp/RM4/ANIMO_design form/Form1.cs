using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANIMO_design_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Emri", "Emri i Episodit");
            dataGridView1.Columns.Add("Sezoni", "Sezoni");
            dataGridView1.Columns.Add("Data", "Data e Transmetimit");

            dataGridView1.Rows.Add("1", "Episodi 1", "1", "2025-03-24");
            dataGridView1.Rows.Add("2", "Episodi 2", "1", "2025-03-31");
            dataGridView1.Rows.Add("3", "Episodi 3", "2", "2025-04-07");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("4", "Episodi 4", "2", "2025-04-14");
            MessageBox.Show("Episodi u shtua me sukses!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Rreshti i zgjedhur u fshi!");
            }
            else
            {
                MessageBox.Show("Ju lutem zgjidhni një rresht për të fshirë.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                row.Cells["Emri"].Value = "Episodi i Modifikuar";
                row.Cells["Sezoni"].Value = "3";
                row.Cells["Data"].Value = "2025-04-21";
                MessageBox.Show("Rreshti i zgjedhur u modifikua!");
            }
            else
            {
                MessageBox.Show("Ju lutem zgjidhni një rresht për të modifikuar.");
            }
        }
    }
}
