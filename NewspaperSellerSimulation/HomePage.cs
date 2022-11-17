using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using System.IO;
using NewspaperSellerTesting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using static NewspaperSellerModels.Enums;

namespace NewspaperSellerSimulation
{
    public partial class HomePage : Form
    {
       
        private static int testCaseNum = 0;
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void testCase1_Click(object sender, EventArgs e)
        {
            
            testCaseNum = 1;

            SystemInputInformation sii = new SystemInputInformation();
            sii.Show();
        }

        private void testCase2_Click(object sender, EventArgs e)
        {
            testCaseNum = 2;

            SystemInputInformation sii = new SystemInputInformation();
            sii.Show();
        }

        private void testCase3_Click(object sender, EventArgs e)
        {
            testCaseNum = 3;

            SystemInputInformation sii = new SystemInputInformation();
            sii.Show();
        }
       
        public static int return_testCaseNum()
        {
            return testCaseNum;
        }
        
    }
}
