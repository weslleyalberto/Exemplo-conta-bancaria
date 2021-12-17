namespace Conta.Entities
{
    public class ContaEmpresa : Contas
    {
        public Double  LimiteEmprestimo { get; private set; }

        public ContaEmpresa() : base()
        {

        }
        public ContaEmpresa(int numero,string holder,double saldo,double limiteEmprestimo): base(numero,holder,saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }
        public void SetLimiteCredito(double limite)
        {
            LimiteEmprestimo = limite;
        }
        public void Emprestimo(double valor)
        {
            if(valor <= LimiteEmprestimo)
            {
               Deposito(valor);
            }
        }
        public override void Saque(double saque)
        {
            base.Saque(saque);
            Saldo -= 2.0;
        }
        
    }
}
