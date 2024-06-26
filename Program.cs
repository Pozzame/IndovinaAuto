Console.WriteLine("Quante iterazioni?");
int iterazioni = Convert.ToInt32(Console.ReadLine());

Random rng = new Random();
int media=0;
int ite = iterazioni;
while (Convert.ToBoolean(iterazioni))
{
    int segreto = rng.Next(100);
    Console.WriteLine("Num da trovare " + segreto);
    media += TrovatoreBinario(segreto);
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

int TrovatoreBinario(int num)
{
    int prove = 1;
    int prova = 50;
    while (prova != num)
    {
        Console.WriteLine("Sto provando " + prova);
        Thread.Sleep(100);
    if (num < prova)
        prova = prova/2;
    else if (num > prova)
        prova = 100-prova + (prova/2);
    prove++;
    }
    return prove;
}
/*
    int prova = ((end - start) /2) + start;
    if (num == prova)
        return prove;
    else if (num < prova)
        TrovatoreBinario(num, start, prova);
    else if (num>prova)
        TrovatoreBinario(num, prova, end);
    return prove;
}
*/