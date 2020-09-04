using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load it up with five gumballs total
            // Console.WriteLine(machina); //State of machine
            //
            // machina.InsertQuarter(); // Throw a quarter in..
            // machina.TurnCrank(); //Turn the crank; we should get our gumball.
            //
            // Console.WriteLine(machina); // State
            //
            // machina.InsertQuarter(); // throw a quearter in 
            // machina.EjectQuarter(); //Ask for it back
            // machina.TurnCrank(); //Turn the crank; we shouldnt get our gumball
            //
            // Console.WriteLine(machina); //State
            //
            // machina.InsertQuarter(); //Throw a quarter in
            // machina.TurnCrank(); //Turn the crank we should get our gumball
            // machina.InsertQuarter(); //Throw a quarter in
            // machina.TurnCrank(); //Turn the crank; we should get our gumball
            // machina.EjectQuarter(); //Ask for a quarter back we didn't put in.
            //
            // Console.WriteLine(machina);
            //
            // machina.InsertQuarter(); //Throw firs quarter
            // machina.InsertQuarter(); //Throw SECOND quarter
            // machina.TurnCrank(); //Turn the crank we should get our gumball
            // machina.InsertQuarter();
            // machina.TurnCrank();
            // machina.InsertQuarter();
            // machina.TurnCrank();
            //
            // Console.WriteLine(machina);
            // Console.WriteLine(machina);
            //
            // machina.InsertQuarter();
            // machina.TurnCrank();
            //
            // Console.WriteLine(machina);
            //
            // machina.InsertQuarter();
            // machina.TurnCrank();
            // machina.InsertQuarter();
            // machina.TurnCrank();


            var machina = new GumballMachina(5, "Bali");
            var monitor = new GumballMonitor(machina);
            monitor.Report();
        }
    }

    public interface IService 
    {

    }
}
