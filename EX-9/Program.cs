
// BONJOUR

int reponse;

do
{
    Console.WriteLine("Tapez 1 si vous êtes étudiante, 2 si vous êtes étudiant: ");
    reponse = Convert.ToInt32(Console.ReadLine()!);
} while (!(reponse == 1 || reponse == 2));

if (reponse == 1)
{
    Console.WriteLine("Bonjour Mademoiselle");
}
else
{
    Console.WriteLine("Bonjour Monsieur");
}

//--------------------------------------------------------------

// AFFICHE PHRASE

const char ARRET = '.';
const int MAX = 15;
char unCar;
string phrase = "";
int compt = 0;
int blancs = 0;

Console.WriteLine("Entrez votre phrase en la terminant par un point");

do
{
    unCar = Console.ReadKey().KeyChar;
    // Console.ReadKey() method is used to obtain the next character or function key 
    //pressed by the user and the KeyChar is used to get the Unicode character represented 
    //by the current System.ConsoleKeyInfo object. Thus Console.ReadKey().KeyChar can be used 
    //to read a single/first character. Basically, it will read a character or a function and 
    //show it on the console but without waiting for the Enter key to press. As soon as you will 
    //enter a character output will display on the console.

    // Console.WriteLine(); // Pour aller à la ligne si on veut
    if (unCar != ARRET)
    {
        if (unCar != ' ')
        {
            phrase += unCar;
            compt++;
        }
        else blancs++;
    }
} while ((unCar != ARRET) && (compt < MAX));

// présentation des résultats
Console.WriteLine("\n" + phrase);
Console.WriteLine("Le nombre de caractères saisis est " + compt);
Console.WriteLine("Le nombre de blancs effacés est " + blancs);
if (unCar == ARRET) Console.WriteLine("Sortie de l'algo par saisie valeur ARRET");
else Console.WriteLine("Sortie de l'algo par dépassement nb caractères MAX");

//------------------------------------------------------------

