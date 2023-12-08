using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPilot.Controllers
{
    internal class WritePath
    {
        public static void AddPath(string newPath)
        {
            if(newPath != null)
            {
                Environment.SetEnvironmentVariable("PATH", newPath, EnvironmentVariableTarget.User);
            }
        }
    }
}
