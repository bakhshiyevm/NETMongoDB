// See https://aka.ms/new-console-template for more information
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using NETMongoDB;

Console.WriteLine("Hello, World!");


string connectionString = "mongodb://localhost:27017";
MongoClient client = new MongoClient(connectionString);
IMongoDatabase local = client.GetDatabase("local");
IMongoDatabase dev = client.GetDatabase("dev");

var x = local.GetCollection<Root>("startup_log");
var usersCol = dev.GetCollection<User>("users");
var bson = dev.GetCollection<BsonDocument>("users");

var users = dev.GetCollection<User>("users").Find(x=>
!string.IsNullOrEmpty(x.name));

var us = new User { age = 21, name = "murmur" };
var uskid = new User { age = 12, name = "kid" };

BsonDocument user = new BsonDocument(us.ToBsonDocument());

usersCol.InsertOne(uskid);
bson.InsertOne(user);

;

   using (var cursor = client.ListDatabasesAsync().GetAwaiter().GetResult())
    {
        var databaseDocuments = await cursor.ToListAsync();
        foreach (var databaseDocument in databaseDocuments)
        {
            Console.WriteLine(databaseDocument["name"]);
        }
    }