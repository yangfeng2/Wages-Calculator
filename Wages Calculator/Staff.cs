using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wages_Calculator
{
    public class Staff
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public int TfnNumber { get; set; }
        public int Wages { get; set; }
        public string Position { get; set; }

        public DateTime MonStart;
        public DateTime MonEnd ;
        public DateTime TueStart ;
        public DateTime TueEnd ;
        public DateTime WedStart ;
        public DateTime WedEnd ;
        public DateTime ThuStart ;
        public DateTime ThuEnd ;
        public DateTime FriStart ;
        public DateTime FriEnd ;
        public DateTime SaturStart ;
        public DateTime SatEnd ;
        public DateTime SunStart ;
        public DateTime SunEnd ;

        public double MonWages;
        public double TueWages;
        public double WedWages;
        public double ThuWages;
        public double FriWages;
        public double SatWages;
        public double SunWages;

        public Staff()
        {

        }

        public Staff(string _name, string _gender, string _nationality, int _TfnNumber, int _wages, string _position)
        {
            Name = _name;
            Gender = _gender;
            Nationality = _nationality;
            TfnNumber = _TfnNumber;
            Wages = _wages;
            Position = _position;
        }

        public void CalculateWages(string day)
        {
            if (day == "Monday")
            {
                MonWages = MonEnd.Subtract(MonStart).TotalHours * Wages;
                Console.WriteLine(MonWages);
            }
            if (day == "Tuesday")
            {
                TueWages = TueEnd.Subtract(TueStart).TotalHours * Wages;
                Console.WriteLine(TueWages);
            }
            if (day == "Wednesday")
            {
                WedWages = WedEnd.Subtract(WedStart).TotalHours * Wages;
                Console.WriteLine(WedWages);

            }
            if (day == "Thursday")
            {
                ThuWages = ThuEnd.Subtract(ThuStart).TotalHours * Wages;
                Console.WriteLine(ThuWages);
            }
            if (day == "Friday")
            {
                FriWages = FriEnd.Subtract(FriStart).TotalHours * Wages;
                Console.WriteLine(FriWages);
            }
            if (day == "Saturday")
            {
                SatWages = SatEnd.Subtract(SaturStart).TotalHours * Wages;
                Console.WriteLine(SatWages);
            }
            if (day == "Sunday")
            {
                SunWages = SunEnd.Subtract(SunStart).TotalHours * Wages;
                Console.WriteLine(SunWages);
            }

        }

        public string showDetails()
        {
            string details = ("Name: "+Name+", Gender: "+Gender+", Nationality: "+Nationality+", TFN Number: "+TfnNumber+", Wages Per Hour: "+Wages+", Position: "+Position+"");
            return details;
        }

        public double totalWages()
        {
            return Math.Round(MonWages + TueWages + WedWages + ThuWages + FriWages + SatWages + SunWages,2);
        }
    }
}
