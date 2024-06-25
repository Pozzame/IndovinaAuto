Console.WriteLine("Quante iterazioni?");
int iterazioni = Convert.ToInt32(Console.ReadLine());

Random rng = new Random();
int media=0;
int ite = iterazioni;
while (Convert.ToBoolean(iterazioni))
{
    media += TrovatoreRand(rng.Next(1000));
    //Console.WriteLine($"Ci ha messo {volte} volte");
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

int TrovatoreAureo(int num)
{
    int prove = 1;
    
    int prova = rng.Next(1000);
    while(num != prova)
    {
        if (prova < num)
        {

        }
        prove++;
    }
    return prove;
}