using System.Speech.Synthesis;

int solde = 2345;
Console.WriteLine("Saisissez:\n" +
                  "1-pour obtenir les horaires d'ouverture\n" +
                  "2-pour consulter votre solde\n" +
                  "3- pour ajouter des points à votre solde\n" +
                  "9-pour être mis en relation avec un opérateur");
string saisie = Console.ReadLine();
var synthesizer = new SpeechSynthesizer();
synthesizer.SetOutputToDefaultAudioDevice();

if (saisie == "1")
{
    string text = "Nos bureaux sont ouverts du lundi au vendredi, de 8h à 17h sans interruption";
    Console.WriteLine(text);
    synthesizer.Speak(text);
    
}
else if (saisie == "2")
{
    Console.WriteLine($"Votre solde est de: {solde}€");
}
else if (saisie == "3")
{
    Console.WriteLine($"Votre solde est de: {solde}€\n" +
                      "Saisissez un nombre de points à ajouter:");
    saisie = Console.ReadLine();
    int pointsAjout = Convert.ToInt32(saisie);
    solde += pointsAjout;
    Console.WriteLine($"Votre nouveau solde est de: {solde}€");
}
else if (saisie == "9")
{
    Console.Beep();
}
else
{
    Console.WriteLine("Saisie incorrecte - numéro de menu inconnu\n");    
}