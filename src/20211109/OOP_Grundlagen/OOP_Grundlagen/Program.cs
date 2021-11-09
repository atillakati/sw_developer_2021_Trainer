
using System;
using Wifi.ConsoleTools.Misc;

namespace OOP_Grundlagen
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiter ma = new Mitarbeiter("Gandalf", Gender.Male, new DateTime(1890, 5,20));
            Mitarbeiter ma2 = new Mitarbeiter("Martha", Gender.Female, new DateTime(2001, 4, 10));

            
            //ma2.DisplayInfos();            

            DisplayEmployeeId(ma);
            DisplayEmployeeId(ma2);            

            ma.DisplayInfos();                        
        }

        static void DisplayEmployeeId(Mitarbeiter ma)
        {                       
            Console.WriteLine($"ID: {ma.Id}");
        }
    }
}
