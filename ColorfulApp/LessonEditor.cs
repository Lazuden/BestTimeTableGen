using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorfulApp
{
    public class LessonEditor
    {
        int count;
        Lesson lesson;

        public LessonEditor()
        {
            Count = 0;
        }

        public LessonEditor(Lesson les, int cnt)
        {
            Count = cnt;
            Lesson = les;
        }

        public int Count { get => count; set => count = value; }
        public Lesson Lesson { get => lesson; set => lesson = value; }

        public string Teacher { get => lesson.Teacher.Name; }
        public string Subject { get => lesson.Subject.Name; }
        public string Class { get => lesson.Cls.Name; }
    }
}
