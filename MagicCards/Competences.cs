using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCardPortTest
{

    internal class Competences
    {
        public List<Magic_Card_Competences> records = new List<Magic_Card_Competences>
        {
            new Magic_Card_Competences { Id=0, Name="Sonzai", Check_info=false, Level_1=true, Level_2=true,
                                         Won_battle=false, Dependent_events=false, Result_grade=1.1}
        };

        public static Dictionary<String, double> MC_coefficients = new Dictionary<String, double>()
        {
            {"check_info", 0.1},
            {"level_1", 0.2},
            {"level_2", 0.2},
            {"won_battle", 0.3},
            {"dependent_events", 0.3}
        };

        public void mc_change_completion(string competence, Magic_Card_Competences record)
        {
            Type obj = typeof(Magic_Card_Competences);
            obj.GetProperty(competence).SetValue(record, true);
            Console.WriteLine("Changed " + competence + " to true.");
        }

        public void fill_csv()
        {
            // C:\Users\slava\Desktop\Important (but maybe not)\Project
            using (var writer = new StreamWriter("C:\\Users\\slava\\Desktop\\Important (but maybe not)\\Project\\Magic_card_test.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
        }
    }

    internal class Magic_Card_Competences
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Check_info { get; set; }
        public bool Level_1 { get; set; }
        public bool Level_2 { get; set; }
        public bool Won_battle { get; set; }
        public bool Dependent_events { get; set; }
        public double Result_grade { get; set; }
    }

    public class Bool_Double_Pair
    {
        public Bool_Double_Pair(bool completion, double coeff)
        {
            Completion = completion;
            Coefficient = coeff;
        }

        public bool Completion { get; set; }
        public double Coefficient { get; set; }
    }
}
