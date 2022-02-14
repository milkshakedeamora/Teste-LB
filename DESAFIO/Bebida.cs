namespace DESAFIO
{
    public class Bebida 
    {
        private string nome;
        private int quantidade;
        private double preco;

        public Bebida(string nome, double preco, int quantidade){
            this.nome = nome;
            if(preco<=0){
                Console.WriteLine("Preço invalido. Mudado para R$0");
                preco = 0;
            }else{
                this.preco= preco;
            }
            
            if(quantidade<0){
                Console.WriteLine("Quantidade invalida. Mudado para 0");
                quantidade= 0;
            }else{
                this.quantidade= quantidade;
            }
        }
        public string Nome{
            get{return this.nome;} 
            set{this.nome = value;}
        }
        public double Preco{
          get {return this.preco;}
          set{if(preco > 0)
              this.preco= value;}
        }
        public int Quantidade{
          get {return this.quantidade;}
          set{if(quantidade > 0)
              this.quantidade= value;}
        }

        public bool removerEstoque(int quantidade){
            if(this.quantidade > quantidade){
                this.quantidade-=quantidade;
                return true;
            }
            else{
                Console.WriteLine("Quantidade insuficiente. Quantidade em estoque:"+quantidade);
                return false;
            }
        }

        public double valor(int quantidade){
            
            return this.preco*quantidade;
                        
        }

        
    }
}