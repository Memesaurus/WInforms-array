using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int N;
        public static int staticN;
        public static int[] staticArr;

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateArrayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                N = int.Parse(NChangeTxtBox.Text);
            }
            catch
            {
                return;
            }
            int[] Arr = new int[N];
            Program.GenerateArray(Arr, N);
            staticArr = Arr;
            staticN = N;
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
    }
}
