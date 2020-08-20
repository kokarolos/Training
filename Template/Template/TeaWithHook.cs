using System;

namespace Template
{
    public class TeaWithHook : CaffeineBeverage
    {
        public override void AddCondiment()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override bool CustomerWantsCondiments()
        {
            var userInput = GetUserInput();
            return userInput.ToLower() == "yes" ? true : false;
        }

        private string GetUserInput()
        {
            string answer = "";
            Console.WriteLine("Would u like lemon with your Tea");
            try
            {
                answer = Console.ReadLine();
            }
            catch (Exception)
            {
                throw;
            }
            return answer;
        }

    }
}
