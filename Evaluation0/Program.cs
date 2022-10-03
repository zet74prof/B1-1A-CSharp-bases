//déclaration des variables
decimal tempMin = 36.2m;
decimal tempMax = 40.4m;
string etatPerso = "OK";
bool dead = false;
decimal tempPerso;

Console.WriteLine("Saisissez votre température: \n");
//Récupération de la saisie utilisateur
string saisie = Console.ReadLine();

if (Decimal.TryParse(saisie, out tempPerso))
{
    //si la température du perso est inférieure à la température minimum
    //ou si la température du perso est supérieure à la température maximum
    //alors le perso est mort
    if (tempPerso < tempMin || tempPerso > tempMax)
    {
        dead = true;
        etatPerso = "mort";
        Console.WriteLine($"Vous êtes {etatPerso}\n");
    }
    else if (tempPerso < 36m || tempPerso > 38.5m)
    {
        etatPerso = "bien malade";
        Console.WriteLine("Vous êtes " + etatPerso + "\n");
    }
    else if (tempPerso < 36.6m || tempPerso > 37.4m)
    {
        etatPerso = "un peu malade";
        Console.WriteLine($"Vous êtes {etatPerso}\n");
    }
    else
    {
        etatPerso = "en forme";
        Console.WriteLine("Vous êtes " + etatPerso + "\n");
    }
}
else
{
    Console.WriteLine("Saisissez un nombre décimal avec la virgule comme séparateur");
}






