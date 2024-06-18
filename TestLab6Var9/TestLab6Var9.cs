using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab6Variant9;
namespace TestLab6Var9
{
    [TestClass]
    public class TestLab6Var9
    {
        [TestMethod]
        public void Task1_CalculateSumPositiveElementsShadedAreaMatrix_203()
        {
            int[,] C = {
{4,9,18,12,19,2,19,19,0,},
{-9,-7,1,13,11,8,10,-4,13,},
{-5,5,9,-4,-6,-3,-3,15,9,},
{1,11,9,-7,3,15,9,13,16,},
{14,15,15,18,8,6,5,13,-3,},
{9,3,0,-5,11,-10,5,7,-9,},
{12,-3,5,10,4,-7,13,8,-3,},
{10,18,9,6,-7,17,12,16,0,},
{18,-4,17,-8,11,0,19,7,2,},
};
            int expected = 203;
            int actual = Lab6Var9.Task1(C);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task1_CalculateSumPositiveElementsShadedAreaMatrix_192()
        {
            int[,] C = {
{-2,7,1,5,-6,5,11,1,5,},
{13,-5,16,6,15,0,19,5,5,},
{6,18,10,6,8,-4,9,-2,-6,},
{14,10,14,1,-8,12,3,15,-3,},
{10,8,16,11,16,11,17,10,3,},
{-10,7,15,-5,16,10,-6,5,1,},
{19,12,19,-6,16,16,1,16,10,},
{11,1,-8,-7,-8,-10,-8,-1,17,},
{8,14,-8,18,8,18,13,8,10,},
};
            int expected = 192;
            int actual = Lab6Var9.Task1(C);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task1_CalculateSumPositiveElementsShadedAreaMatrix_156()
        {
            int[,] C = {
{7,-5,17,4,-9,-3,9,10,18,},
{3,4,5,9,-1,10,10,-9,2,},
{-10,-3,15,8,-10,-3,-2,-4,16,},
{17,-6,16,13,2,15,7,6,7,},
{18,-3,2,19,6,17,-9,3,9,},
{-4,4,-3,3,19,1,-1,3,-1,},
{-5,19,-5,10,-4,15,1,11,5,},
{-9,9,-8,10,-8,12,-8,11,14,},
{-10,-9,10,18,6,6,8,-8,11,},
};
            int expected = 156;
            int actual = Lab6Var9.Task1(C);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task1_CalculateSumPositiveElementsShadedAreaMatrix_187()
        {
            int[,] C = {
{7,2,16,16,-10,2,14,-10,14,},
{15,2,16,12,-3,0,-9,-3,0,},
{11,-7,9,7,13,-9,18,13,1,},
{13,2,-3,17,18,5,-3,0,1,},
{4,-7,10,5,1,-5,15,-4,-1,},
{14,17,4,4,-6,3,-6,11,10,},
{5,19,8,14,18,-4,-10,-9,8,},
{7,18,4,0,5,16,19,6,-7,},
{9,-4,12,3,12,7,12,-6,16,},
};
            int expected = 187;
            int actual = Lab6Var9.Task1(C);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task1_CalculateSumPositiveElementsShadedAreaMatrix_133()
        {
            int[,] C = {
{-3,5,12,3,8,-4,9,16,-1,},
{2,2,-1,0,-6,-3,-2,15,12,},
{3,8,12,-5,8,-2,8,12,2,},
{-9,2,19,-2,3,-5,0,5,19,},
{-4,11,9,-7,2,10,19,4,-8,},
{-8,-9,0,3,2,18,0,-8,-1,},
{-7,-9,16,4,14,15,14,7,3,},
{0,-6,19,-7,-10,9,-3,-9,-7,},
{-7,-1,-5,-8,-5,-6,-4,6,11,},
};
            int expected = 133;
            int actual = Lab6Var9.Task1(C);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task2_FormOneDimensionalArrayFromElementsShadedAreaMatrixLarger10_15_16_16_14_17_12_15_18_16_15()
        {
            int[,] C ={
{9,-2,6,-9,-3,-1,-5,13,-5,},
{0,1,18,9,-5,-8,1,14,18,},
{-3,13,-3,-6,17,11,-6,-1,11,},
{-9,2,-8,5,-3,-5,5,10,15,},
{3,19,9,3,10,0,13,-10,15,},
{-10,-8,-10,1,-4,7,3,2,-6,},
{11,4,0,15,16,18,7,-7,0,},
{-8,15,-6,12,-7,5,-3,17,15,},
{-2,14,-7,16,1,16,15,-6,-4,},
};
            int[] expected = { 15, 16, 16, 14, 17, 12, 15, 18, 16, 15 };
            int[] actual = Lab6Var9.Task2(C);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task2_FormOneDimensionalArrayFromElementsShadedAreaMatrixLarger10_19_12_16_15_15_19_13_13_14_19_18_17()
        {
            int[,] C ={
{1,-10,12,12,-5,6,14,16,-1,},
{15,-5,4,1,-6,17,4,-4,-8,},
{19,-2,4,-7,17,14,-2,5,7,},
{7,6,10,-4,0,10,11,15,-6,},
{4,15,-4,-7,10,8,0,1,15,},
{-7,-9,10,17,4,0,15,-6,14,},
{-6,-2,-8,18,4,9,19,-3,-1,},
{8,8,14,13,10,-1,13,19,0,},
{15,15,7,16,12,5,19,-6,4,},
};
            int[] expected = { 19, 12, 16, 15, 15, 19, 13, 13, 14, 19, 18, 17 };
            int[] actual = Lab6Var9.Task2(C);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task2_FormOneDimensionalArrayFromElementsShadedAreaMatrixLarger10_15_11_19_15_17_11_19_12()
        {
            int[,] C ={
{2,-7,1,-8,12,-10,19,-7,12,},
{7,-9,12,16,18,17,-9,8,2,},
{11,14,19,-9,1,1,0,6,-8,},
{2,10,-1,7,16,-3,9,-8,18,},
{9,3,0,-10,7,-6,15,-7,0,},
{10,4,6,-10,8,-2,0,13,-7,},
{16,0,12,19,11,-5,17,6,3,},
{3,-10,-5,4,-3,15,19,2,-5,},
{-9,11,-3,15,-4,-3,-9,9,-8,},
};
            int[] expected = { 15, 11, 19, 15, 17, 11, 19, 12 };
            int[] actual = Lab6Var9.Task2(C);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task2_FormOneDimensionalArrayFromElementsShadedAreaMatrixLarger10_16_18_14_14_12_19()
        {
            int[,] C ={
{-3,-9,4,18,-5,-9,-1,15,9,},
{16,16,18,-7,4,4,-8,-9,19,},
{13,12,13,6,10,4,10,14,5,},
{3,4,3,-1,11,17,-10,10,18,},
{-2,14,-10,8,-7,-4,-6,7,1,},
{14,4,-1,19,6,12,11,13,-10,},
{15,10,1,-10,-3,1,5,15,1,},
{-5,6,-5,-9,-7,14,5,14,-4,},
{18,-6,9,6,2,-8,-8,16,-1,},
};
            int[] expected = { 16, 18, 14, 14, 12, 19 };
            int[] actual = Lab6Var9.Task2(C);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task2_FormOneDimensionalArrayFromElementsShadedAreaMatrixLarger10_17_11_16_14_11_17_13_15()
        {
            int[,] C ={
{-7,-3,17,-5,14,15,12,12,13,},
{14,18,12,-7,-3,8,12,14,-3,},
{18,16,-2,1,10,-2,-10,4,17,},
{10,0,2,-7,14,6,19,7,14,},
{-5,0,17,4,-2,-2,-2,19,1,},
{-1,7,-8,-7,15,13,-5,5,16,},
{18,12,7,9,-5,-1,17,-9,2,},
{0,11,-7,-4,-6,9,14,7,3,},
{-1,4,7,-10,-8,10,16,11,17,},
};
            int[] expected = { 17, 11, 16, 14, 11, 17, 13, 15 };
            int[] actual = Lab6Var9.Task2(C);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3_FormOneDimensionalArrayFromNumberElementsEqualMaximumEntireMatrixEachRowShadedArea_0_0_0_0_0_0_1_1_0()
        {
            int[,] C ={
{16,3,18,-3,9,3,-7,16,-2,},
{4,4,-6,9,6,-7,11,15,-1,},
{-2,18,17,-9,-10,-5,-1,10,16,},
{9,12,5,9,4,-1,-1,11,5,},
{10,-4,9,12,-5,-6,-1,7,9,},
{1,14,-8,12,-4,15,-3,11,-7,},
{10,15,2,12,18,19,6,3,-7,},
{13,14,19,15,0,14,8,-10,8,},
{10,5,12,13,12,2,6,17,16,},
};
            int[] expected = { 0, 0, 0, 0, 0, 0, 1, 1, 0 };
            int[] actual = Lab6Var9.Task3(C);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3_FormOneDimensionalArrayFromNumberElementsEqualMaximumEntireMatrixEachRowShadedArea_0_0_0_0_0_0_0_0_0()
        {
            int[,] C ={
{9,16,6,9,-2,-7,10,-8,-6,},
{16,-4,5,16,19,11,-7,11,-9,},
{12,3,17,19,-8,3,8,17,16,},
{5,-5,4,-9,-6,1,14,13,13,},
{-1,5,10,-6,15,13,5,-8,10,},
{-7,12,-4,-9,3,-5,-10,1,-6,},
{5,9,14,-8,-10,1,-4,-6,16,},
{10,14,-8,-7,-9,-5,17,14,-5,},
{0,7,8,-7,4,-10,13,5,-6,},
};
            int[] expected = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] actual = Lab6Var9.Task3(C);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3_FormOneDimensionalArrayFromNumberElementsEqualMaximumEntireMatrixEachRowShadedArea_0_0_0_0_0_0_0_1_1()
        {
            int[,] C ={
{-1,1,2,-8,-2,1,-3,-1,2,},
{13,-10,14,7,3,14,-2,-1,-1,},
{-7,-4,-6,13,2,14,3,7,12,},
{0,8,-6,-6,10,4,-8,0,-9,},
{-2,-8,12,-6,0,-6,-10,5,12,},
{12,7,8,-4,7,7,-8,6,-5,},
{12,1,13,3,4,6,4,11,5,},
{-3,8,-5,0,4,-7,13,14,-4,},
{1,14,11,-10,12,12,-9,6,14,},
};
            int[] expected = { 0, 0, 0, 0, 0, 0, 0, 1, 1 };
            int[] actual = Lab6Var9.Task3(C);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3_FormOneDimensionalArrayFromNumberElementsEqualMaximumEntireMatrixEachRowShadedArea_0_0_0_0_0_0_0_0_1()
        {
            int[,] C ={
{-4,8,8,-6,14,-9,-10,12,-4,},
{-7,4,3,8,0,5,0,13,11,},
{13,-5,3,7,3,-10,1,13,-7,},
{10,10,6,4,2,-6,-6,-3,-8,},
{5,-1,-3,-8,-9,14,-9,3,-3,},
{6,-10,0,3,1,8,1,-3,-4,},
{-10,3,-5,8,7,-10,13,-5,-9,},
{4,4,-9,-1,4,-7,2,9,4,},
{3,11,-6,4,6,14,7,10,12,},
};
            int[] expected = { 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            int[] actual = Lab6Var9.Task3(C);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3_FormOneDimensionalArrayFromNumberElementsEqualMaximumEntireMatrixEachRowShadedArea_0_0_0_0_0_1_0_0_0()
        {
            int[,] C ={
{2,7,14,8,-7,-4,2,-1,8,},
{5,4,6,-7,-7,3,0,9,3,},
{-8,6,6,1,-1,0,2,-2,5,},
{8,3,10,1,8,-10,2,-8,13,},
{6,3,-6,8,-9,11,13,12,14,},
{14,-7,8,0,8,14,14,1,7,},
{5,-10,-2,4,-4,10,6,9,10,},
{12,-6,10,6,5,-10,5,8,-4,},
{-1,-2,5,10,2,2,0,3,-6,},
};
            int[] expected = { 0, 0, 0, 0, 0, 1, 0, 0, 0 };
            int[] actual = Lab6Var9.Task3(C);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
