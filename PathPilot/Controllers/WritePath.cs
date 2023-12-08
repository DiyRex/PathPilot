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
            /*// Get the current value of the PATH variable
            string currentPath = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);

            // Check if the path is already in the variable
            if (!currentPath.Split(';').Contains(newPath, StringComparer.OrdinalIgnoreCase))*/
            if(newPath != null)
            {
                // If not, add it to the PATH variable
                Environment.SetEnvironmentVariable("PATH", newPath, EnvironmentVariableTarget.User);
            }
        }
    }
}
