namespace tp2;

public class Employee
{
    private string nom;
    private float salaire;
    private string poste;
    private string dateEmbauche;

    public Employee(string nom, float salaire, string poste, string dateEmbauche)
    {
        this.nom = nom;
        this.salaire = salaire;
        this.poste = poste;
        this.dateEmbauche = dateEmbauche;
        
    }
    
    public string getNom(){ return this.nom; }
    public void setNom(string nom){ this.nom = nom; }
    
    public float getSalaire(){ return this.salaire; }
    public void setSalaire(float salaire){ this.salaire = salaire; }
    
    public string getPoste(){ return this.poste; }
    public void setPoste(string poste){ this.poste = poste; }
    
    public string getDateEmbauche(){ return this.dateEmbauche; }
    public void setDateEmbauche(string dateEmbauche){this.dateEmbauche = dateEmbauche; }

    public void Afficher()
    {
        Console.WriteLine("Le nom d'Employee : "+nom+
                          "\n Le salaire : "+salaire+
                          "\n Son poste : "+poste+
                          "\n Date d'Embauche :"+dateEmbauche);
    }
}