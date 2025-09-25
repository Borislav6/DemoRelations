using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class Biography:BaseEntity
    {
        public string BiographyData { get; set; }
        public DateTime BirthDate { get; set; }

        public string PlaceOfBirth { get; set; }

        public string Nationality { get; set; }

        public int AuthorId { get; set; }
            public virtual Author Author { get; set; }

    }
}
