using System.Linq;
using FluentAssertions; 
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.ConsoleApp.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [DataTestMethod]
        [DataRow("dotnet", "core")]
        public void Given_Arguments_When_Main_Invoked_Then_It_Should_Return_Result(params string[] args)
        {
            Program.Main(args);

            Program.Model.Arguments.First().Should().Be(args.First());
        }
    }
}
