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

namespace BankStuff
{
    public partial class Form1 : Form
    {

        private List<int> validnumbers = new List<int>();

        public Form1()
        {
            InitializeComponent();
            foreach (string s in (File.ReadAllText($"{Application.StartupPath}\\validnumbers.txt")).Split(new[] { Environment.NewLine }, StringSplitOptions.None))
            {
                validnumbers.Add(int.Parse(s));
            }
        }

        private int Turnintoint(string inputstring, int biggerthen = 0)
        {
            int inputnum;
            if (int.TryParse(inputstring, out inputnum) && inputnum > biggerthen) { return inputnum; }
            else if (!int.TryParse(inputstring, out inputnum) && inputstring == "") { return biggerthen; }
            else { return biggerthen - 1; }
        }

        private void checkusernumber_Click(object sender, EventArgs e)
        {
            int usernumber = Turnintoint(sevendigetinputTB.Text, 999999);
            if (validnumbers.Contains(usernumber))
            {
                MessageBox.Show("Usernumber accepted");
            }
            else
            {
                MessageBox.Show("Usernumber not accepted\nProgram terminated");
                this.Close();
            }
        }
    }
}
