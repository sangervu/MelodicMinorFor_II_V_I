
using System.Collections.Generic;

namespace DesktopMelodicMinor4minor_II_V_I
{
    class WS_Flat
    {
        public string getScales(string savel)
        {
            // Create Dictionary.
            Dictionary<string, string> hash = new Dictionary<string, string>();
            hash.Add("c", "d");
            hash.Add("db", "eb");
            hash.Add("d", "e");
            hash.Add("eb", "f");
            hash.Add("e", "gb");
            hash.Add("f", "g");
            hash.Add("gb", "ab");
            hash.Add("g", "a");
            hash.Add("ab", "bb");
            hash.Add("a", "b");
            hash.Add("bb", "c");
            hash.Add("b", "db");


            hash.TryGetValue(savel, out string value);
            return value;
        }
    }
}
