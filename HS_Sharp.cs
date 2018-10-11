
using System.Collections.Generic;

namespace DesktopMelodicMinor4minor_II_V_I
{
    class HS_Sharp
    {
        public string getScales(string savel)
        {

            // Create Dictionary.
            Dictionary<string, string> hash = new Dictionary<string, string>();

            hash.Add("c", "c#");
            hash.Add("c#", "d");
            hash.Add("d", "d#");
            hash.Add("d#", "e");
            hash.Add("e", "f");
            hash.Add("f", "f#");
            hash.Add("f#", "g");
            hash.Add("g", "g#");
            hash.Add("g#", "a");
            hash.Add("a", "a#");
            hash.Add("a#", "b");
            hash.Add("b", "c");

            hash.TryGetValue(savel, out string value);
            return value;
        }
    }
}
