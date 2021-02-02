using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndCommand
{
    public class AddNumberCommand : Command
    {
        private Stats _stats;

        public AddNumberCommand(Stats stats, string commandName)
            : base(commandName)
        {
            _stats = stats;
        }

        public override void Run()
        {
            Console.Write("Skriv tall: ");
            var numberStr = Console.ReadLine();
            var number = Convert.ToInt32(numberStr);
            _stats.AddNumber(number);
        }
    }
}
