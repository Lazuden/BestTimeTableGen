using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorfulApp
{
    [Serializable]
    public class Lesson
    {
        Teacher teacher;
        tClass cls;
        Subject subject;
        int color;
        int weight;
        int id;

        public override string ToString()
        {
            return subject.Name + ", " + teacher.Name;
        }
        public string Info
        {
            get { return Cls.Name + ", " + subject.Name; }
        }
        public int Color
        {
            get { return color; }
            set { color = value; }
        }

        public Teacher Teacher
        {
            get
            {
                return teacher;
            }

            set
            {
                teacher = value;
            }
        }

        public tClass Cls
        {
            get
            {
                return cls;
            }

            set
            {
                cls = value;
            }
        }

        public Subject Subject { get => subject; set => subject = value; }
        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
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

        public Lesson()
        {
            color = 0;
            Weight = 0;
        }

        public Lesson(Teacher teacher, tClass tclass, Subject subject) : this()
        {
            this.teacher = teacher;
            cls = tclass;
            this.subject = subject;
        }

        public Lesson(Teacher teacher, tClass tclass, Subject subject, int id) : this(teacher, tclass, subject)
        {
            this.id = id;
        }
    }
}
