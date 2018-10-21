using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FindFiles
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start to count directories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCount_Click(object sender, EventArgs e)
        {
            string path1 = txtBxFirstCatalog.Text.Trim();
            string path2 = txtBxSecondCatalog.Text.Trim();
            if (path1 == "" || path2 == "")
            {
                Messages.ShowWarning("The field is empty");
                return;
            }
            try
            {
                var thread = new Thread(() =>
                {
                    CountDirsWithNumberFiles(
                        FileUtils.GetFullPath(txtBxFirstCatalog.Text),
                        FileUtils.GetFullPath(txtBxSecondCatalog.Text),
                        Convert.ToInt32(numUpDownCountFiles.Value),
                        chckBxRecursive.Checked);
                });
                thread.IsBackground = true;
                thread.Start();
            }
            catch (Exception ex)
            {
                Messages.ShowError(ex.Message);
            }
        }

        /// <summary>
        /// Sets lists of directories into form's components
        /// </summary>
        /// <param name="list1">The first list</param>
        /// <param name="list2">The second list</param>
        private void setListDirs(string[] list1, string[] list2)
        {
            Invoke(new Action(() =>
            {
                txtBoxCountCatalogsInFirst.Text = list1.Length.ToString();
                txtBoxCountCatalogsInSecond.Text = list2.Length.ToString();

                cmbBxCatalogsInFirst.Items.Clear();
                cmbBxCatalogsInSecond.Items.Clear();

                cmbBxCatalogsInFirst.Items.AddRange(list1);
                cmbBxCatalogsInSecond.Items.AddRange(list2);
                
                cmbBxCatalogsInFirst.SelectedIndex = 
                    cmbBxCatalogsInFirst.Items.Count == 0 ? -1 : 0;

                cmbBxCatalogsInSecond.SelectedIndex =
                    cmbBxCatalogsInSecond.Items.Count == 0 ? -1 : 0;
            }));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <param name="countFiles"></param>
        /// <param name="recur"></param>
        private void CountDirsWithNumberFiles(
            string path1, 
            string path2, 
            int countFiles, 
            bool recur)
        {
            // The predicate returns true if the number of files
            // in directory more than a given number
            Func<string, bool> predicate = dir =>             
                FileUtils.GetFiles(dir, false).Count() > countFiles;

            // The first thread to search
            IEnumerable<string> listFiles1 = null;
            var thread1 = new Thread(() => 
            {
                listFiles1 = GetSubDirs(path1, recur, predicate);
            });
            thread1.IsBackground = true;            

            // The second thread to search
            IEnumerable<string> listFiles2 = null;
            var thread2 = new Thread(() =>
            {
                listFiles2 = GetSubDirs(path2, recur, predicate);
            });
            thread2.IsBackground = true;

            // start threads
            thread1.Start();
            thread2.Start();

            // Waiting until threads complete
            thread1.Join();
            thread2.Join();

            // Set values to form
            setListDirs(listFiles1.ToArray(), listFiles2.ToArray());
        }

        /// <summary>
        /// Gets subdirectories that conform to a given predicate
        /// </summary>
        /// <param name="path">The path from which it needs to get
        /// subdirectories</param>
        /// <param name="recursivly">Whether they will be gotten recursivly</param>
        /// <param name="predicte">
        /// The predicate takes a directory name as param</param>
        /// <returns>The list of dicrectories</returns>
        private IEnumerable<string> GetSubDirs(
            string path,
            bool recursivly,
            Func<string, bool> predicte)
        {
            var listDirs = new LinkedList<string>();
            try
            {                
                IEnumerable<string> dirs;
                if (recursivly)
                {
                    dirs = FileUtils.GetAllDirectories(path);
                }
                else
                {
                    dirs = FileUtils.GetDirectories(path, true);
                }
                foreach (var dir in dirs)
                {
                    if (predicte(dir))
                        listDirs.AddLast(dir);
                }                
            }
            catch (Exception ex)
            {
                Messages.ShowError(ex.Message);
            }
            return listDirs;
        }

        /// <summary>
        /// Selecting the first directory in a dialog window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetDir1_Click(object sender, EventArgs e)
        {
            if (fldBrwsrDlg.ShowDialog() == DialogResult.OK)
            {
                txtBxFirstCatalog.Text = fldBrwsrDlg.SelectedPath;
            }
        }

        /// <summary>
        /// Selecting the second directory in a dialog window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetDir2_Click(object sender, EventArgs e)
        {
            if (fldBrwsrDlg.ShowDialog() == DialogResult.OK)
            {
                txtBxSecondCatalog.Text = fldBrwsrDlg.SelectedPath;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Messages.ShowMessage("Help");
        }

        private void chckBxRecursive_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxCountCatalogsInFirst.Clear();
            txtBoxCountCatalogsInSecond.Clear();

            cmbBxCatalogsInFirst.Items.Clear();
            cmbBxCatalogsInSecond.Items.Clear();
        }
    }
}
