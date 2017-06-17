namespace GITLearning
{
    partial class BranchAndCommitTagging
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgAllBranchInfo = new System.Windows.Forms.DataGridView();
            this.lblAllBranchCount = new System.Windows.Forms.Label();
            this.lblBranchCountName = new System.Windows.Forms.Label();
            this.gbAllBranchAndCommit = new System.Windows.Forms.GroupBox();
            this.tvAllBranches = new System.Windows.Forms.TreeView();
            this.grpCommitToBranchAssociation = new System.Windows.Forms.GroupBox();
            this.lblCommitId = new System.Windows.Forms.Label();
            this.txtCommitId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgBranches = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllBranchInfo)).BeginInit();
            this.gbAllBranchAndCommit.SuspendLayout();
            this.grpCommitToBranchAssociation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBranches)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAllBranchInfo
            // 
            this.dgAllBranchInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllBranchInfo.Location = new System.Drawing.Point(262, 71);
            this.dgAllBranchInfo.Name = "dgAllBranchInfo";
            this.dgAllBranchInfo.RowTemplate.Height = 24;
            this.dgAllBranchInfo.Size = new System.Drawing.Size(437, 489);
            this.dgAllBranchInfo.TabIndex = 0;
            // 
            // lblAllBranchCount
            // 
            this.lblAllBranchCount.AutoSize = true;
            this.lblAllBranchCount.Location = new System.Drawing.Point(185, 33);
            this.lblAllBranchCount.Name = "lblAllBranchCount";
            this.lblAllBranchCount.Size = new System.Drawing.Size(16, 17);
            this.lblAllBranchCount.TabIndex = 3;
            this.lblAllBranchCount.Text = "0";
            // 
            // lblBranchCountName
            // 
            this.lblBranchCountName.AutoSize = true;
            this.lblBranchCountName.Location = new System.Drawing.Point(6, 33);
            this.lblBranchCountName.Name = "lblBranchCountName";
            this.lblBranchCountName.Size = new System.Drawing.Size(173, 17);
            this.lblBranchCountName.TabIndex = 2;
            this.lblBranchCountName.Text = "Total Number Of Braches:";
            // 
            // gbAllBranchAndCommit
            // 
            this.gbAllBranchAndCommit.Controls.Add(this.tvAllBranches);
            this.gbAllBranchAndCommit.Controls.Add(this.dgAllBranchInfo);
            this.gbAllBranchAndCommit.Controls.Add(this.lblBranchCountName);
            this.gbAllBranchAndCommit.Controls.Add(this.lblAllBranchCount);
            this.gbAllBranchAndCommit.Location = new System.Drawing.Point(12, 36);
            this.gbAllBranchAndCommit.Name = "gbAllBranchAndCommit";
            this.gbAllBranchAndCommit.Size = new System.Drawing.Size(723, 575);
            this.gbAllBranchAndCommit.TabIndex = 4;
            this.gbAllBranchAndCommit.TabStop = false;
            this.gbAllBranchAndCommit.Text = "All Branch And Commit Information";
            // 
            // tvAllBranches
            // 
            this.tvAllBranches.Location = new System.Drawing.Point(9, 71);
            this.tvAllBranches.Name = "tvAllBranches";
            this.tvAllBranches.Size = new System.Drawing.Size(208, 273);
            this.tvAllBranches.TabIndex = 4;
            this.tvAllBranches.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAllBranches_AfterSelect);
            // 
            // grpCommitToBranchAssociation
            // 
            this.grpCommitToBranchAssociation.Controls.Add(this.dgBranches);
            this.grpCommitToBranchAssociation.Controls.Add(this.btnSearch);
            this.grpCommitToBranchAssociation.Controls.Add(this.txtCommitId);
            this.grpCommitToBranchAssociation.Controls.Add(this.lblCommitId);
            this.grpCommitToBranchAssociation.Location = new System.Drawing.Point(783, 36);
            this.grpCommitToBranchAssociation.Name = "grpCommitToBranchAssociation";
            this.grpCommitToBranchAssociation.Size = new System.Drawing.Size(603, 575);
            this.grpCommitToBranchAssociation.TabIndex = 5;
            this.grpCommitToBranchAssociation.TabStop = false;
            this.grpCommitToBranchAssociation.Text = "Commit to branch association";
            // 
            // lblCommitId
            // 
            this.lblCommitId.AutoSize = true;
            this.lblCommitId.Location = new System.Drawing.Point(12, 33);
            this.lblCommitId.Name = "lblCommitId";
            this.lblCommitId.Size = new System.Drawing.Size(73, 17);
            this.lblCommitId.TabIndex = 0;
            this.lblCommitId.Text = "Commit Id:";
            // 
            // txtCommitId
            // 
            this.txtCommitId.Location = new System.Drawing.Point(92, 33);
            this.txtCommitId.Name = "txtCommitId";
            this.txtCommitId.Size = new System.Drawing.Size(362, 22);
            this.txtCommitId.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(471, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgBranches
            // 
            this.dgBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBranches.Location = new System.Drawing.Point(17, 71);
            this.dgBranches.Name = "dgBranches";
            this.dgBranches.RowTemplate.Height = 24;
            this.dgBranches.Size = new System.Drawing.Size(437, 489);
            this.dgBranches.TabIndex = 5;
            // 
            // BranchAndCommitTagging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 623);
            this.Controls.Add(this.grpCommitToBranchAssociation);
            this.Controls.Add(this.gbAllBranchAndCommit);
            this.Name = "BranchAndCommitTagging";
            this.Text = "frmBranchAndCommitTagging";
            this.Load += new System.EventHandler(this.frmBranchAndCommitTagging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAllBranchInfo)).EndInit();
            this.gbAllBranchAndCommit.ResumeLayout(false);
            this.gbAllBranchAndCommit.PerformLayout();
            this.grpCommitToBranchAssociation.ResumeLayout(false);
            this.grpCommitToBranchAssociation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBranches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAllBranchInfo;
        private System.Windows.Forms.Label lblAllBranchCount;
        private System.Windows.Forms.Label lblBranchCountName;
        private System.Windows.Forms.GroupBox gbAllBranchAndCommit;
        private System.Windows.Forms.TreeView tvAllBranches;
        private System.Windows.Forms.GroupBox grpCommitToBranchAssociation;
        private System.Windows.Forms.TextBox txtCommitId;
        private System.Windows.Forms.Label lblCommitId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgBranches;
    }
}

