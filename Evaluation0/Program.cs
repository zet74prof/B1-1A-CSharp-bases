//déclaration des variables
decimal tempMin = 35.2m;
decimal tempMax = 40.4m;
string etatPerso = "en forme";
bool dead = false;
decimal tempPerso;

Console.WriteLine("Saisissez votre température (ex: 37,4): \n");
//Récupération de la saisie utilisateur
string saisie = Console.ReadLine();

if (Decimal.TryParse(saisie, out tempPerso))
{
    //si la température du perso est inférieure ou égale à la température minimum
    //ou si la température du perso est supérieure ou égale à la température maximum
    //alors le perso est mort
    if (tempPerso <= tempMin || tempPerso >= tempMax)
    {
        dead = true;
    }
    //sinon si la température du perso est strictement inférieure à 36
    //ou si la température du perso est strictement supérieure à 38.5
    else if (tempPerso < 36m || tempPerso > 38.5m)
    {
        etatPerso = "bien malade";
        //Console.WriteLine("Vous êtes " + etatPerso + "\n");
    }
    //sinon si la température du perso est strictement inférieure à 36.6
    //ou si la température du perso est strictement supérieure à 37.4
    else if (tempPerso < 36.6m || tempPerso > 37.4m)
    {
        etatPerso = "un peu malade";
        //Console.WriteLine($"Vous êtes {etatPerso}\n");
    }
    else
    {
        //Console.WriteLine("Vous êtes " + etatPerso + "\n");
    }

    if (dead)
    {
        etatPerso = "mort";
        //Console.WriteLine("Vous êtes mort");
    }
    Console.WriteLine("Vous êtes " + etatPerso + "\n");
}
else
{
    Console.WriteLine("Saisissez un nombre décimal avec la virgule comme séparateur");
}






