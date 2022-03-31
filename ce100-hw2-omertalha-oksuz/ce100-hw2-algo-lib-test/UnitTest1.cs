using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw2_algo_lib_cs;
using ce100_hw2_algo_lib_test;


namespace ce100_hw2_algo_lib_test
{
    [TestClass]
    public class UnitTest1
    {
        //MatrixMulRecTest
        [TestMethod]
        public void MatrixMulRecTest1()
        {
            int row1 = 2, col1 = 2,
            row2 = 2, col2 = 2;
            int[,] A = {{3, 7},
                       {2, 1} };
            Class1.i = 0; Class1.j = 0; Class1.k = 0;

            int[,] B = {{4, 5},
                       {6, 1} };

            int[,] C = new int[row1, col2];

            int[,] expected = { { 54, 22 },
                              { 14, 11 } };

            Class1.multiplyMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }
    

        [TestMethod]
        public void MatrixMulRecTest2()
        {
            int row1 = 2, col1 = 2,
            row2 = 2, col2 = 2;
            int[,] A = {{9, 0},
                       {4, 8} };
            Class1.i = 0; Class1.j = 0; Class1.k = 0;

            int[,] B = {{5, 6},
                       {7, 1} };

            int[,] C = new int[row1, col2];

            int[,] expected = { { 45, 54 },
                              { 76, 32 } };

            Class1.multiplyMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }

        [TestMethod]
        public void MatrixMulRecTest3()
        {
            int row1 = 2, col1 = 2,
            row2 = 2, col2 = 2;
            int[,] A = {{5, 8},
                       {2, 9} };
            Class1.i = 0; Class1.j = 0; Class1.k = 0;

            int[,] B = {{7 ,3},
                        {6, 4} };

            int[,] C = new int[row1, col2];

            int[,] expected = { { 83, 47 },
                              { 68, 42 } };

            Class1.multiplyMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }

        //MatrixMulStrTest
        [TestMethod]
        public void MatrixMulStrTest1()
        {
            float[,] array = { { 2, 2 },
                           { 3, 3 } };
            float n = 2;               

            float[,] array2 = { { 4, 4 },
                            { 5, 5 } };

            float[,] result = { { 18, 18 },
                            { 27, 27 } };

            float[,] exp = Class1.strassen(array, array2, 2);
            CollectionAssert.AreEqual(exp, result);
        }

        [TestMethod]
        public void MatrixMulStrTest2()
        {
            float[,] array = { { 5, 1 },
                           { 2, 4 } };
            float n = 2;

            float[,] array2 = { { 3, 4 },
                            { 2, 1 } };

            float[,] result = { { 17, 21 },
                            { 14, 12 } };

            float[,] exp = Class1.strassen(array, array2, 2);
            CollectionAssert.AreEqual(exp, result);
        }

        [TestMethod]
        public void MatrixMulStrTest3()
        {
            float[,] array = { { 1, 2 },
                           { 2, 4 } };
            float n = 2;

            float[,] array2 = { { 4, 1 },
                            { 1, 4 } };

            float[,] result = { { 6, 9 },
                            { 12, 18 } };

            float[,] exp = Class1.strassen(array, array2, 2);
            CollectionAssert.AreEqual(exp, result);
        }

        //MatrixMulItrTest
        [TestMethod]
        public void MatrixMulItrTest1()
        {
            int[,] array = { { 1, 2, 3, 4 },
                           { 1, 0, 3, 2 },
                           { 1, 3, 2, 3 },
                           { 3, 3, 4, 0 } };

            int[,] array2 = { { 3, 1, 2, 4 },
                            { 2, 2, 4, 3 },
                            { 5, 1, 7, 2 },
                            { 3, 2, 4, 4 } };

            int[,] result =  { { 32, 14, 47, 32 },
                             { 24, 8, 31, 18 },
                             { 25, 12, 40, 29 },
                             { 32, 10, 46, 29 } };

            int[,] exp = Class1.multiply(array, array2, result);
            CollectionAssert.AreEqual(exp, result);
        }

        [TestMethod]
        public void MatrixMulItrTest2()
        {
            int[,] array = { { 2, 4, 1, 3 },
                           { 3, 1, 2, 4 },
                           { 1, 2, 3, 4 },
                           { 4, 3, 1, 2 } };

            int[,] array2 = { { 3, 2, 1, 4 },
                            { 3, 2, 4, 1 },
                            { 4, 1, 2, 3 },
                            { 1, 2, 4, 3 } };

            int[,] result = { { 25, 19, 32, 24 },
                            { 24, 18, 27, 31 },
                            { 25, 17, 31, 27 },
                            { 27, 19, 26, 28 } };

            int[,] exp = Class1.multiply(array, array2, result);
            CollectionAssert.AreEqual(exp, result);

        }

