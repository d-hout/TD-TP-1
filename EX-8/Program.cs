// SAISIE MOT DE PASSE EN 3 COUPS

string password = "";
int compt = 3;

do
{
    Console.WriteLine("Saisir mot de passe SVP");
    password = Console.ReadLine()!; // x! means x will never be null
    compt--;

    //Optionnel 
    if (password != "mdp") Console.WriteLine($"Mot de passe incorrect, il vous reste {compt} tentative(s)");
    else Console.WriteLine(":)");

} while (password != "mdp" && compt > 0);
