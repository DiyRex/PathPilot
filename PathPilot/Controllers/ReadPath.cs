using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPilot.Controllers
{
    internal class ReadPath
    {
        public static string[] ReadValue()
        {
            string currentPath = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
            string[] path = currentPath.Split(';');
            return path;
        }
    }
}
