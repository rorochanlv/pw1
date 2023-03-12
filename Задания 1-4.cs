
using System;

// Здесь мы создаем класс Car
class Car {
    
   public double maxSpeed;
    public string carName;
    
    // Здесь мы создаем конструктор класса, конструктор класс это метод, который ВСЕГДА вызывается при создании класса.
     public Car () 
    {
        // В конструкторе мы присваеваем нашим созданным выше переменным значения по умолчанию
        maxSpeed = 180;
        carName = "unknown";
    }
    
    // конструктор может принимать какие-либо параметры, это нужно для того,
    // чтобы записивыть в наши переменные какие-либо другие значения
    public Car (double maxSpeed, string carName)
    {
        // this -> это ключевое слово, Оно обозначает класс, в котором находится.
        // В нашем случае this это класс Car
        this.maxSpeed = maxSpeed;
        this.carName = carName;
    }
    
    // Здесь мы находим время, когда расстояние делим на скорость
    public double CalculateTime(double distance) 
    {
        return distance / maxSpeed;
    }
    
    // Здесь мы выводим наши переменные carName и maxSpeed в консоль
    public void specificationsVehicle () {
        Console.WriteLine ($"car name: {carName}");
        Console.WriteLine ($"max speed is {maxSpeed} km/h");
    }
    
}

public class Programm
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        car.specificationsVehicle();
        // Если внутри new Car() написать число и текст через запятую, то вызывится второй конструктор
        // где мы можем присваивать уже свои значения в переменные
        Car car2 = new Car(200, "Volga");
        car2.specificationsVehicle();
    }
}