using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsrpp_5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public String fileName = "file_students.txt";

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 1000;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderCell.Value = "First Name";
            dataGridView1.Columns[0].HeaderCell.Value = "Second Name";
            dataGridView1.Columns[0].HeaderCell.Value = "Faculty";
            dataGridView1.Columns[0].HeaderCell.Value = "Group";

            string[] lines = System.IO.File.ReadAllLines(fileName);

            int i = 0;
            foreach (string line in lines)
            {
                string[] words = line.Split(' ');
                dataGridView1.Rows[i].Cells[0].Value = words[2];
                dataGridView1.Rows[i].Cells[1].Value = words[5];
                dataGridView1.Rows[i].Cells[2].Value = words[7];
                dataGridView1.Rows[i].Cells[3].Value = words[9];
                i++;
            }
        }
    }
}
