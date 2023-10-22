﻿// See https://aka.ms/new-console-template for more information
using singleton;

//Singleton s1 = Singleton.GetInstance();
//Singleton s2 = Singleton.GetInstance();

//if (s1 == s2)
//{
//    Console.WriteLine("Singleton works, both variables contain the same instance.");
//}
//else
//{
//    Console.WriteLine("Singleton failed, variables contain different instances.");
//}

TestSingletonThread();

static void TestSingletonThread()
{
    // The client code.

    Console.WriteLine(
        "{0}\n{1}\n\n{2}\n",
        "If you see the same value, then singleton was reused (yay!)",
        "If you see different values, then 2 singletons were created (booo!!)",
        "RESULT:"
    );

    Thread process1 = new Thread(() =>
    {

        SingletonThread singleton = SingletonThread.GetInstance("FOO");
        Console.WriteLine(singleton.Value);
    });

    Thread process2 = new Thread(() =>
    {
        SingletonThread singleton = SingletonThread.GetInstance("BAR");
        Console.WriteLine(singleton.Value);
    });

    process1.Start();
    process2.Start();

    process1.Join();
    process2.Join();
}

static void TestSingleton()
{
    // The client code.
    Singleton s1 = Singleton.GetInstance();
    Singleton s2 = Singleton.GetInstance();

    if (s1 == s2)
    {
        Console.WriteLine("Singleton works, both variables contain the same instance.");
    }
    else
    {
        Console.WriteLine("Singleton failed, variables contain different instances.");
    }
}