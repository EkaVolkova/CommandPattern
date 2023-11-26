namespace CommandPattern
{
    public class GateOpenAction : ICommand
    {
        Gate gate;
        public GateOpenAction(Gate gate)
        {
            this.gate = gate;
        }
        public void Close()
        {
            gate.Close();
        }

        public void Open()
        {
            gate.Open();
        }
    }
}
