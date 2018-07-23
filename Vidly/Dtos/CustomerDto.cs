using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        //Only use primitive data types in Dto objects

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }
       
        public byte MembershipTypeId { get; set; } //byte means implicit validation check & error if no value provided

       
        public DateTime? Birthdate { get; set; }

    }
}