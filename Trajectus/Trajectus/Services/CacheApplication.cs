using Newtonsoft.Json;
using System.IO;
using System.Reflection;
using System.Web;

namespace Trajectus.Services
{
    public class CacheApplication
    { 
        private static readonly CacheApplication _instance = new CacheApplication();
        private CacheApplication() { }
        public static CacheApplication Instance {  get { return _instance;  } }

        public string RootPath { get { return HttpContext.Current.Server.MapPath(@"~\"); } }

        public string ResourcesPath {  get { return Path.Combine(RootPath, @"Resources\"); } }
    }
}