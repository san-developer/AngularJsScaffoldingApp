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

namespace AngularJsScaffoldingApp
{
    public partial class Form1 : Form
    {
        private string ProjectPath { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnScaffold_Click(object sender, EventArgs e)
        {
            CreateProjectPathIfNotExists();

            CreateFolderStructure();

            MessageBox.Show("Great!");
        }

        private void CreateFolderStructure()
        {
            DirectoryCopy(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "template"), ProjectPath, true);

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
    }
}
