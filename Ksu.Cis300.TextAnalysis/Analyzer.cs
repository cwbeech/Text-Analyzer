/* Analyzer.cs
 * Author: Calvin Beechner
 */
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextAnalysis
{
    /// <summary>
    /// Analyzer class. Used for calculating frequency tables and computing difference measures.
    /// </summary>
    static class Analyzer
    {
        /// <summary>
        /// Regular expression describing all nonempty strings containing no lower-case letters.
        /// </summary>
        private const string _regularExpression = "[^a-z]+";

        /// <summary>
        /// Gets the frequency tables.
        /// </summary>
        /// <param name="files">FileInfo[] containing an array of all the files to be processed.</param>
        /// <returns>Returns a Dictionary<string, double>[] containing the frequency tables for the given files.</returns>
        public static Dictionary<string, double>[] GetFrequencyTables(FileInfo[] files)
        {
            Dictionary<string, double>[] result = new Dictionary<string, double>[files.Length];
            int fileCount = 0;
            foreach (FileInfo file in files)
            {
                Dictionary<string, double> temp = new Dictionary<string, double>();
                int wordCount = 0;
                using (StreamReader input = new StreamReader(file.FullName))
                {
                    while (input.EndOfStream != true)
                    {
                        string[] words = Regex.Split(input.ReadLine().ToLower(), _regularExpression);
                        foreach (string word in words)
                        {
                            if (word != "") //filter out non-usable strings
                            {
                                if (temp.TryGetValue(word, out double value))
                                {
                                    temp.Remove(word);
                                    temp.Add(word, value + 1);
                                    wordCount++;
                                }
                                else
                                {
                                    temp.Add(word, 1);
                                    wordCount++;
                                }
                            }
                        }
                    }
                }
                Dictionary<string, double> final = new Dictionary<string, double>();
                foreach (KeyValuePair<string, double> item in temp)
                {
                    final.Add(item.Key, item.Value / (double)wordCount);
                }
                result[fileCount] = final;
                fileCount++;
            }
            return result;
        }

        /// <summary>
        /// Computes the difference measures of the different frequency tables.
        /// </summary>
        /// <param name="frequencyTable">A Dictionary giving the frequency table for the file to which all files will be compared.</param>
        /// <param name="frequencyTables">A Dictionary[] giving the frequency tables for the files to compare to the above file.</param>
        /// <param name="threshold">A double giving the threshold for the word frequencies.</param>
        /// <param name="numberOfWords">An out int[] containing the number of words used in the computation of each difference measure.</param>
        /// <returns>A double[] giving the difference measures computed.</returns>
        public static double[] ComputeMeasures(Dictionary<string, double> frequencyTable, Dictionary<string, double>[] frequencyTables, double threshold, out int[] numberOfWords)
        {
            double[] sums = new double[frequencyTables.Length];
            numberOfWords = new int[frequencyTables.Length];
            for (int i = 0; i < sums.Length; i++){
                double one = ThresholdSum(frequencyTable, threshold, frequencyTables[i], 1, out numberOfWords[i]); //threshold bounds likely need tweaking.
                int sum = numberOfWords[i];
                double two = ThresholdSum(frequencyTables[i], threshold, frequencyTable, threshold, out numberOfWords[i]); //threshold bounds likely need tweaking.
                numberOfWords[i] += sum;
                sums[i] = Math.Sqrt(one + two);
            }
            return sums;
        }

        /// <summary>
        /// Computes the difference measures by taking in two sums.
        /// </summary>
        /// <param name="frequency1">A Dictionary<string, double> giving the frequency table for one file.</param>
        /// <param name="threshold">A double giving the threshold.</param>
        /// <param name="frequency2">A Dictionary<string, double> giving the frequency table for the other file.</param>
        /// <param name="upperThreshold">A double giving the upper threshold for this file.</param>
        /// <param name="numberOfWords">An out int giving the number of words used in computing this sum.</param>
        /// <returns>Returns the sum of part of the difference measures.</returns>
        private static double ThresholdSum(Dictionary<string, double> frequency1, double threshold, Dictionary<string, double> frequency2, double upperThreshold, out int numberOfWords )
        {
            //Dictionary<string, double> foundInFirst = new Dictionary<string, double>();
            double result = 0;
            numberOfWords = 0;
            foreach (KeyValuePair<string, double> item in frequency1)
            {
                if ((item.Value >= threshold)) //iterates through the first frequency table.
                {
                    frequency2.TryGetValue(item.Key, out double value); //looks up each word in the seconds dictionary.
                    if ((value <= upperThreshold)) //if they meet the threshold,
                    {
                        result += Math.Pow(item.Value - value, 2); //we find the square of the differences and add it to the sum.
                        numberOfWords++;
                    }
                }
            }
            return result;
        }
    }
}
