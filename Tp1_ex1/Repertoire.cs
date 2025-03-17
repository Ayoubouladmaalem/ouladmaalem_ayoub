using System.ComponentModel.DataAnnotations.Schema;

namespace Tp1;

public class Repertoire
{
    private string nom;
    private int nbr_fichiers;
    private Fichier[] fichiers;
    
    public Repertoire(){}

    public Repertoire(string nom, int nbr_fichiers, Fichier[] fichiers)
    {
        this.nom = nom;
        this.nbr_fichiers = nbr_fichiers;
        this.fichiers = fichiers;

    }

    public void Afficher()
    {
        Console.WriteLine("Le nom de repertoire est "+nom);
        if (fichiers.Length == 0)
        {
            Console.WriteLine("Le fichiers est empty");
        }

        foreach (Fichier fichier in fichiers)
        {
            fichier.Afficher();
        }
        {
            
        }
    }

    public int Rechercher(string nom)
    {
        for (int i = 0; i < fichiers.Length; i++)
        {
            if (fichiers[i].getNom() == nom)
            {
                return i;

            }
        }
        return -1;
    }

    public void Ajouter(Fichier fichier)
    {
        Fichier[] nouveauTableau = new Fichier[fichiers.Length + 1]; // Nouveau tableau avec une case en plus
        for (int i = 0; i < fichiers.Length; i++)
        {
            nouveauTableau[i] = fichiers[i]; // Copier les anciens fichiers
        }
        nouveauTableau[fichiers.Length] = fichier; // Ajouter le nouveau fichier
        fichiers = nouveauTableau; // Remplacer l'ancien tableau
    }

    public void RechercherPdf()
    {
        for (int i = 0; i < fichiers.Length; i++)
        {
            if (fichiers[i].getExtension() == ".pdf")
            {
                Console.WriteLine("Fichier PDF trouvé : " + fichiers[i].getNom() + fichiers[i].getExtension());
            }
        }
    }
    
    //Supprimer ➔ enlève un fichier du tableau en utilisant son nom;

    public void SupprimerFichier(string nom)
    {
        int index = Rechercher(nom);
        
        if (index == -1) // Si le fichier n'existe pas
        {
            Console.WriteLine("Fichier non trouvé : " + nom);
            return;
        }
        
        Fichier[] nouveauTableau = new Fichier[fichiers.Length - 1];

        
        //copie les fichiers sauf celui a supprimer 
        int j = 0;
        for (int i = 0; i < fichiers.Length; i++)
        {
            if (i != index)
            {
                nouveauTableau[j] = fichiers[i];
                j++;
            }
        }
        // Mise à jour du tableau original
        fichiers = nouveauTableau;

        Console.WriteLine("Fichier supprimé avec succès : " + nom);
    }
    
    // Renommer ➔ Modifie le nom d’un fichier.

    public void Renommer(string oldName, string newName)
    {
        int index = Rechercher(oldName);

        if (index == -1)
        {
            Console.WriteLine("Fichier non trouvé");
        }
        
        fichiers[index].setNom(newName);
        Console.WriteLine("Fichier renommé avec succès"+oldName+ "->" +newName);
    }

    public void ModifierTaille(string nom, float newtaille)
    {
        int index = Rechercher(nom);
        if (index == -1)
        {
            Console.WriteLine("Le fichier n'existe pas ");
        }
        fichiers[index].setTaille(newtaille);
        Console.WriteLine("La taille de fichier est modifié vers "+newtaille);
    }

}