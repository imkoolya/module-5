using System;

class Program
{
    static void Main()
    {
        var user = GetUserDetails();
        DisplayUserDetails(user);
    }

    static (string firstName, string lastName, int age, bool hasPets, string[] petNames, string[] favoriteColors) GetUserDetails()
    {
        Console.Write("Введите ваше имя: ");
        string firstName = Console.ReadLine();

        Console.Write("Введите вашу фамилию: ");
        string lastName = Console.ReadLine();

        int age = GetValidNumberFromConsole("Введите ваш возраст: ");

        Console.Write("Есть ли у вас питомец? (да/нет): ");
        bool hasPets = Console.ReadLine().ToLower() == "да";

        string[] petNames = null;
        if (hasPets)
        {
            int numPets = GetValidNumberFromConsole("Сколько у вас питомцев? ");
            petNames = GetPetNames(numPets);
        }

        int numColors = GetValidNumberFromConsole("Сколько у вас любимых цветов? ");
        string[] favoriteColors = GetFavoriteColors(numColors);

        return (firstName, lastName, age, hasPets, petNames, favoriteColors);
    }

    static int GetValidNumberFromConsole(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out number) && number > 0)
            {
                return number;
            }
            Console.WriteLine("Пожалуйста, введите корректное число.");
        }
    }

    static string[] GetPetNames(int numPets)
    {
        string[] petNames = new string[numPets];
        for (int i = 0; i < numPets; i++)
        {
            Console.Write($"Введите имя {i + 1} питомца: ");
            petNames[i] = Console.ReadLine();
        }
        return petNames;
    }

    static string[] GetFavoriteColors(int numColors)
    {
        string[] favoriteColors = new string[numColors];
        for (int i = 0; i < numColors; i++)
        {
            Console.Write($"Введите ваш любимый цвет №{i + 1}: ");
            favoriteColors[i] = Console.ReadLine();
        }
        return favoriteColors;
    }

    static void DisplayUserDetails((string firstName, string lastName, int age, bool hasPets, string[] petNames, string[] favoriteColors) user)
    {
        Console.WriteLine("\nВаши данные:");
        Console.WriteLine($"Имя: {user.firstName}");
        Console.WriteLine($"Фамилия: {user.lastName}");
        Console.WriteLine($"Возраст: {user.age}");
        Console.WriteLine($"Наличие питомца: {(user.hasPets ? "Да" : "Нет")}");
        if (user.hasPets)
        {
            Console.WriteLine("Имена питомцев: " + string.Join(", ", user.petNames));
        }
        Console.WriteLine("Любимые цвета: " + string.Join(", ", user.favoriteColors));
    }
}