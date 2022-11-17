using NewspaperSellerModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperSellerSimulation
{
    public partial class SimulationTable : Form
    {
        public SimulationTable()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SimulationTable_Load(object sender, EventArgs e)
        {
            SimulationSystem simulationSystem = new SimulationSystem();
            int testCaseNum = HomePage.return_testCaseNum();
            String OpenedFilePath = "";

            if (testCaseNum == 1)
            {
                OpenedFilePath = "D:\\Nourhan\\ModelingAndSimulation\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation\\TestCases\\TestCase1.txt";
            }
            else if (testCaseNum == 2)
            {
                OpenedFilePath = "D:\\Nourhan\\ModelingAndSimulation\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation\\TestCases\\TestCase2.txt";
            }
            else if (testCaseNum == 3)
            {
                OpenedFilePath = "D:\\Nourhan\\ModelingAndSimulation\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation\\TestCases\\TestCase3.txt";
            }
            else
            {
                MessageBox.Show("Please, choose a testcase");
            }
            simulationSystem.read_files(OpenedFilePath);
            fill_simulationtable(simulationSystem);
            fill_performance_table(simulationSystem);

        }

        private void fill_simulationtable(SimulationSystem s)
        {
            table.Controls.Add(new Label() { Text = "Day" }, 0, 0);
            table.Controls.Add(new Label() { Text = "Random Digits For Type Of Newsdays" }, 1, 0);
            table.Controls.Add(new Label() { Text = "Type Of Newsdays" }, 2, 0);
            table.Controls.Add(new Label() { Text = "Random Digit For Demand" }, 3, 0);
            table.Controls.Add(new Label() { Text = "Demand" }, 4, 0);
            table.Controls.Add(new Label() { Text = "Revenue From Sales" }, 5, 0);
            table.Controls.Add(new Label() { Text = "Lost Profit" }, 6, 0);
            table.Controls.Add(new Label() { Text = "Scrap Profit" }, 7, 0);
            table.Controls.Add(new Label() { Text = "Daily Profit" }, 8, 0);

            for (int i = 0; i < s.SimulationTable.Count; i++)
            {
                table.Controls.Add(new Label() { Text = s.SimulationTable[i].DayNo.ToString()}, 0, i + 1);
                table.Controls.Add(new Label() { Text = s.SimulationTable[i].RandomNewsDayType.ToString() }, 1, i + 1);
                table.Controls.Add(new Label() { Text = s.SimulationTable[i].NewsDayType.ToString() }, 2, i + 1);
                table.Controls.Add(new Label() { Text = s.SimulationTable[i].RandomDemand.ToString() }, 3, i + 1);
                table.Controls.Add(new Label() { Text = s.SimulationTable[i].Demand.ToString() }, 4, i + 1);
                table.Controls.Add(new Label() { Text = s.SimulationTable[i].SalesProfit.ToString() }, 5, i + 1);
                table.Controls.Add(new Label() { Text = s.SimulationTable[i].LostProfit.ToString() }, 6, i + 1);
                table.Controls.Add(new Label() { Text = s.SimulationTable[i].ScrapProfit.ToString() }, 7, i + 1);
                table.Controls.Add(new Label() { Text = s.SimulationTable[i].DailyNetProfit.ToString() }, 8, i + 1);
            }

        }

        private void fill_performance_table(SimulationSystem s)
        {
            table2.Controls.Add(new Label() { Text = "TotalSalesProfit" }, 0, 0);
            table2.Controls.Add(new Label() { Text = "TotalCost" }, 1, 0);
            table2.Controls.Add(new Label() { Text = "TotalLostProfit" }, 2, 0);
            table2.Controls.Add(new Label() { Text = "TotalScrapProfit" }, 3, 0);
            table2.Controls.Add(new Label() { Text = "TotalNetProfit" }, 4, 0);
            table2.Controls.Add(new Label() { Text = "DaysWithMoreDemand" }, 5, 0);
            table2.Controls.Add(new Label() { Text = "DaysWithUnsoldPapers" }, 6, 0);

            table2.Controls.Add(new Label() { Text = s.PerformanceMeasures.TotalSalesProfit.ToString() }, 0, 1);
            table2.Controls.Add(new Label() { Text = s.PerformanceMeasures.TotalCost.ToString() }, 1, 1);
            table2.Controls.Add(new Label() { Text = s.PerformanceMeasures.TotalLostProfit.ToString() }, 2, 1);
            table2.Controls.Add(new Label() { Text = s.PerformanceMeasures.TotalScrapProfit.ToString() }, 3, 1);
            table2.Controls.Add(new Label() { Text = s.PerformanceMeasures.TotalNetProfit.ToString() }, 4, 1);
            table2.Controls.Add(new Label() { Text = s.PerformanceMeasures.DaysWithMoreDemand.ToString() }, 5, 1);
            table2.Controls.Add(new Label() { Text = s.PerformanceMeasures.DaysWithUnsoldPapers.ToString() }, 6, 1);
        }
    

    }
}
