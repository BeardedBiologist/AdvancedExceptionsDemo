namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";

            try
            {
                DifferentMethod();

                Console.Write("What is your name?: ");
                name = Console.ReadLine();
                ComplexMethod(name);
                SimpleMethod();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("You should not be calling these methods");
                Console.WriteLine(ex.Message);
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("You forgot to finish your code!!!!");
            }
            catch (Exception ex) when (name.ToLower() == "tim")
            {
                Console.WriteLine("You used Tim's name, didn't you?");
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I always run!!");
            }

            Console.ReadLine();
        }

        private static void ComplexMethod(string name)
        {
            if (name.ToLower() == "tim")
            {
                throw new InsufficientMemoryException("Tim is too tall for " +
                    "this method.");
            }
            else
            {
                throw new ArgumentException("This person isn't Tim");
            }
        }

        private static void DifferentMethod()
        {
            Console.WriteLine("This is the DifferentMethod working properly");
        }

        private static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling" +
                " the SimpleMethod");
        }

        
    }
}