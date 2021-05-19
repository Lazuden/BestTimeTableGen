using System;

namespace ColorfulApp
{
    [Serializable]
    public class Lesson
    {
        public override string ToString() => $"{Subject.Name}, {Teacher.Name}";
        public string Info => $"{Cls.Name}, {Subject.Name}";

        public int Color { get; set; }

        public Teacher Teacher { get; set; }

        public tClass Cls { get; set; }

        public Subject Subject { get; set; }

        // todo: используется?
        public int Weight { get; set; }
        public int Id { get; set; }

        //todo: используется?
        public Lesson()
        {
            Color = 0;
            Weight = 0;
        }

        public Lesson(Teacher teacher, tClass tclass, Subject subject) : this()
        {
            Teacher = teacher;
            Cls = tclass;
            Subject = subject;
        }

        //todo: используется?
        public Lesson(Teacher teacher, tClass tclass, Subject subject, int id) : this(teacher, tclass, subject)
        {
            Id = id;
        }
    }
}
