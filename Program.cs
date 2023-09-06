static List<int> SortNumbers(List<int> numeros)
{
    for (int i = numeros.Count -1; i >= 1; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (numeros[j] > numeros[j + 1])
            {
                int aux = numeros[j];
                numeros[j] = numeros[j + 1];
                numeros[j + 1] = aux;
            }
        }
    }

    return numeros;
}

List<int> numeros = new List<int> { 5, 2, 9, 1, 5, 6, 8, 18, 2, 56, 65, 26, 28, 26, 23, 24, 22 };
List<int> numerosOrdenados = SortNumbers(numeros);

foreach (var numero in numerosOrdenados)
{
    Console.Write(numero + " "); 
}

