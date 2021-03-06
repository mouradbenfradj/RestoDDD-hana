using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoDDD.Application.Entities
{
    public class Reservation_DTO
    {
        public int ReservationId { get; set; }
        public int NombrePres { get; set; }
        public DateTime ResvDate { get; set; }

        public int id_resto { get; set; }
        public int id_memb { get; set; }


        public virtual Membre_DTO Membre { get; set; }
        public virtual Restaurant_DTO Restaurant { get; set; }
    }
}
