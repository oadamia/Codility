namespace ConsoleApp
{
    public class Nesting
    {
        //Brute Force 100$ Correct
        public int solution(string S) {
            if (S.Length % 2 != 0)
                return 0;
            
            int counter = 0;
            foreach (var symbol in S)
            {
                if (symbol == '(')
                    counter++;
                else
                    counter--;

                if (counter < 0)
                    return 0;
            }

            if (counter == 0)
            {
                return 1;
            } else {
                return 0;
            }
        }

        //more elegant solution
        public int solution1(string S) {
            if (S.Length == 0)
                return 1;
            if (S.Length % 2 != 0)
                return 0;

            int count = 0;

            foreach (var symbol in S)
            {
                if (symbol == '(')
                    count++;
                else {
                    if (count == 0)
                        return 0;
                    count--;
                }
            }

            if (count != 0)
                return 0;

            return 1;
        }
    }
}