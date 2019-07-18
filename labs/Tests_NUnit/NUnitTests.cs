using NUnit.Framework;
using lab_22_first_test;
using Tests;
using System.Collections;

namespace Tests
{
    public class NUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10, 10, 10, 1000)]
        [TestCase(10, 11, 12, 1320)]
        [TestCase(10, 15, 20, 3000)]
        public void CubicNumbersTest(int x, int y, int z, int expected)
        {
            // arrange
            var instance = new LabWork();
            // act
            var actual = instance.CubeNumbers(x, y, z);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 10, 10, 1000)]
        [TestCase(2, 2, 2, 8)]
        public void CubicNumbersStatisticTest(int x, int y, int z, int expected)
        {
            var actual = LabWork.CubeNumbersStatic(x, y, z);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]

        public void ArrayLengthTest(int[] myArray, int expected)
        {
            var actual = LabWork.GetLengthOfArray(myArray);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 10, 20, 30, 40}, 1012)]
        public void Mega_Multiple_Coding_Loops(int[] myArray, int expected)
        {

            var actual = Eng35Tests.Mega_Multiple_Coding_Loops(myArray);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 15)]
        [TestCase(new int[] { 2, 4, 6, 8 }, 20)]
        [TestCase(new int[] { 3, 6, 9, 12 }, 30)]
        public void Sum_Of_Array(int[] myArray, int expected)
        {
            var actual = Eng35Tests.SumOfArray(myArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 4, 2, 144)]
        public void Multiply_Ans(int x, int y, int z, int expected)
        {
            var actual = Eng35Tests.Multiply(x, y, z);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        public void Three_Array(int[] myArray, int[] expected)
        {
            var actual = Eng35Tests.ThreeArray(myArray);
            Assert.AreEqual(expected, actual);
        }

        Cats Cat01 = new Cats("cat01", 10);
        Cats Cat02 = new Cats("cat02", 7);
        Cats Cat03 = new Cats("cat03", 4);
        Cats[] catArray; // = { Cat01, Cat02, Cat03 };


        [TestCase(2,10,4,2)]
        public void Divisor(int x, int y, int divisor, int expected)
        {
            var actual = Eng35Tests.How_Many_Numbers_Divisible_By(x, y, divisor);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 20, 30, 40}, 1012)]
        public void Loop_Array_Queue(int [] arr, int expected)
        {
            var actual = Eng35Tests.Array_Loop_Queue_Stack(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5,6,7,8,9,35840)]
        public void Snap_Lab_02(int n1, int n2, int n3, int n4, int n5, int expected)
        {
            var actual = Eng35Tests.Snap_Lab_02(n1, n2, n3, n4, n5);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1_000_000, 1_048_576)]
        public void Rabbit_Explosion_B1(int i, double expected)
        {
            var actual = Eng35Tests.Rabbit_Explosion_B1(i);
            Assert.AreEqual(expected, actual);
        }
    }
}