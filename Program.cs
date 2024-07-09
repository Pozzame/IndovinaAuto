/*Console.Clear();
Console.WriteLine("Che algoritmo vuoi utilizzare?");
Console.WriteLine("1 - Binario; \n2 - Rand");
int algoritmo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Quanti numeri?");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Quante iterazioni?");
int iterazioni = Convert.ToInt32(Console.ReadLine());

Random rng = new Random();
int media=0;
int ite = iterazioni;
while (Convert.ToBoolean(iterazioni))
{
    if (algoritmo == 1) media += TrovatoreBinario(rng.Next(max), max);
    else if (algoritmo == 2) media += TrovatoreRand(rng.Next(max), max);
    iterazioni--;
}
Console.WriteLine($"Ci ha messo mediamente {media/ite} volte.");

int TrovatoreBinario(int num, int massimo)
{
    int prove = 1;
    int min = 0;
    int prova;
    do
    {
        prova = ((massimo-min)/2)+min;
        Console.WriteLine("Provo con: " + prova + " ad indovinare: " + num);
    if (num < prova) massimo = prova;
    else if (num > prova) min = prova;
    prove++;
    } while (prova != num);
    Console.WriteLine($"Indovinato con {prove-1}");
    return prove-1;
}

int TrovatoreRand(int num, int massimo)
{
    int prove = 1;
    int prova;
    do
    {
        prova = rng.Next(massimo);
        Console.WriteLine("Provo con: " + prova + " ad indovinare: " + num);
        prove++;
    }while(num != prova);
    Console.WriteLine($"Indovinato con {prove-1}");
    return prove-1;
}*/
using Spectre.Console;

AnsiConsole.WriteLine();
AnsiConsole.Write(new Calendar(2020, 10)
        .RoundedBorder()
        .HighlightStyle(Style.Parse("red"))
        .HeaderStyle(Style.Parse("yellow"))
        .AddCalendarEvent("An event", 2020, 9, 22)
        .AddCalendarEvent("Another event", 2020, 10, 2)
        .AddCalendarEvent("A third event", 2020, 10, 13));
