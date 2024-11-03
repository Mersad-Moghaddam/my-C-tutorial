Random random = new();
int minValue = 1;
int maxValue = 10;
int randomNumber = random.Next(minValue, maxValue + 1);

Console.WriteLine("What is your name?");
string name = Console.ReadLine()!;
Console.WriteLine("Enter Your Guess Number");
for(int i = 0; i < 3; i++)
{
    int guess = Convert.ToInt32(Console.ReadLine());
    if (guess == randomNumber)
    {
        Console.WriteLine("You Win! the number was " + randomNumber);
        break;
    }
    else if (guess > randomNumber)
    {
        Console.WriteLine("Your guess is too high");
    }
    else
    {
        Console.WriteLine("Your guess is too low");
    }
}

