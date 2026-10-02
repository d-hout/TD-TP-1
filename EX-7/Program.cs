// ANALYSE D'UN CODE QUI DIT SI LE NB SAISI A 2 CHIFFRES

const int NombreStop = 99999;

Console.WriteLine("Entrez un nombre ou " + NombreStop + " pour finir : ");

int uneVal = Convert.ToInt32(Console.ReadLine());

while (uneVal != NombreStop) // tant que valeur saisie au clavier != nombreStop
{
    if ((uneVal >= 10) && (uneVal <= 99)) // si valeur comprise entre 10 et 99
    {
        Console.WriteLine(uneVal + " est un nombre à deux chiffres");
    }
    Console.WriteLine("Entrez un nombre ou " + NombreStop + " pour finir : ");
    uneVal = Convert.ToInt32(Console.ReadLine()); // Saisie d'une nouvelle valeur
}
Console.WriteLine("Fin");

// Pas for car on ne sait pas à l'avance le nombre de fois que sera exécutée la boucle
// Pas do...while car si le nombre stop est saisi d'emblée pas d'utilité à entrer dans la boucle

// NB: Convert or Parse --> equivalent but
// if a null string is passed to Convert it returns 0, 
// whereas Int32.Parse throws an ArgumentNullException.