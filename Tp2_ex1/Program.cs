
using tp2;

public class Program
{
    static void Main(string[] args)
    {
        Employee E1 = new Employee("Anas", 1000, "secretaire", "12/22/2018");
        Employee E2 = new Employee("Anas", 1000, "secretaire", "12/22/2018");
        Employee E3 = new Employee("Anas", 1000, "secretaire", "12/22/2018");
        Employee E4 = new Employee("Anas", 1000, "secretaire", "12/22/2018");

        GestionEmployes G = new GestionEmployes();
        
        G.addEmployee(E1);
        G.addEmployee(E2);
        G.addEmployee(E3);
        G.addEmployee(E4);

        G.salaireTotal();
        
        G.Afficher();
        
        Console.WriteLine("-----------------Directeur-------------------");
        Directeur directeur = Directeur.getInstance();
        directeur.setGestionEmployes(G);
        directeur.GetGestionEmployes().Afficher();
    }
}