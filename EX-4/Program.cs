// DUREE DE TRAJET

int hDepart = 22;
int minDepart = 47;
int hArrivee = 2;
int minArrivee = 17;
int minTrajet = 0;

if (hDepart<hArrivee){
     minTrajet = hArrivee*60+minArrivee-hDepart*60-minDepart;
}
else{    //changement de jour
    minTrajet= (24-hDepart)*60-minDepart+hArrivee*60+minArrivee;
}

Console.WriteLine($"Temps de trajet en min {minTrajet}");

int hTrajet=minTrajet/60;
minTrajet=minTrajet%60;

Console.WriteLine($"Durée du trajet : {hTrajet} heure(s) et {minTrajet} minute(s)");
