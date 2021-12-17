namespace Conta.Entities
{
    public class Contas
    {
        public int Numero { get; private set; }
        public string Holder { get; private set; }
        public double Saldo { get; protected set; }
        public Contas()
        {

        }

        public Contas(int numero, string holder, double saldo)
        {
            Numero = numero;
            Holder = holder;
            Saldo = saldo;
        }
        public void SetHolder(string holder)
        {
            Holder = holder;
        }
        public void SetNumero(int numero)
        {
            Numero = numero;
        }
        public virtual void Saque(double saque)
        {
            Saldo-= saque + 5.0;
        }
        public  void Deposito(double deposito)
        {
            Saldo += deposito;
        }
    }
}
