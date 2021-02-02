using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace InterfaceAndCommand
{
    class A
    {
        public A()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public B() : base()
        {
            Console.WriteLine("B");
        }
    }

    class C : B
    {
        public C(string s) : base()
        {
            Console.WriteLine("C");
        }

        public void Run()
        {

        }
    }

    class D : C
    {
        public D() : base("kj")
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var command = new Command("kjghjh");


            var stats = new Stats();
            //var commands = new Command[]
            //{
            //    new AddNumberCommand(stats, "add"),
            //    new ResetCommand(stats, "reset"),
            //    new ShowCommand(stats, "show"),
            //};
            //ISpeak speaker = new SpeakerB();
            //speaker.Speak();
            //Console.WriteLine("Velkommen");
            //do
            //{
            //    Console.Write("Kommando: ");
            //    var commandStr = Console.ReadLine();
            //    var command = commands.FirstOrDefault(c => c.IsMatch(commandStr));
            //    command?.Run();
            //} while (true);
        }

        //static void ReflectionThing()
        //{
        //    var commandType = typeof(Command);
        //    var implementingTypes = Assembly.GetExecutingAssembly()
        //        .GetTypes()
        //        .Where(t => commandType.IsAssignableFrom(t))
        //        .Where(t =>  t != commandType);
        //    //.Where(IsSubclass);
        //    foreach (var type in implementingTypes)
        //    {
        //        Console.WriteLine(type.Name);
        //    }
        //}

        //static bool IsSubclass(Type type)
        //{
        //    return type.IsSubclassOf(typeof(ICommand));
        //}
    }
}
