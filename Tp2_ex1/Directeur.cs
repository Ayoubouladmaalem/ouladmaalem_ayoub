namespace tp2;

public class Directeur
{
    private static Directeur instance; // Instance unique
    private GestionEmployes gestionEmployes;
    
    // Constructeur privé pour empêcher l'instanciation directe
    private Directeur()
    {
        gestionEmployes = new GestionEmployes(); // Initialise la gestion des employés
    }

    public static Directeur getInstance()
    {
        if (instance == null)
        {
            instance = new Directeur();
        }
        return instance;
    }
    
    // Méthode pour récupérer la gestion des employés
    public GestionEmployes GetGestionEmployes()
    {
        return gestionEmployes;
    }

    public void setGestionEmployes(GestionEmployes G)
    {
        this.gestionEmployes = G;
    }

    public void salaireTotal()
    {
        gestionEmployes.salaireTotal();
    }

    public void salaireMoyen(Employee employee)
    {
        gestionEmployes.salaireMoyen(employee);
    }
    
    
}