using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    static class Program
    {
        public static string GetArray(int[] Arr, int N)
        {
            string ArrayToText = null;
            for (int i = 0; i < N; i++)
                ArrayToText += Arr[i] + " ";
            return ArrayToText;
        }
        public static int RefreshArray(int[] _Arr, int[] Arr, int N, int _N)
        {
            Array.Resize(ref Arr, N);
            for (int i = 0; i < N; i++)
                _Arr[i] = Arr[i];
            return N;
        }

        public static int GenerateElement(Random rnd)
        {
            return rnd.Next(-100, 100);
        }


        public static void GenerateArray(int[] Arr, int N)
        {
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                Arr[i] = GenerateElement(rnd);
            }
        }


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
