using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using If_else_conditionals;

namespace UnitPractice
{
    [TestFixture]
    public class ProgramTest
    {
        private static string Invalid = "Invalid";

        [Test]
        public void TestMethod_NoArgumnets_Returns25()
        {
            Program Myprog = new Program();
            int MyTestresult = Myprog.Test();
            Assert.AreEqual(15, MyTestresult);
        }

        [Test]
        public void CheckValidity_GreaterThan10_ExpectInvalid()
        {
            Program Myprog = new Program();
            string MyTestresult = Myprog.CheckValidity(11);
            Assert.AreEqual(Invalid, MyTestresult);
        }

        [Test]
        public void CheckValidity_GreaterExactly10_ExpectValid()
        {
            Program Myprog = new Program();
            string MyTestresult = Myprog.CheckValidity(10);
            Assert.AreEqual(Invalid, MyTestresult);
        }


    }
}
