using TP1Calculatrice;
string reponse = "oui";
while (reponse != "non")
{
    Console.WriteLine("Renseignez un premier nombre");
    string entreePremierNombre = Console.ReadLine();
    float premierNombre = float.Parse(entreePremierNombre);
    Console.WriteLine("Renseignez un second nombre");
    string entreeSecondNombre = Console.ReadLine();
    float secondNombre = float.Parse(entreeSecondNombre);
    
    Console.WriteLine("Choisissez votre opération : + ; - ; * ; / ; %");
    string operateur = Console.ReadLine();

    if (operateur == "+")
    {
        Console.WriteLine(premierNombre + " + " + secondNombre + " : " + Class1.Addition(premierNombre,secondNombre));
    }
    else if (operateur == "-")
    {
        Console.WriteLine(premierNombre + " - " + secondNombre + " : " + Class1.Soustraction(premierNombre, secondNombre));
    }
    else if (operateur == "*")
    {
        Console.WriteLine(premierNombre + " x " + secondNombre + " : " + Class1.Multiplication(premierNombre, secondNombre));
    } else if (operateur == "/") {
        Console.WriteLine(premierNombre + " / " + secondNombre + " : " + Class1.Division(premierNombre, secondNombre));
    } else if (operateur == "%")
    {
        Console.WriteLine(premierNombre + " % " + secondNombre + " : " + Class1.Modulo(premierNombre, secondNombre));
    }
    Console.WriteLine("Voulez vous continuer ?");
    reponse = Console.ReadLine();
}
