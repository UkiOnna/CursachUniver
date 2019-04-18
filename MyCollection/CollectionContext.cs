namespace MyCollection
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CollectionContext : DbContext
    {

        public CollectionContext()
            : base("name=CollectionContext")
        {
        }

         public virtual DbSet<CollectionElement> Elements { get; set; }
    }

}