using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndCommand
{
    public class ResetCommand:Command
    {
        private Stats _stats;

        public ResetCommand(Stats stats, string commandName):base(commandName)
        {
            _stats = stats;
        }
        public void Run()
        {
            _stats.Reset();
        }
    }
}
