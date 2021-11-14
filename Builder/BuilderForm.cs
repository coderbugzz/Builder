using Builder.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Builder
{
    public partial class BuilderForm : Form
    {
        public BuilderForm()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput_rich.Clear();
                using (PowerShell powerShell = PowerShell.Create())
                {
                    string commnd_text = "cd " + txtMSBuildLoc.Text + "\n";
                    commnd_text += @"msbuild.exe '" + txtCProjLoc.Text + "' /p:Configuration=Release /p:DeployOnBuild=True /p:DeployDefaultTarget=WebPublish /p:WebPublishMethod=FileSystem /p:DeleteExistingFiles=True /p:publishUrl='" + txtOutputLoc.Text + "'";
                    powerShell.AddScript(commnd_text);
                    powerShell.AddCommand("Out-String");
                    Collection<PSObject> PSOutput = powerShell.Invoke();

                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (PSObject pSObject in PSOutput)
                        stringBuilder.AppendLine(pSObject.ToString());
                    txtOutput_rich.Text = stringBuilder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuilderForm_Load(object sender, EventArgs e)
        {
            txtMSBuildLoc.Text = Builder.Class.settings.getBuilder();

            List<projectModel> models = new List<projectModel>();
            models = Builder.Class.settings.getSettings();

            if (models != null)
            {
                for (int i = 0; i < models.Count; i++)
                {
                    if (models[i].ProjectName != null)
                    {
                        txtSaveProject.Items.Add(models[i].ProjectName);
                    }
                }
            }
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            List<projectModel> models = new List<projectModel>();
            models = Builder.Class.settings.getSettings();

            for (int i = 0; i < models.Count; i++)
            {
                if (models[i].ProjectName == txtSaveProject.Text)
                {
                    txtCProjLoc.Text = models[i].details.CsprojLocation;
                    txtOutputLoc.Text = models[i].details.ProjectOutput;
                    txtLocalCloneRepo.Text = models[i].details.CloneRepository;
                    txtProjSolution.Text = models[i].details.ProjectSolution;
                }
            }
        }
        private void btnRepoChanges_Click(object sender, EventArgs e)
        {
            txtOutput_rich.Clear();
            txtOutput_rich.Text = Builder.Class.GitCommand.command(txtLocalCloneRepo.Text, "git log -5");

        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            txtOutput_rich.Clear();

            txtOutput_rich.Text = Builder.Class.GitCommand.command(txtLocalCloneRepo.Text, "git fetch") + "\n";
            txtOutput_rich.Text += Builder.Class.GitCommand.command(txtLocalCloneRepo.Text, "git pull");
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    FileInfo fileInfo = new FileInfo(filePath);
                    filePath = fileInfo.DirectoryName;
                }
            }
            txtMSBuildLoc.Text = filePath;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "cs project|*.csproj";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            txtLocalCloneRepo.Text = filePath;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);

                txtOutputLoc.Text = folderPath;
               
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);

                txtLocalCloneRepo.Text = folderPath;
                
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtMSBuildLoc.Text = Builder.Class.settings.getBuilder();


            List<projectModel> models = new List<projectModel>();
            models = Builder.Class.settings.getSettings();

            for (int i = 0; i < models.Count; i++)
            {
                if (models[i].ProjectName != null)
                {
                    txtSaveProject.Items.Add(models[i].ProjectName);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //txtOutput_rich.Text = Builder.Class.GitCommand.command(txtLocalCloneRepo.Text, "nuget restore " + txtProjSolution.Text);


            using (PowerShell powerShell = PowerShell.Create())
            {

                string commnd_text = "nuget restore " + txtProjSolution.Text; //"cd " + txtLocalCloneRepo.Text + "\n";
                                                                             // commnd_text += "nuget restore " + txtProjSolution.Text;
                powerShell.AddScript(commnd_text);
                powerShell.AddCommand("Out-String");
                Collection<PSObject> PSOutput = powerShell.Invoke();

                StringBuilder stringBuilder = new StringBuilder();
                foreach (PSObject pSObject in PSOutput)
                    stringBuilder.AppendLine(pSObject.ToString());
                txtOutput_rich.Text = stringBuilder.ToString();
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "cs project|*.sln";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            txtProjSolution.Text = filePath;
        }
    }
}
