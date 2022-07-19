using System;
using System.Collections.Generic;
using System.Text;

namespace Generateur
{
    class Fichier
    {
        public string REFFICHIER { get; set; }
        public byte[] FICHIER { get; set; }
        public string NOM_FICHIER { get; set; }
        public string TAILLE { get; set; }
        public DateTime DATE_ENREGISTREMENT { get; set; }
        public string type { get; set; }
        public string CODECLIENT { get; set; }
        public string DESCRIPTION { get; set; }
        public string REFABONNE { get; set; }
    }
}
