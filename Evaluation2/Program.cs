Console.WriteLine("Entrez votre age: ");
string ageSaisi =  Console.ReadLine();
Console.WriteLine("Entrez votre poids en kg (ex: 23,4): ");
string poidsSaisi = Console.ReadLine();
bool enfant = false;
int quantiteDolipraneMaxParJour = 0;
string msgDoseMax = "Dose quotidienne max: ";
string msgDoseAdulte = "500 mg ou 1 g de paracétamol, 1 à 3 fois par jour";
string msgDose4h = " mg 6 fois par jour";
string msgDose6h = " mg 4 fois par jour";
Console.WriteLine("Posologie Doliprane :\n");

if (Int32.TryParse(ageSaisi, out int age) && Decimal.TryParse(poidsSaisi, out decimal poids))
{
    if (age < 14)
    {
        enfant = true;
    }

    if (!enfant)
    {
        quantiteDolipraneMaxParJour = 3000;
        Console.WriteLine(msgDoseMax + quantiteDolipraneMaxParJour + " mg");
        Console.WriteLine(msgDoseAdulte);
    }
    else
    {
        quantiteDolipraneMaxParJour = (int)(poids * 60);
        Console.WriteLine(msgDoseMax + quantiteDolipraneMaxParJour + " mg");
        Console.WriteLine($"{quantiteDolipraneMaxParJour/6m} {msgDose4h}");
        Console.WriteLine($"{quantiteDolipraneMaxParJour/4m} {msgDose6h}");
    }
}