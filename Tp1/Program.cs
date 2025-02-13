class Program
{
    static void Main(string[] args)
    {
      
        Repertoire repertoire = new Repertoire("TP1");

       
        repertoire.addFile(new Fichier("Affichage d Java", "pdf", 1200));
        repertoire.addFile(new Fichier("tswira", "jpg", 500));
        repertoire.addFile(new Fichier("cv", "docx", 300));

        
        repertoire.Afficher();

       
        int index = repertoire.RechercherFichier("tswira");
        Console.WriteLine(index != -1 ? "Fichier trouvé." : "Fichier non trouvé.");

        
        repertoire.RechercherPDF();

       
        repertoire.Supprimer("tswira");

     
repertoire.Rennomer("cv", "cv 9dim");

    
        repertoire.ModifierTaille("Affichage d Java", 1500);

        Console.WriteLine($"Taille du répertoire: {repertoire.GetTaille()} en  MO");
    }
}