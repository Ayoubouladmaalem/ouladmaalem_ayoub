namespace Tp1;

public class Fichier
{
    private string nom;
    private string extension;
    private float Taille;

    public Fichier(string nom, string extension, float Taille)
    {
        this.nom = nom;
        this.extension = extension;
        this.Taille = Taille;
    }

    public void Afficher()
    {
        Console.WriteLine(
            "Nom de fichier est "+ nom+
            "Extension de fichier est "+ extension+
            "La taille de fichier est "+Taille
        );
    }

    public string getNom()
    {
        return nom;
    }

    public void setNom(string nom)
    {
        this.nom = nom;
    }
    
    public string getExtension(){ return extension; }

    public void setTaille(float taille)
    {
        this.Taille = taille;
    }

    public void getTaille()
    {
      Console.WriteLine("La taille de fichier est"+Taille*0.001+"MO");  
    }

}