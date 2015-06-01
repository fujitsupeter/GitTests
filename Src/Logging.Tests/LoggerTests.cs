using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Tests
{
    [TestFixture]
    public class LoggerTests
    {
        [Test]
        public void Log_Should_Return_Logstring()
        {
            var expect = "LOG: HELLO WORLD!";

            var actual = Logger.Log("HELLO WORLD!");

            Assert.AreEqual(expect, actual);

        }

    }
}
