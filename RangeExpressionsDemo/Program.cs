using System.Collections.Concurrent;

namespace RangeExpressionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string helloworld = "Hello, World!";
            const string emptystring = "";
            var header = $"Range Expressions in C# {typeof(Program).Assembly.GetName().Version}";
            var title = $"Using \"{helloworld}\"";

            Console.WriteLine(header);
            Console.WriteLine();            
            Console.WriteLine(title);
            Console.WriteLine(new string('=', title.Length));                         
            Console.WriteLine($"Last character                  [^1]    :{helloworld[^1]}");
            Console.WriteLine($"First character                 [1]     :{helloworld[^1]}");
            Console.WriteLine($"Two from the right              [^2..]  :{helloworld[^2..]}");            
            Console.WriteLine($"Two from the left               [..2]   :{helloworld[..2]}");   
            Console.WriteLine($"All except last                 [..^1]  :{helloworld[..^1]}");
            Console.WriteLine($"Between first and last          [1..^1] :{helloworld[1..^1]}");
            Console.WriteLine($"From 4th to 2nd from the right  [^4..^2]:{helloworld[^4..^2]}");
            Console.WriteLine($"Between first and last          [1..^1] :{helloworld[1..^1]}");
            
            title = $"Using \"{emptystring}\" raises exception:";
            Console.WriteLine(title);
            Console.WriteLine(new string('=',title.Length));
            try
            {
                Console.WriteLine($"Only first                      [1]  :{emptystring[1]}");
                Console.WriteLine($"Only last                       [^1] :{emptystring[^1]}");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Trying to access a character in an empty string: {ex}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Trying range expressions on an empty string: {ex}");
            }
            

        }
    }
}
