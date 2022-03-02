

public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int conta;
    public double saldo = 100;

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

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
    public bool Transferir (double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false ;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true ;
            }
        }
    }

// isso é uma classe
// funciona como uma planta de uma casa, mas é para criar objetos
    
