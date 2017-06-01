using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LtxParser
{
    public class Section
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



        public double GetDouble(string field)
        {
            return Convert.ToDouble(fields[field]);
        }

        public int GetInt(string field)
        {
            return Convert.ToInt16(fields[field]);
        }

        public List<double> GetDoubles(string field)
        {
            List<double> list = new List<double>();
            foreach (Match match in listRx.Matches(fields[field]))
                list.Add(Convert.ToDouble(match.Value));
            return list;
        }

        public List<string> GetStrings(string field)
        {
            List<string> list = new List<string>();
            foreach (Match match in listRx.Matches(fields[field]))
                list.Add(match.Value);
            return list;
        }

        public Dictionary<string, string>.KeyCollection Fields
        {
            get
            {
                return fields.Keys;
            }
        }
    }
}
