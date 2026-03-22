namespace RangeExpressionsDemo
{
    internal class Program
    {
        /// <summary>
        /// Serves as the entry point for the application, demonstrating the use of range expressions and indexers with
        /// strings in C#.
        /// </summary>
        /// <remarks>The method outputs examples of using range and index expressions on both non-empty
        /// and empty strings, highlighting their behavior and the exceptions that may occur when accessing elements in
        /// an empty string. It also demonstrates exception handling for invalid index operations.</remarks>
        /// <param name="args">An array of command-line arguments supplied to the application. This parameter is not used.</param>
        static void Main(string[] args)
        {
            // The string "Hello, World!" is defined to demonstrate the use of range expressions and indexers, allowing us to show how to access specific characters and ranges within the string.
            const string helloworld = "Hello, World!";
            // An empty string is defined to demonstrate the behavior of range expressions when applied to an empty string, which will lead to exceptions when trying to access characters.
            const string emptystring = "";
            // The header variable is created to display the title of the demonstration, which includes the version of the assembly.
            var header = $"Range Expressions in C# {typeof(Program).Assembly.GetName().Version}";
            // The title is dynamically generated to include the string being demonstrated, which helps clarify the context of the output.
            var title = $"Using \"{helloworld}\"";

            // Save the current console foreground color to restore it later after demonstrating exceptions.
            var saveforeground = Console.ForegroundColor;

            Console.WriteLine(header);
            Console.WriteLine();
            Console.WriteLine(title);
            Console.WriteLine(new string('=', title.Length));
            Console.WriteLine($"{"Last character",-32}{"[^1]",8}:{helloworld[^1]}");
            Console.WriteLine($"{"First character",-32}{"[1]",8}:{helloworld[^1]}");
            Console.WriteLine($"{"Two from the right",-32}{"[^2..]",8}:{helloworld[^2..]}");
            Console.WriteLine($"{"Two from the left",-32}{"[..2]",8}:{helloworld[..2]}");
            Console.WriteLine($"{"All except last",-32}{"[..^1]",8}:{helloworld[..^1]}");
            Console.WriteLine($"{"Between first and last",-32}{"[1..^1]",8} :{helloworld[1..^1]}");
            Console.WriteLine($"{"From 4th to 2nd from the right",-32}{"[^4..^2]",8}:{helloworld[^4..^2]}");
            Console.WriteLine($"{"Between first and last",-32}{"[1..^1]",8}:{helloworld[1..^1]}");
            Console.WriteLine();

            title = $"Using \"{emptystring}\" raises exception:";
            Console.WriteLine(title);
            Console.WriteLine(new string('=', title.Length));
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine($"{"Only first",-32}{"[1]",8}:{{emptystring[1]}}");
            Console.WriteLine($"{"Only last",-32}{"[^1]",8}:{{emptystring[^1]}}");
            Console.WriteLine();

            Console.ForegroundColor = saveforeground;

            try
            {
                Console.WriteLine($"{"Only first",-32}{"[1]",8}:{emptystring[1]}");
                Console.WriteLine($"{"Only last",-32}{"[^1]",8}:{emptystring[^1]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Trying to access a character in an empty string:\n{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Trying range expression:\n{ex.Message}");
            }
            finally
            {
                Console.ForegroundColor = saveforeground;
            }
        }
    }
}
