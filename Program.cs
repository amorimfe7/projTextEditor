namespace TextEditor{

    class Program{

        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("=========== BEM VINDO AO TEXT EDITOR ===========");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("Qual atividade que você deseja realizar?");
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("[1] - Abrir arquivo");
            Console.WriteLine("[2] - Criar novo arquivo");
            Console.WriteLine("[0] - Sair");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            short option = short.Parse(Console.ReadLine());

            switch(option){
                case 0: System.Environment.Exit(0); break;
                case 1: //Open(); break;
                case 2: //Edit(); break;
                default: Menu(); break;
            }
        } 
    }
}
