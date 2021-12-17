namespace Conta.Entities
{
    public class ContaPoupanca : Contas
    {
        public double TaxaDeJuros { get; private set; }
        public ContaPoupanca() : base()
        {

        }
        public ContaPoupanca(int numero,string holder,
            double saldo, double taxaDeJuros ) : base(numero, holder, saldo)
        {
            TaxaDeJuros = taxaDeJuros;
        }
        public void SetTaxaJutos(double taxaJuros)
        {
            TaxaDeJuros = taxaJuros;
        }
        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaDeJuros;
        }
        public override void Saque(double saque)
        {
            Saldo-= saque;

        }


    }
}
