using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models
{
    public class Product
    {
        //Šifra izdelka
        public string Code { get; set; } = string.Empty;

        //Model izdelka
        public string Model { get; set; } = string.Empty;

        //Širina aparata
        public int Width { get; set; }

        //Višina aparata
        public int Height { get; set; }
        
        //Globina aparata
        public int Depth { get; set; }
    }
}
