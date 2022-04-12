﻿using ByteBank;



namespace ByteBank
{

    public class ContaCorrente
    {
        
        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }
        public Cliente Titular { get; set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        public int Numero { get; }
        public int Agencia { get; }
        
    
        private double _saldo = 100; 

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0 ) 
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            if (numeroAgencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(numeroAgencia));
            } 
            if (numeroConta <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numeroConta));
            }

            Agencia = numeroAgencia;
            Numero = numeroConta;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

        }


        public bool Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para saque.", nameof(valor));
            }

            if (this._saldo < valor)
            {
                ContadorSaquesNaoPermitidos ++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            
            this._saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para transferência.", nameof(valor));
            }
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }
            contaDestino.Depositar(valor);

        }

    }

}



