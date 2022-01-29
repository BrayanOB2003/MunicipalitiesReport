using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalitiesReport.src
{
    public class Municipality
    {
        private String region;
        private String codeOfRegion;
        private String department;
        private String codeOfDepart;
        private String municipalityName;

        public Municipality(String r, String cor, String dpt, String cfd, String name)
        {
            region = r;
            codeOfRegion = cor;
            codeOfDepart = dpt;
            codeOfDepart = cfd;
            municipalityName = name;
        }

        public string Region { get => region; set => region = value; }
        public string CodeOfRegion { get => codeOfRegion; set => codeOfRegion = value; }
        public string Department { get => department; set => department = value; }
        public string CodeOfDepart { get => codeOfDepart; set => codeOfDepart = value; }
        public string MunicipalityName { get => municipalityName; set => municipalityName = value; }
    }
}
