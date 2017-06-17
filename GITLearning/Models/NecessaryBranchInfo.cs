using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITLearning.Models
{
    class NecessaryBranchInfo
    {
        public string BranchName { get; set; }

        public int CommitCount { get; set; }

        public List<NecessaryBranchInfo> Commits { get; set; }

        public bool IsOriginator { get; set; }
    }
}
