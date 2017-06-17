using GITLearning.Models;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITLearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  Repository repo = new Repository(@"E:\Repo\GIT\TFSAssist");
            var branchInfoList = new List<BranchInfo>();
            //foreach (Commit commit in repo.Commits)
            //{
            //}

            //foreach (var branch in repo.Branches)
            //{
            //    var branchInfo = new BranchInfo()
            //    {
            //        Name = branch.FriendlyName,
            //        CommitCount = branch.Commits.Count()
            //    };

            //    foreach (Commit commit in branch.Commits)
            //    {

            //    }

            //    branchInfoList.Add(branchInfo);
            //}

            //dataGridView1.DataSource = branchInfoList;

            using (var repo = new Repository(@"E:\Repo\GIT\TFSAssist"))
            {
                const string commitSha = "433a62f8c17db361a963d950b1c7c313a2c2d0a4";
                //IEnumerable<Branch> branches = ListBranchesContaininingCommit(repo, commitSha);

                foreach (var branch in repo.Branches)
                {
                    var commits = repo.Commits.Where(c => c.Sha == commitSha);

                    if (!commits.Any())
                    {
                        continue;
                    }

                    //yield return branch;
                }

                //branches.Count().ShouldEqual(6);

                //const string otherCommitSha = "4a202b346bb0fb0db7eff3cffeb3c70babbd2045";
                //branches = ListBranchesContaininingCommit(repo, otherCommitSha);

                //branches.Count().ShouldEqual(1); // origin/packed-test
            }
        }

        private IEnumerable<Branch> ListBranchesContaininingCommit(Repository repo, string commitSha)
        {
            bool directBranchHasBeenFound = false;
            foreach (var branch in repo.Branches)
            {
                if (branch.Tip.Sha != commitSha)
                {
                    continue;
                }

                directBranchHasBeenFound = true;
                yield return branch;
            }

            if (directBranchHasBeenFound)
            {
                yield break;
            }

            foreach (var branch in repo.Branches)
            {
                var commits = repo.Commits.QueryBy(new CommitFilter { IncludeReachableFrom = branch }).Where(c => c.Sha == commitSha);

                if (!commits.Any())
                {
                    continue;
                }

                yield return branch;
            }
        }
    }
}
