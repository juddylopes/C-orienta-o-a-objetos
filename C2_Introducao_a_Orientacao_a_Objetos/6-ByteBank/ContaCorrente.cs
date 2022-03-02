using _6_ByteBank;



namespace _6_ByteBank
{

    public class ContaCorrente
    {
       // private Cliente _titular; //necessário nome do namespace e da classe

       // public Cliente Titular
       //  {
       //     get 
       //     { 
       //        return _titular; 
       //    }    
       //     set 
       //     { 
       //        _titular = value;
       //     }   
       // }

        // outra forma de simplificar:
        // sem colocar o private Cliente _titular antes
        
        public Cliente Titular { get; set; } 
        public int Agencia {  get; set; }
        public int Numero { get; set; }
    
        private double _saldo = 100; // é visível apenas dentro dessa classe para os métodos dessa mesma classe.

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0 ) // value: palavra reservada para o *argumento* do set
                {
                    return;
                }
                _saldo = value;
            }
        }

        // Get e Set - métodos de encapsulamento para proteger a informação


        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }


        }



        // o sacar é uma função e não uma variável ... A primeira letra de uma função é sempre maiúscula 
        // + ação é representada por verbo
        //this: palavra reservada para acessar a variável do objeto base
        // return: devolve um valor para quem recorreu a função
        // se a expressão booleana tiver um IF dentro é obrigatório return para as opções apresentadas
        // void: função/método sem retorno
    }

}



