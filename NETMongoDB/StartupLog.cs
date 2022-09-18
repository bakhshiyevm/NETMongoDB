using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETMongoDB
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class BuildEnvironment
    {
        public string distmod { get; set; }
        public string distarch { get; set; }
        public string cc { get; set; }
        public string ccflags { get; set; }
        public string cxx { get; set; }
        public string cxxflags { get; set; }
        public string linkflags { get; set; }
        public string target_arch { get; set; }
        public string target_os { get; set; }
        public string cppdefines { get; set; }
    }

    public class Buildinfo
    {
        public string version { get; set; }
        public string gitVersion { get; set; }
        public string targetMinOS { get; set; }
        public List<object> modules { get; set; }
        public string allocator { get; set; }
        public string javascriptEngine { get; set; }
        public string sysInfo { get; set; }
        public List<int> versionArray { get; set; }
        public Openssl openssl { get; set; }
        public BuildEnvironment buildEnvironment { get; set; }
        public int bits { get; set; }
        public bool debug { get; set; }
        public int maxBsonObjectSize { get; set; }
        public List<string> storageEngines { get; set; }
    }

    public class CmdLine
    {
        public string config { get; set; }
        public Net net { get; set; }
        public bool service { get; set; }
        public Storage storage { get; set; }
        public SystemLog systemLog { get; set; }
    }

    public class Date
    {
        [JsonProperty("$numberLong")]
        public string NumberLong { get; set; }
    }

    public class Journal
    {
        public bool enabled { get; set; }
    }

    public class Net
    {
        public string bindIp { get; set; }
        public int port { get; set; }
    }

    public class Openssl
    {
        public string running { get; set; }
    }

    public class Pid
    {
        [JsonProperty("$numberLong")]
        public string NumberLong { get; set; }
    }

    public class Root
    {
        public string _id { get; set; }
        public string hostname { get; set; }
        public StartTime startTime { get; set; }
        public string startTimeLocal { get; set; }
        public CmdLine cmdLine { get; set; }
        public Pid pid { get; set; }
        public Buildinfo buildinfo { get; set; }
    }

    public class StartTime
    {
        [JsonProperty("$date")]
        public Date Date { get; set; }
    }

    public class Storage
    {
        public string dbPath { get; set; }
        public Journal journal { get; set; }
    }

    public class SystemLog
    {
        public string destination { get; set; }
        public bool logAppend { get; set; }
        public string path { get; set; }
    }


}
