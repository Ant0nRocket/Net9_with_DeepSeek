namespace T_0001_Code;

class Program
{
    static void Main(string[] args)
    {
        int number = 10; // 1
        Person person = new Person(); // 2
        person.Name = "Anton"; // 3
    }
}

class Person
{
    public string Name { get; set; }
}