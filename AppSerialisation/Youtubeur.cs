using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSerialisation
{
    public class Youtubeur
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string titre { get; set; } = string.Empty;
        public List<Video>Videos{ get; set; }

    }
}
