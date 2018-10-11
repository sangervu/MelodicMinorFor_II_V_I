
using System.Collections.Generic;

namespace DesktopMelodicMinor4minor_II_V_I
{
    public class WS_Sharp
    {
        public string getScales(string savel)
        {
            // Create Dictionary.
            Dictionary<string, string> hash = new Dictionary<string, string>();

            hash.Add("c", "d");
            hash.Add("c#", "d#");
            hash.Add("d", "e");
            hash.Add("d#", "f");
            hash.Add("e", "f#");
            hash.Add("f", "g");
            hash.Add("f#", "g#");
            hash.Add("g", "a");
            hash.Add("g#", "a#");
            hash.Add("a", "b");
            hash.Add("a#", "c");
            hash.Add("b", "c#");

            hash.TryGetValue(savel, out string value);
            return value;
        }
    }
}
