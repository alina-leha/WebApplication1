using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Anime
    {
        public int Id { get; set; }
        public string img { set; get; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}
