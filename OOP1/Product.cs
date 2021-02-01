using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //snippet
        public int Id { get; set; } //Priöary Key
        public int CategoryId { get; set; } //Foreign Key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        // CRUD Operations (Create - Read - Update - Delete )

    }
}
