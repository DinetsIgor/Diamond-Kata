using DiamondKata.Exceptions;
using DiamondKata.Generators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiamondKata.Tests.Generators
{
    /// <summary>
    /// Provides unit tests for class <see cref="DiamondGenerator"/>.
    /// </summary>
    [TestClass]
    public class DiamondGeneratorTests
    {
        private DiamondGenerator _generator;

        /// <summary>
        /// Initializes the test.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            _generator = new DiamondGenerator();
        }

        /// <summary>
        /// Checks Generate method for case when char is in lower case.
        /// </summary>
        [TestMethod]
        public void Generate_CharIsInLowerCase_ShouldThrowException()
        {
            Assert.ThrowsException<DiamondValidationException>(() => _generator.Generate('d'));
        }

        /// <summary>
        /// Checks Generate method for case when char is number.
        /// </summary>
        [TestMethod]
        public void Generate_CharIsNumber_ShouldThrowException()
        {
            Assert.ThrowsException<DiamondValidationException>(() => _generator.Generate('3'));
        }

        /// <summary>
        /// Checks Generate method for case when char is special char.
        /// </summary>
        [TestMethod]
        public void Generate_CharIsSpecialChar_ShouldThrowException()
        {
            Assert.ThrowsException<DiamondValidationException>(() => _generator.Generate('#'));
        }

        /// <summary>
        /// Checks Generate method for case when char is first char of 'A..Z' sequence.
        /// </summary>
        [TestMethod]
        public void Generate_CharIsFirstCharOfSequence_ShouldSucceed()
        {
            var lines = _generator.Generate('A');
            
            Assert.AreEqual(1, lines.Count());
            Assert.AreEqual("A", lines.ElementAt(0));
        }

        /// <summary>
        /// Checks Generate method for case when char is second char of 'A..Z' sequence.
        /// </summary>
        [TestMethod]
        public void Generate_CharIsSecondCharOfSequence_ShouldSucceed()
        {
            var lines = _generator.Generate('B');

            Assert.AreEqual(3, lines.Count());
            Assert.AreEqual(" A ", lines.ElementAt(0));
            Assert.AreEqual("B B", lines.ElementAt(1));
            Assert.AreEqual(" A ", lines.ElementAt(2));
        }

        /// <summary>
        /// Checks Generate method for case when char is in the middle of 'A..Z' sequence.
        /// </summary>
        [TestMethod]
        public void Generate_CharIsInMiddleOfSequence_ShouldSucceed()
        {
            var lines = _generator.Generate('E');

            Assert.AreEqual(9, lines.Count());
            Assert.AreEqual("    A    ", lines.ElementAt(0));
            Assert.AreEqual("   B B   ", lines.ElementAt(1));
            Assert.AreEqual("  C   C  ", lines.ElementAt(2));
            Assert.AreEqual(" D     D ", lines.ElementAt(3));
            Assert.AreEqual("E       E", lines.ElementAt(4));
            Assert.AreEqual(" D     D ", lines.ElementAt(5));
            Assert.AreEqual("  C   C  ", lines.ElementAt(6));
            Assert.AreEqual("   B B   ", lines.ElementAt(7));
            Assert.AreEqual("    A    ", lines.ElementAt(8));
        }
    }
}
