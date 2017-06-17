using GITLearning.Models;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITLearning
{
    public partial class BranchAndCommitTagging : Form
    {
        private static Repository _myRepository = null;

        public static Repository MyRepository
        {
            get
            {
                if (_myRepository == null)
                {
                    _myRepository = new Repository(ConfigurationManager.AppSettings["GitRepoName"]);
                }

                return _myRepository;
            }
        }

        public BranchAndCommitTagging()
        {
            InitializeComponent();
        }

        private void frmBranchAndCommitTagging_Load(object sender, EventArgs e)
        {
            var branchInfoList = new List<NecessaryBranchInfo>();
            lblAllBranchCount.Text = MyRepository.Branches.Count().ToString();

            foreach (var branch in MyRepository.Branches)
            {
                tvAllBranches.Nodes.Add(branch.FriendlyName);
            }
        }

        private void tvAllBranches_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string branchName = (sender as TreeView).SelectedNode.Text;
            List<NecessaryCommitInfo> commitInfoList = new List<NecessaryCommitInfo>();

            var branch = MyRepository.Branches.FirstOrDefault(c => c.FriendlyName.Equals(branchName, StringComparison.CurrentCultureIgnoreCase));


            foreach (var commit in branch.Commits)
            {
                var commitInfo = new NecessaryCommitInfo()
                {
                    CommitId = commit.Sha,
                    CommitDescription = commit.Message,
                    CommittedBy = commit.Author.Name,
                    CommittedOn = commit.Author.When.ToString(),
                    ////TODO AssociatedTask = commit.Tree;
                };

                commitInfoList.Add(commitInfo);
            }

            dgAllBranchInfo.DataSource = commitInfoList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<NecessaryBranchInfo> branchInfoList = new List<NecessaryBranchInfo>();
            var branches = MyRepository.Branches.ToList().FindAll(x => x.Commits.Any(y => y.Sha == txtCommitId.Text));

            foreach (var branch in branches)
            {
                var branchInfo = new NecessaryBranchInfo
                {
                    BranchName = branch.FriendlyName
                };

                branchInfoList.Add(branchInfo);
            }

            dgBranches.DataSource = branchInfoList;
        }

        private IEnumerable<Branch> ListBranchesContaininingCommit(Repository repo, string commitSha)
        {
            //using (var repo = new Repository(@"E:\Repo\GIT\TFSAssist"))
            //{
            //    const string commitSha = "433a62f8c17db361a963d950b1c7c313a2c2d0a4";
            //    //IEnumerable<Branch> branches = ListBranchesContaininingCommit(repo, commitSha);

            //    foreach (var branch in repo.Branches)
            //    {
            //        var commits = repo.Commits.Where(c => c.Sha == commitSha);

            //        if (!commits.Any())
            //        {
            //            continue;
            //        }

            //        //yield return branch;
            //    }

            //    //branches.Count().ShouldEqual(6);

            //    //const string otherCommitSha = "4a202b346bb0fb0db7eff3cffeb3c70babbd2045";
            //    //branches = ListBranchesContaininingCommit(repo, otherCommitSha);

            //    //branches.Count().ShouldEqual(1); // origin/packed-test
            //}

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
