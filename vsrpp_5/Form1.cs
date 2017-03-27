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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
            Разработайте MDI – приложение, позволяющее вводить
            информацию о студентах: фамилия, имя, факультет, группа. Приложение
            должно обеспечивать возможность создания для каждого студента своей
            формы. Организовать сохранение информации в файл.
        */

        // File -> New window
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 mdiChild = new Form2();
            mdiChild.MdiParent = this;
            mdiChild.Show();
        }

        // File -> Close current window
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        // File -> Exit application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Window -> Cascade Tiles
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        // Window -> Horisontally Tiles
        private void horizontallyTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        // Window -> Vertically Tiles
        private void verticallyTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        // Edit -> Copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                TextBox editTextBox = (TextBox)activeChild.ActiveControl;
                if (editTextBox != null)
                {
                    Clipboard.SetDataObject(editTextBox.SelectedText);
                }
            }
        }

        // Edit -> Paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                TextBox editTextBox = (TextBox)activeChild.ActiveControl;

                if (editTextBox != null)
                {
                    IDataObject data = Clipboard.GetDataObject();
                    if(data.GetDataPresent(DataFormats.Text))
                    {
                        editTextBox.SelectedText = data.GetData(DataFormats.Text).ToString(); 
                    }
                }
            }
        }

        // Report
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 mdiReport = new Form3();
            mdiReport.MdiParent = this;
            mdiReport.Show();
        }       
    }
}
