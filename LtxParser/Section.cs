using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LtxParser
{
    public class Section : IEnumerable<string>
    {
        private static readonly Regex listRx = new Regex(@"[^\s,]+");

        public readonly string Name;
        private Dictionary<string, string> fields = new Dictionary<string, string>();

        public Section(string name)
        {
            Name = name;
        }

        public string this[string field]
        {
            get
            {
                return fields[field];
            }

            internal set
            {
                fields[field] = value;
            }
        }

        public bool ContainsField(string key)
        {
            return fields.ContainsKey(key);
        }


        #region Reading-as-type functions
        private static bool toBool(string value)
        {
            value = value.ToLower();
            if (value == "true" || value == "1")
                return true;
            else if (value == "false" || value == "0")
                return false;
            else
                throw new FormatException("Boolean string must be 'true', 'false', '0', or '1'.");
        }

        /// <summary>
        /// Parse a boolean value.
        /// </summary>
        public bool GetBool(string field)
        {
            return toBool(fields[field]);
        }

        /// <summary>
        /// Parse a comma/whitespace-separated list of boolean values.
        /// </summary>
        public List<bool> GetBools(string field)
        {
            List<bool> list = new List<bool>();
            foreach (string value in Regex.Split(fields[field], @"[,\s]+"))
                list.Add(toBool(value));
            return list;
        }
        
        /// <summary>
        /// Parse a floating point value.
        /// </summary>
        public double GetDouble(string field)
        {
            return Convert.ToDouble(fields[field]);
        }

        /// <summary>
        /// Parse a comma/whitespace-separated list of floating point values.
        /// </summary>
        public List<double> GetDoubles(string field)
        {
            List<double> list = new List<double>();
            foreach (string value in Regex.Split(fields[field], @"[,\s]+"))
                list.Add(Convert.ToDouble(value));
            return list;
        }

        /// <summary>
        /// Parse an integer value.
        /// </summary>
        public int GetInt(string field)
        {
            return Convert.ToInt32(fields[field]);
        }

        /// <summary>
        /// Parse a comma/whitespace-separated list of integer values.
        /// </summary>
        public List<int> GetInts(string field)
        {
            List<int> list = new List<int>();
            foreach (string value in Regex.Split(fields[field], @"[,\s]+"))
                list.Add(Convert.ToInt32(value));
            return list;
        }

        // Might as well just use the Section indexer directly but whatever dude, you do you
        /// <summary>
        /// Parse a string value.
        /// </summary>
        public string GetString(string field)
        {
            return fields[field];
        }

        /// <summary>
        /// Parse a comma/whitespace-separated list of string values.
        /// </summary>
        public List<string> GetStrings(string field)
        {
            List<string> list = new List<string>();
            foreach (string value in Regex.Split(fields[field], @"[,\s]+"))
                list.Add(value);
            return list;
        }
        #endregion

        public IEnumerator<string> GetEnumerator()
        {
            foreach (string field in fields.Keys)
                yield return field;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
