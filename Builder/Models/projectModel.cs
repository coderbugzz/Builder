using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models
{
    public class projectModel
    {
        public string ProjectName { get; set; }
        public ProjectDetails details { get; set; }
    }


    public class ProjectDetails
    {
        
        public string CsprojLocation { get; set; }
        public string ProjectOutput { get; set; }
        public string CloneRepository { get; set; }

        public string ProjectSolution { get; set; }
    }
}
