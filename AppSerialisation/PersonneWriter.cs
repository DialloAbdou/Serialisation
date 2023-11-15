using System.Xml;

namespace AppSerialisation
{
    public class PersonneWriter
    {

        public static void CreateXmlPersonne(Personne personne)
        {
            
            var parametre = new XmlWriterSettings
            {
                Indent = true,
            };

            var writer = XmlWriter.Create(@"C:\FormationC#\Serialisation\AppSerialisation\data.xml", parametre);
           
            writer.WriteStartElement("personne");
            writer.WriteElementString("Nom",personne.Nom);
            writer.WriteElementString("Prenom",personne.Prenom);
            writer.WriteElementString("DateDeNaissance",personne.DateDeNaissance.ToString());
            writer.WriteElementString("Taille",personne.Taille.ToString());
            writer.WriteEndElement();
            writer.Flush();
        }
    }


    
}
