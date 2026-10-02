// MAGASIN

double totalFacture = 830.25;
double montantArticle = 600;
string typeArticle = "lave-linge";
double remise = 0;

if (totalFacture>=5000) remise=0.2;
else 
{
    if (totalFacture>=1000)
    {
    if(typeArticle=="lave-vaisselle" && montantArticle>=400) remise=0.15;
    else remise=0.1;
    }
else{
    if(typeArticle=="lave-linge" && montantArticle>=500) remise=0.1;
    }
}

totalFacture*=(1-remise);

Console.WriteLine($"Remise accordée: {remise:p1}");
Console.WriteLine($"Montant à régler: {totalFacture} €");
