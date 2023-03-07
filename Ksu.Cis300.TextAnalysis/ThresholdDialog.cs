/* ThresholdDialog.cs
 * Author: Calvin Beechner
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextAnalysis
{
    /// <summary>
    /// ThresholdDialog class, used when the user manipulates the Threshold.
    /// </summary>
    public partial class ThresholdDialog : Form
    {
        /// <summary>
        /// Constructor for the ThresholdDialog.
        /// </summary>
        public ThresholdDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets a decimal giving the value in the NumericUpDown.
        /// </summary>
        public decimal UpDown
        {
            get => uxNumericUpDown1.Value;
        }
    }
}
