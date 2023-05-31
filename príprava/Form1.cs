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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1.jun_príprava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Human> Clovek = new List<Human>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty || textBox2.Text.Trim() == string.Empty || textBox3.Text.Trim() == string.Empty || textBox4.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Všetky polia musia byť vyplnené!");
                return;
            }
            string meno = textBox1.Text;
            string priezvisko = textBox2.Text;
            string rok_narodenia = textBox3.Text;
            string robota = textBox4.Text;
            Clovek.Add(new Human(meno, priezvisko, rok_narodenia, robota));
            File.AppendAllText(@"C:\\Users\ASUS\source\repos\1.jun_príprava\zoznam.txt", textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + textBox4.Text + "; \n");
            //textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //zapísanie z listu
            dataGridView1.Rows.Clear();
            foreach (var item in Clovek)
            {
                dataGridView1.Rows.Add(new object[] { item.Meno, item.Priezvisko, item.Rok_narodenia, item.Robota });
            }

            /* //zapísanie zo súboru
            string[] lines = File.ReadAllLines(@"C:\\Users\ASUS\source\repos\1.jun_príprava\zoznam.txt");
            string[] values;
            dataGridView1.Rows.Clear();

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(';');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dataGridView1.Rows.Add(row);
            }
            */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Create(@"C:\\Users\ASUS\source\repos\1.jun_príprava\zoznam.txt").Close();
        }
    }
}
