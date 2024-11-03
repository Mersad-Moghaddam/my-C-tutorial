Console.WriteLine("What is your name?");
string name = Console.ReadLine()!;
Console.WriteLine("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is your job?");
string job = Console.ReadLine()!;
Console.WriteLine("Are you a student?");
bool isStudent = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("How many years of coding experience do you have?");
int codingAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Do you love C#?");
bool isLoveCSharp = Convert.ToBoolean(Console.ReadLine());


string love;
string student;
if (isLoveCSharp)
{
    love = "I love C#";
}
else
{
    love = "I don't love C#";
}
if (isStudent)
{
    student = "I am a student";

}
else
{
    student = "I am not a student";
}



Console.WriteLine("Enter your favorite car names (separated by commas):");
string input = Console.ReadLine()!;
string[] cars = input.Split(',');


Console.WriteLine($"Hello, my name is {name}, I am {age} years old {job},\n {love},and {student} also i have {codingAge} years of coding experience");
Console.WriteLine("My favorite cars are:");
foreach (var car in cars)
{
    Console.WriteLine(car);
}


