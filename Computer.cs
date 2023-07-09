// Структура данных

using System;
namespace project;

class Computer {
    private string? OS; //содали поле OS (операционная система)
    private int diagonal, weight;

// создаём конструктор:
    public Computer(string? OS, int diagonal, int weight){ //тут указ что прин три наших поля
        this.OS = OS;  // тут указываем, что устанавливаем знач в поля
        this.diagonal = diagonal;
        this.weight = weight;
    }


    // создаём метод:
    public void Start() => System.Console.WriteLine("Комп запущен");
}


// далее мы создаём файл ComputerApp.cs