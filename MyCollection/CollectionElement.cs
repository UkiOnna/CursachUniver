using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection
{
   public class CollectionElement
    {
        [Key]
        public int Id { get; set; }
        public string ElementType { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public bool IsWatched { get; set; }
        public string Link { get; set; }
        public int? Rate { get; set; }
        public DateTime CreationDate { get; set; }
        public byte[] Image { get; set; }
    }
}
