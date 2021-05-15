using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorfulApp
{
    public class Subject
    {
        string name;
        bool isTechnicalSubject;

        public string Name { get => name; set => name = value; }
        public bool IsTechnicalSubject { get => isTechnicalSubject; set => isTechnicalSubject = value; }

        public Subject(string val, bool tech = false)
        {
            name = val;
            isTechnicalSubject = tech;
        }

        public Subject()
        {

        }

    }
}
