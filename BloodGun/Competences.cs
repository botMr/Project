using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodGun_PORT
{
    internal static class Competences
    {
        public static List<Blood_Gun_Competences> records = new List<Blood_Gun_Competences>
        {
            new Blood_Gun_Competences { Id=0, Name="_Test_", Check_info=false, Level_1=false, Level_2=false, Result_grade=0},
            new Blood_Gun_Competences { Id=1, Name="_placeholder_", Check_info=false, Level_1=false, Level_2=false, Result_grade=0}
        };

        public static Dictionary<String, double> BG_coefficients = new Dictionary<String, double>()
        {
            {"check_info", 0.2},
            {"level_1", 0.4},
            {"level_2", 0.5},
        };

        public static void bg_change_completion(string competence, Blood_Gun_Competences record)
        {
            Type obj = typeof(Blood_Gun_Competences);
            obj.GetProperty(competence).SetValue(record, true);
            Console.WriteLine("Changed " + competence + " to true.");
        }

        static bool filled_csv = false;

        public static void fill_competences()
        {
            // Record created from Data.cs
            records[1].Name = Data.Nick + '_' + Data.Name + '_' + Data.Group;
            if (Data.Complete > 0) { records[1].Level_1 = true; }
            if (Data.Complete > 1) { records[1].Level_2 = true; }

            foreach (var record in records)
            {
                record.Result_grade = Data.Rate;
            }
        }

        public static void fill_csv()
        {
            if (!Competences.filled_csv)
            {
                fill_competences();

                var csv_path = Path.GetFullPath(@"C:\Users\slava\Desktop\Important (but maybe not)\Project\Blood_gun_competences_data.csv");
                using (var writer = new StreamWriter(csv_path))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(records);
                }
                Competences.filled_csv = true;
            }
        }
    }

    internal class Blood_Gun_Competences
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Check_info { get; set; }
        public bool Level_1 { get; set; }
        public bool Level_2 { get; set; }
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
