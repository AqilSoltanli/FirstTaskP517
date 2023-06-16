
#region task1
Console.WriteLine("score deyer teyin edin");
int score = int.Parse(Console.ReadLine());

if (score >= 88 && score <= 100)
{
    Console.WriteLine("Success - AA");
}
else if (score >= 81 && score < 88)
{
    Console.WriteLine("Success - BA");
}
else if (score >= 74 && score < 81)
{
    Console.WriteLine("Success - BB");
}
else if (score >= 67 && score < 74)
{
    Console.WriteLine("Success - CB");
}
else if (score >= 60 && score < 67)
{
    Console.WriteLine("Success - CC");
}
else if (score >= 0 && score < 60)
{
    Console.WriteLine("Fail - FF");
}
else
{
    Console.WriteLine("Invalid score");
}
#endregion

#region Task2
Console.WriteLine("commandi daxil edin.command start stop ve ya wait ola biler");
string command = Console.ReadLine();

switch (command)
{
    case "start":
        Console.WriteLine("Game is starting");
        break;

    case "stop":
        Console.WriteLine("Game stopped");
        break;
    case "wait":
        Console.WriteLine("Game paused");
        break;
    default:
        Console.WriteLine("Command not found");
        break;
};
#endregion

#region task3
Console.WriteLine("ededi daxil edin");
int value = int.Parse(Console.ReadLine());
int i;
int sum = 0;

for (i = 1; i <= value; i++)
{
    sum += i;
}

Console.WriteLine("Total sum: " + sum);
Console.ReadLine();
#endregion

#region task4
int n = 1;
while (n <= 100)
{
    n++;
    if (n % 3 == 0 || n % 5 == 0)
    {
        Console.WriteLine(n);
    }
}
#endregion