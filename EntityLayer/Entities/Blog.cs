using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Name { get; set; }
       
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public List<Comment> Comments { get; set; }
		public int AuthorId { get; set; }
		public Author Author { get; set; }
       

    }
}
