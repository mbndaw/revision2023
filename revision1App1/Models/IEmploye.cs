using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision1App1.Models
{
    internal interface IEmploye
    {
        void Add(employer empl);
        employer FindByMatricule(string matricule);
        List<employer> FindAll();

    }
}
