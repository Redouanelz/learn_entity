using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_entity
{
    class Program
    {
        static void Main(string[] args)
        {

            var cnx = new RlzProjectEntities();

            // Reading 
            List<FicheProj> FicheProjList = cnx.FicheProjs.ToList<FicheProj>();
            foreach(FicheProj f in FicheProjList)
            {
                Console.WriteLine(f.NomProj + " " + f.ChefProj );
            }
            // Inserting
            FicheProj FicheProj = new FicheProj()
            {
                IDProj = 123,
                NomProj = "NEW PROJECT",
                ChefProj = "BMYPRO CREATION",
                CodeProj = "CODE123"
                
            };
            cnx.FicheProjs.Add(FicheProj);
            cnx.SaveChanges();
            // Updating
            FicheProj FicheProjUpdate = FicheProjList[0];
            FicheProjUpdate.CodeProj = "NEW CODE 456";
            cnx.SaveChanges();
            // Deleting
            FicheProj FicheProjDelete = FicheProjList[0];
            cnx.FicheProjs.Remove(FicheProjDelete);
            cnx.SaveChanges();

        }
    }
}
