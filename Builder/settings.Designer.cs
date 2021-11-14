
namespace Builder
{
    partial class settings
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSProjLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectSolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMSbuilLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuildOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCProjLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtLocalRepoLoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtProjSolution = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName,
            this.ProjectOutput,
            this.CSProjLocation,
            this.ProjectSolution});
            this.dataGridView1.Location = new System.Drawing.Point(12, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.MinimumWidth = 6;
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Width = 125;
            // 
            // ProjectOutput
            // 
            this.ProjectOutput.HeaderText = "Project Output";
            this.ProjectOutput.MinimumWidth = 6;
            this.ProjectOutput.Name = "ProjectOutput";
            this.ProjectOutput.Width = 125;
            // 
            // CSProjLocation
            // 
            this.CSProjLocation.HeaderText = "CSProj Location";
            this.CSProjLocation.MinimumWidth = 6;
            this.CSProjLocation.Name = "CSProjLocation";
            this.CSProjLocation.Width = 125;
            // 
            // ProjectSolution
            // 
            this.ProjectSolution.HeaderText = "Project Solution";
            this.ProjectSolution.MinimumWidth = 6;
            this.ProjectSolution.Name = "ProjectSolution";
            this.ProjectSolution.Width = 125;
            // 
            // txtMSbuilLocation
            // 
            this.txtMSbuilLocation.Location = new System.Drawing.Point(136, 12);
            this.txtMSbuilLocation.Name = "txtMSbuilLocation";
            this.txtMSbuilLocation.Size = new System.Drawing.Size(532, 22);
            this.txtMSbuilLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Save Projects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Builder location";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(136, 40);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(190, 22);
            this.txtProjectName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Name";
            // 
            // txtBuildOutput
            // 
            this.txtBuildOutput.Location = new System.Drawing.Point(136, 68);
            this.txtBuildOutput.Name = "txtBuildOutput";
            this.txtBuildOutput.Size = new System.Drawing.Size(568, 22);
            this.txtBuildOutput.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Project Output";
            // 
            // txtCProjLocation
            // 
            this.txtCProjLocation.Location = new System.Drawing.Point(136, 124);
            this.txtCProjLocation.Name = "txtCProjLocation";
            this.txtCProjLocation.Size = new System.Drawing.Size(568, 22);
            this.txtCProjLocation.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "CSProj location";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save Project";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtLocalRepoLoc
            // 
            this.txtLocalRepoLoc.Location = new System.Drawing.Point(136, 96);
            this.txtLocalRepoLoc.Name = "txtLocalRepoLoc";
            this.txtLocalRepoLoc.Size = new System.Drawing.Size(568, 22);
            this.txtLocalRepoLoc.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Clone Repo:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(671, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(710, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 24);
            this.button4.TabIndex = 4;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(710, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 24);
            this.button5.TabIndex = 4;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(710, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 24);
            this.button6.TabIndex = 4;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtProjSolution
            // 
            this.txtProjSolution.Location = new System.Drawing.Point(136, 152);
            this.txtProjSolution.Name = "txtProjSolution";
            this.txtProjSolution.Size = new System.Drawing.Size(568, 22);
            this.txtProjSolution.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Project Solution";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(710, 153);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 24);
            this.button7.TabIndex = 4;
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocalRepoLoc);
            this.Controls.Add(this.txtProjSolution);
            this.Controls.Add(this.txtCProjLocation);
            this.Controls.Add(this.txtBuildOutput);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtMSbuilLocation);
            this.Controls.Add(this.dataGridView1);
            this.Name = "settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMSbuilLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuildOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCProjLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtLocalRepoLoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtProjSolution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSProjLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectSolution;
    }
}