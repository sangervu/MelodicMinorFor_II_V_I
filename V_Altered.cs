
namespace DesktopMelodicMinor4minor_II_V_I
{
    public class V_Altered
    {
        public string newRoot4MMScaleV;

        public V_Altered(string keyNote)
        {

            string note2, note3, note4, note5;

            WS_Sharp ws_sharp = new WS_Sharp();
            HS_Sharp hs_sharp = new HS_Sharp();
            WS_Flat ws_flat = new WS_Flat();
            HS_Flat hs_flat = new HS_Flat();

            // Find the new root for melodic minor scale used on for Alt V scale       
            // W W W W
            if (keyNote.Equals("d") || keyNote.Equals("e") || keyNote.Equals("a") || keyNote.Equals("c#") ||
                keyNote.Equals("d#") || keyNote.Equals("f#") || keyNote.Equals("g#") || keyNote.Equals("a#"))
            {

                //intervalli1 = "H";
                note2 = ws_sharp.getScales(keyNote);

                //intervalli2 = "W";
                note3 = ws_sharp.getScales(note2);

                //intervalli3 = "W";
                note4 = ws_sharp.getScales(note3);

                //intervalli4 = "W";
                note5 = ws_sharp.getScales(note4);

                this.newRoot4MMScaleV = note5;

            }
            else if (keyNote.Equals("c") || keyNote.Equals("f") || keyNote.Equals("g") || keyNote.Equals("b") ||
             keyNote.Equals("db") || keyNote.Equals("eb") || keyNote.Equals("gb") || keyNote.Equals("ab") || keyNote.Equals("bb"))
            {

                //intervalli1 = "W";
                note2 = ws_flat.getScales(keyNote);

                //intervalli2 = "W";
                note3 = ws_flat.getScales(note2);

                //intervalli3 = "W";
                note4 = ws_flat.getScales(note3);

                //intervalli4 = "W";
                note5 = ws_flat.getScales(note4);

                this.newRoot4MMScaleV = note5;

            }
            else
            {

            }

        }
    }
}
