using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETMongoDB
{
	public class User
	{
		[BsonId(IdGenerator = typeof(ObjectIdGenerator))]
		public ObjectId _id { get; set; }
		public string name { get; set; }
		public int age { get; set; }
	}
}
