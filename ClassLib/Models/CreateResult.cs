using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Models
{
    public class CreateResult
    {
        public bool IsSuccessful { get; set; } = false;
        public List<string> Errors { get; set; } = new List<string>();
        public int InsertedObjectId { get; set; } = 0;
    }
}
