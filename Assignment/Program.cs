
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
        }
    }
}
