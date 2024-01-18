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
            case 1: Open(); break;
            case 2: Edit(); break;
            default: Menu(); break;
        }
    }

    static void Open(){
        Console.Clear();

        Console.WriteLine($"Qual o caminho do arquivo? || Ex: C:\\Projetos\\nome-do-arquivo.txt");
        string path = Console.ReadLine();

        using(var file = new StreamReader(path)){
            
            string text = file.ReadToEnd();
            Console.WriteLine(text);
        }

        Console.WriteLine("");
        Console.WriteLine("Pressione [ESC] para sair || Pressione [ENTER] para retornar ao Menu");

            if(Console.ReadKey().Key == ConsoleKey.Escape){
                System.Environment.Exit(0);
            } else {
                Menu();
            }
      }

    static void Edit(){
        Console.Clear();

        Console.WriteLine("Digite seu texto abaixo || Pressione [ESC] para sair ");
        Console.WriteLine("------------------------------------------------------");
        string text = "";

        do{
            text+= Console.ReadLine(); 
            text+= Environment.NewLine; 
        } while(Console.ReadKey().Key != ConsoleKey.Escape);
        
        Save(text); 
        }
    
    static void Save(string text){
        Console.Clear();
        Console.WriteLine("1 Onde você deseja salvar o arquivo? || Ex: C:\\Projetos\\nome-do-arquivo.txt");
        var path = Console.ReadLine();

        using(var file = new StreamWriter(path)){
            file.Write(text);
        } 
        
        Console.WriteLine("");
        Console.WriteLine($"Arquivo {path} salvo com sucesso!");
        Console.WriteLine("");
        Console.WriteLine("Pressione [ESC] para sair || Pressione [ENTER] para retornar ao Menu");

        if(Console.ReadKey().Key == ConsoleKey.Escape){
                System.Environment.Exit(0);
            } else {
                Menu();
            }
        }
    }
}
