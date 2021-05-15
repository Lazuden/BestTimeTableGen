using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorfulApp
{
    [Serializable]
    public class Teacher
    {
        int id;
        string name;
        HashSet<Subject> subjects;
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string SubjectsText
        {
            get
            {
                return String.Join(", ", subjects.Select(x => x.Name));
            }
        }

        public HashSet<Subject> Subjs { get => subjects; set => subjects = value; }

        public Teacher(int id, string name, HashSet<Subject> subjects)
        {
            this.name = name;
            this.id = id;
            this.subjects = subjects;
        }
        public Teacher()
        {

        }
    }
}
