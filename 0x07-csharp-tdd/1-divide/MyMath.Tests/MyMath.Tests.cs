using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class DivideTests
    {
        [Test]
        public void divide_byzero_returnnull()
        {
            int num = 0;
            int[,]  matrix = new int[2,2]{{3, 24}, {6, 15}, {9, 25}, {21, 30}};
            int[,] results = new Matrix.Divide(matrix, num)
            Assert.AreEqual(null, results);
        }
         [Test]
        public void divide_number_returnmatrix()
        {
            int num = 3;
            int[,]  matrix = new int[2,2]{{3, 24}, {6, 15}, {9, 27}, {21, 30}};
            int[,] results = new Matrix.Divide(matrix, num);
            int [,] expected = new int[2,2]{{1,8},{2,5},{3, 9},{7, 10}};
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void matrix()
        {
            int[,] firstMatrix = null;

            int[,] newMatrix = Matrix.Divide(firstMatrix, 5);
            Assert.AreEqual(null, newMatrix);
        }

        [Test]
        public void divide()
        {
            int[,] firstMatrix = new int[2, 2] {{4, 2}, {2, 4}};

            int[,] newMatrix = Matrix.Divide(firstMatrix, 2);
            Assert.AreEqual(new int[2, 2] {{2, 1}, {2, 1}}, newMatrix);
        }
    }
}