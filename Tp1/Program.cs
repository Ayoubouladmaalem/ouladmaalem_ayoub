using System;

namespace Tp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Fichier F1 = new Fichier("Classe", ".ensat", 30);
            Fichier F2 = new Fichier("Ecole", ".ensat", 30);
            Fichier F3 = new Fichier("Cité", ".pdf", 20);
            Fichier F4 = new Fichier("home", ".ensat", 15);



            Repertoire R = new Repertoire("Student",15,[F1,F2,F3,F4]);

            R.Afficher();
            // R.SupprimerFichier("Ecole");
            // R.Afficher();

            R.Renommer("Classe","AYOUB");
            R.ModifierTaille("AYOUB",50);
            R.Afficher();

            // int index = R.Rechercher("classe");
            // Console.WriteLine(index);
            // R.RechercherPdf();
        }
    }
}