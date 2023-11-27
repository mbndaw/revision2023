 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revision1App1.DAO;
using revision1App1.Models;

namespace revision1App1
{
    internal class Program
    {
        private static bool continuer;

        static void Main(string[] args)
       {
            //    List<employer> employer = new List<employer>();
            //    Console.WriteLine("Combien d'employers voulez vous ajouter ? ");
            //    int nombreEmployer = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < nombreEmployer; i ++ )
            //    {
            //        Console.WriteLine($"Saisie de l'employer {i + 1 }");
            //        employer nouvelEmployer = new employer();   
            //        nouvelEmployer.Saisie();
            //        employer.Add( nouvelEmployer );
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("La liste des employer saisis est :");
            //    foreach (employer emp in employer ) { 
            //     Console.WriteLine(emp.ToString()); 
            //    Console.WriteLine();
            //    }
            //
            Console.WriteLine("saisir 1 pour ajouter un employer \n");
            Console.WriteLine("saisir 2 pour afficher tous les employer \n");
            Console.WriteLine("saisir 3 pour rechercher un employer \n");
            int choix = int.Parse(Console.ReadLine());
            IEmploye etudiantdao = new EmployeDAO();
            switch (choix)
            {
                case 1:
                    try
                    {
                        employer employer = new employer();
                       
                            employer.Saisie();
                            etudiantdao.Add(employer);
                            Console.WriteLine("employer ajouté avec succes!");
                        //while (continuer)
                        //{
                            Console.WriteLine("voulez vous continuer à saisir?( Tapez 1 si oui ,0 non");
                        string reponse = Console.ReadLine();
                        continuer = (reponse == "1");

                        //}

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e);
                    }
                    break;
                case 2:
                    etudiantdao.FindAll().ForEach(em => Console.WriteLine(em));
                    break;

                case 3:
                    Console.WriteLine("saisir le matricule de l'employer \n");
                    string matricule = Console.ReadLine();
                    employer et = etudiantdao.FindByMatricule(matricule);
                    if (et != null)
                    {
                        Console.WriteLine(et);
                       
                    }
                    else
                    {
                        Console.WriteLine("employer introuvable ");
                    }

                    break;
            }
        }
    }
}
