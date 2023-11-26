# CommandPattern

Дан клиентский код
    
    class Program
    {
       static void Main(string[] args)
       {
           Pult pult = new Pult();
           Gate gate = new Gate();
          
           pult.SetAction(new GateOpenAction(gate));
           pult.OpenButton();
           pult.CloseButton();
       }
    }

И код класса 


    class Gate
    {
       public void Open()
       {
           Console.WriteLine("Открываем ворота");
       }
     
       public void Close()
       {
           Console.WriteLine("Закрываем ворота");
       }
    }
Допишите реализацию так, чтобы получить вывод:

    Открываем ворота
    Закрываем ворота

