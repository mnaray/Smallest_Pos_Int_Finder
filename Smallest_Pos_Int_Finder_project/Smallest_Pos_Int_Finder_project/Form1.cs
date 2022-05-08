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

namespace Smallest_Pos_Int_Finder_project
{
    public partial class MainWindow : Form
    {
        public string path;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            path = @"" + path_input.Text;

            string[] fileContentsString = File.ReadAllLines(path);
            int[] fileContentsInteger = Array.ConvertAll(fileContentsString, s => int.Parse(s));

            solution.Text = SmallestPositiveInt(fileContentsInteger).ToString();
        }



        public static int SmallestPositiveInt(int[] A)
        {
            int solution = 0;
            int numToCheck = 1;
            int firstPositiveIndex = 0;
            Array.Sort(A);

            foreach (int item in A)
            {
                if (item > 0)
                {
                    firstPositiveIndex = Array.IndexOf(A, item);
                    break;
                }
            }

            int[] onlyPositives = new int[A.Length - 1 - firstPositiveIndex];

            for (int i = 0; i < A.Length - 1 - firstPositiveIndex; i++)
            {
                onlyPositives[i] = A[firstPositiveIndex + i];
            }

            foreach (int item in onlyPositives)
            {
                if (numToCheck == item)
                {
                    numToCheck++;
                }
                else
                {
                    solution = numToCheck;
                }
            }

            return solution;
        }
    }
}
