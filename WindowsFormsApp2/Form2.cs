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
    public partial class Form2 : Form
    {
        int N = Form1.staticN;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitialArrayLbl.Text = Program.GetArray(Form1.staticArr, Form1.staticN);             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteElementsBtn_Click(object sender, EventArgs e)
        {
            int[] Arr = new int[N];
            N = Program.RefreshArray(Arr, Form1.staticArr, Form1.staticN, N);
            int Sum = 0;
            int count = 0;
            for (int i = 0; i < N; i++)
                Sum += Arr[i];

            float AverageNumber = (float)Sum / (float)N;


            for (int i = N - 1; i >= 0; i--)
            {
                if (Arr[i] > AverageNumber)
                {
                    count++;
                    for (int k = i; k < N - 1; k++)
                    {
                        Arr[k] = Arr[k + 1];
                    }
                }
            }

            OutputArrayLbl.Text = Program.GetArray(Arr, N-count);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int n, K;
            try
            {
                n = int.Parse(NChangeTextBox.Text);
                K = int.Parse(KChangeTextbox.Text);
            }
            catch
            {
                return;
            }
            int[] Arr = new int[N];
            N = Program.RefreshArray(Arr, Form1.staticArr, Form1.staticN, N);
            Random rnd = new Random();
            Array.Resize(ref Arr, N + n);
            for (int i = 0; i < n; i++)
            {
                for (int j = N + n - 1; j > K; j--)
                    Arr[j] = Arr[j - 1];
                Arr[K] = Program.GenerateElement(rnd);
            }
            
            OutputArrayLbl.Text = Program.GetArray(Arr, Arr.Length);
        }

        private void MoveBtn_Click(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = int.Parse(NChangeTextBox.Text);
            }
            catch { return; }
            int[] Arr = new int[N];
            N = Program.RefreshArray(Arr, Form1.staticArr, Form1.staticN, N);
            int temp;

            for (int i = 0; i < n; i++)
            {
                temp = Arr[0];
                for (int j = 0; j < N - 1; j++)
                    Arr[j] = Arr[j + 1];
                Arr[N - 1] = temp;
            }
            OutputArrayLbl.Text = Program.GetArray(Arr, Arr.Length);
        }

        private void MaxElementBtn_Click(object sender, EventArgs e)
        {
            int[] Arr = new int[N];
            N = Program.RefreshArray(Arr, Form1.staticArr, Form1.staticN, N);
            int Max, IMax = 0;

            Max = -100;

            for (int i = 0; i < N; i++)
            {
                if (Arr[i] > Max && Arr[i] % 2 == 0)
                {
                    Max = Arr[i];
                    IMax = i;
                }
            }
            if (Max == Arr[0] && Arr[0] % 2 == 1)
                OutputArrayLbl.Text = "Такого элемента нет!";
            else
            {
                OutputArrayLbl.Text = "Максимальный четный элемент: " + Max + " Индекс: " + IMax;
            }
        }

        private void FlagsortBtn_Click(object sender, EventArgs e)
        {
            int[] Arr = new int[N];
            N = Program.RefreshArray(Arr, Form1.staticArr, Form1.staticN, N);
            bool SwitchFlag = ClockwiseRadio.Checked;
            bool flag;
            int temp;

            do
            {
                flag = false;
                for (int i = 0; i < N - 1; i++)
                {
                    if (SwitchFlag == false)
                    {
                        if (Arr[i] < Arr[i + 1])
                        {
                            flag = true;
                            temp = Arr[i];
                            Arr[i] = Arr[i + 1];
                            Arr[i + 1] = temp;
                        }
                    }
                    else
                    {
                        if (Arr[i] > Arr[i + 1])
                        {
                            flag = true;
                            temp = Arr[i];
                            Arr[i] = Arr[i + 1];
                            Arr[i + 1] = temp;
                        }
                    }
                }
            } while (flag);
            OutputArrayLbl.Text = Program.GetArray(Arr, Arr.Length);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
