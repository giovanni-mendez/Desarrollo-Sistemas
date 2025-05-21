Console.WriteLine("Ingrese 1er numero: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la operacion(+, -): ");
string operacion = Console.ReadLine();

Console.WriteLine("Ingrese 2do numero: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int resultado = Calcular(num1, operacion, num2);
        Console.WriteLine("Resultado: " + resultado);

Console.WriteLine("Desea ingresar otro numero(S/N)");
string respuesta = Console.ReadLine();

do
{
    Console.WriteLine("Ingrese otro numero: ");
    int numNuevo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese la operacion(+, -): ");

    operacion = Console.ReadLine();

    double ResultadoFinal = Calcular(resultado, operacion, numNuevo);
    Console.WriteLine("Respuesta: " + ResultadoFinal);

    Console.WriteLine("Desea ingresar otro numero(S/N)");
    respuesta = Console.ReadLine();
}
while (respuesta == "s" || respuesta == "S");

int Calcular(int num1, string operador, int num2)
{
    if (operador == "+")
        return Sumar(num1, num2);
    else if (operador == "-")
        return Restar(num1, num2);
    else if (operador == "*")
        return Multiplicar(num1, num2);
//    else if (operador == "/")
//        return Dividir(num1, num2);
    else
    {
        Console.WriteLine("Operador no válido");
        return 0;
    }
}

int Sumar(int num1, int num2)
{
    if (num1 < 0 || num2 < 0)
    {
        Console.WriteLine("Ingrese números mayores a 0");
        return 0;
    }
    else
        return num1 + num2;
}

int Restar(int num1, int num2)
{
    if (num1 < 0 || num2 < 0)
    {
        Console.WriteLine("Ingrese números mayores a 0");
        return 0;
    }
    else
        return num1 - num2;
}

int Multiplicar(int num1, int num2)
{
    if (num1 < 0 || num2 < 0)
    {
    Console.WriteLine("ingrese numero mayores a 0");
    return 0;
    }
    else
        return num1 * num2;
}

//double Dividir(int num1, int num2)
//{
//    if (num1 < 0 || num2 < 0)
//    {
//        Console.WriteLine("ingrese numero mayores a 0");
//        return 0;
//    }
//    else
//        return num1 / num2;
//}