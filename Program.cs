Console.WriteLine("Quante iterazioni?");
int iterazioni = Convert.ToInt32(Console.ReadLine());

Random rng = new Random();
int media=0;
int ite = iterazioni;
while (Convert.ToBoolean(iterazioni))
{
    media += TrovatoreRand(rng.Next(1000));
    iterazioni--;
}
Console.WriteLine($"Ci ha messo mediamente {media/ite} volte.");

int TrovatoreRand(int num)
{
    int prove = 1;
    
    while(num != rng.Next(1000))
    {
        prove++;            
    }
    return prove;
}




int TrovatoreBinario(int num, int start, int end)
{
    int prove = 1;
    int prova = ((end - start) /2) + start;
    if (num == prova)
        return prova;
    else if (num < prova)
        TrovatoreBinario(num, start, prova);
    else if (num>prova)
        TrovatoreBinario(num, prova, end);
/*    while(num != Binario())
    {
        if (prova < num)
        {

        }
        prove++;
    }*/
    return prove;
}

int Binario(int inizio, int fine)
{
    return ((fine - inizio) /2) + inizio;
}