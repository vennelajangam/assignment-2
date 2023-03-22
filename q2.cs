using System;

enum DuckType { Rubber, Mallard, Redhead }

interface IDuck
{
    void Fly();
    void Quack();
    void ShowDetails();
}

class RubberDuck : IDuck
{
    public void Fly()
    {
        Console.WriteLine("Rubber ducks cannot fly.");
    }

    public void Quack()
    {
        Console.WriteLine("Squeak!");
    }

    public void ShowDetails()
    {
        Console.WriteLine("It's a rubber duck.");
    }
}

class MallardDuck : IDuck
{
    public void Fly()
    {
        Console.WriteLine("Mallard ducks fly fast.");
    }

    public void Quack()
    {
        Console.WriteLine("Quack! Quack!");
    }

    public void ShowDetails()
    {
        Console.WriteLine("It's a mallard duck.");
    }
}

class RedheadDuck : IDuck
{
    public void Fly()
    {
        Console.WriteLine("Redhead ducks fly slow.");
    }

    public void Quack()
    {
        Console.WriteLine("Quack.");
    }

    public void ShowDetails()
    {
        Console.WriteLine("it's redhead duck.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        int weight = 5;
        int numWings = 2;
        DuckType type = DuckType.Mallard;

        IDuck duck = null;

        switch (type)
        {
            case DuckType.Rubber:
                duck = new RubberDuck();
                break;
            case DuckType.Mallard:
                duck = new MallardDuck();
                break;
            case DuckType.Redhead:
                duck = new RedheadDuck();
                break;
        }

        duck.Fly();
        duck.Quack();
        duck.ShowDetails();

        Console.ReadKey();
    }
}

