using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FWRuleDeciderTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var _assembly = Assembly.GetExecutingAssembly();
            var _stream = _assembly.GetManifestResourceStream("FWRuleDeciderTestConsole.EmbeddedResourceTest.txt");
            string[] allResources = GetEmbeddedResourceNames();
            
            int a = 5;

        }
        public static Stream GetEmbeddedResourceStream(string resourceName)
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
        }
        public static string[] GetEmbeddedResourceNames()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();
        }
    }
}
