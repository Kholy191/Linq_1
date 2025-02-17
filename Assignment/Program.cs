﻿
using System.Diagnostics;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Find all products that are out of stock.

            //var Result = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q2 Find all products that are in stock and cost more than 3.00 per unit.

            //var Result = ListGenerator.ProductList.Where(P => (P.UnitsInStock > 0 && P.UnitPrice > 3.00M));

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3 Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((ARR, Index) => ARR.Length < Index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q1 [Transformation] Return a sequence of just the names of a list of products.

            //var Result = ListGenerator.ProductList.Select(P => P.ProductName);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q2 [Transformation] Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Result = words.Select(X => new {Upper = X.ToUpper() , Lower = X.ToLower()} );

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3 [Transformation] Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var Result = ListGenerator.ProductList.Select(P => new {PID = P.ProductID, 
            //                                            PNAME = P.ProductName , Price = P.UnitPrice});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q4 [Transformation] Determine if the value of ints in an array match their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Select((Value, Index) => Value == Index);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q5 Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var Result = from A in numbersA 
            //             from B in numbersB
            //             where A < B
            //             select new { A, B };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            //}

            #endregion

            #region Q6 [Transformation] Select all orders where the order total is less than 500.00.

            //var Result = ListGenerator.CustomerList.SelectMany(O => O.Orders).Where(O => O.Total < 500.00M);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q7 [Transformation] Select all orders where the order was made in 1998 or later.

            //var Result = ListGenerator.CustomerList.SelectMany(O => O.Orders).Where(O => O.OrderDate.Year > 1997);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
        }
    }
}
