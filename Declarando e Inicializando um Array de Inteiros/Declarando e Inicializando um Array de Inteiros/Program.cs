﻿int[] numeros = new int[5];


numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;
numeros[3] = 40;
numeros[4] = 50;


for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento {i}: {numeros[i]}");
}