
Console.Write("Entrez la moyenne de l'élève:");
double moy = Convert.ToDouble(Console.ReadLine()!);

if (moy >= 10)
{
    Console.WriteLine("L'élève passe ");

    // Calcul de l'appréciation

    if (moy < 12)
    {
        Console.WriteLine("Appréciation : P ");
    }
    else
    {
        if (moy < 14)
        {
            Console.WriteLine("Appréciation : AB ");
        }
        else
        {
            if (moy < 16)
            {
                Console.WriteLine("Appréciation : Bien ");
            }
            else
            {
                Console.WriteLine("Appréciation : Excellent ");
            }
        }
    }

    // Autre solution qui évite de dupliquer le message affiché
    string appreciation = "P";
    if (moy >= 12)
    {
        if (moy < 14)
        {
            appreciation = "AB";
        }
        else
        {
            if (moy < 16)
            {
                appreciation = "B";
            }
            else
            {
                appreciation = "Excellent";
            }
        }
    }
    Console.WriteLine($"Appréciation : {appreciation}");

}
else
{
    Console.WriteLine("L'élève est refusé");
}
