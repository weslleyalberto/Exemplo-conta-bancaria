// See https://aka.ms/new-console-template for more information



using Conta.Entities;

Contas conta = new (1500,"Weslley",1500.00);
ContaEmpresa cont = new ContaEmpresa(100,"Marina",1000.00,0.01);

//Upcasting

Contas conta1 = cont;
Contas conta2 = new ContaEmpresa(1,"Carcará",5.0,0.05);
Contas conta3 = new ContaPoupanca(3, "Anna", 0.0, 0.01);

//Downcasting
ContaEmpresa contaEmpresa = (ContaEmpresa) conta2;
if(conta2.GetType() == typeof(ContaEmpresa))
{
    Console.WriteLine("Conta é uma contaEmpresa");
}
