using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Municipality
    {
        private String type;
        private String codeOfMunicipality;
        private String department;
        private String codeOfDepart;
        private String municipalityName;

        public Municipality(String r, String cor, String dpt, String cfd, String name)
        {
            type = r;
            codeOfMunicipality = cor;
            department = dpt;
            codeOfDepart = cfd;
            municipalityName = name;
        }

        public string CodeOfRegion { get => codeOfMunicipality; set => codeOfMunicipality = value; }
        public string Department { get => department; set => department = value; }
        public string CodeOfDepart { get => codeOfDepart; set => codeOfDepart = value; }
        public string MunicipalityName { get => municipalityName; set => municipalityName = value; }
        public string Type { get => type; set => type = value; }
    }
}
