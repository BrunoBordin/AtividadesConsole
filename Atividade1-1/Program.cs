long sequenciaTamanho = 0;
long numeroMaximaSquencia = 0;

for (long i = 1; i <= 1000000; i++)
{
    long numero = i;
    long tamanhoSequencia = 1;

    while (numero != 1)
    {
        if (numero % 2 == 0)
        {
            numero /= 2;
        }
        else
        {
            numero = 3 * numero + 1;
        }

        tamanhoSequencia++;
    }

    if (tamanhoSequencia > sequenciaTamanho)
    {
        sequenciaTamanho = tamanhoSequencia;
        numeroMaximaSquencia = i;
    }
}

Console.WriteLine($"o número que produz a maior sequencia é {numeroMaximaSquencia}, com uma sequência de comprimento {sequenciaTamanho}.");