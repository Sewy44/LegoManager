using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoManager.Models
{
    public class Lego
    {
        public int LegoID { get; set; }
        public string SetName { get; set; }
        public int ReleaseYear { get; set; }
        public double CurrentValue { get; set; }
        public int NumberOfPieces { get; set; }
        public int NumberOfSetsOwned { get; set; }
    }
}
