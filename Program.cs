Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Введіть Прізвище: ");
string surname = Console.ReadLine();
Console.WriteLine("Введіть Ім'я: ");
string name = Console.ReadLine();

if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname))
{
    if (char.ToLower(name[0]) == char.ToLower(surname[0]))
        Console.WriteLine($"Прізвище починається на ту ж літеру ({name[0]}), що і ім’я");

    else 
        Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я!");
}