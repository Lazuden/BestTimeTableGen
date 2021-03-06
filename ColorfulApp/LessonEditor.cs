namespace ColorfulApp
{
    public class LessonEditor
    {
        // todo: используется?
        public LessonEditor()
        {
            Count = 0;
        }

        public LessonEditor(Lesson les, int cnt)
        {
            Count = cnt;
            Lesson = les;
        }

        public int Count { get; set; }
        public Lesson Lesson { get; set; }
        public string Teacher => Lesson.Teacher.Name;
        public string Subject => Lesson.Subject.Name;
        public string Class => Lesson.Cls.Name;
    }
}
