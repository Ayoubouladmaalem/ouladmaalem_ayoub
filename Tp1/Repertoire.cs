using System;

public class Repertoire
{
  
    public string Nom { get; set; }
    public int NbrFichiers { get;  set; }
    private Fichier[] fichiers;

    private const int MaxFichiers = 30;

   
    public Repertoire(string nom)
    {
        Nom = nom;
        fichiers = new Fichier[MaxFichiers];
        NbrFichiers = 0;
    }

    //methode bach t afficher repertoire
    public void Afficher()
    {
        Console.WriteLine($"Répertoire: {Nom}");
        for (int i = 0; i < NbrFichiers; i++)
        {
            fichiers[i].Afficher();
        }
    }
    //methode ta3 recherche b le nom
    public int RechercherFichier(string nomFichier)
    {
        for (int i = 0; i < NbrFichiers; i++)
        {
            if(fichiers[i].Nom == nomFichier)
            {
                return i;
            }
        }
        return -1;
    }

    //methode kat ajouter fichier flkhr d tableau
    public void addFile(Fichier fichier)
    {
        if(NbrFichiers<MaxFichiers)
        {
            fichiers[NbrFichiers] = fichier;
            NbrFichiers++;
            Console.WriteLine("Ficher tzad b naja7");
        }
        else{
            Console.WriteLine("Le répertoire 3aaamr");
        }
        }

        //methode de recherche b extension pdf 
        public Fichier RechercherPDF()
        {
            for (int i = 0; i < NbrFichiers; i++)
            {
                if(fichiers[i].Extension == "pdf")
                {
                    return fichiers[i];
                }
            }
            return null;
            
        }
        //SUPPRIME FICHIER B smiyto
        public void Supprimer(string Smiya)
        {
            int i = RechercherFichier(Smiya);
            if(i!=-1)
            {
                for (int j = i; j < NbrFichiers; j++)
                {
                    fichiers[j] = fichiers[j+1];
                }
                NbrFichiers--;
                Console.WriteLine("Fichier supprimé bi naja7");
            }
            else{
                Console.WriteLine("Fichier makaynch");
                
            }
        }

        //methode bach tbadel taille fichier
        public void ModifierTaille(string nomFichier, float taille)
        {
            int i = RechercherFichier(nomFichier);
            if(i!=-1)
            {
                fichiers[i].Taille = taille;
                Console.WriteLine("Taille modifiée bi naja7");
            }
            else{
                Console.WriteLine("Fichier makaynch");
            }
        }


        //methode bach tbdl smiya
        public void Rennomer(string Smiya,string Smiya2)
    {
        int i = RechercherFichier(Smiya);
        if(i!=-1)
        {
            fichiers[i].Nom = Smiya2;
            Console.WriteLine("Nom modifié bi naja7");
        }
        else{
            Console.WriteLine("Fichier makaynch");
        }

        
    }

      public float GetTaille()
    {
        float tailleTotaleKO = 0;
        for (int i = 0; i < NbrFichiers; i++)
        {
            tailleTotaleKO += fichiers[i].Taille;
        }
        return tailleTotaleKO / 1024; // Conversion en MO
    }
}
        

    




 


