// See https://aka.ms/new-console-template for more information

DESAFIO.Estoque estoque = new DESAFIO.Estoque();


while(true){
    Console.WriteLine("Digite a opção que deseja:");
    Console.WriteLine("1 - Visualizar estoque e quantidade:");
    Console.WriteLine("2 - Comprar Bebida");
    Console.WriteLine("3 - Mostrar vendas");
    Console.WriteLine("4 - Adicionar Bebida");
    Console.WriteLine("5 - Remover Bebida");
    string escolha = Console.ReadLine();
    switch(escolha){           
            
            case "1": 
             estoque.exibirProdutos();
            break;
            
            case "2": 
             estoque.venda();
            break;
            
            case "3": 
             Console.WriteLine(estoque.Vendas+" vendas foram realizadas totalizando R$"+estoque.ValorVendas.ToString("N2"));
            break;
            
            case "4": 
             Console.WriteLine(estoque.adicionarProduto());
            break;
            case "5":
            Console.WriteLine("Digite o nome do produto que deseja remover:");
            string produto = Console.ReadLine();
            estoque.removerProduto(produto);
            break;           
            
            default:
             Console.WriteLine("Nenhuma opção válida digitada.");
            break;
            
         
         }
    
}

Console.WriteLine("Hello, World!");
