using Builder.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtProjectName.Text.Trim() != "" && txtBuildOutput.Text.Trim() != "" && txtCProjLocation.Text.Trim() != "" && txtLocalRepoLoc.Text.Trim() != "")
            {
                List<projectModel> models = new List<projectModel>();

                var current_settings = Builder.Class.settings.getSettings();

                if (current_settings != null)
                {
                    models = current_settings;
                }

                ProjectDetails details = new ProjectDetails {
                 ProjectOutput = txtBuildOutput.Text,
                 CsprojLocation = txtCProjLocation.Text,
                 CloneRepository = txtLocalRepoLoc.Text,
                 ProjectSolution = txtProjSolution.Text
                };
                models.Add(new projectModel{ ProjectName = txtProjectName.Text, details = details});

                string json = JsonConvert.SerializeObject(models);
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json", json);

                
                models = Builder.Class.settings.getSettings();

                for (int i = 0; i < models.Count; i++)
                {
                    if (models[i].ProjectName != null)
                    {
                        dataGridView1.Rows.Add(models[i].ProjectName, models[i].details.ProjectOutput, models[i].details.CsprojLocation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Oopsss empty!");
            }
        }

        private void settings_Load(object sender, EventArgs e)
        {
            List<projectModel> models = new List<projectModel>();
            models = Builder.Class.settings.getSettings();

            if (models != null)
            { 
            for (int i = 0; i < models.Count; i++)
            {
                if (models[i].ProjectName != null)
                {
                    dataGridView1.Rows.Add(models[i].ProjectName, models[i].details.ProjectOutput, models[i].details.CsprojLocation,models[i].details.ProjectSolution);
                }
            }
            }
            txtMSbuilLocation.Text = Builder.Class.settings.getBuilder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMSbuilLocation.Text.Trim() != "")
            {
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\builder.json", txtMSbuilLocation.Text);
            }
            else
            {
                MessageBox.Show("oooopsss");
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    FileInfo fileInfo = new FileInfo(filePath);
                    filePath = fileInfo.DirectoryName;
                    //Read the contents of the file into a stream
                    //var fileStream = openFileDialog.OpenFile();

                    //using (StreamReader reader = new StreamReader(fileStream))
                    //{
                    //    fileContent = reader.ReadToEnd();
                    //}
                }
            }
            txtMSbuilLocation.Text = filePath;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
           folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
             folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);

                txtBuildOutput.Text = folderPath;
                // ...
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);

                txtLocalRepoLoc.Text = folderPath;
                // ...
            }
        }

        private void button5_Click(object sender, EventArgs e)
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
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //FileInfo fileInfo = new FileInfo(filePath);
                    //filePath = fileInfo.DirectoryName;
                    //Read the contents of the file into a stream
                    //var fileStream = openFileDialog.OpenFile();

                    //using (StreamReader reader = new StreamReader(fileStream))
                    //{
                    //    fileContent = reader.ReadToEnd();
                    //}
                }
            }
            txtCProjLocation.Text = filePath;
        }

        private void button7_Click(object sender, EventArgs e)
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
