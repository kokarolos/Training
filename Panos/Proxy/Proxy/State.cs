namespace Proxy
{
    public interface State
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }

}
