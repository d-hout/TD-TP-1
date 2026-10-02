// ***   CHERCHE MAX   *** //

Console.WriteLine("Combien de valeurs souhaitez-vous saisir?");
int nbValeurs = Convert.ToInt32(Console.ReadLine()!);
// attention aucun contrôle sur la saisie

Console.WriteLine("Entrez vos valeurs:");
Console.Write("1ère valeur: ");
int val = Convert.ToInt32(Console.ReadLine()!);

int valMaxi = val;
int indMaxi = 0;
for (int i = 1; i < nbValeurs; i++)
{
    Console.Write((i + 1) + "e valeur: ");
    val = Convert.ToInt32(Console.ReadLine()!);

    if (val > valMaxi)
    {
        indMaxi = i;
        valMaxi = val;
    }
}
Console.WriteLine("La plus grande valeur est " + valMaxi +
                  ". C’est la " + (indMaxi + 1) + "e valeur de la suite de " + nbValeurs + " valeurs");