        [TestMethod]
        public void MatrixMulItrTest3()
        {
            int[,] array = { { 0, 1, 2, 3 },
                           { 2, 3, 1, 0 },
                           { 2, 1, 0, 3 },
                           { 1, 2, 3, 0 } };

            int[,] array2 = { { 4, 2, 0, 1 },
                            { 3, 4, 0, 2 },
                            { 0, 4, 2, 3 },
                            { 1, 3, 2, 0 } };

            int[,] result = { { 6, 21, 10, 8 },
                            { 17, 20, 2, 11 },
                            { 14, 17, 6, 4 },
                            { 10, 22, 6, 14 } };
            int[,] exp = Class1.multiply(array, array2, result);
            CollectionAssert.AreEqual (exp, result);
        }

        //QuickSoLoTest
        [TestMethod]
        public void QuickSoLoTest1()
        {
            int[] array = { 5, 3, 4, 2, 1, 0, 6, 7 };
            int n = array.Length - 1;
            int[] expected = { 0, 1, 2, 3, 4, 5, 6 ,7 };

            Class1.quickSort(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void QuickSoLoTest2()
        {
            int[] array = { 3, 7, 5, 4, 6, 2, 8 };
            int n = array.Length - 1;
            int[] expected = { 2, 3, 4, 5, 6, 7, 8 };

            Class1.quickSort(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void QuickSoLoTest3()
        {
            int[] array = { 35, 61, 98, 14, 76, 20, 50 };
            int n = array.Length - 1;
            int[] expected = { 14, 20, 35, 50, 61, 76, 98 };

            Class1.quickSort(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        //QuickSoHoTest
        [TestMethod]
        public void QuickSoHoTest1()
        {
            int[] array = { 5, 3, 4, 2, 1, 0, 6, 7 };
            int n = array.Length - 1;
            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7 };

            Class1.quickSortHo(array, 0, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSoHoTest2()
        {
            int[] array = { 3, 7, 5, 4, 6, 2, 8 };
            int n = array.Length - 1;
            int[] expected = { 2, 3, 4, 5, 6, 7, 8 };

            Class1.quickSortHo(array, 0, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSoHoTest3()
        {
            int[] array = { 35, 61, 98, 14, 76, 20, 50 };
            int n = array.Length - 1;
            int[] expected = { 14, 20, 35, 50, 61, 76, 98 };

            Class1.quickSortHo(array, 0, n);
            CollectionAssert.AreEqual(expected, array);
        }

        //RandomizedQuickSoLoTest
        [TestMethod]
        public void RandomizedQuickSoLoTest1()
        {
            int[] array = { 8, 4, 2, 6, 9, 0, 1 };
            int n = array.Length - 1;
            int[] expected = { 0, 1, 2, 4, 6, 8, 9 };

            Class1.QuickSoLo(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void RandomizedQuickSoLoTest2()
        {
            int[] array = { 54, 32, 87, 21, 44, 94, 18 };
            int n = array.Length - 1;
            int[] expected = { 18, 21, 32, 44, 54, 87, 94 };

            Class1.QuickSoLo(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void RandomizedQuickSoLoTest3()
        {
            int[] array = { 47, 14, 72, 36, 91, 65, 21 };
            int n = array.Length - 1;
            int[] expected = { 14, 21, 36, 47, 65, 72, 91 };

            Class1.QuickSoLo(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        //RandomizedQuickSoHoTest
        [TestMethod]
        public void RandomizedQuickSoHoTest1()
        {
            int[] array = { 6, 2, 8, 1, 9, 0, 3, 5 };
            int n = array.Length;
            int[] expected = { 0, 1, 2, 3, 5, 6, 8, 9 };

            Class1.randomQuicksortHoare(array, 0, n-1);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void RandomizedQuickSoHoTest2()
        {
            int[] array = { 403, 802, 107, 908, 524, 733, 236 };
            int n = array.Length;
            int[] expected = { 107, 236, 403, 524, 733, 802, 908 };

            Class1.randomQuicksortHoare(array, 0, n - 1);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void RandomizedQuickSoHoTest3()
        {
            int[] array = { 335, 662, 449, 113, 992, 556, 773, 225 };
            int n = array.Length;
            int[] expected = { 113, 225, 335, 449, 556, 662, 773, 992 };

            Class1.randomQuicksortHoare(array, 0, n - 1);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void SelectionProblem_1()
        {
            int[] arr = { 45, 22, 4, 9, 12, 10 };
            int n = arr.Length, k = 6;
            int expected = 45;
            int actual = Class1.kthSmallest(arr, 0, n - 1, k);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void SelectionProblemTest2()
        {
            int[] arr = { 25, 35, 9, 10, 17, 2 };
            int n = arr.Length, k = 1;
            int expected = 2;
            int actual = Class1.kthSmallest(arr, 0, n - 1, k);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SelectionProblemTest3()
        {
            int[] arr = { 4, 7, 11, 5, 41, 55 };
            int n = arr.Length, k = 6;
            int expected = 55;
            int actual = Class1.kthSmallest(arr, 0, n - 1, k);
            Assert.AreEqual(expected, actual);
        }
        
        //HeapSoTest
        [TestMethod]
        public void HeapSoTest1()
        {
            int[] array = new int[] { 1, 3, 4, 2, 0 };
            int n = array.Length;
            int[] expected = new int[] { 0, 1, 2, 3, 4 };

            Class1.heapSort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void HeapSoTest2()
        {
            int[] array = new int[] { 11, 22, 33, 44, 55 };
            int n = array.Length;
            int[] expected = new int[] { 11, 22, 33, 44, 55 };

            Class1.heapSort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void HeapSoTest3()
        {
            int[] array = new int[] { 20, 60, 30, 50, 40, 10 };
            int n = array.Length;
            int[] expected = new int[] { 10, 20, 30, 40, 50, 60 };

            Class1.heapSort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        //PriotyQueueWithHeapTest
        [TestMethod]
        public void PriotyQueueWithHeapTest1()
        {
            int[] arr = new int[] { 4, 1, 2, 3, 5,  };
            Class1.insert(5);
            Class1.insert(4);
            Class1.insert(3);
            Class1.insert(2);
            Class1.insert(1);
            int expected = Class1.extractMax();
            Assert.AreEqual(5, expected);
        }

        [TestMethod]
        public void PriotyQueueWithHeapTest2()
        {
            int[] arr = new int[] { 30, 40, 10, 70, 80 };
            Class1.insert(80);
            Class1.insert(70);
            Class1.insert(40);
            Class1.insert(30);
            Class1.insert(10);
            int expected = Class1.extractMax();
            Assert.AreEqual(80, expected);
        }

        [TestMethod]
        public void PriotyQueueWithHeapTest3()
        {
            int[] arr = new int[] { 917, 200, 432, 543, 511 };
            Class1.insert(917);
            Class1.insert(543);
            Class1.insert(511);
            Class1.insert(432);
            Class1.insert(200);
            int expected = Class1.extractMax();
            Assert.AreEqual(917, expected);
        }


        //CountingSoTest
        [TestMethod]
        public void CountingSoTest1()
        {
            int[] array = new int[] { 1, 4, 7, 2, 6, 5 };
            int n = array.Length;
            int[] expected = new int[] { 1, 2, 4, 5, 6, 7 };

            Class1.CountingSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSoTest2()
        {
            int[] array = { 32, 56, 18, 50, 73, 71 };
            int n = array.Length;
            int[] expected = new int[] { 18, 32, 50, 56, 71, 73 };

            Class1.CountingSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSoTest3()
        {
            int[] array =  { 20, 50, 39, 29, 13, 15, 85 };
            int n = array.Length;
            int[] expected = { 13, 15, 20, 29, 39, 50, 85 };

            Class1.CountingSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        //RadixSoTest
        [TestMethod]
        public void RadixSoTest1()
        {
            int[] array = { 6, 3, 5, 1, 0, 4, 2 };
            int n = array.Length;
            int[] expected = { 0, 1, 2, 3, 4, 5, 6 };

            Class1.radixsort(array, n);
            CollectionAssert.AreEqual(expected, array);

        }

        [TestMethod]
        public void RadixSoTest2()
        {
            int[] array = { 11, 44, 77, 99, 88, 22 };
            int n = array.Length;
            int[] expected = { 11, 22, 44, 77, 88, 99 };

            Class1.radixsort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RadixSoTest3()
        {
            int[] array = { 387, 217, 634, 546, 495 };
            int n = array.Length;
            int[] expected = { 217, 387, 495, 546, 634 };

            Class1.radixsort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }


    }
}
