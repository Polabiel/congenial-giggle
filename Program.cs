using PrimeiroProjeto;

Console.WriteLine("Hello, World!");

Data hoje = new Data();
Console.WriteLine(hoje.ToString()) ;


// uso de metodos para ter acesso ao atributo private
hoje.setDia(6);
Console.WriteLine(hoje.getDia());

// uso de PROPRIEDADE
hoje.Mes = 3;   // set de Mes é acionado
Console.WriteLine(hoje.Mes);// get de Mes é acionado
Console.WriteLine(hoje.ToString());

Console.ReadLine();  