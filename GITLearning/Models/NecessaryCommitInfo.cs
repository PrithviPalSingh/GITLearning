using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITLearning.Models
{
    class NecessaryCommitInfo
    {
        public string CommitId { get; set; }

        public string CommitDescription { get; set; }

        public string CommittedBy { get; set; }

        public string CommittedOn { get; set; }

        public string AssociatedTask { get; set; }        
    }
}
