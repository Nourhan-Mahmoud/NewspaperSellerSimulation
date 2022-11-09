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
    public partial class SystemInputInformation : Form
    {
        private SimulationSystem simulationSystem;
        public SystemInputInformation()
        {
            InitializeComponent();
        }

        private void PurchasePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void SystemInputInformation_Load(object sender, EventArgs e)
        {
            simulationSystem = HomePage.return_simulationSystem();

            NumOfNewspapers.Text = (simulationSystem.NumOfNewspapers).ToString();
            NumOfRecords.Text = (simulationSystem.NumOfRecords).ToString();
            PurchasePrice.Text = (simulationSystem.PurchasePrice).ToString();
            ScrapPrice.Text = (simulationSystem.ScrapPrice).ToString();
            SellingPrice.Text = (simulationSystem.SellingPrice).ToString();

            fill_table1(simulationSystem);
            fill_table2(simulationSystem);

        }

        private void fill_table1(SimulationSystem ss)
        {

            tableLayoutPanel1.Controls.Add(new Label() { Text = "Type of Newsday" }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Probability" }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Commulative Probability" }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Random Digit Assignment"}, 3, 0);

            int row = 1;
            for (int i = 0; i < 3; i++)
            {
                
                tableLayoutPanel1.Controls.Add(new Label() { Text = ss.DayTypeDistributions[i].DayType.ToString() }, 0, row);
                tableLayoutPanel1.Controls.Add(new Label() { Text = ss.DayTypeDistributions[i].Probability.ToString() }, 1, row);
                tableLayoutPanel1.Controls.Add(new Label() { Text = ss.DayTypeDistributions[i].CummProbability.ToString() }, 2, row);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "" + ss.DayTypeDistributions[i].MinRange + " - " + ss.DayTypeDistributions[i].MaxRange }, 3, row);
                row++;
            }
        }

        private void fill_table2(SimulationSystem ss)
        {
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Demand" }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Good" }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Fair" }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Poor" }, 3, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Good" }, 4, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Fair" }, 5, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Poor" }, 6, 0);

            int row = 1;
            for (int i = 0; i < 7; i++)
            {

                tableLayoutPanel1.Controls.Add(new Label() { Text = ss.DemandDistributions[i].Demand.ToString() }, 0, row);
                tableLayoutPanel1.Controls.Add(new Label() { Text = ss.DemandDistributions[i].DayTypeDistributions[0].Probability.ToString() }, 1, row);
                tableLayoutPanel1.Controls.Add(new Label() { Text = ss.DemandDistributions[i].DayTypeDistributions[1].Probability.ToString() }, 2, row);
                tableLayoutPanel1.Controls.Add(new Label() { Text = ss.DemandDistributions[i].DayTypeDistributions[2].Probability.ToString()}, 3, row);
                tableLayoutPanel1.Controls.Add(new Label() { Text = ""+ ss.DemandDistributions[i].DayTypeDistributions[0].MinRange + " - "+ ss.DemandDistributions[i].DayTypeDistributions[0].MaxRange}, 4, row);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "" + ss.DemandDistributions[i].DayTypeDistributions[1].MinRange + " - " + ss.DemandDistributions[i].DayTypeDistributions[1].MaxRange }, 5, row);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "" + ss.DemandDistributions[i].DayTypeDistributions[2].MinRange + " - " + ss.DemandDistributions[i].DayTypeDistributions[2].MaxRange }, 6, row);


                row++;
            }
        }

        private void NumOfNewspapers_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumOfRecords_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScrapPrice_TextChanged(object sender, EventArgs e)
        {

        }

        //SellingPrice 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
