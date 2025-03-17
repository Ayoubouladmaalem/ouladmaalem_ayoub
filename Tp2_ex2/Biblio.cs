namespace Tp2_ex2;

public class Biblio
{
    private List<Document> documents;
    
    public Biblio()
    {
        documents = new List<Document>();
    }

    public void addDocument(Document doc)
    {
        documents.Add(doc);
    }

    public int Count()
    {
        int count = 0;
        foreach (Document doc in documents)
        {
            if (doc is Livre)
            {
                count++;
            }
        }

        return count;
    }

    public void AfficherDictionnaire()
    {
        for (int i = 0; i < documents.Count; i++)
        {
            if (documents[i] is Dictionnaire dic)
            {
                dic.Afficher();
            }
        }
    }

    public void tousLesAuteurs()
    {
        foreach (Document doc in documents)
        {
            Console.WriteLine("Numéro est :" +doc.getId());
            if (doc is Livre l)
            {
                Console.WriteLine("Les auteurs: " + l.getAuteur());
            }
            else
            {
                Console.WriteLine("Aucun auteur");
            }
        }
    }

    public void toutesLesDescriptions()
    {
        foreach (Document doc in documents)
        {
            if (doc is Livre l)
            {
                Console.WriteLine(l.description());
            }
            else if (doc is Dictionnaire dic)
            {
                Console.WriteLine(dic.description());
            }
        }
    }
    
    
    
    
    
}