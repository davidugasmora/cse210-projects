class Program
{
    public static void Main(string[] args)
    {
        // Person myPerson = new Person("Bubba", "Bob", 53);
        // Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceman = new PoliceMan("Cooper", "Silver", 34, "club", 56, 87);
        // Console.WriteLine(myPoliceman.GetPersonInformation());
        // Console.WriteLine(myPoliceman.GetPoliceManInforamtion());

        Doctor myDoctor = new Doctor("Bob", "Payne", 56, "Hammer", 450000);
        // Console.WriteLine(myDoctor.GetDoctorInforamtion());

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPoliceman);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }
    }

    private static void DisplayPersonInformation(Person person)
    {
        Console.Write(person.GetPersonInformation());
        Console.WriteLine($" :: Salary: {person.GetSalary()}");
    }
}