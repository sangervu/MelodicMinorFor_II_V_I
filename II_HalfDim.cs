
namespace DesktopMelodicMinor4minor_II_V_I
{
    public class II_HalfDim
    {
        public string newRoot4MMScale;

        public II_HalfDim(string keyNote)
        {

            string note2, note3, note4;

            WS_Sharp ws_sharp = new WS_Sharp();
            HS_Sharp hs_sharp = new HS_Sharp();
            WS_Flat ws_flat = new WS_Flat();
            HS_Flat hs_flat = new HS_Flat();

            // Find the new root for melodic minor scale used on for Half dim. scale       
            // W W H
            if (keyNote.Equals("d") || keyNote.Equals("e") || keyNote.Equals("a") || keyNote.Equals("c#") ||
                keyNote.Equals("d#") || keyNote.Equals("f#") || keyNote.Equals("g#") || keyNote.Equals("a#"))
            {

                //intervalli1 = "W";
                note2 = ws_sharp.getScales(keyNote);

                //intervalli2 = "W";
                note3 = ws_sharp.getScales(note2);

                //intervalli3 = "H";
                note4 = hs_sharp.getScales(note3);

                this.newRoot4MMScale = note4;

            }
            else if (keyNote.Equals("c") || keyNote.Equals("f") || keyNote.Equals("g") || keyNote.Equals("b") ||
              keyNote.Equals("db") || keyNote.Equals("eb") || keyNote.Equals("gb") || keyNote.Equals("ab") || keyNote.Equals("bb"))
            {

                //intervalli1 = "W";
                note2 = ws_flat.getScales(keyNote);

                //intervalli2 = "W";
                note3 = ws_flat.getScales(note2);

                //intervalli3 = "H";
                note4 = hs_flat.getScales(note3);

                this.newRoot4MMScale = note4;
            }
            else
            {

            }

        }
    }
}
