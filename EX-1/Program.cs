int a = 1, b = 2;
int temporaire;

Console.WriteLine($"Avant Permutation: a={a}, b={b}");

temporaire = b;
b = a;
a = temporaire;

Console.WriteLine($"Après Permutation: a={a}, b={b}");

