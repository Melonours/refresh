static void AfficherInfosPersonne(string nom, int age)
{
    Console.WriteLine();
    Console.WriteLine($"Salut {nom}, tu as {age} ans");
    Console.WriteLine($"Ton age l'année prochaine sera {age + 1} ans");


    if (age == 18)
    {
        Console.WriteLine("Vous êtes tout juste majeur");
    }
    else if (age == 17)
    {
        Console.WriteLine("Vous serez bientôt majeur");
    }
    else if (age >= 60)
    {
        Console.WriteLine("Vous êtes sénior");
    }
    else if (age >= 18)
    {
        Console.WriteLine("Vous êtes majeur");
    }
    else if (age < 10)
    {
        Console.WriteLine("Vous êtes un enfant ");
    }
    else
    {
        Console.WriteLine("Vous êtes mineur");
    }
}


static int DemanderAge(string nom)
{
    int ageNum = 0;
    while (ageNum <= 0)
    {
        Console.WriteLine($"{nom}, quel est ton age ?");
        string ageStr = Console.ReadLine();

        try
        {
            ageNum = int.Parse(ageStr);
            if (ageNum < 0)
            {
                Console.WriteLine("Erreur !!! L'âge ne peut pas être négatif");
            }
            if (ageNum == 0)
            {
                Console.WriteLine("Erreur !!! L'âge ne doit pas être égal à zéro");
            }
        }
        catch
        {
            Console.WriteLine("Erreur !!! Veuillez entrer un nombre valide");
        }
    }
    return ageNum;
}


static string DemanderNom(int numeroPersonne)
{
    string nom = "";
    while (nom == "")
    {
        Console.WriteLine($"Quel est ton nom personne {numeroPersonne}?");
        nom = Console.ReadLine();
        nom = nom.Trim();

        if (nom == "")
        {
            Console.WriteLine("Erreur !!! Le nom ne peut pas être vide");
        }
    }
    return nom;
}

string nom1 = DemanderNom(1);
string nom2 = DemanderNom(2);

int age1 = DemanderAge(nom1);
int age2 = DemanderAge(nom2);


AfficherInfosPersonne(nom1, age1);
AfficherInfosPersonne(nom2, age2);

Console.ReadLine();