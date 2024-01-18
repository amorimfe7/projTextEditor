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
        }
    }
}
