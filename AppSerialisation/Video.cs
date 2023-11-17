namespace AppSerialisation
{
    public class Video
    {
        public int Id { get; set; }
        public string Titre { get; set; } = string.Empty;
        public int Duree { get; set; }
        public Youtubeur Youtubeur { get; set; } 

    }
}