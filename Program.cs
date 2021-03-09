using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTermino;
            //continue escrevendo a solucao

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split();
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[4]);

            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);
            segundoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[4]);
           

            int transformaSegundosInicio = (diaInicio*24*60*60+horaMomentoInicio*60*60+minutoMomentoInicio*60+segundoMomentoInicio);
            int transformaSegundosTermino = (diaTermino*24*60*60 + horaMomentoTermino*60*60 + minutoMomentoTermino*60 + segundoMomentoTermino);

            int somaTotalSegundos = ( transformaSegundosTermino - transformaSegundosInicio );
            int W = somaTotalSegundos / (24*60*60);
            int X = (somaTotalSegundos-W*(24*60*60)) / (60*60);
            int Y = (somaTotalSegundos-X*(60*60)-W*(24*60*60)) / (60);
            int Z = (somaTotalSegundos-Y*(60)-X*(60*60)-W*(24*60*60));
          

            Console.WriteLine("{0} dia(s)", W);
            Console.WriteLine("{0} hora(s)", X);
            Console.WriteLine("{0} minuto(s)", Y);
            Console.WriteLine("{0} segundo(s)", Z);


    }

}