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

namespace _2022_02_15_Nobel_dij
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""|| textBox2.Text=="" || textBox3.Text=="" ||textBox4.Text=="")
            {
                MessageBox.Show("toltson ki minden mezot");
                return;
            }

            if (int.TryParse(textBox1.Text, out int év) || év< 1989 )
            {
                MessageBox.Show("hiba! az evszam nem megfelelo");
                return;
            }

            try
            {
                StringWriter sw = new StringWriter("uj_dijazott.txt");

                sw.WriteLine("Év;Név;SzületésHalálozás;Országkód");
                sw.WriteLine(textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + textBox4.Text + ";");

                sw.Close();

            }
            catch (Exception)
            {

                MessageBox.Show($"hiba az allomany irasanal\n{ex.message}");
            }
        }
    }
}
