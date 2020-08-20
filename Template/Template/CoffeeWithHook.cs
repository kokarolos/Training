using System;

namespace Template
{
    public class CoffeeWithHook : CaffeineBeverage
    {
        public override void AddCondiment()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through Filter");
        }

        public override bool CustomerWantsCondiments()
        {
            var userInput = GetUserInput();
            return userInput.ToLower() == "yes" ? true : false;
        }

        private string GetUserInput()
        {
            string answer = "";
            Console.WriteLine("Would u like milk and Sugar with your coffee");
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
