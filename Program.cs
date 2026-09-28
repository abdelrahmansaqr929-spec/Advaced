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

        }
    }
}
