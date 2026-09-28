namespace Abvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region answer_01
            //1- a genaric class is a class that can work with different data type useing tepy parametr
            //2- code reuse,type safety,aviod casting ,better preformance

            #endregion
            #region answer02
            Container<string> c = new Container<string>();
            c.Add("test ");
            Console.WriteLine(c.Get());
            #endregion
            #region answer_03
            // it's meane that a genaric class can have more than one type 
            pair<int,string> p = new pair <int,string>( 9,"saqr");
            #endregion
            #region answer_04
            //it's can work with different data type
            int y = 0;
            int x = 9;
            swap(ref x , ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            #endregion
            #region answer _05
            int a = 0;
            int s = 9;
            Console.WriteLine(   findMax(a, s));

            #endregion
            #region answer_06
            //it's an interface that use atype parameter
            //example is implemanted
            #endregion
            #region answer_07
            //it's mean the type must be struct 
            Test<int> t = new Test<int>();
            #endregion
            #region answer_08
            //it's meane that type must be class
            Class1<string> c1 = new Class1<string>();

            #endregion
            #region answer_09
            //it's meane that type must have public parameter costractor
            Class2<int> c2 = new Class2<int>();
            #endregion
            #region answer_10
            // it's meane thatt type must  implement interface

            #endregion
            #region answer11
            //it's mean that type must be inhart from base class
            #endregion
            #region answer12
            //put where after that classand struct , interface, new().
            #endregion
            #region answer13
            //it's return the dafulte value 
            int k = default(int);
            #endregion
            #region answer14
            SafeList<int> sf = new SafeList<int>();
            sf.Add(9);
            Console.WriteLine(sf.Get(0));
            Console.WriteLine(sf.Get(2));
            #endregion
            #region answer15
            //  Covariance lets you use a more derived type where a base type is expected.For example, if Dog inherits from Animal, you can treat IEnumerable<Dog> as IEnumerable<Animal>.
            //The out keyword marks a generic type parameter as output only: it can be returned from methods but cannot be used as a method parameter.
            IProduser<Dog> dogs = new DogPriduser();
            IProduser<Animal> animals = dogs;
            #endregion

        }
        static void swap <T>(ref T a ,ref T b){
            T temp = a;
            a = b;
            b = temp;
        }
        static T findMax<T>(T a,T b ) where T :IComparable<T>
        {
            if (a.CompareTo(b) > 0)
                return a;
            return b;

        }
    }
}
