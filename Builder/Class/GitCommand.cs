using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Class
{
    public static class GitCommand
    {
        public static string command(string location, string command)
        {
            string output = "";
            using (PowerShell powerShell = PowerShell.Create())
            {

                string commnd_text = "cd " + location + "\n";
                commnd_text += command;
                powerShell.AddScript(commnd_text);
                powerShell.AddCommand("Out-String");
                Collection<PSObject> PSOutput = powerShell.Invoke();

                StringBuilder stringBuilder = new StringBuilder();
                foreach (PSObject pSObject in PSOutput)
                    stringBuilder.AppendLine(pSObject.ToString());
                output = stringBuilder.ToString();
            }

            return output;
        }
    }
}
