﻿using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mês

        int mes = 1;
        while(mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine(" No mês " + mes + " Você tem R$ " + investimento);

            mes++;
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}