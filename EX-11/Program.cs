// ***   SAISIE HORS INTERVALLE   *** //

int valDebut, valFin;

do
{
    Console.WriteLine("Quelle est la valeur minimale de l'intervalle d'exclusion?");
    valDebut = Convert.ToInt32(Console.ReadLine()!);

    Console.WriteLine("Quelle est la valeur maximale de l'intervalle d'exclusion?");
    valFin = Convert.ToInt32(Console.ReadLine()!);
} while (valDebut > valFin);


int idx = 1, val = 0;
do
{
    Console.Write((idx++) + "e valeur ? ");
    val = Convert.ToInt32(Console.ReadLine()!);

} while ((val < valDebut) || (val > valFin));
Console.WriteLine($"La valeur interdite est {val}. C’est la {--idx}ème valeur saisie");
