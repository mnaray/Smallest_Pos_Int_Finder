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

            // MyFunction
        }
        public static int SmallestPositiveInt()
        {
            // my function

            return 1;
        }
    }
}
