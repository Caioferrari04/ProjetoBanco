Conta c1 = new Conta(1);
Conta c2 = new Conta(2);

c1.Depositar(1000.0);
c2.Depositar(2000.0);
c1.Sacar(231.0);
c2.Sacar(100.0);

System.Console.WriteLine(c1.ToString());
System.Console.WriteLine(c2.ToString());

c1.Transferir(500.0, c2);
System.Console.WriteLine(c1.ToString());
System.Console.WriteLine(c2.ToString());

c2.Transferir(500.0, c1);
System.Console.WriteLine(c1.ToString());
System.Console.WriteLine(c2.ToString());

c1.Depositar(-600.0);
