using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePage());

            String OpenedFilePath1 = "..\\..\\TestCases\\TestCase1.txt";
            String OpenedFilePath2 = "..\\..\\TestCases\\TestCase2.txt";

            String OpenedFilePath3 = "..\\..\\TestCases\\TestCase3.txt";

            SimulationSystem system = new SimulationSystem();
            system.read_files(OpenedFilePath1);
            String testingResults = TestingManager.Test(system, Constants.FileNames.TestCase1);
            MessageBox.Show(testingResults);


            SimulationSystem system1 = new SimulationSystem();
            system1.read_files(OpenedFilePath2);
            String testingResults1 = TestingManager.Test(system1, Constants.FileNames.TestCase2);
            MessageBox.Show(testingResults1);

            SimulationSystem system2 = new SimulationSystem();
            system2.read_files(OpenedFilePath3);
            String testingResults2 = TestingManager.Test(system2, Constants.FileNames.TestCase3);
            MessageBox.Show(testingResults2);
        }
    }
}
