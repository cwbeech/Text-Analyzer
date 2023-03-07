/* UserInterface.cs
 * Author: Calvin Beechenr
 */
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextAnalysis
{
    /// <summary>
    /// UserInterface class, used for displaying the program to the user and processing user inputs and program outputs.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// String giving a format string to use wen displaying the differnce measures.
        /// </summary>
        private const string _format = "N5";

        /// <summary>
        /// Defines the column indices for the differences and the words used in ListView.
        /// </summary>
        private const int _column = 0;

        /// <summary>
        /// ThresholdDialog to keep track of the dialog.
        /// </summary>
        private ThresholdDialog _dialog = new ThresholdDialog();

        /// <summary>
        /// Contains the frequency tables for the files currently displayed in the ListView.
        /// </summary>
        private Dictionary<string, double>[] _tables;

        /// <summary>
        /// UserInterface constructor.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            uxToolStripTextBox1.Text = _dialog.UpDown.ToString("0.000");
        }

        /// <summary>
        /// Event handler for the "Open Folder" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxFolderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo filePath = new DirectoryInfo(uxFolderBrowserDialog1.SelectedPath);
                    FileInfo[] files = filePath.GetFiles();
                    if (files.Count() == 0)
                    {
                        throw new System.IO.IOException("The selected folder contains no files.");
                    }
                    _tables = Analyzer.GetFrequencyTables(files);
                    uxListView1.Items.Clear();
                    for (int i = 0; i < files.Length; i++)
                    {
                        uxListView1.Items.Add(new ListViewItem(files[i].Name)); //adds filename
                        uxListView1.Items[i].SubItems.Add(_tables[i].Count.ToString());
                        uxListView1.Items[i].SubItems.Add("");
                        uxListView1.Items[i].SubItems.Add("");
                    }
                    uxListView1.SelectedIndices.Add(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Event handler for the ListView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxListView1.SelectedIndices.Count >= 1)
            {
                int y = uxListView1.SelectedIndices[_column]; //index of selection
                double[] result = Analyzer.ComputeMeasures(_tables[y], _tables, Convert.ToDouble(uxToolStripTextBox1.Text), out int[] numberOfWords);
                for (int i = 0; i < _tables.Length; i++)
                {
                    uxListView1.Items[i].SubItems[3].Text = result[i].ToString("0.00000");
                }
                for (int i = 0; i < _tables.Length; i++)
                {
                    uxListView1.Items[i].SubItems[2].Text = numberOfWords[i].ToString();
                }
            }
        }

        /// <summary>
        /// Event handler for Threshold: menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxThresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_dialog.ShowDialog() == DialogResult.OK)
            {
                uxToolStripTextBox1.Text = _dialog.UpDown.ToString("0.000");
                uxListView1_SelectedIndexChanged(sender, e);
            }
        }
    }
}