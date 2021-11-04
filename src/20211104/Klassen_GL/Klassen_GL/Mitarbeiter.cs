using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_GL
{
    class Mitarbeiter
    {
        public string Name;

        public void ChangeName(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                Name = newName;
            }
        }
    }
}
