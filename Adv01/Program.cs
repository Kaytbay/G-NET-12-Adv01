using System.Diagnostics.Metrics;

namespace Adv01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01:
            // What is a generic class? Why use generics?

            // A generic class uses type parameters <T> that are replaced with actual types when you create an instance

            //Type Safety	,Performance  ,Code Reuse , IntelliSense 



            #endregion


            #region Q02:

            // Contianer added

            #endregion


            #region Q03
            // What are multiple type parameters? Write Pair<TKey, TValue>.

            //have more than one parameters liike ley,value or first and second


            // pair class added


            #endregion


            #region Q04:

            // What is a generic method? Write Swap<T> method


            //A generic method declares its own type parameter(s). It can exist in both generic and non-generic classes. 
            //The compiler often infers the type argument


            /*
             public static void swap<T>(ref T x, ref T y)
             {
                 T temp = x;
                 x = y;
                 y = temp;
             }
            */


            #endregion


            #region Q05:

            /*   public static T? FindMax<T>(T[] values) where T : IComparable<T> //where T : INumber<T>
              {
                  T max = default(T);
                  foreach (var item in values)
                  {
                      max = item.CompareTo(max) > 0 ? item : max!;
                  }
                  return max;
              }
            */
            #endregion


            



        }
    }
}
