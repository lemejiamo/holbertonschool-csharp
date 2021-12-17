﻿using NUnit.Framework;

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
    }
}