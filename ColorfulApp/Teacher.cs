using System;
using System.Collections.Generic;
using System.Linq;

namespace ColorfulApp
{
    [Serializable]
    public class Teacher
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public HashSet<Subject> Subjects { get; set; }

        public Teacher(int id, string name, HashSet<Subject> subjects)
        {
            Name = name;
            Id = id;
            Subjects = subjects;
        }
        public Teacher()
        {

        }        
        // todo: не используется.
        public string SubjectsText => string.Join(", ", Subjects.Select(x => x.Name));
    }
}
