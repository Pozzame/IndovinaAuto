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
    if (algoritmo == 1) media += TrovatoreBinario(rng.Next(max));
    else if (algoritmo == 2) media += TrovatoreRand(rng.Next(max));
    iterazioni--;
}
Console.WriteLine($"Ci ha messo mediamente {media/ite} volte.");

int TrovatoreBinario(int num)
{
    int prove = 1;
    int min = 0;
    int prova;
    do
    {
        prova = ((max-min)/2)+min;
    if (num < prova) max = prova;
    else if (num > prova) min = prova;
    prove++;
    } while (prova != num);
    return prove;
}

int TrovatoreRand(int num)
{
    int prove = 1;
    while(num != rng.Next(max)) prove++;
    return prove;
}