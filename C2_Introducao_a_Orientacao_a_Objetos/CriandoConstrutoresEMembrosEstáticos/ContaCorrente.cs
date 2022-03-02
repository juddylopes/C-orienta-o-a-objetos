



namespace CriandoConstrutoresEMembrosEstáticos
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0) // o valor/variável da agencia deve ser maior que 0
                {
                    return;
                }
                _agencia = value;
            }
        }

        public int Numero { get; set; }

        public static int TotalDeContasCriadas {  get; private set; }

        public ContaCorrente (int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo; // obter o saldo 
            }
            set
            {
                if (value < 0) // se colocar saldo menor que zero, retorna. Se não, o saldo fica válido
                {
                    return;
                }
                _saldo = value;
            }
        }

        public bool Sacar (double valor) // bool não leva get e set, com ele tem que ter sempre if e else + return false ou true
        {
            if (_saldo < valor) // valor que a pessoa quer sacar
            {
                return false; // se o saldo é menor que o valor a saque, não é possível sacar
            }

            _saldo -= valor;
            return true; // se não, saca aí
        }

        public void Depositar (double valor)
        {
            _saldo += valor;  // acrescenta ao saldo da conta, o valor depositado
        }

        public bool Transferir (double valor, ContaCorrente contaDestino)
        {
            if ( Saldo < valor) // se o valor a ser transferido for menor que o saldo então retorna falso.
            {
                return false;
            }
            _saldo -= valor; // se o saldo é maior que o valor, esse valor é reduzido da conta 
            contaDestino.Depositar(valor); // e depositado na contaDestino
            return true;
        }



    }
}
