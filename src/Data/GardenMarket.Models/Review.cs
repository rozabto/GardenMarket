using System;
using System.Collections.Generic;
using System.Text;

namespace GardenMarket.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }
    }
}
