using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Department
    {
        private String name;
        private int numberOfMunicipalities;

        public Department(string n, int i)
        {
            name = n;
            numberOfMunicipalities = i;
        }
        public string Name { get => name; set => name = value; }
        public int NumberOfMunicipalities { get => numberOfMunicipalities; set => numberOfMunicipalities = value; }
    }
}
