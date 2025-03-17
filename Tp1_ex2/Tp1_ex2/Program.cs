using DefaultNamespace;

class Program
{
    static void Main(string[] args)
    {
        Programmeur P1 = new Programmeur(1, "Ahmed", "Ahmed", 1);
        Programmeur P2 = new Programmeur(2, "Ayoub", "Ahmed", 1);
        Programmeur P3 = new Programmeur(3, "Saooud", "Ahmed", 1);
        Programmeur P4 = new Programmeur(4, "Daoud", "Ahmed", 1);

        Projet P = new Projet(1, "Cafe", "52 minutes", 5);
        
        P.AjouterProgrammeur(P1);
        P.AjouterProgrammeur(P2);
        P.AjouterProgrammeur(P3);
        P.AjouterProgrammeur(P4);
        
        P.Afficher();
        
        // P.Rechercher("Ahmed");
        
        P.Changer_Bureau("Saooud",5);
        
        P.Afficher();
    }
}
