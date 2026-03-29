using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

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




            #region Q06:

            //: What is a generic interface? Write IRepository<T>

            //define contracts with type parameters. Classes implementing them specify the actual types.


            // IRepo added

            #endregion


            #region Q07:

            //What is the 'struct' constraint? Write an example.
            //struct constraint : T must be a value type

            /*    class ValueType<T> where T : struct
            {
                public T Value { get; set; }
            }*/


            #endregion


            #region Q08:

            //What is the 'class' constraint? Write an example

            //where T : class restricts T to reference types only. 
            //This allows T to be null and enables reference comparison.

            /* class Reference<T> where T : class
             {
                 public T Value { get; set; }
             }
            */
            #endregion


            #region Q09:

            //What is the 'new()' constraint? Write an example.

            //where T : new () requires T to have a public parameterless constructor.
            //This allows you to create instances of T inside the generic code.

            /* class ItemFactory<T> where T : new()
             {
                 public T GetNewItem()
                 {
                     return new T();
                 }
             }*/

            #endregion


            #region Q10:
            //What is the interface constraint? Write an example.

            //where T : IInterface requires T to implement a specific interface. 
            // This enables calling interface methods on type parameter.

            /* 
                public static T? FindMax<T>(T[] values) where T : IComparable<T> //where T : INumber<T>
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


            #region Q11:
            //What is the base class constraint? Write an example
            //BaseClass: T must inherit from BaseClass

            /*   class Animal { }
                 class Cat : Animal { }

            class  Shelter<T> where T : Animal
            {
                public T Value { get; set; }
            }
            */

            #endregion


            #region Q12:
            //How do you apply multiple constraints? Write an example. 

            //You can combine multiple constraints for a single type parameter,
             //and have different constraints for different type parameters.
 

           /*
            class Dog<T> where T : class, new()
            {
                public T Add()
                {
                    return new T();
                }
            }
           */

        #endregion













    }
    }
}
