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

    internal static class Competences
    {
        public static List<Magic_Card_Competences> records = new List<Magic_Card_Competences>
        {
            new Magic_Card_Competences { Id=0, Name="Test", Check_info=false, Level_1=false, Level_2=false,
                                         Won_battle=false, Dependent_events=false, Result_grade=0},
            new Magic_Card_Competences { Id=1, Name="_placeholder_", Check_info=false, Level_1=false, Level_2=false,
                                         Won_battle=false, Dependent_events= false, Result_grade=0}
        };

        public static Dictionary<String, double> MC_coefficients = new Dictionary<String, double>()
        {
            {"check_info", 0.1},
            {"level_1", 0.2},
            {"level_2", 0.2},
            {"won_battle", 0.3},
            {"dependent_events", 0.3}
        };

        public static void mc_change_completion(string competence, Magic_Card_Competences record)
        {
            Type obj = typeof(Magic_Card_Competences);
            obj.GetProperty(competence).SetValue(record, true);
            Console.WriteLine("Changed " + competence + " to true.");
        }

        public static void fill_competences()
        {
            // Record created from Data.cs
            records[1].Name = Data.Name + '_' + Data.Last;
            if (Data.Lvl > 0) { records[1].Level_1 = true; }
            if (Data.Lvl > 1) { records[1].Level_2 = true; }
            if (Data.Lvl > 2) { records[1].Won_battle = true; }

            foreach (var record in records)
            {
                if (record.Level_2 && record.Won_battle)
                {
                    record.Dependent_events = true;
                }

                record.Result_grade = Data.Rang;
            }
        }

        static bool filled_csv = false;

        public static void fill_csv()
        {
            if (!Competences.filled_csv)
            {
                fill_competences();

                var csv_path = Path.GetFullPath(@"C:\Users\slava\Desktop\Important (but maybe not)\Project\Magic_card_competences_data.csv");
                using (var writer = new StreamWriter(csv_path))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(records);
                }

                Competences.filled_csv = true;
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
