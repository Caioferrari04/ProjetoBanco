public class Conta
{
    public int Codigo { get; }
    public double Saldo { get; private set; }

    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor) 
    {
        if(valor < 0)
            throw new ApplicationException("Valor invalido: valor nao pode ser negativo");
        if(valor > Saldo)
            throw new ApplicationException("Valor invalido: voce nao possui o saldo suficiente para essa operacao");

        Saldo = Saldo - valor;
    }
    

    public void Depositar(double valor) 
    {
        if(valor < 0)
            throw new ApplicationException("Valor invalido: valor nao pode ser negativo");

        Saldo = Saldo + valor;
    }

    public void Transferir(double valor, Conta conta)
    {
        this.Sacar(valor);
        conta.Depositar(valor);
    }
    
    public override string ToString() => $"Código da conta: {this.Codigo}\nSaldo da conta: {this.Saldo}";
}
