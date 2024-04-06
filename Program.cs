using Calculadora.Models;




string continuar = "s";
CalculadoraModel calc = new CalculadoraModel();
ReceberNumeros receber = new ReceberNumeros();

do
{
    Console.Clear();
    Console.WriteLine("--------CALCULADORA EM C#--------  \r\n \r\nO que deseja fazer?");
    Console.WriteLine("1- SOMAR \r\n2- SUBTRAIR \r\n3- MULTIPLICAR \r\n4- DIVIDIR \r\n");

    Console.WriteLine("ESCOLHA: ");
    var escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            int primeiroNumeroSoma = receber.PrimeiroNumero();
            int segundoNumeroSoma = receber.SegundoNumero();
            calc.Somar(primeiroNumeroSoma, segundoNumeroSoma);
            break;
        case "2":
            int primeiroNumeroSub = receber.PrimeiroNumero();
            int segundoNumeroSub = receber.SegundoNumero();
            calc.Subtrair(primeiroNumeroSub, segundoNumeroSub);
            break;
        case "3":
            int primeiroNumeroMul = receber.PrimeiroNumero();
            int segundoNumeroMul = receber.SegundoNumero();
            calc.Multiplicar(primeiroNumeroMul, segundoNumeroMul);
            break;
        case "4":
            int primeiroNumeroDiv = receber.PrimeiroNumero();
            int segundoNumeroDiv = receber.SegundoNumero();
            calc.Dividir(primeiroNumeroDiv, segundoNumeroDiv);
            break;
        default:
            Console.WriteLine("NÚMERO INVÁLIDO. TENTE NOVAMENTE!");
            break;
    }
    Console.WriteLine("DESEJA CONTINUAR? (s/n)");
    string escolhaContinuar = Console.ReadLine().ToLower();
    if (escolhaContinuar != "s")
    {
        Console.Clear();
        continuar = "n";
        Console.WriteLine("ENCERRANDO PROGRAMA!!");
    }
}
while (continuar == "s");