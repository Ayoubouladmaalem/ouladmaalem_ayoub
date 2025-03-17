namespace tp2;

public class GestionEmployes
{
    private List<Employee> employees;

    public GestionEmployes()
    {
        employees = new List<Employee>();
    }

    public void addEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public void supprimerEmployee(Employee employee)
    {
        employees.Remove(employee);
    }
    

    public float salaireTotal()
    {
        float total = 0;
        for (int i=0; i<employees.Count; i++)
        {
            total += employees[i].getSalaire(); 
        }
        return total;
    }

    public float salaireMoyen(Employee emp)
    {
        float moyen = 0;
        moyen = emp.getSalaire() / salaireTotal();
        return moyen;
    }

    public void Afficher()
    {
        foreach(Employee emp in employees)
        {
            emp.Afficher();
            Console.WriteLine("Le salaire moyen: "+ salaireMoyen(emp));
        }
        Console.WriteLine("\n Le salaire Total:"+ salaireTotal());
        
    }
    
}