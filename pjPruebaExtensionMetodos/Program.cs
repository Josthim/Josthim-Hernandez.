using Modelo;

int numero = 57;
bool par = numero.EsPar();
Console.WriteLine("{0} es {1}", numero, par);

// Extensión del double
double valor = 55.18;
Console.WriteLine(valor.Duplica());

// Dado un entero realice una extensión de método para saber si es primo 
bool primo = numero.EsPrimo();
Console.WriteLine("{0} es {1}", numero, primo);