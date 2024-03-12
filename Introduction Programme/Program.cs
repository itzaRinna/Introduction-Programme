using System;
using System.Threading;

namespace Introduction_Programme
{
    public class Program
    {
        // Global variables
        public int Spd = 40;

        public static void Main(string[] args)
        {
            Program program = new Program(); // Create an instance of Program
            Gender gender = new Gender();

            program.Begin();
            gender.Ask();
        }

        public bool IsString(object input)
        {
            return input is string;
        }

        public void SlowPrint(string text, int delay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }

        public void Begin()
        {
            string name = "";
            string introduct = "Welcome to our introduction program. This platform is designed to provide you with insights into our company and to better understand your background and interests. We appreciate your participation as it helps us tailor our services to your needs effectively.\r\n";

            // Begin the program
            SlowPrint(introduct, Spd);
            SlowPrint("What is your name?\n", Spd);
            name = Console.ReadLine();
            while (name == "")
            {
                SlowPrint("Invalid, please enter your name\n", Spd);
                name = Console.ReadLine();
            }
            SlowPrint($"Hello {name}, nice to meet you.\n", Spd);
        }
    }

    public struct GenderOptions
    {
        public const string Male = "1. Male";
        public const string Female = "2. Female";
        public const string NonBinary = "3. Non-Binary";
    }

    public class Gender
    {
        public void Ask()
        {
            string gender_Ask = "Could you please provide your demographic information regarding gender identity?\n";
            string gender_Ans = "";
            string male = GenderOptions.Male + "\n";
            string female = GenderOptions.Female + "\n";
            string non_binary = GenderOptions.NonBinary + "\n";

            Program program = new Program(); // Create an instance of Program to access its methods
            program.SlowPrint(gender_Ask, program.Spd); // Call SlowPrint method from Program class
            Console.WriteLine($"{male}\n{female}\n{non_binary}");
            gender_Ans = Console.ReadLine();
            while (gender_Ans == "")
            {
                program.SlowPrint("Invalid, please enter your gender", program.Spd);
                gender_Ans = Console.ReadLine();
            }
            if (gender_Ans == "1")
            {
                program.SlowPrint("So you are a Male", program.Spd);
            }
            else if (gender_Ans == "2")
            {
                program.SlowPrint("So you are a Memale", program.Spd);
            }
            else if (gender_Ans == "3")
            {
                program.SlowPrint("So you are Non-Binary", program.Spd);
            }
            else
            {
                Console.WriteLine("Sorry you're not in the matrix");
            }
        }
    }
}
