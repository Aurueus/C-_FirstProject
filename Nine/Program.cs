using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Nine;

public class Programm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("TASK 1:");
        Console.WriteLine();
        List<IAnimal> animals = new List<IAnimal>();
        animals.Add(new Dog());
        animals.Add(new Cat());

        foreach (IAnimal animal in animals)
        {
            animal.MakeSound();
        }

        Console.WriteLine();
        Console.WriteLine("TASK 2");
        Console.WriteLine();

        Car car = new Car();
        car.Model = "Mercedez-Benz";
        car.Year = 2024;
        car.Start();

        Console.WriteLine();
        Console.WriteLine("TASK 3");
        Console.WriteLine();

        Document doc = new Document();
        doc.Read();
        doc.Write("Hello world!");
        doc.Read();

        Console.WriteLine();
        Console.WriteLine("TASK 4");
        Console.WriteLine();

        Console.WriteLine("Select payment method(press 1 for credit card payment | press 2 for PayPal payment)");
        int choice = int.Parse(Console.ReadLine());
        IPaymentProcessor processor;
        switch (choice)
        {
            case 1:
                processor = new CreditCardPayment();
                processor.ProcessPayment(5000);
                break;

            case 2:
                processor = new PayPalPayment();
                processor.ProcessPayment(5000);
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        Console.WriteLine();
        Console.WriteLine("TASK 5");
        Console.WriteLine();

        ILogger logger = new ConsoleLogger();
        logger.Log("Oh hi there");
        logger.LogWithTime("NVM");

        Console.WriteLine();
        Console.WriteLine("TASK 6");
        Console.WriteLine();

        List<IShape> shapes = new List<IShape>();

        shapes.Add(new Rectangle(20.3, 45.3));
        shapes.Add(new Circle(23.3));

        foreach (IShape shape in shapes)
        {
            Console.WriteLine($"The area of the shape is: {shape.GetArea()}");
        }
        Console.WriteLine();
    }
}
