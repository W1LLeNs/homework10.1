Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть ім'я та прізвище через пробіл: ");
string input = Console.ReadLine();

if (!string.IsNullOrEmpty(input))
{
    string[] parts = input.Split(' ');

    if (parts.Length >= 2)
    {
        string firstName = parts[0];
        string lastName = parts[1];

        if (char.ToLower(firstName[0]) == char.ToLower(lastName[0]))
        {
            Console.WriteLine($"Перша літера ({firstName[0]}) однакова!");
        }
        else
        {
            Console.WriteLine($"Перші літери ({firstName[0]}) та ({lastName[0]}) різні!");
        }
    }
}
else
{
    Console.WriteLine("Рядок не може бути порожнім!");
}