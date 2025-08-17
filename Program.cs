using DesafioPOO.Models;
 

Console.WriteLine($"Digite o numero");
string numeroDigitado = Console.ReadLine();

Console.WriteLine($"Digite o modelo");
string modeloDigitado = Console.ReadLine();

Console.WriteLine($"Digite o imei");
string imeiDigitado = Console.ReadLine();

Console.WriteLine($"Digite a memoria (apenas numeros)");
int memoriaDigitada = Convert.ToInt32(Console.ReadLine());

if (modeloDigitado == "nokia")
{
    Nokia nokia = new Nokia(numeroDigitado, modeloDigitado, imeiDigitado, memoriaDigitada);

    nokia.InstalarAplicativo("App Nokia");
}

if (modeloDigitado == "iphone")
{
    Iphone iphone = new Iphone(numeroDigitado, modeloDigitado, imeiDigitado, memoriaDigitada);

    iphone.InstalarAplicativo("Iphone App");
}

