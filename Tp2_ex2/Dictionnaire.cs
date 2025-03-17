namespace Tp2_ex2;

public class Dictionnaire : Document
{
    private string langue;
    private int nbr_mots;

    public Dictionnaire(string titre, string langue, int nbr_mots) : base(titre)
    {
        this.langue = langue;
        this.nbr_mots = nbr_mots;
    }

    public override void Afficher() 
    {
        Console.WriteLine("L'Id est: "+getId()+
                          "\n Le titre est : "+getTitre()+
                          "\n La langue est : "+ langue +
                          "\n Le nbr des mots est : "+nbr_mots);
    }

    public virtual string description()
    {
        return base.description()+"La langue est : "+langue+"\n Le nbr des mots est : "+nbr_mots;
    }
    
}