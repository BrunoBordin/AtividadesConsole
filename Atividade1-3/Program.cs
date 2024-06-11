int[] arrayUm = { 1, 3, 7, 29, 42, 98, 234, 93 };
int[] arrayDois = { 4, 6, 93, 7, 55, 32, 3 };

var numerosNaoContidos = arrayUm.Except(arrayDois);

foreach (var numero in numerosNaoContidos)
{
    Console.WriteLine(numero);
}