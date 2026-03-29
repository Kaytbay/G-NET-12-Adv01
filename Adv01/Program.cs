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




            #region Q13:
            //What does the 'default' keyword do in generics?

            //default(T) or default returns the default value for type 
            //reference types: null
            //value types: zero


            #endregion


            #region Q14:

            //: Write a SafeList<T> that returns default when the index is invalid.

            /*
              internal class SafeList<T>
              {
                  private readonly List<T> _list = [];

                  public void Add(T item) { _list.Add(item); }

                  public T? GetItem(int index)
                  {
                      if (index < _list.Count)
                          return _list[index];
                      return default(T);
                  }
              }
            */


            #endregion


            #region Q15:

            //What is covariance? Explain the 'out' keyword.

            //Covariance allows a  ref from a parent type to be assigned to a child type.
            //The 'out' keyword is used to specify covariance  that only allows a type to be used as a return type
            #endregion


            #region Q16:


            //What is contravariance? Explain the 'in' keyword.


            //Contravariance allows a ref from a child type to be assigned to a parent type.
            //The 'in' keyword is used to specify contravariance  that only allows a type to be used as a parameter type
            #endregion


            #region Q17:
            //What is the difference between covariance and contravariance?

            //Covariance (out)  ,Derived → Base , Output only(return)	
            //Contravariance (in)  ,Base → Derived , Input only(parameter)


            #endregion


            #region Q18:
            //How do static members work in generic types?

            // Each closed generic type has its own copy of static fields


            #endregion


            #region Q19:

            //How can you inherit from a generic class?

            /*
            Pattern 1: Inherit and Pass Type Parameter => Derived class is also generic
            Pattern 2: Inherit with Concrete Type => Derived class specifies the type
            Pattern 3: Add New Type Parameter => Derived class adds more type parameters
            */
            #endregion


            #region Q20:

            /*
             Create a generic Cache<TKey, TValue>with Add, Get, Remove, Contains, and expiration support. 
             */

            // Cache class added


           // Cache<int, string> TestCache = new();

           // TestCache.Add(1, "v1", TimeSpan.FromMinutes(5));
           // TestCache.Add(2, "v2",TimeSpan.FromSeconds(1));

           // //Console.WriteLine(TestCache.Get(1));
           //// Console.WriteLine(TestCache.Get(2));
           // TestCache.Remove(2);
           // Console.WriteLine(TestCache.Get(2));



            #endregion















        }
    }
}
