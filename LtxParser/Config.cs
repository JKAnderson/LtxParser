using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace LtxParser
{
    public class Config : IEnumerable<Section>
    {
        /// <summary>
        /// Parse a standard .ltx tree.
        /// </summary>
        /// <param name="filePath">The full path to the root file.</param>
        /// <example><c>ReadLtx(@"C:\Vanilla\gamedata\config\system.ltx")</c></example>
        public static Config ReadLtx(string filePath)
        {
            return new Config(Path.GetDirectoryName(filePath), Path.GetFileName(filePath));
        }

        /// <summary>
        /// Parse an .ltx tree, substituting missing files from a fallback if not found in the primary location.
        /// </summary>
        /// <param name="modConfig">The root directory of the primary config source.</param>
        /// <param name="vanillaConfig">The root directory of the fallback config source.</param>
        /// <param name="fileName">The file name (without path) of the root file.</param>
        /// <example><c>ReadModLtx(@"C:\AMK\gamedata\config", @"C:\Vanilla\gamedata\config", "system.ltx")</c></example>
        public static Config ReadModLtx(string modConfig, string vanillaConfig, string fileName)
        {
            return new Config(modConfig, vanillaConfig, fileName);
        }

        /// <summary>
        /// Parse .ltx-formatted text, instead of actual files. Useful for loading custom data.
        /// </summary>
        /// <param name="ltx">The text to be parsed.</param>
        /// <example><code>
        /// Config spawn = ReadLtx(@"C:\ACDC\all\alife_l01_escape.ltx");
        /// foreach (Section section in spawn.Sections)
        /// {
        ///     Config customData = ReadCustomData(section["custom_data"]);
        /// }
        /// </code></example>
        public static Config ReadCustomData(string ltx)
        {
            return new Config(ltx);
        }

        private static readonly Encoding ENCODING_RU = Encoding.GetEncoding(1251);
        private static readonly Regex commentRx = new Regex("^[^;]+");
        private static readonly Regex includeRx = new Regex(@"^#include\s*""(?<directory>.+\\)?(?<file>.+)""$");
        private static readonly Regex sectionRx = new Regex(@"^\[(?<section>[^\]]+)\](?:\:(?<inherits>.+))?");
        private static readonly Regex fieldRx = new Regex(@"^(?<field>.+?)(?:\s*\=\s*(?<value>.+))?$");
        private static readonly Regex listRx = new Regex(@"[^\s,]+");

        private enum ConfigMode
        {
            Normal,
            Mod,
            CustomData
        }

        private ConfigMode mode;
        private Dictionary<string, Section> sections = new Dictionary<string, Section>();
        private string rootDir, vanillaRootDir, currentSection;
        private bool blockMode = false;
        private string blockField, blockValue;

        /// <summary>
        /// Fields at the beginning of an .ltx without a preceding section will be stored here.
        /// Only used for custom data support; actual .ltx files should never have loose fields.
        /// </summary>
        public Section Default = new Section("Default");

        private Config(string setRootDir, string rootFile)
        {
            mode = ConfigMode.Normal;
            rootDir = setRootDir + @"\";
            parseFile("", readFile(rootFile));
        }

        private Config(string modRoot, string vanillaRoot, string rootFile)
        {
            mode = ConfigMode.Mod;
            rootDir = modRoot + @"\";
            vanillaRootDir = vanillaRoot + @"\";
            parseFile("", readFile(rootFile));
        }

        private Config(string ltxData)
        {
            mode = ConfigMode.CustomData;
            parseFile("", Regex.Split(ltxData, @"\r?\n|\r"));
        }

        public Section this[string section]
        {
            get
            {
                return sections[section.ToLower()];
            }
        }

        /// <summary>
        /// Checks if the section exists in this config.
        /// </summary>
        /// <param name="section">The section in question; automatically lowercased.</param>
        /// <returns>True if it is present, else false.</returns>
        public bool ContainsSection(string section)
        {
            return sections.ContainsKey(section.ToLower());
        }

        private string[] readFile(string subPath)
        {
            if (File.Exists(rootDir + subPath))
            {
                return File.ReadAllLines(rootDir + subPath, ENCODING_RU);
            }
            else if (mode == ConfigMode.Mod && File.Exists(vanillaRootDir + subPath))
            {
                return File.ReadAllLines(vanillaRootDir + subPath, ENCODING_RU);
            }
            else
            {
                throw new FileNotFoundException("File not found.", rootDir + subPath);
            }
        }

        private void parseFile(string currentpath, string[] lines)
        {
            foreach (string line in lines)
            {
                string rawLine = commentRx.Match(line).Value.Trim();

                if (blockMode)
                {
                    if (rawLine == "END")
                    {
                        blockMode = false;
                        sections[currentSection][blockField] = blockValue;
                    }
                    else
                    {
                        if (blockValue.Length > 0)
                            blockValue += "\r\n";
                        blockValue += rawLine;
                    }
                    continue;
                }

                if (rawLine.Length == 0)
                    continue;

                if (includeRx.IsMatch(rawLine))
                {
                    Match includeMatch = includeRx.Match(rawLine);
                    string includeDir = includeMatch.Groups["directory"].Value;
                    string includeFile = includeMatch.Groups["file"].Value;
                    parseFile(currentpath + includeDir, readFile(currentpath + includeDir + includeFile));
                }
                else if (sectionRx.IsMatch(rawLine))
                {
                    Match sectionMatch = sectionRx.Match(rawLine);
                    string section = sectionMatch.Groups["section"].Value.ToLower();
                    string inheritance = sectionMatch.Groups["inherits"].Value;
                    if (!sections.ContainsKey(section))
                        sections[section] = new Section(section);
                    else
                    {
                        throw new DuplicateSectionException(
                            string.Format("Duplicate section found: [{0}]", section));
                    }
                    foreach (Match inherit in listRx.Matches(inheritance))
                    {
                        string inheritSection = inherit.Value;
                        if (sections.ContainsKey(inheritSection))
                        {
                            foreach (string field in sections[inheritSection])
                                sections[section][field] = sections[inheritSection][field];
                        }
                        else
                        {
                            throw new InheritedSectionNotFoundException(
                                string.Format("Base section [{0}] inherits missing section [{1}].", section, inheritSection));
                        }
                    }
                    currentSection = section;
                }
                else if (fieldRx.IsMatch(rawLine))
                {
                    Match fieldMatch = fieldRx.Match(rawLine);
                    string field = fieldMatch.Groups["field"].Value;
                    string value = fieldMatch.Groups["value"].Value;
                    if (value == "<<END")
                    {
                        blockMode = true;
                        blockField = field;
                        blockValue = "";
                    }
                    else if (currentSection != null)
                        sections[currentSection][field] = value;
                    else if (mode == ConfigMode.CustomData)
                        Default[field] = value;
                    else
                    {
                        throw new OrphanedFieldException(
                            string.Format("Loose field found before sections: {0} = {1}", field, value));
                    }
                }
                else
                {
                    throw new LtxFormatException(
                        string.Format("Unrecognized line format: {0}", rawLine));
                }
            }
        }

        public IEnumerator<Section> GetEnumerator()
        {
            yield return Default;
            foreach (Section section in sections.Values)
                yield return section;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
