using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredPisomkou
{
    public partial class Form1 : Form
    {
        List<Suradnice> suradnice = new List<Suradnice>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (x_textbox.Text.Trim() == string.Empty || y_textbox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Všetky polia musia byť vyplnené!");
                return;
            }
            string x_suradnica = x_textbox.Text;
            string y_suradnica = y_textbox.Text;
            int x = 0;
            int y = 0;
            if (!Int32.TryParse(x_suradnica, out x) && !Int32.TryParse(y_suradnica, out y))
            {
                MessageBox.Show("Zadajte prosím číslo!");
                return;
            }
            suradnice.Add(new Suradnice(x_suradnica, y_suradnica));
            LoadDgview();
        }

        private void LoadDgview()
        {
            suradniceDgview.Rows.Clear();
            foreach (Suradnice item in suradnice)
            {
                suradniceDgview.Rows.Add(new object[] { item.X, item.Y });
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            suradniceDgview.Rows.Clear();

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Vyberte súbor",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt"
            };

            

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (!File.Exists(openFileDialog1.FileName))
            {
                MessageBox.Show("Súbor neexistuje");
                return;
            }

            string textFromFile = File.ReadAllText(openFileDialog1.FileName).Trim();
            string[] splittedText = textFromFile.Split(new char[] { ';', '\n' });
            if (splittedText.Length % 2 != 0)
            {
                MessageBox.Show("Zlý súbor");
                return;
            }
            suradnice.Clear();
            for (int i = 0; i < splittedText.Length; i += 2)
            {
                
                suradnice.Add(new Suradnice(splittedText[i], splittedText[i+1]));
            }
            LoadDgview();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\";      
            sfd.Title = "Save text Files";
            sfd.DefaultExt = "txt";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FileName = "Suradnice.txt";

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            using (StreamWriter writer = new StreamWriter(sfd.FileName))
            {
                foreach (DataGridViewRow row in suradniceDgview.Rows)
                {
                    string x = row.Cells[0].Value.ToString();
                    string y = row.Cells[1].Value.ToString();
                    writer.Write(x + ";" + y + "\n");
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int row_index = suradniceDgview.CurrentRow.Index;
            suradnice.RemoveAt(row_index);
            LoadDgview();
        }
    }
}
