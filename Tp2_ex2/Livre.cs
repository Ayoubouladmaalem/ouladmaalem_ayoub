namespace Tp2_ex2;

public class Livre : Document
{
    private string auteur;
    private int nbr_page;

    public Livre(string titre, string auteur, int nbr_page) : base(titre)
    {
        this.auteur = auteur;
        this.nbr_page = nbr_page;
    }

    public override void Afficher() 
    {
        Console.WriteLine("L'Id est: "+getId()+
                          "\n Le titre est : "+getTitre()+
                          "\n L'auteur est : "+ auteur +
                          "\n Le nbr de page est : "+nbr_page);
    }
    public string getAuteur(){return auteur;}

    public override string description()
    {
        return base.description() + "\n Auteur : " + auteur + "\n Pages : "+nbr_page;
    }
}