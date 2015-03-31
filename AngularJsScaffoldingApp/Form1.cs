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

            CreateIndexFile();

            CreateFolderStructure();
        }

        private void CreateFolderStructure()
        {
            throw new NotImplementedException();
        }

        private void CreateIndexFile()
        {
            File.AppendAllText(Path.Combine(ProjectPath, "index.html"), @"<!doctype html>
<html ng-app>
  <head>
    <script src='http://ajax.googleapis.com/ajax/libs/angularjs/1.0.5/angular.min.js'></script>
    <script src='script.js'></script>

  </head>
  <body>

<div>
  
  </div>
  
</div>



  </body>
</html>
");
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
