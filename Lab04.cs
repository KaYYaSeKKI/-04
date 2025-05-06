using System;

class Printer
{
    // Поля (характеристики принтера)
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Type { get; set; } // Лазерный, струйный и т.п.
    public int PrintSpeed { get; set; } // страниц в минуту
    public bool ColorPrinting { get; set; } // цветная печать или нет
    public string ConnectionType { get; set; } // USB, Wi-Fi и т.п.
    public bool IsDuplex { get; set; } // двусторонняя печать

    // Конструктор
    public Printer(string brand, string model, string type, int printSpeed, bool colorPrinting, string connectionType, bool isDuplex)
    {
        Brand = brand;
        Model = model;
        Type = type;
        PrintSpeed = printSpeed;
        ColorPrinting = colorPrinting;
        ConnectionType = connectionType;
        IsDuplex = isDuplex;
    }

    // Метод для отображения информации о принтере
    public void PrintInfo()
    {
        Console.WriteLine("Інформація про принтер:");
        Console.WriteLine($"Бренд: {Brand}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Тип: {Type}");
        Console.WriteLine($"Швидкість друку: {PrintSpeed} стор./хв");
        Console.WriteLine($"Кольоровий друк: {(ColorPrinting ? "Так" : "Ні")}");
        Console.WriteLine($"Тип підключення: {ConnectionType}");
        Console.WriteLine($"Двосторонній друк: {(IsDuplex ? "Так" : "Ні")}");
    }

    // Пример дополнительного метода — проверка скорости печати
    public bool IsFastPrinter()
    {
        return PrintSpeed >= 30;
    }
}

// Тест класса
class Program
{
    static void Main()
    {
        Printer printer = new Printer("HP", "LaserJet 1020", "Лазерний", 25, false, "USB", false);
        printer.PrintInfo();

        Console.WriteLine($"Цей принтер є швидким? {(printer.IsFastPrinter() ? "Так" : "Ні")}");
    }
}
