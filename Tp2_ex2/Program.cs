using Tp2_ex2;

public class Program
{
    static void Main(string[] args)
    {
        Livre L1 = new Livre("open game", "Ayoub", 30);
        Livre L2 = new Livre("open game", "Anas", 30);

        Dictionnaire D = new Dictionnaire("La rousse", "Frc", 3000);

        Biblio B = new Biblio();
        B.addDocument(L1);
        B.addDocument(L2);
        B.addDocument(D);

        int x = B.Count();
        Console.WriteLine("Le nombre de Livre est "+x +"\n");
        Console.WriteLine("-----Affichage dictionnaire-----");
        B.AfficherDictionnaire();
        
        B.tousLesAuteurs();

        Console.WriteLine("\n");
        Console.WriteLine("\n");
        Console.WriteLine("\n");
        Console.WriteLine("Afficher tous les documents\n");

        
        
        B.toutesLesDescriptions();
    }
}