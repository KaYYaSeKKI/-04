using System;

﻿using System;

namespace Lab04
{
    class City
    {
        // Поля класу
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public double AnnualIncome { get; set; }
        public double Area { get; set; }
        public bool HasPort { get; set; }
        public bool HasAirport { get; set; }

        // Метод для обчислення середнього доходу на одного мешканця
        public double IncomePerCapita()
        {
            return Population > 0 ? AnnualIncome / Population : 0;
        }

        // Метод для виводу інформації
        public void DisplayInfo()
        {
            Console.WriteLine("\nІнформація про місто:");
            Console.WriteLine($"Назва міста: {Name}");
            Console.WriteLine($"Країна: {Country}");
            Console.WriteLine($"Регіон: {Region}");
            Console.WriteLine($"Населення: {Population}");
            Console.WriteLine($"Річний дохід: {AnnualIncome}");
            Console.WriteLine($"Площа: {Area} км²");
            Console.WriteLine($"Порт: {(HasPort ? "Так" : "Ні")}");
            Console.WriteLine($"Аеропорт: {(HasAirport ? "Так" : "Ні")}");
            Console.WriteLine($"Середній дохід на одного мешканця: {IncomePerCapita():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення об'єкта міста
            City city = new City();

            // Введення даних
            Console.Write("Введіть назву міста: ");
            city.Name = Console.ReadLine();

            Console.Write("Введіть назву країни: ");
            city.Country = Console.ReadLine();

            Console.Write("Введіть назву регіону: ");
            city.Region = Console.ReadLine();

            Console.Write("Введіть кількість населення: ");
            city.Population = int.Parse(Console.ReadLine());

            Console.Write("Введіть річний дохід міста: ");
            city.AnnualIncome = double.Parse(Console.ReadLine());

            Console.Write("Введіть площу міста (км²): ");
            city.Area = double.Parse(Console.ReadLine());

            Console.Write("Чи має місто порт? (true/false): ");
            city.HasPort = bool.Parse(Console.ReadLine());

            Console.Write("Чи має місто аеропорт? (true/false): ");
            city.HasAirport = bool.Parse(Console.ReadLine());

            // Виведення результатів
            city.DisplayInfo();

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
