using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoMusicExplorer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Passing the connection string in MongoClient  
            //var client = new MongoClient("mongodb+srv://TestUser:PASSWORD@cluster0.maoqh.mongodb.net/sample?retryWrites=true&w=majority");
            ////Get sample_mflix Database  
            //var db = client.GetDatabase("sample_mflix");
            ////Get movies collection  
            //var collection = db.GetCollection<BsonDocument>("movies");
            ////Find document with title Peter Pan  
            //var result = collection.Find("{title:'Peter Pan'}").FirstOrDefault();
            //Console.WriteLine(result);

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
