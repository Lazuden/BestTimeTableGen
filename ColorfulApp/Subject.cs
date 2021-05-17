namespace ColorfulApp
{
    public class Subject
    {
        public string Name { get; set; }
        public bool IsTechnicalSubject { get; set; }

        public Subject(string val, bool tech = false)
        {
            Name = val;
            IsTechnicalSubject = tech;
        }

        public Subject()
        {

        }
    }
}
