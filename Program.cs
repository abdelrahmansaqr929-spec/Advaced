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
