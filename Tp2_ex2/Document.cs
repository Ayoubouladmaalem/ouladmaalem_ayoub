namespace Tp2_ex2;

public abstract class Document
{
    private static int compteur = 0;
    private int Id ;
    private string titre;

    public Document(string titre)
    {
        this.Id = ++compteur;
        this.titre = titre;
    }

    public abstract void Afficher();
    
    public int getId(){return Id;}
    public string getTitre(){return titre;}
    
    public void setTitre(string titre){this.titre = titre;}
    public void setId(int Id){this.Id = Id;}

    public virtual string description()
    {
        return "id"+Id +" titre"+titre;
    }
}