
namespace Builder
{
    partial class BuilderForm
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
            this.components = new System.ComponentModel.Container();
            this.btnBuild = new System.Windows.Forms.Button();
            this.txtMSBuildLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCProjLoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtOutput_rich = new System.Windows.Forms.RichTextBox();
            this.txtOutputLoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaveProject = new System.Windows.Forms.ComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.txtLocalCloneRepo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRepoChanges = new System.Windows.Forms.Button();
            this.btnPull = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.txtProjSolution = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRestoreNuget = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(663, 123);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(123, 51);
            this.btnBuild.TabIndex = 0;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // txtMSBuildLoc
            // 
            this.txtMSBuildLoc.Location = new System.Drawing.Point(137, 12);
            this.txtMSBuildLoc.Name = "txtMSBuildLoc";
            this.txtMSBuildLoc.Size = new System.Drawing.Size(478, 22);
            this.txtMSBuildLoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Builder location:";
            // 
            // txtCProjLoc
            // 
            this.txtCProjLoc.Location = new System.Drawing.Point(137, 120);
            this.txtCProjLoc.Name = "txtCProjLoc";
            this.txtCProjLoc.Size = new System.Drawing.Size(478, 22);
            this.txtCProjLoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CsProj File:";
            // 
            // txtOutput_rich
            // 
            this.txtOutput_rich.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput_rich.Location = new System.Drawing.Point(9, 263);
            this.txtOutput_rich.Name = "txtOutput_rich";
            this.txtOutput_rich.Size = new System.Drawing.Size(885, 428);
            this.txtOutput_rich.TabIndex = 5;
            this.txtOutput_rich.Text = "";
            // 
            // txtOutputLoc
            // 
            this.txtOutputLoc.Location = new System.Drawing.Point(137, 152);
            this.txtOutputLoc.Name = "txtOutputLoc";
            this.txtOutputLoc.Size = new System.Drawing.Size(478, 22);
            this.txtOutputLoc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "OutPut Location:";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(663, 10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(123, 28);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Save project:";
            // 
            // txtSaveProject
            // 
            this.txtSaveProject.FormattingEnabled = true;
            this.txtSaveProject.Location = new System.Drawing.Point(137, 47);
            this.txtSaveProject.Name = "txtSaveProject";
            this.txtSaveProject.Size = new System.Drawing.Size(478, 24);
            this.txtSaveProject.TabIndex = 8;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(663, 45);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(123, 28);
            this.btnReload.TabIndex = 9;
            this.btnReload.Text = "Load";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtLocalCloneRepo
            // 
            this.txtLocalCloneRepo.Location = new System.Drawing.Point(137, 190);
            this.txtLocalCloneRepo.Name = "txtLocalCloneRepo";
            this.txtLocalCloneRepo.Size = new System.Drawing.Size(478, 22);
            this.txtLocalCloneRepo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Clone Repository:";
            // 
            // btnRepoChanges
            // 
            this.btnRepoChanges.Location = new System.Drawing.Point(663, 185);
            this.btnRepoChanges.Name = "btnRepoChanges";
            this.btnRepoChanges.Size = new System.Drawing.Size(123, 33);
            this.btnRepoChanges.TabIndex = 11;
            this.btnRepoChanges.Text = "View Changes";
            this.btnRepoChanges.UseVisualStyleBackColor = true;
            this.btnRepoChanges.Click += new System.EventHandler(this.btnRepoChanges_Click);
            // 
            // btnPull
            // 
            this.btnPull.Location = new System.Drawing.Point(791, 187);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(109, 31);
            this.btnPull.TabIndex = 12;
            this.btnPull.Text = "Pull Remote";
            this.btnPull.UseVisualStyleBackColor = true;
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(618, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(618, 120);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(618, 152);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "...";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(618, 189);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "...";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(805, 10);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 63);
            this.button10.TabIndex = 14;
            this.button10.Text = "Reload form";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // txtProjSolution
            // 
            this.txtProjSolution.Location = new System.Drawing.Point(137, 87);
            this.txtProjSolution.Name = "txtProjSolution";
            this.txtProjSolution.Size = new System.Drawing.Size(478, 22);
            this.txtProjSolution.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Project Solution:";
            // 
            // btnRestoreNuget
            // 
            this.btnRestoreNuget.Location = new System.Drawing.Point(663, 83);
            this.btnRestoreNuget.Name = "btnRestoreNuget";
            this.btnRestoreNuget.Size = new System.Drawing.Size(123, 28);
            this.btnRestoreNuget.TabIndex = 15;
            this.btnRestoreNuget.Text = "Restore Nuget";
            this.btnRestoreNuget.UseVisualStyleBackColor = true;
            this.btnRestoreNuget.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(618, 86);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 23);
            this.button12.TabIndex = 13;
            this.button12.Text = "...";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 243);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(55, 17);
            this.lblOutput.TabIndex = 16;
            this.lblOutput.Text = "Output:";
            // 
            // BuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 703);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnRestoreNuget);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnPull);
            this.Controls.Add(this.btnRepoChanges);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtSaveProject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.txtOutput_rich);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocalCloneRepo);
            this.Controls.Add(this.txtOutputLoc);
            this.Controls.Add(this.txtProjSolution);
            this.Controls.Add(this.txtCProjLoc);
            this.Controls.Add(this.txtMSBuildLoc);
            this.Controls.Add(this.btnBuild);
            this.Name = "BuilderForm";
            this.Text = "Builder Form";
            this.Load += new System.EventHandler(this.BuilderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.TextBox txtMSBuildLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCProjLoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RichTextBox txtOutput_rich;
        private System.Windows.Forms.TextBox txtOutputLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtSaveProject;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtLocalCloneRepo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRepoChanges;
        private System.Windows.Forms.Button btnPull;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox txtProjSolution;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRestoreNuget;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label lblOutput;
    }
}

