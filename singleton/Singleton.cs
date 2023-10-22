using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    //It’s pretty easy to implement a sloppy Singleton. You just need to hide the constructor and implement a static creation method.
    // The same class behaves incorrectly in a multithreaded environment.
    // Multiple threads can call the creation method simultaneously and get several instances of Singleton class.

    // The Singleton class defines the `GetInstance` method that serves as an
    // alternative to constructor and lets clients access the same instance of this class over and over.

    // EN : The Singleton should always be a 'sealed' class to prevent class
    // inheritance through external classes and also through nested classes.
    public sealed class Singleton
    {
        // The Singleton's constructor should always be private to prevent direct construction calls with the `new` operator.
        private Singleton() { }

        // The Singleton's instance is stored in a static field. There there are multiple ways to initialize this field, all of them have various pros and cons.
        // In this example we'll show the simplest of these ways, which, however, doesn't work really well in multithreaded program.
        private static Singleton _instance;

        // This is the static method that controls the access to the singletoninstance.
        // On the first run, it creates a singleton object and places it into the static field.
        // On subsequent runs, it returns the client existing object stored in the static field.
        
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
