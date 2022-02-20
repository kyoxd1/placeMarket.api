using System;


namespace placeMarket.api.Models
{
    public class UserRol
    {
         public int Id { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual Rol Rol { get; set; }
        public int RolId { get; set; }
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }
        public string Status { get; set; } // pending/available/completed //main/assistant
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        //Params
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserCreationId { get; set; }
        public int UserUpdateId { get; set; }
        public DateTime DeleteDate { get; set; }
        public int DeleteUserId { get; set; }

    }
}