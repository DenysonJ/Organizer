using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Organizer
{
    public partial class Form1 : Form
    {
        string currentPath;
        string[] files;
        List<FileInfo> filesInfo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentPath = Directory.GetCurrentDirectory();
            files = Directory.GetFiles(currentPath);
            filesInfo = new List<FileInfo>();

            foreach (string thisFile in files)
            {
                filesInfo.Add(null);
                try
                {
                    filesInfo.Add(new FileInfo(thisFile));
                }
                catch (FileNotFoundException Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                
            }
        }
    }
}
