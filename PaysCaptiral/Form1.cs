using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaysCaptiral
{
    public partial class pays : Form
    {
        public pays()
        {
            InitializeComponent();
            string line;
            char caractere = ';'; 
            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\users\dell-optilex-3010\Documents\payss.csv", Encoding.GetEncoding("iso-8859-1"));
            while ((line = file.ReadLine()) != null)
            {
                string[] substrings = line.Split(caractere);
                pay.Items.Add(substrings[0]);
                capital.Items.Add(substrings[1]);
            }
            file.Close();
        }

        private void pay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listpays = pay.SelectedItem.ToString();
            int index = pay.SelectedIndex;
            capital.SetSelected(index, true);
            TextPay.Text = pay.SelectedItem.ToString();
            TextCapit.Text = capital.SelectedItem.ToString();
        }

        private void Ajout_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter db = new System.IO.StreamWriter(@"c:\users\dell-optilex-3010\Documents\payss.csv");

            String pay = TextPay.Text;
            string capit = TextCapit.Text;
            
            db.Close();
        }

        private void Supression_Click(object sender, EventArgs e)
        {

        }

        private void Sauvegarde_Click(object sender, EventArgs e)
        {
           
        }
    }
}
