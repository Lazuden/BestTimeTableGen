using System;

namespace ColorfulApp
{
    [Serializable]
    public class Lesson
    {
        public Lesson(Teacher teacher, tClass tclass, Subject subject)
        {
            Teacher = teacher;
            Cls = tclass;
            Subject = subject;
            Color = 0;
            Weight = 0;
        }
       
        public int Id { get; set; }

        public Teacher Teacher { get; set; }
        public tClass Cls { get; set; }
        public Subject Subject { get; set; }

        public int Weight { get; set; } // todo: не используется.
        public int Color { get; set; } // todo: не используется.

        public string Info => $"{Cls.Name}, {Subject.Name}";

        public override string ToString() => $"{Subject.Name}, {Teacher.Name}";
    }
}
