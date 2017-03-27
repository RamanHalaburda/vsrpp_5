using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace vsrpp_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /*
            Разработайте MDI – приложение, позволяющее вводить
            информацию о студентах: фамилия, имя, факультет, группа. Приложение
            должно обеспечивать возможность создания для каждого студента своей
            формы. Организовать сохранение информации в файл.
        */

        public String fileName = "file_students.txt";

        // Add and Close
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                FileStream file = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(file);

                sw.WriteLine(String.Concat(
                    label1.Text, " ", textBox1.Text, " ",
                    label2.Text, " ", textBox2.Text, " ",
                    label3.Text, " ", textBox3.Text, " ",
                    label4.Text, " ", textBox4.Text));
                
                sw.Close();
                file.Close();

                this.Close();
            }            
        }
    }
}
