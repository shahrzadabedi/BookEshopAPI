using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookEshopAPI
{
    public class BookStoreBook
    {
        public MongoDBRef Book { get; set; }
        public MongoDBRef BookStore { get; set; }
    }
}
