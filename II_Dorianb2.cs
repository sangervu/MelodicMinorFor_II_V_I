using System;

namespace DesktopMelodicMinor4minor_II_V_I
{
    public class II_Dorianb2
    {
        public String newRoot4MMScale;

        public II_Dorianb2(String keyNote)
        {

            WS_Sharp ws_sharp = new WS_Sharp();
            HS_Sharp hs_sharp = new HS_Sharp();
            WS_Flat ws_flat = new WS_Flat();
            HS_Flat hs_flat = new HS_Flat();

            // Find the new root for melodic minor scale used on for Dorianb2 scale       
            // Same root note!
            if (keyNote.Equals("d") || keyNote.Equals("e") || keyNote.Equals("a") || keyNote.Equals("c#") ||
               keyNote.Equals("d#") || keyNote.Equals("f#") || keyNote.Equals("g#") || keyNote.Equals("a#"))
            {

                this.newRoot4MMScale = keyNote;

            }
            else if (keyNote.Equals("c") || keyNote.Equals("f") || keyNote.Equals("g") || keyNote.Equals("b") ||
              keyNote.Equals("db") || keyNote.Equals("eb") || keyNote.Equals("gb") || keyNote.Equals("ab") || keyNote.Equals("bb"))
            {

                this.newRoot4MMScale = keyNote;

            }
            else
            {

            }

        }

    }
}
