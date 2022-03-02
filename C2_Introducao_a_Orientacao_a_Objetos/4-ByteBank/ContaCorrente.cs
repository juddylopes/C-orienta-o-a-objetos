
public class ContaCorrente
{
    public string titular; 
    public int agencia;
    public int conta;
    public double saldo = 100;
    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
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

    
