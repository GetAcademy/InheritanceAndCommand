using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndCommand
{
    public class ShowCommand : Command
    {
        private Stats _stats;

        public ShowCommand(Stats stats, string commandName) : base(commandName)
        {
            _stats = stats;
        }

        public override void Run()
        {
            base.Run();
            Console.WriteLine(_stats.GetStats());
        }
    }
}
