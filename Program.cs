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

    static void Open(){

    }

    static void Edit(){
        Console.Clear();

        Console.WriteLine("Digite seu texto abaixo || Pressione [ESC] para sair ");
        Console.WriteLine("------------------------");
        string text = "";


        do{
            text+= Console.ReadLine(); //lendo apenas linha
            text+= Environment.NewLine; //adicionando nova linha
        }
        while(Console.ReadKey().Key != ConsoleKey.Escape); //enquanto a entrada da tecla n for ESC
            Console.Write(text);
        }
    
    static void Save(string text){
        Console.Clear();

        Console.WriteLine("Onde você deseja salvar o arquivo?");
        var path = Console.ReadLine();

        using(var file = new StreamWriter(path)){ //criando e salvando arquivo
            file.Write(text);
        } 
        
        Console.WriteLine("Arquivo salvo com sucesso!");
    }

    }
}
