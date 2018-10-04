using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebAppSample
{
    public class DumpAllEnvController : Controller
    {
        public IDictionary Index()
        {
            String output = "";
            IDictionary d = System.Environment.GetEnvironmentVariables();
            foreach(DictionaryEntry entry in d)
            {
                output += entry.Key + ": " + entry.Value;
                Console.Out.WriteLine(output);
                output += "<br/>";
            }
            return d;
        }
    }
}
