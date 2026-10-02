// RACINES POLYNOMES

double a=3, b=2, c=-1;

double delta=b*b-4*a*c; //ou Math.Pow(b,2)
double x1=0, x2=0;

if(delta<0) Console.WriteLine("Pas de solution réelle");
else if (delta==0) 
{
    x1=-b/(2*a);
    Console.WriteLine($"Une solution réelle: {x1}");
}
else{
    x1=(-b-Math.Sqrt(delta))/(2*a);
    x2=(-b+Math.Sqrt(delta))/(2*a);
     Console.WriteLine($"Deux solutions réelles: {x1} et {x2}");
}