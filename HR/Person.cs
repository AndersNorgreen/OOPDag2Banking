namespace OOPDag2Banking.HR
{
    internal class Person
    {
        private readonly List<Person> _people;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
