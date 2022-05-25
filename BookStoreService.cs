using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookEshopAPI
{
    public class BookStoreService
    {
        private readonly IMongoCollection<BookStore> _bookStores;
        public BookStoreService(IBookEshopDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _bookStores = database.GetCollection<BookStore>(settings.BookStoreCollectionName);
        }
        public BookStore Get(string id) =>
            _bookStores.Find<BookStore>(bookStore => bookStore.Id == id).FirstOrDefault();
        public BookStore Create(BookStore bookStore)
        {
            _bookStores.InsertOne(bookStore);
            return bookStore;
        }
    }
}
