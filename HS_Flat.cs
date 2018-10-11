
using System.Collections.Generic;

namespace DesktopMelodicMinor4minor_II_V_I
{
    class HS_Flat
    {
        public string getScales(string savel)
        {
            // Create Dictionary.
            Dictionary<string, string> hash = new Dictionary<string, string>();
            hash.Add("c", "db");
            hash.Add("db", "d");
            hash.Add("d", "eb");
            hash.Add("eb", "e");
            hash.Add("e", "f");
            hash.Add("f", "gb");
            hash.Add("gb", "g");
            hash.Add("g", "ab");
            hash.Add("ab", "a");
            hash.Add("a", "bb");
            hash.Add("bb", "b");
            hash.Add("b", "c");

            hash.TryGetValue(savel, out string value);
            return value;
        }
    }
}
