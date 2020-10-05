using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery.Models
{
    public class Imagen
    {
        public int id { get; set; }
        public string author { get; set; }
        public string width   { get; set; }
        public string height { get; set; }
        public string url { get; set; }

        public string download_url { get; set; }


    }
}