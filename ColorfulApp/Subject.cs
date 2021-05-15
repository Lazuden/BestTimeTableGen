namespace ColorfulApp
{
    public class Subject
    {
        public string Name { get; set; }
        public bool IsTechnicalSubject { get; set; }

        public Subject(string name, bool tech = false)
        {
            Name = name;
            IsTechnicalSubject = tech;
        }
    }
}
