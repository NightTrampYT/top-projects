Random random = new Random();
Console.Write("Guess the number: ");
int secretNum = random.Next(1, 101);

int userNum = int.Parse(Console.ReadLine());
while (userNum != secretNum)
{
    if (userNum < secretNum)
    {
        Console.WriteLine("You entered number less than the secret one\nEnter new one");
        userNum = int.Parse(Console.ReadLine());
    }
    else if (userNum > secretNum)
    {
        Console.WriteLine("You entered number bigger than the secret one\nEnter new one");
        userNum = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("You're right!");