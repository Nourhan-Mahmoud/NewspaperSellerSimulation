using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();


        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }




        private static List<DemandDistribution> dd;
        public void read_files(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            for (int i = 0; i < lines.Length; i++)
            {
                switch (lines[i])
                {
                    case "NumOfNewspapers":
                        NumOfNewspapers = int.Parse(lines[i + 1]);
                        break;
                    case "NumOfRecords":
                        NumOfRecords = int.Parse(lines[i + 1]);
                        break;
                    case "PurchasePrice":
                        PurchasePrice = decimal.Parse(lines[i + 1]);
                        break;
                    case "ScrapPrice":
                        ScrapPrice = decimal.Parse(lines[i + 1]);
                        break;
                    case "SellingPrice":
                        SellingPrice = decimal.Parse(lines[i + 1]);
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

                        DayTypeDistributions.Add(dt1);


                        DayTypeDistribution dt2 = new DayTypeDistribution();

                        dt2.DayType = Enums.DayType.Fair;
                        dt2.Probability = dl[1];
                        dt2.CummProbability = DayTypeDistributions[0].CummProbability + dl[1];
                        dt2.MinRange = DayTypeDistributions[0].MaxRange + 1;
                        dt2.MaxRange = (int)(dt2.CummProbability * 100);
                        DayTypeDistributions.Add(dt2);

                        DayTypeDistribution dt3 = new DayTypeDistribution();
                        dt3.DayType = Enums.DayType.Poor;
                        dt3.Probability = dl[2];
                        dt3.CummProbability = DayTypeDistributions[1].CummProbability + dl[2];
                        dt3.MinRange = DayTypeDistributions[1].MaxRange + 1;
                        dt3.MaxRange = (int)(dt3.CummProbability * 100);
                        DayTypeDistributions.Add(dt3);

                        break;

                    case "DemandDistributions":
                        int cnt = 0;
                        bool overrange = false;
                        bool overrange1 = false;
                        bool overrange2 = false;
                        dd = new List<DemandDistribution>();
                        for (int x = i + 1; x < i + 8; x++) //1->8
                        {
                            string[] line = lines[x].Split(',');

                            if (cnt == 0)
                            {

                                DemandDistribution dd1 = new DemandDistribution();

                                dd1.Demand = int.Parse(line[0]);

                                DayTypeDistribution dt = new DayTypeDistribution();
                                dt.DayType = Enums.DayType.Good;
                                dt.Probability = decimal.Parse(line[1]);
                                dt.CummProbability = dt.Probability;
                                dt.MinRange = 1;
                                dt.MaxRange = (int)(decimal.Parse(line[1]) * 100);
                                dd1.DayTypeDistributions.Add(dt);

                                DayTypeDistribution dt_1 = new DayTypeDistribution();
                                dt_1.DayType = Enums.DayType.Fair;
                                dt_1.Probability = decimal.Parse(line[2]);
                                dt_1.CummProbability = dt_1.Probability;
                                dt_1.MinRange = 1;
                                dt_1.MaxRange = (int)(decimal.Parse(line[2]) * 100);
                                dd1.DayTypeDistributions.Add(dt_1);

                                DayTypeDistribution dt_2 = new DayTypeDistribution();
                                dt_2.DayType = Enums.DayType.Poor;
                                dt_2.Probability = decimal.Parse(line[3]);
                                dt_2.CummProbability = dt_2.Probability;
                                dt_2.MinRange = 1;
                                dt_2.MaxRange = (int)(decimal.Parse(line[3]) * 100);
                                dd1.DayTypeDistributions.Add(dt_2);

                                dd.Add(dd1);
                                DemandDistributions.Add(dd1);
                            }
                            else
                            {

                                DemandDistribution dd2 = new DemandDistribution();
                                dd2.Demand = int.Parse(line[0]);

                                DayTypeDistribution dt = new DayTypeDistribution();
                                dt.DayType = Enums.DayType.Good;
                                dt.Probability = decimal.Parse(line[1]);
                                dt.CummProbability = dt.Probability + dd[cnt - 1].DayTypeDistributions[0].CummProbability;

                                if (overrange == false)
                                {
                                    dt.MinRange = dd[cnt - 1].DayTypeDistributions[0].MaxRange + 1;
                                    dt.MaxRange = (int)(decimal.Parse(line[1]) * 100) + dt.MinRange - 1;
                                }

                                if (dt.MinRange > 100)
                                {
                                    dt.MaxRange = 00;
                                    dt.MinRange = 00;
                                    overrange = true;
                                }
                                dd2.DayTypeDistributions.Add(dt);

                                DayTypeDistribution dt_1 = new DayTypeDistribution();
                                dt_1.DayType = Enums.DayType.Fair;
                                dt_1.Probability = decimal.Parse(line[2]);
                                dt_1.CummProbability = dt_1.Probability + dd[cnt - 1].DayTypeDistributions[1].CummProbability;

                                if (overrange1 == false)
                                {
                                    dt_1.MinRange = dd[cnt - 1].DayTypeDistributions[1].MaxRange + 1;
                                    dt_1.MaxRange = (int)(decimal.Parse(line[2]) * 100) + dt_1.MinRange - 1;
                                }

                                if (dt_1.MinRange > 100)
                                {
                                    dt_1.MaxRange = 00;
                                    dt_1.MinRange = 00;
                                    overrange1 = true;
                                }
                                dd2.DayTypeDistributions.Add(dt_1);

                                DayTypeDistribution dt_2 = new DayTypeDistribution();
                                dt_2.DayType = Enums.DayType.Poor;
                                dt_2.Probability = decimal.Parse(line[3]);
                                dt_2.CummProbability = dt_2.Probability + dd[cnt - 1].DayTypeDistributions[2].CummProbability;

                                if (overrange2 == false)
                                {
                                    dt_2.MinRange = dd[cnt - 1].DayTypeDistributions[2].MaxRange + 1;
                                    dt_2.MaxRange = (int)(decimal.Parse(line[3]) * 100) + dt_2.MinRange - 1;
                                }
                                if (dt_2.MinRange > 100)
                                {
                                    dt_2.MaxRange = 00;
                                    dt_2.MinRange = 00;
                                    overrange2 = true;
                                }
                                dd2.DayTypeDistributions.Add(dt_2);

                                dd.Add(dd2);
                                DemandDistributions.Add(dd2);
                            }

                            cnt++;
                        }

                        break;
                    default:
                        break;
                }



            }
        }
    }
}
