namespace DefaultNamespace;

public class Projet
{
    private int code;
    private string sujet;
    private string duree;
    private int nbr_programmeur;
    private List<Programmeur> Programmeurs;
    private List<Consommation> Consommations;
    
    public Projet(){}

    public Projet(int code, string sujet, string duree, int nbr_programmeur)
    {
        this.code = code;
        this.sujet = sujet;
        this.duree = duree;
        this.nbr_programmeur = nbr_programmeur;
        Programmeurs = new List<Programmeur>();
        Consommations = new List<Consommation>();
    }

    public void AjouterProgrammeur(Programmeur programmeur)
    {
        Programmeurs.Add(programmeur);
        Console.WriteLine("Le programmeur : "+programmeur+"est ajouté avec succès");
    }

    public void Afficher()
    {
        Console.WriteLine("Le sujet de projet est : "+sujet);

        foreach (Programmeur programmeur in Programmeurs)
        {
            programmeur.Afficher();
        }
        
    }

    public int Rechercher(string nom)
    {
        for (int i = 0; i < Programmeurs.Count ; i++)
        {
            if (Programmeurs[i].getNom() == nom)
            {
                Console.WriteLine("L'indice de Programmeur est "+ i);
                return i;
            }
        }

        return -1;
    }

    public void SupprimerProgrammeur(Programmeur programmeur)
    {
        Programmeurs.Remove(programmeur);
    }

    public void AjouterConsommation(Consommation consommation)
    {
        Consommations.Add(consommation);
        Console.WriteLine("Le consommation est : "+consommation);
    }

    public void Changer_Bureau(string nom, int newBureau)
    {
        int index = Rechercher(nom);
            if (index != -1)
            {
                Programmeurs[index].setBureau(newBureau);
                Console.WriteLine("Le bureau de programmeur est maintenant : "+Programmeurs[index].getBureau());
            }
            else
            {
                Console.WriteLine("Programmeur non trouvé");
            }
    }
    
    public void AfficherTotalTasses(int noSemaine)
    {
        int total = 0;
    
        foreach (Consommation conso in Consommations)
        {
            if (conso.getNoSemaine() == noSemaine)
            {
                total += conso.getNbTasses();
            }
        }
    
        Console.WriteLine($"Total de tasses de café consommées en semaine {noSemaine} : {total}");
    }

    
    
}