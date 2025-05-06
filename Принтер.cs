using System;

class Printer
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Type { get; set; }
    public int PrintSpeed { get; set; }
    public bool ColorPrinting { get; set; }
    public string ConnectionType { get; set; }
    public bool IsDuplex { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine("\nІнформація про принтер:");
        Console.WriteLine($"Бренд: {Brand}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Тип: {Type}");
        Console.WriteLine($"Швидкість друку: {PrintSpeed} стор./хв");
        Console.WriteLine($"Кольоровий друк: {(ColorPrinting ? "Так" : "Ні")}");
        Console.WriteLine($"Тип підключення: {ConnectionType}");
        Console.WriteLine($"Двосторонній друк: {(IsDuplex ? "Так" : "Ні")}");
    }

    public bool IsFastPrinter()
    {
        return PrintSpeed >= 30;
    }
}

class Program
{
    static void Main()
    {
        Printer printer = new Printer();

        Console.Write("Введіть бренд принтера: ");
        printer.Brand = Console.ReadLine();

        Console.Write("Введіть модель принтера: ");
        printer.Model = Console.ReadLine();

        Console.Write("Введіть тип принтера: ");
        printer.Type = Console.ReadLine();

        Console.Write("Введіть швидкість друку: ");
        printer.PrintSpeed = int.Parse(Console.ReadLine());

        Console.Write("Кольоровий друк (true/false): ");
        printer.ColorPrinting = bool.Parse(Console.ReadLine());

        Console.Write("Тип підключення: ");
        printer.ConnectionType = Console.ReadLine();

        Console.Write("Двосторонній друк (true/false): ");
        printer.IsDuplex = bool.Parse(Console.ReadLine());

        printer.PrintInfo();

        Console.WriteLine($"Цей принтер є швидким? {(printer.IsFastPrinter() ? "Так" : "Ні")}");
    }
}
