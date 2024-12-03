using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using SequenceOfNumbers;
#pragma warning disable CA1416
namespace SequenceOfNumbers.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod]
        public void Arithmetic_Generate_Test()
        {
            // Arrange
            var arithmetic = new Arithmetic(5, 1, 2);

            // Act
            var sequence = arithmetic.Generate(5);

            // Assert
            Assert.AreEqual(sequence.Count, 5); 
            for (int i = 0; i < sequence.Count; i++)
            {
                Assert.AreEqual(sequence[i], new List<double> { 1, 3, 5, 7, 9 }[i]);
            }
           
        }
        [TestMethod]
        public void Arithmetic_SumN_Test()
        {
            // Arrange
            var arithmetic = new Arithmetic(5, 1, 2);

            // Act
            var sum = arithmetic.SumN(5);

            // Assert
            Assert.AreEqual(25, sum);
        }
        [TestMethod]
        public void Geometric_Generate_Test()
        {
            // Arrange
            var geometric = new Geometric(5, 1, 2);

            // Act
            var sequence = geometric.Generate(5);

            // Assert
            Assert.AreEqual(sequence.Count, 5);
            for (int i = 0; i < sequence.Count; i++)
            {
                Assert.AreEqual(sequence[i], new List<double> { 1, 2, 4, 8, 16 }[i]);
            }
            
        }

        [TestMethod]
        public void Geometric_SumN_Test()
        {
            // Arrange
            var geometric = new Geometric(5, 1, 2);

            // Act
            var sum = geometric.SumN(5);

            // Assert
            Assert.AreEqual(31, sum); // 1 + 2 + 4 + 8 + 16 = 31
        }

        [TestMethod]
        public void Fibonacci_Generate_Test()
        {
            // Arrange
            var fibonacci = new Fibonacci(5, 0, 1);

            // Act
            var sequence = fibonacci.Generate(5);

            // Assert
            Assert.AreEqual(sequence.Count, 5);
            for (int i = 0; i < sequence.Count; i++)
            {
                Assert.AreEqual(sequence[i], new List<double> { 0, 1, 1, 2, 3 }[i]);
            }
          
        }

        [TestMethod]
        public void Fibonacci_SumN_Test()
        {
            // Arrange
            var fibonacci = new Fibonacci(5, 0, 1);

            // Act
            var sum = fibonacci.SumN(5);

            // Assert
            Assert.AreEqual(7, sum); // 0 + 1 + 1 + 2 + 3 = 7
        }

        [TestMethod]
        public void Cont_AddSequence_Test()
        {
            // Arrange
            var container = new Cont(new System.Windows.Forms.TextBox());
            var arithmetic = new Arithmetic(5, 1, 2);

            // Act
            container.AddSequence(arithmetic);

            // Assert
            Assert.IsNotNull(container.First);
            Assert.AreEqual(arithmetic, container.First?.item);
        }

        [TestMethod]
        public void Cont_RemoveSequence_Test()
        {
            // Arrange
            var container = new Cont(new System.Windows.Forms.TextBox());
            var arithmetic = new Arithmetic(5, 1, 2);
            var geometric = new Geometric(5, 1, 2);
            container.AddSequence(arithmetic);
            container.AddSequence(geometric);

            // Act
            var result = container.RemoveSequence(1);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(geometric, container.First?.item);
        }

        [TestMethod]
        public void Cont_SumAllSequences_Test()
        {
            // Arrange
            var container = new Cont(new System.Windows.Forms.TextBox());
            container.AddSequence(new Arithmetic(5, 1, 2)); // Sum = 25
            container.AddSequence(new Geometric(5, 1, 2));  // Sum = 31

            // Act
            var totalSum = container.SumAllSequences();

            // Assert
            Assert.AreEqual(56, totalSum);
        }

        [TestMethod]
        public void Cont_FindSequenceWithMaxSum_Test()
        {
            // Arrange
            var container = new Cont(new System.Windows.Forms.TextBox());
            var arithmetic = new Arithmetic(5, 1, 2); // Sum = 25
            var geometric = new Geometric(5, 1, 2);  // Sum = 31
            container.AddSequence(arithmetic);
            container.AddSequence(geometric);

            // Act
            var maxSumSequence = container.FindSequenceWithMaxSum();

            // Assert
            Assert.AreEqual(geometric, maxSumSequence);
        }
    }
#pragma warning restore CA1416
}




