using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
	public class NewsLetter
	{
        [Key]
        public int MailId { get; set; }
        public string Email { get; set; }
        public bool EmaiLStatus { get; set; }

    }
}
