using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AppSerialisation
{
    public class PersonneReader
    {

        public static void AfficheReadXmlPersonne(Personne personne)
        {
            var setting = new XmlReaderSettings
            {
                IgnoreComments = true,
                IgnoreWhitespace = true
            };
            var reader = XmlReader.Create(@"C:\FormationC#\Serialisation\AppSerialisation\serialisationXml.xml", setting);

            reader.ReadStartElement("Personne");
            reader.ReadStartElement("Nom");
            personne.Nom = reader.ReadContentAsString();
            reader.ReadEndElement(); // fin de lecture
            reader.ReadStartElement("Prenom");
            personne.Prenom = reader.ReadContentAsString();
            reader.ReadEndElement(); // fin de lecture
            reader.ReadStartElement("DateDeNaissance");
            personne.DateDeNaissance = reader.ReadContentAsDateTime();
            reader.ReadEndElement(); // fin de lecture
            reader.ReadStartElement("Taille");
            personne.Taille = reader.ReadContentAsInt();
            reader.ReadEndElement(); // fin de lecture
            reader.ReadEndElement(); // fin de lecture

            Console.WriteLine($"les Données Personne Nom: {personne.Nom}, Prenom : {personne.Prenom}, DateNaissance : {personne.DateDeNaissance:dd/mm/yyyy}, Taille : {personne.Taille} cm");

        }
    }
}
