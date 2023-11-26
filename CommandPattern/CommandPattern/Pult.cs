namespace CommandPattern
{
    public class Pult 
    {
        ICommand command;

        public void SetAction(ICommand command)
        {
            this.command = command;
        }

        public void OpenButton()
        {
            command.Open();
        }

        public void CloseButton()
        {
            command.Close();
        }
    }
}
