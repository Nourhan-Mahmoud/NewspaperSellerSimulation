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
        private static SimulationSystem simSys;
        private string OpenedFilePath = "";
        private static List<DemandDistribution> dd;
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            simSys = new SimulationSystem();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void testCase1_Click(object sender, EventArgs e)
        {
            OpenedFilePath = "D:\\Nourhan\\ModelingAndSimulation\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation\\TestCases\\TestCase1.txt";
            read_testcases(OpenedFilePath);
            SystemInputInformation sii = new SystemInputInformation();
            sii.Show();
        }

        private void testCase2_Click(object sender, EventArgs e)
        {
            OpenedFilePath = "D:\\Nourhan\\ModelingAndSimulation\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation\\TestCases\\TestCase2.txt";
            read_testcases(OpenedFilePath);
            SystemInputInformation sii = new SystemInputInformation();
            sii.Show();
        }

        private void testCase3_Click(object sender, EventArgs e)
        {
            OpenedFilePath = "D:\\Nourhan\\ModelingAndSimulation\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation\\TestCases\\TestCase3.txt";
            read_testcases(OpenedFilePath);
            SystemInputInformation sii = new SystemInputInformation();
            sii.Show();
        }

        private void read_testcases(string filepath)
        {
            
            string[] lines = File.ReadAllLines(filepath);
            for (int i = 0; i < lines.Length; i++)
            {
                switch (lines[i])
                {
                    case "NumOfNewspapers":
                        simSys.NumOfNewspapers = int.Parse(lines[i + 1]);
                        break;
                    case "NumOfRecords":
                        simSys.NumOfRecords = int.Parse(lines[i + 1]);
                        break;
                    case "PurchasePrice":
                        simSys.PurchasePrice = decimal.Parse(lines[i + 1]);
                        break;
                    case "ScrapPrice":
                        simSys.ScrapPrice = decimal.Parse(lines[i + 1]);
                        break;
                    case "SellingPrice":
                        simSys.SellingPrice = decimal.Parse(lines[i + 1]);
                        break;
                    case "DayTypeDistributions":
                        string s = lines[i + 1];
                        string[] l = s.Split(',');
                        decimal[] dl = new decimal[3]; 
                        for (int j = 0; j < l.Length; j++)
                        {
                            dl[j] = decimal.Parse(l[j]);
                        }
                        //simSys.DayTypeDistributions = new List<DayTypeDistribution>();
                        DayTypeDistribution dt1 = new DayTypeDistribution();
                        dt1.DayType = Enums.DayType.Good;
                        dt1.Probability = dl[0];
                        dt1.CummProbability = dl[0];
                        dt1.MinRange = 1;
                        dt1.MaxRange = (int)(dl[0] * 100);

                        simSys.DayTypeDistributions.Add(dt1);


                        DayTypeDistribution dt2 = new DayTypeDistribution();

                        dt2.DayType = Enums.DayType.Fair;
                        dt2.Probability = dl[1];
                        dt2.CummProbability = simSys.DayTypeDistributions[0].CummProbability + dl[1];
                        dt2.MinRange = simSys.DayTypeDistributions[0].MaxRange + 1;
                        dt2.MaxRange = (int)(dl[1] * 100);
                        simSys.DayTypeDistributions.Add(dt2);

                        DayTypeDistribution dt3 = new DayTypeDistribution();
                        dt3.DayType = Enums.DayType.Poor;
                        dt3.Probability = dl[2];
                        dt3.CummProbability = simSys.DayTypeDistributions[1].CummProbability + dl[2];
                        dt3.MinRange = simSys.DayTypeDistributions[1].MaxRange + 1;
                        dt3.MaxRange = (int)(dl[1] * 100);
                        simSys.DayTypeDistributions.Add(dt3);

                        break;

                    case "DemandDistributions":
                        int cnt = 0;
                        
                        dd = new List<DemandDistribution>();
                        for (int x = i+1;x < i+7; x++)
                        {
                            string[] line = lines[x].Split(',');
                            
                            if (cnt == 0)
                            {


                                dd[cnt].Demand = int.Parse(line[0]);

                                DayTypeDistribution dt = new DayTypeDistribution();
                                dt.DayType = Enums.DayType.Good;
                                dt.Probability = decimal.Parse(line[1]);
                                dt.CummProbability = dt.Probability;
                                dt.MinRange = 1;
                                dt.MaxRange = (int)(decimal.Parse(line[1]) * 100);
                                dd[cnt].DayTypeDistributions.Add(dt);

                                DayTypeDistribution dt_1 = new DayTypeDistribution();
                                dt_1.DayType = Enums.DayType.Fair;
                                dt_1.Probability = decimal.Parse(line[2]);
                                dt_1.CummProbability = dt_1.Probability;
                                dt_1.MinRange = 1;
                                dt_1.MaxRange = (int)(decimal.Parse(line[2]) * 100);
                                dd[cnt].DayTypeDistributions.Add(dt_1);

                                DayTypeDistribution dt_2 = new DayTypeDistribution();
                                dt_2.DayType = Enums.DayType.Poor;
                                dt_2.Probability = decimal.Parse(line[3]);
                                dt_2.CummProbability = dt_2.Probability;
                                dt_2.MinRange = 1;
                                dt_2.MaxRange = (int)(decimal.Parse(line[3]) * 100);
                                dd[cnt].DayTypeDistributions.Add(dt_2);

                                simSys.DemandDistributions.Add(dd[cnt]);
                            }
                            else
                            {
                                

                                dd[cnt].Demand = int.Parse(line[0]);

                                DayTypeDistribution dt = new DayTypeDistribution();
                                dt.DayType = Enums.DayType.Good;
                                dt.Probability = decimal.Parse(line[1]);
                                dt.CummProbability = dd[cnt].DayTypeDistributions[0].Probability+ dd[cnt-1].DayTypeDistributions[0].CummProbability;
                                dt.MinRange = dd[cnt-1].DayTypeDistributions[0].MaxRange +1;
                                dt.MaxRange = (int)(decimal.Parse(line[1]) * 100);
                                dd[cnt].DayTypeDistributions.Add(dt);

                                DayTypeDistribution dt_1 = new DayTypeDistribution();
                                dt_1.DayType = Enums.DayType.Fair;
                                dt_1.Probability = decimal.Parse(line[2]);
                                dt_1.CummProbability = dd[cnt].DayTypeDistributions[1].Probability + dd[cnt - 1].DayTypeDistributions[1].CummProbability;
                                dt_1.MinRange = dd[cnt - 1].DayTypeDistributions[1].MaxRange + 1;
                                dt_1.MaxRange = (int)(decimal.Parse(line[2]) * 100);
                                dd[cnt].DayTypeDistributions.Add(dt_1);

                                DayTypeDistribution dt_2 = new DayTypeDistribution();
                                dt_2.DayType = Enums.DayType.Poor;
                                dt_2.Probability = decimal.Parse(line[3]);
                                dt_2.CummProbability = dd[cnt].DayTypeDistributions[2].Probability + dd[cnt - 1].DayTypeDistributions[2].CummProbability;
                                dt_2.MinRange = dd[cnt - 1].DayTypeDistributions[2].MaxRange + 1;
                                dt_2.MaxRange = (int)(decimal.Parse(line[3]) * 100);
                                dd[cnt].DayTypeDistributions.Add(dt_2);

                                simSys.DemandDistributions.Add(dd[cnt]);
                            }

                            cnt++;
                        }
                        
                        break;
                    default:
                        break;
                }



            }
        }

        public static SimulationSystem return_simulationSystem()
        {
            return simSys;
        }
    }
}
