using ConculatorConsole;

namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 3;

            var result = Matemathisc.Add(a, b);
            Console.WriteLine(result);
        }
    }
}
