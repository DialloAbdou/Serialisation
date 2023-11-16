using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppSerialisation
{
    public class PersonneDocumentXml
    {

        /// <summary>
        ///  Lecture xDocuments
        /// </summary>
        /// <param name="fichier"></param>
        /// <param name="personne"></param>
        /// <returns></returns>
        public static Personne ReadPersonneDocXml(string fichier, Personne personne)
        {

            var doc = XDocument.Load(fichier);

            if (doc.Root is not null)
            {
                foreach (var item in doc.Root.Elements())
                {
                    if (item.Name == "Nom")
                    {
                        personne.Nom = item.Value;
                    }
                    else if (item.Name == "Prenom")
                    {
                        personne.Prenom = item.Value;
                    }else if(item.Name == "DateDeNaissance")
                    {
                        personne.DateDeNaissance = DateTime.Parse(item.Value);
                    }
                    else
                    {
                        personne.Taille = int.Parse(item.Value);
                    }
                }

            }
            return personne;

        }

        public static void AddPersonneDocXml(string fichier)
        {
            var doc = XDocument.Load (fichier);
            var Adresse = new XElement("Adresse", "16 rue Felibre Gaut 13100 Aix-en-provence");
            if (doc.Root is not null)
            {
                var elementTaille = doc.Root.Element("Taille");
                if(elementTaille is not null)
                {
                    elementTaille.AddAfterSelf(Adresse);
                }

            }

            Console.WriteLine(doc);
        }


    }
}
