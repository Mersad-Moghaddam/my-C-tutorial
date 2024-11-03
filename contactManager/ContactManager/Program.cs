using ContactManager;

List<Contact> contacts = [];

while (true)
{
    Console.WriteLine("1.Add Contact");
    Console.WriteLine("2.Remove Contact");
    Console.WriteLine("3.Search Contact");
    Console.WriteLine("4.Contact List ");
    Console.WriteLine("5.Exite");

    Console.Write("   Please Enter Your Choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            AddContact(contacts);
            break;
        case 2:
            DeleteContact(contacts);
            break;
        case 3:
            SearchContact(contacts);
            break;
        case 4:
            DisplayContacts(contacts);
            break;
        case 5:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Input is Not Valid.");
            break;
    }
}

void AddContact(List<Contact> contacts)
{
    Console.Write("Enter Contact Name : ");
    string name = Console.ReadLine()!;

    Console.Write("Enter Contact Last Name : ");
    string lastName = Console.ReadLine()!;

    Console.Write("Enter Contact Phone Number: ");
    string phoneNumber = Console.ReadLine()!;

    Console.Write("Enter Contact Email : ");
    string email = Console.ReadLine()!;

    Contact contact = new(name, lastName, phoneNumber, email);
    contacts.Add(contact);
    Console.Clear();
    Console.WriteLine("Contact Successfully Added.");
}

void DeleteContact(List<Contact> contacts)
{
    Console.Write("Enter Contact Name : ");
    string name = Console.ReadLine()!;

    Console.Write("Enter Contact Last Name : ");
    string lastName = Console.ReadLine()!;

    Contact contact = contacts.Find(c => c.Name == name && c.LastName == lastName)!;

    if (contact != null)
    {
        contacts.Remove(contact);
        Console.Clear();
        Console.WriteLine("Contact Successfully Deleted.");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Contact Not Found.");
    }
}

void SearchContact(List<Contact> contacts)
{
    Console.Write("Enter Contact Name : ");
    string name = Console.ReadLine()!;

    Console.Write("Enter Contact Last Name : ");
    string lastName = Console.ReadLine()!;

    Contact contact = contacts.Find(c => c.Name == name && c.LastName == lastName)!;

    if (contact != null)
    {
        Console.WriteLine($"Name: {contact.Name}");
        Console.WriteLine($"Last Name : {contact.LastName}");
        Console.WriteLine($"Phone Number : {contact.PhoneNumber}");
        Console.WriteLine($"Email Address : {contact.Email}");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Contact Not Found  .");
    }
}

void DisplayContacts(List<Contact> contacts)
{
    foreach (var contact in contacts)
    {
        Console.Clear();
        Console.WriteLine($"Name: {contact.Name}");
        Console.WriteLine($"Last Name: {contact.LastName}");
        Console.WriteLine($"Phone Number : {contact.PhoneNumber}");
        Console.WriteLine($"Email Address : {contact.Email}");
        Console.WriteLine("------------------------");
    }
}

namespace ContactManager
{
    public class Contact(string name, string lastName, string phoneNumber, string email)
    {
        public string Name { get; set; } = name;
        public string LastName { get; set; } = lastName;
        public string PhoneNumber { get; set; } = phoneNumber;
        public string Email { get; set; } = email;
    }
}