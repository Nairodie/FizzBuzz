namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string Output(int x)
        {
            var collection = Enumberable.Range(1,100);
            string output;

            if ((x % 3 == 0) && (x % 5 == 0))
            {
                output = "FizzBuzz";
            }
            else if(x % 3 == 0)
            {
                output = "Fizz";
            }
            else if (x % 5 == 0)
            {
                output = "Buzz";
            }
            else
            {
                output = x.ToString();
            }

            return output;
        }
    }
}
