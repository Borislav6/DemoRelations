using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; } = null!;
        public virtual ICollection<BookCategory> BooksCategories { get; set; } = null!;
    }
}
