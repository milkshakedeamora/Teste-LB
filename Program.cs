using System.Numerics;

int CalcularFatorial (int num) {
        int f=1;
        while(num>0) {
            f*=num;
            num--;
        }
        return f;
      }


//-----------------------------------------------------------------------



double? CalcularPremio(double valor, string tipo,double? proprio){
         if(proprio > 0){
             return valor*proprio;
         }
         if(valor<=0){
             return null;
         }
         switch(tipo){
            case "basic":
             return valor;
            
            case "vip": 
             return 1.2*valor;
            
            case "premium": 
             return 1.5*valor;
            
            case "deluxe": 
             return 1.8*valor;
            
            case "special": 
             return 2*valor;
            
            default:
             return null;
            
         
         }
     }


//----------------------------------------------------------------

int ContarNumerosPrimos(int numero){
    int primos =0;
    bool primo(int num) {
    for (var divisor = 2; divisor < num; divisor++) 
        if (num % divisor == 0) return false;
        return true;
    }
    for(int i = 2; i <= numero; i++){
        if(primo(i))primos++;
            
    }
    return primos;

}

//-----------------------------------------------------------------
int CalcularVogais(String texto){
    int contarVogais = 0;
        
    texto = texto.ToLower();
        
    foreach (char letra in texto){
            
        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            contarVogais++;
        }
        
    return contarVogais;
    }
//-----------------------------------------------------------



string CalcularValorComDescontoFormatado(string valor, string desconto) {
    valor = valor.Replace(".","");          
    valor = valor.Substring(3,(valor.Length-3));
    double v = Double.Parse(valor);
    desconto = desconto.Replace("%","");
    double d = Double.Parse(desconto)/100;
    return "R$ "+(v*(1-d)).ToString("N2");
         
}

//----------------------------------------------------

int CalcularDiferencaData(string data1,string data2){
          DateTime FormatarData(string data){
          string formatedate =data.Substring(0,2)+"/"+data.Substring(2,2)+"/"+data.Substring(4,4);
          return Convert.ToDateTime(formatedate);
      }
          
          return((FormatarData(data2) - FormatarData(data1)).Days);
}
      
    
//--------------------------------------------------


int[] ObterElementosPares(int[] vetor){
    var lista = vetor.ToList(); 
    for(int i =0; i < lista.Count;i++){
        if(lista[i]%2!=0)
            lista.RemoveAt(i);
        }
        return lista.ToArray();
}
        
//----------------------------------------------------------
string[] BuscarPessoa(string[]vetor, string nome){
    List<string> lista = new List<string>();
    foreach(string pessoa in vetor ){
        if(pessoa.Contains(nome))
        lista.Add(pessoa);
            
    }
    return lista.ToArray();
    
}

//-----------------------------------------------------------

string[,]TransformarEmMatriz(string cadeianumeros){
    string[]numeros = cadeianumeros.Split(',');
    int y =0;
    string[,] array = new string[(numeros.Length/2), 2];
    for(int i = 0; i< (array.Length/2);i++){
        for(int j = 0; j < 2;j++){
            array[i,j]= numeros[y];
            y++;
        }
    }
        
    return array;
}

//-------------------------------------------------------------------------------

int[] ObterElementosFaltantes(int [] vetor1,int [] vetor2){
    List<int> faltantes = new List<int>();  
    
    foreach(int n in vetor1){        
        if(!vetor2.Contains(n))
        faltantes.Add(n);        
    }
    foreach(int n in vetor2){        
        if(!vetor1.Contains(n))
        faltantes.Add(n);        
    }
    return faltantes.ToArray();


}




        
        