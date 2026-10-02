// DOUBLETS CHAINE
Console.WriteLine("Entrez la phrase:");
String phr = Console.ReadLine()!;

int doub = 0, doubs = 0, trip = 0;
int i;
string phrssesp = Convert.ToString(phr[0]);

if ((phr == "") || (phr.Length == 1)) Console.WriteLine($"La phrase est trop courte");
else
{
    // enlever les espaces
    for (i = 1; i < phr.Length; i++)
    {
        if (phr[i] != ' ')
        {
            phrssesp = phrssesp + phr.Substring(i, 1);
        }
    }
    //Console.WriteLine(phrssesp);

    for (i = 0; i < phrssesp.Length - 2; i++)
    {
        if (phrssesp[i] == phrssesp[i + 1])            // ou phr.Substring(i, 1);
        {
            doub++;
            if (phrssesp[i] == 's')
                doubs++;

            if (phrssesp[i + 1] == phrssesp[i + 2])
            {
                trip++;
                doub -= 2;
                if (phrssesp[i] == 's') doubs -= 2;
            }
        }
    }

    Console.WriteLine($"La phrase contient {trip} triplets, {doub} doublets dont {doubs} double s");
}
