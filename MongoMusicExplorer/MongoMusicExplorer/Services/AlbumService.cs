using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoMusicExplorer.Models;
using MongoDB.Driver;

namespace MongoMusicExplorer.Services
{
    public class AlbumService
    {
        private readonly IMongoCollection<Album> _albums;

        public AlbumService(IMusicDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _albums = database.GetCollection<Album>(settings.MusicCollectionName);
        }

        public List<Album> Get() =>
            _albums.Find(album => true).ToList();

        public Album Get(string id) =>
            _albums.Find<Album>(album => album._id == id).FirstOrDefault();

        public Album Create(Album album)
        {
            _albums.InsertOne(album);
            return album;
        }

        public void Update(string id, Album albumIn) =>
            _albums.ReplaceOne(album => album._id == id, albumIn);

        public void Remove(Album albumIn) =>
            _albums.DeleteOne(album => album._id == albumIn._id);

        public void Remove(string id) =>
            _albums.DeleteOne(album => album._id == id);
    }
}
