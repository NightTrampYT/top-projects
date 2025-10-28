int fn = int.Parse(Console.ReadLine());
int sn = int.Parse(Console.ReadLine());
var operation = Console.ReadLine();
switch (operation)
{
    case "+":
        Console.WriteLine(fn+sn);
        break;
    case "-":
        Console.WriteLine(fn-sn);
        break;
    case "*":
        Console.WriteLine(fn*sn);
        break;
    case "/":
        if (sn != 0)
        {
            Console.WriteLine(fn/sn);
        }
        else
        {
            Console.WriteLine("Error: u can't divide by zero");
        }
        break;
}