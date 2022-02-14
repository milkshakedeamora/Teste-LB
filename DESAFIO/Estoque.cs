namespace DESAFIO
{
    public class Estoque
    {
        static List<Bebida> bebidas= new List<Bebida>();
        int vendas = 0;
        double valorVendas = 0;

         public int Vendas{
            get{return this.vendas;} 
            set{this.vendas = value;}
        }
        
         public double ValorVendas{
            get{return this.valorVendas;} 
            set{this.valorVendas = value;}
        }



        public string adicionarProduto(){
            Console.WriteLine("Digite o nome da nova bebida:");
            string nome = Console.ReadLine(); 
            if (bebidas.Exists(b => b.Nome== nome))
                return "Bebida já existente.";
            Console.WriteLine("Digite o valor da nova bebida:");
            double preco = double.Parse(Console.ReadLine());   
            Console.WriteLine("Digite a quantidade da nova bebida:");
            int quantidade = int.Parse(Console.ReadLine());        

            
            bebidas.Add(new Bebida(nome,preco,quantidade));
            return "Bebida adicionada";

        }
        public void exibirProdutos(){
            foreach (Bebida b in bebidas)
            {
                Console.WriteLine(b.Nome + " - " + b.Quantidade+" - R$"+b.Preco);
            }
        }
        public void removerProduto(string nome){
            Console.WriteLine(bebidas.RemoveAll(delegate (Bebida b) { return b.Nome == nome; }));

        }

        public string nomeBebida(){
            Console.WriteLine("Digite o nome da bebida:");
            string nomePdt = Console.ReadLine();

           while(true){
                if (bebidas.Exists(b => b.Nome== nomePdt)){
                return nomePdt;
            }            
            else{
                Console.WriteLine("O nome digitado não é valido. Digite novamente:");
                nomePdt = Console.ReadLine();
            }
           }


        }

        public void venda(){
            double valort =0;
            Console.WriteLine("---- VENDA ----");
            while(true){            
            string nomeProduto = nomeBebida(); 
            int idx= bebidas.FindIndex(delegate (Bebida b) { return b.Nome == nomeProduto; });           
            Console.WriteLine("Digite a quantidade:");
            int qtdProduto = int.Parse(Console.ReadLine());
            if(bebidas[idx].removerEstoque(qtdProduto))
            valort+= bebidas[idx].valor(qtdProduto);
            Console.WriteLine("Total:"+valort);
            Console.WriteLine("DIGITE:");
            Console.WriteLine("2 - Finalizar venda. Qualquer outro para continuar.");
            string? resposta = Console.ReadLine();
            if(resposta == "2")
            break;
            }
            valorVendas+=valort;
            Console.WriteLine("Digite o valor recebido:");
            double recebido = double.Parse(Console.ReadLine());            
            double troco = recebido-valort;
            while(troco<0){
                Console.WriteLine("Ainda faltam: R$ "+troco.ToString("N2"));
                Console.WriteLine("Digite novo valor inserido: R$ ");
                recebido = double.Parse(Console.ReadLine()); 
                valort=troco;
                troco = valort+recebido;           
            }
            Console.WriteLine("Venda finalizada. Troco de R$"+troco.ToString("N2"));
            vendas++;
            
            }
            
            

        

        
        
            
                

            
           


        
    }
}