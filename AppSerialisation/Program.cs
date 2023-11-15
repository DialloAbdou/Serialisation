// See https://aka.ms/new-console-template for more information
using System.Xml;
using AppSerialisation;

Personne personne = new Personne();
Console.WriteLine(" Lecture XML avec XMLReader !");
// Appelle de la methode  Reader
PersonneReader.AfficheReadXmlPersonne(personne);

// Appelle de la methode Writer
PersonneWriter.CreateXmlPersonne(personne);
//Console.ReadLine();

