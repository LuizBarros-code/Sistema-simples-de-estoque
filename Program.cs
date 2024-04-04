using System.Runtime.InteropServices;

void menu(Dictionary<string,List<int>> estoque){
  Console.Clear();
  Console.WriteLine("*******************************");
  Console.WriteLine("Sistema de estoque de carro");
  Console.WriteLine("*******************************\n");
  Console.WriteLine("1- Para cadastrar carro.");
  Console.WriteLine("2- Para adicionar estoque de um carro.");
  Console.WriteLine("3- Para ver todos os carros.");
  Console.WriteLine("4- Para ver carro específico.");
  Console.WriteLine("0- Para sair do sistema.\n");
  Console.Write("Digite a opção que deseja: ");
  int n= int.Parse(Console.ReadLine()!);
  switch(n){
    case 1: CadastrarCarro(estoque);
    break;
    case 2: AdicionarEstoque(estoque);
    break;
    case 3: MostrarCarros(estoque);
    break;
    case 4: Mostrarcarro(estoque);
    break;
    case 0: break;
  }
}

void CadastrarCarro(Dictionary<string,List<int>> estoque){
  Console.Clear();
    Console.WriteLine("Qual o nome do carro que deseja cadastrar: ");
    string nomeDoProduto = Console.ReadLine()!;
    estoque.Add(nomeDoProduto, new List<int>());
    Console.WriteLine("Carro cadastrado com sucesso!");
    Thread.Sleep(3000);
    menu(estoque);
}

void AdicionarEstoque(Dictionary<string,List<int>> estoque){
  Console.Clear();
  Console.Write("Digite qual carro deseja adicionar em estoque: ");
  string nomeDoProduto = Console.ReadLine()!;
  if(estoque.ContainsKey(nomeDoProduto)){
    Console.Write("Quantas unidades no estoque: ");
    int unidadesE = int.Parse(Console.ReadLine()!);
    estoque[nomeDoProduto].Add(unidadesE);
    Console.WriteLine("Unidades alocadas com sucesso!");
    Thread.Sleep(3000);
    menu(estoque);
  }else{
    Console.WriteLine("Esse carro não esta cadastrado, tente novamente");
    Thread.Sleep(3000);
    menu(estoque);
  }
}

void MostrarCarros(Dictionary<string,List<int>> estoque){
  Console.Clear();
    foreach(string carro in estoque.Keys){
      int soma = 0;
      Console.Write($"\n{carro}: ");
      for(int i = 0; i < estoque[carro].Count;i++){
        Console.Write($" {estoque[carro][i]} ");
        soma = soma + estoque[carro][i];
      }
      Console.WriteLine($"\nA soma do estoque do carro é: {soma}");
      Console.Write($"\nA media de carro para cada estoque é: {estoque[carro].Average()}");
    }
}

void Mostrarcarro(Dictionary<string,List<int>> estoque){
  Console.Clear();
  Console.Write("Digite qual carro que deseja olha:");
  string nomeDoCarro = Console.ReadLine()!;
  int soma = 0;
  if(estoque.ContainsKey(nomeDoCarro)){
    Console.WriteLine($"{nomeDoCarro}:");
      for(int i = 0; i < estoque[nomeDoCarro].Count;i++){
        Console.Write($" {estoque[nomeDoCarro][i]}\n");
        soma = soma + estoque[nomeDoCarro][i];
      }
      Console.WriteLine($"\nA soma do estoque do carro é: {soma}");
      Console.Write($"A media de carro para cada estoque é: {estoque[nomeDoCarro].Average()}");
    }
  }

Dictionary<string,List<int>> estoque = new Dictionary<string, List<int>>();
menu(estoque); 

