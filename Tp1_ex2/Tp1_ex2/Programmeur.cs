namespace DefaultNamespace;

public class Programmeur
{
    private int id;
    private string nom;
    private string prenom;
    private int bureau;
    

    public Programmeur(int id, string nom, string prenom, int bureau)
    {
        this.id = id;
        this.nom = nom;
        this.prenom = prenom;
        this.bureau = bureau;
    }

    public void Afficher()
    {
        Console.WriteLine("Le nom de programmeur est : "+ nom+
                        "\n le prenom est :"+prenom+"\n Son bureau est :"+bureau  );
    }

    public string getNom()
    {
        return nom;
    }
    public int getBureau(){return bureau;}
    public void setBureau(int bureau){this.bureau = bureau;}
    
}