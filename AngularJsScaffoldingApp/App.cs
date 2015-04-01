using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngularJsScaffoldingApp
{
    public partial class ScaffoldAngularJsApp : Form
    {
        private string ProjectPath { get; set; }
        public ScaffoldAngularJsApp()
        {
            InitializeComponent();
        }

        private void btnScaffold_Click(object sender, EventArgs e)
        {
            CreateProjectPathIfNotExists();

            CreateFolderStructure();

            MessageBox.Show("Great!");
        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            CopyAndRenameBaseFilesInProjectFolder();
        }

        private void CopyAndRenameBaseFilesInProjectFolder()
        {
            var baseComponentPath = GetBaseComponentsPath();

            var configPath = Path.Combine(baseComponentPath, "_config.js");
            var baseHtmlPath = Path.Combine(baseComponentPath, "base.html");
            var baseControllerPath = Path.Combine(baseComponentPath, "baseController.js");

            var appTargetControllerPath = Path.Combine(ProjectPath, "app", "app.src.js");

            var newComponentName = txtComponentName.Text;
            var targetComponentPath = Path.Combine(ProjectPath, "app", "components");
            var targetNewComponentPath = Path.Combine(targetComponentPath, newComponentName);

            Replace(txtComponentName.Text, "_config.src.js", configPath, targetNewComponentPath);
            Replace(txtComponentName.Text, txtComponentName.Text + ".html", baseHtmlPath, targetNewComponentPath);
            Replace(txtComponentName.Text, txtComponentName.Text.ToLower() + "Controller.src.js", baseControllerPath, targetNewComponentPath);

            ReplaceMainController(appTargetControllerPath, txtComponentName.Text);
        }

        private void ReplaceMainController(string appTargetControllerPath, string newComponentName)
        {
            var fileData = File.ReadAllText(appTargetControllerPath);
            var replacedHtmlData = Regex.Replace(fileData, @"(?<modules>\[[\w\W]*$?',[[\w\W]*?)\]\)", m =>
            {
                return String.Format("{0}{2}'{1}ConfigModule', ])", m.Groups["modules"].Value, newComponentName, Environment.NewLine);
            });

            File.WriteAllText(Path.Combine(appTargetControllerPath), replacedHtmlData);
        }

        private string GetBaseComponentsPath()
        {
            return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "base", "component");
        }

        private void Replace(string newComponentName, string fileName, string filePath, string targetNewComponentPath)
        {
            var fileData = File.ReadAllText(filePath);
            var replacedHtmlData = Regex.Replace(fileData, @"{{[\w\W]*?}}", m =>
            {
                return newComponentName;
            });

            if (!Directory.Exists(targetNewComponentPath))
            {
                Directory.CreateDirectory(targetNewComponentPath);
            }

            File.AppendAllText(Path.Combine(targetNewComponentPath, fileName), replacedHtmlData);
        }

        private void CreateFolderStructure()
        {
            DirectoryCopy(GetTemplatePath(), ProjectPath, true);
        }

        private string GetTemplatePath()
        {
            return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "base", "template");
        }

        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
            }

            // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void CreateProjectPathIfNotExists()
        {
            ProjectPath = Path.GetDirectoryName(txtProjectPath.Text + "\\");
            if (!Directory.Exists(ProjectPath))
            {
                Directory.CreateDirectory(ProjectPath);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
