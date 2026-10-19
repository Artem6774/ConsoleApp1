using System;

class Program
{
    static void Main()
    {
        // 1. Создаём объект класса Car
        Car car = new Car();

        // 2. Задаём значения полям объекта
        car.Marka = "Жигули";
        car.Nomer = "Т144ТО";
        car.Probeg = 10350;

        // 3. Выводим данные об автомобиле на экран
        car.Show();

        // 4-5. Среднегодовой пробег при возрасте 2 года
        double avg = car.SredniyProbeg(2);
        Console.WriteLine($"Среднегодовой пробег (возраст 2 года): {avg} км/год");

        Console.ReadKey();
    }
}

class Car
{
    // Открытые поля
    public string Marka;   // марка
    public string Nomer;   // гос. номер
    public double Probeg;  // пробег, км

    // Метод показа данных об автомобиле
    public void Show()
    {
        Console.WriteLine($"Марка: {Marka}");
        Console.WriteLine($"Гос. номер: {Nomer}");
        Console.WriteLine($"Пробег: {Probeg} км");
    }

    // Метод расчёта среднегодового пробега
    // age - возраст автомобиля (передаётся параметром)
    public double SredniyProbeg(int age)
    {
        return Probeg / age;
    }
}