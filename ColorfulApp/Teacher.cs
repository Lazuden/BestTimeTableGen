using System;
using System.Collections.Generic;
using System.Linq;

namespace ColorfulApp
{
    [Serializable]
    public class Teacher
    {
        public Teacher(int id, string name, HashSet<Subject> subjects)
        {
            Name = name;
            Id = id;
            Subjects = subjects;
        }

        public Teacher() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<Subject> Subjects { get; set; }

        // todo: не используется.
        public string SubjectsText => string.Join(", ", Subjects.Select(x => x.Name));
    }
}
