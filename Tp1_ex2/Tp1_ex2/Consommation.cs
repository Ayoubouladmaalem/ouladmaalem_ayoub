namespace DefaultNamespace;

public class Consommation
{
    private int no_semaine;
    private int id_programmeur;
    private int nb_Tasses;

    public Consommation(int noSemaine, int idProgrammeur, int nbTasses)
    {
        no_semaine = noSemaine;
        id_programmeur = idProgrammeur;
        nb_Tasses = nbTasses;
    }

    public void Afficher()
    {
        Console.WriteLine("Le nombre de semaines" + no_semaine+ "id_programmeur"+id_programmeur+"nb_Tasses"+nb_Tasses);
    }
    
    public int getNoSemaine(){return no_semaine;}
    public int getIdProgrammeur(){return id_programmeur;}
    public int getNbTasses(){return nb_Tasses;}
    
}