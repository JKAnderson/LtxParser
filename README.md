# LtxParser
A C# library for loading .ltx files, trees, and ltx-formatted strings from the STALKER series.  
It also handles ACDC's special <<END...END block syntax if you're into that sort of thing.  
You can [get it from NuGet.](https://www.nuget.org/packages/LtxParser/)

# Example Use
```
List<string> weaponsWithScopes = new List<string>();
Config config = Config.ReadModLtx(@"C:\AMK\gamedata\config", @"C:\Vanilla\gamedata\config", "system.ltx");
foreach (Section section in config)
{
    if (section.ContainsField("scope_status") && section.GetInt("scope_status") > 0)
    {
        weaponsWithScopes.Add(section.Name);
    }
}
// Congrats, now you have a list of weapons that can use scopes for some reason
```

# Classes
## Config
Represents an entire loaded config tree. Indexable by section names. Iterable by sections.
### Members
Config ReadLtx(string filePath)
+ Returns a Config loaded from the specified file. Ex:

`Config config = Config.ReadLtx(@"C:\Vanilla\gamedata\config\system.ltx");`  

Config ReadModLtx(string modConfig, string vanillaConfig, string fileName)
+ Returns a Config loaded from the mod directory, starting with the specified file.  
Falls back to the vanilla directory if files are missing from the mod directory. Ex:
  
`Config config = Config.ReadModLtx(@"C:\AMK\gamedata\config", @"C:\Vanilla\gamedata\config", "system.ltx");`

Config ReadCustomData(string ltx)
+ Returns a Config loaded from the given string. Ex:

```
string ltx = "[section1]\r\nfield1 = value1";
Config config = Config.ReadCustomData(ltx);
```

bool ContainsSection(string section)
+ Returns true if the section exists in the config.

Section Default
+ Fields occuring before a section are stored here. Only used if config is loaded from ReadCustomData.

## Section
Represents one section of a config. Indexable by field names. Iterable by fields.
### Members
string Name
+ The section name it was loaded from.

bool ContainsField(string field)
+ Returns true if the field exists in this section.

GetBool/GetDouble/GetInt/GetString(string field)
+ Interprets the value in the given field as the appropriate type. Ex:

`bool zoomEnabled = section.GetBool("zoom_enabled");`

GetBools/GetDoubles/GetInt/GetStrings(string field)
+ As above, but returns a List of values separated by commas/whitespace. Ex:

`List<double> coordinates = section.GetDoubles("position");`

## Exceptions
DuplicateSectionException
+ Thrown if two sections with the same name are found.


InheritedSectionNotFoundException
+ Thrown if a section inherits another that does not exist.


OrphanedFieldException
+ Thrown if there's a field before any sections. Ignored when using ReadCustomData.


LtxFormatException
+ Thrown if a line of unknown format is found.
