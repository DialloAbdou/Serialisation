﻿// See https://aka.ms/new-console-template for more information
using System.Xml;
using System.Xml.Linq;
using AppSerialisation;

Personne personne = new Personne();
//Console.WriteLine(" Lecture XML avec XMLReader !");
//// Appelle de la methode  Reader
//PersonneReader.AfficheReadXmlPersonne(personne);
//// Appelle de la methode Writer
//PersonneWriter.CreateXmlPersonne(personne);

//// utilisation des documents 

var fichier = @"C:\FormationC#\Serialisation\AppSerialisation\serialisationXml.xml";
if (fichier is not null)
{
    var personneFin = PersonneDocumentXml.ReadPersonneDocXml(fichier, personne);

    Console.WriteLine($"les Données Personne Nom: {personneFin.Nom}, Prenom : {personneFin.Prenom}, DateNaissance : {personneFin.DateDeNaissance:dd/mm/yyyy}, Taille : {personneFin.Taille} cm");
}

if (fichier is not null)
  PersonneDocumentXml.AddPersonneDocXml(fichier);
EcritureJson.writeJson();

// Serialisation d'un objet

var youtubeur = new Youtubeur
{
    Id = 1,
    Nom = "DIALLO",
    titre = "Developpeur .Net",
    Videos = new List<Video> { new Video { Titre = " serialisation en Json",Duree =108 },new Video { Titre = "Test Unitaire",Duree = 208 }
                }
};

var json = SerialisationJson.createSerialisationObjet(youtubeur);

Console.WriteLine($"{json}");




