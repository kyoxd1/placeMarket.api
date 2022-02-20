using System.Collections.Generic;

namespace placeMarket.api.Models
{
    public class Rol
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public bool Default { get; set; }
        public virtual ICollection<UserRol> UserRols { get; set; }

    }
}