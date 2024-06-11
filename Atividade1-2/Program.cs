int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
//int[] numeros = { 4, 2, 5, 10, 8, 16, 26, 34, 52, 82, 144 };

bool impars = numeros.All(num => num % 2 != 0);

if (impars)
{
    Console.WriteLine("O array contem impars");
}
else
{
    Console.WriteLine("o array contem pares");
}