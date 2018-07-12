using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer:IEnumerable
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; } //Navigational Property

        public byte MembershipTypeId { get; set; }

        public DateTime? Birthdate  { get; set; }


        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}