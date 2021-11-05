using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Models.Entities
{
    public class ContactPost:BaseEntities
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]

        public string Content { get; set; } 
        [Required]

        public string Subject { get; set; }
        public string Answer { get; set; }
        public DateTime? AnswerDate { get; set; }
        public int AnswerByUserID { get; set; }


    }
}
