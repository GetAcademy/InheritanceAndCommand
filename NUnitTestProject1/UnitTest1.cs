using InterfaceAndCommand;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var showCommand = new ShowCommand(new Stats());
            showCommand.Run();
        }
    }
}