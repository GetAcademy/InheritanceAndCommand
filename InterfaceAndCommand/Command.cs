using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndCommand
{
    public abstract class Command
    {
        private string _name;

        protected Command(string name)
        {
            _name = name;
        }

        public abstract void Run();

        public bool IsMatch(string commandName)
        {
            return commandName.ToLower() == _name.ToLower();
        }
    }
}
