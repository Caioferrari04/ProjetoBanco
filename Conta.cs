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
        _validarValor(valor);

        if(valor > Saldo)
            throw new ApplicationException("Valor invalido: voce nao possui o saldo suficiente para essa operacao");

        Saldo = Saldo - valor;
    }
    

    public void Depositar(double valor) 
    {
        _validarValor(valor);        
        Saldo = Saldo + valor;
    }

    public void Transferir(double valor, Conta conta)
    {
        Sacar(valor);
        conta.Depositar(valor);
    }
    
    public override string ToString() => $"Código da conta: {Codigo}\nSaldo da conta: {Saldo}";

    private void _validarValor(double valor)
    {
        if(valor <= 0.0)
            throw new ApplicationException("Valor invalido: valor nao pode ser menor ou igual a zero");
    }
}
