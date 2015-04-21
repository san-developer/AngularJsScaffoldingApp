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
using Xunit;

namespace AngularJsScaffoldingApp
{
    public partial class ScaffoldAngularJsApp : Form
    {
        private string ProjectPath { get { return Path.GetDirectoryName(txtProjectPath.Text + "\\"); } }
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

            MessageBox.Show(txtComponentName.Text + " Component Successfully Added");
        }


        private bool IfModuleAlreadyExists(string moduleName, string targetComponentpath)
        {
            return Directory.Exists(Path.Combine(targetComponentpath, moduleName));
        }

        private void CopyAndRenameBaseFilesInProjectFolder()
        {
            var baseComponentPath = GetBaseComponentsPath();

            var configPath = Path.Combine(baseComponentPath, "_config.js");
            var baseHtmlPath = Path.Combine(baseComponentPath, "base.html");
            var baseControllerPath = Path.Combine(baseComponentPath, "baseController.js");


            var newComponentName = txtComponentName.Text;
            var targetComponentPath = Path.Combine(ProjectPath, "app", "components");
        //    var targetNewComponentPath = Path.Combine(targetComponentPath, newComponentName);
            var appTargetControllerPath = Path.Combine(ProjectPath, "app", "app.src.js");


            string[] ModuleArray;


            if (txtComponentName.Text.Contains("/"))
            {
                ModuleArray = txtComponentName.Text.Split('/');
            }
            else
            {
                ModuleArray = new string[] { txtComponentName.Text };
            }

            for (int i = 0; i < ModuleArray.Length; i++)
            {
                if (!IfModuleAlreadyExists(ModuleArray[i], targetComponentPath))
                {
                    var currentNewModuleName = GetCurrentModuleName(ModuleArray, i);

                    Replace(ModuleArray[i], "_config.src.js", configPath, Path.Combine(targetComponentPath, currentNewModuleName));
                    Replace(ModuleArray[i], ModuleArray[i] + ".html", baseHtmlPath, Path.Combine(targetComponentPath, currentNewModuleName));
                    Replace(ModuleArray[i], ModuleArray[i].ToLower() + "Controller.src.js", baseControllerPath, Path.Combine(targetComponentPath, currentNewModuleName));

                    ReplaceMainController(appTargetControllerPath, ModuleArray[i]);
                }
            }
        }

        private string GetCurrentModuleName(string[] ModuleArray, int index)
        {
            var name = String.Empty;
            for (int i = 0; i < ModuleArray.Length; i++)
            {
                if (i > index) { break; }
                name = Path.Combine(name, ModuleArray[i]);
            }
            return name;
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
            if (!Directory.Exists(ProjectPath))
            {
                Directory.CreateDirectory(ProjectPath);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //[Fact]
        //public void Test()
        //{
        //    Assert.Equal("aaa", GetCurrentModuleName(new string[] { "San", "dro", "mchedli", "shvili" }, 1));
        //}

    }
}
