using System;
using Wifi.ConsoleTools.Misc;

namespace OOP_Grundlagen
{
    class Mitarbeiter
    {
        private Guid _id;
        private string _name;
        private Gender _geschlecht;
        private DateTime _birthday;


        //std. Konstruktor
        //public Mitarbeiter()
        //{
        //    Id = Guid.NewGuid();
        //    Geschlecht = Gender.Undefined;
        //    Name = "No Name_" + Id;
        //}

        //benutzerspezifische Konstruktor
        public Mitarbeiter(string name, Gender geschlecht, DateTime birthday)
        {
            _id = Guid.NewGuid();
            _geschlecht = geschlecht;
            _name = name;
            _birthday = birthday;
        }

        //benutzerspezifische Konstruktor
        public Mitarbeiter(Guid id, string name, Gender geschlecht, DateTime birthday)
        {
            _id = id;
            _geschlecht = geschlecht;
            _name = name;
            _birthday = birthday;
        }


        public Guid Id
        {
            get { return _id; }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public Gender Geschlecht
        {
            get { return _geschlecht; }
            set { _geschlecht = value; }
        }

        public int Alter
        {
            get { return DateTime.Now.Year - _birthday.Year; }
        }


        public void ChangeName(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                _name = newName;
            }
        }

        public void DisplayInfos()
        {
            Console.WriteLine($"    ID: [{_id}]");
            Console.WriteLine($"  Name: {_name}");
            Console.WriteLine($"Gender: {_geschlecht}");
        }
    }
}
