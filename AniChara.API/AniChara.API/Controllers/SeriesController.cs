using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using AniChara.API.Models;

namespace AniChara.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private IMongoCollection<Series> _seriesCollection;

        public SeriesController(IMongoClient client)
        {
            var db = client.GetDatabase("anichara_db");
            _seriesCollection = db.GetCollection<Series>("series");
        }

        [HttpGet]
        public IEnumerable<Series> Get()
        {
            return _seriesCollection.Find(new BsonDocument()).ToList();
        }
    }
}
