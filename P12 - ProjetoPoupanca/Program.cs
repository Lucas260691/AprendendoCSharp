using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");



        // rendimento de 0.5% (0.005) ao mês


        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine(" No mês " + mes + " Você tem R$ " + investimento);

            mes++;
        }
        */

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes++) 
        {
            investimento *= 1.005;
            Console.WriteLine(" No mês " + mes + " Você tem R$ " + investimento);
        }



        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}