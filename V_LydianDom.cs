using System;

namespace DesktopMelodicMinor4minor_II_V_I
{
    public class V_LydianDom
    {

        public String newRoot4MMScale;

        public V_LydianDom(String keyNote)
        {
 
            String note1;

            WS_Sharp ws_sharp = new WS_Sharp();
            HS_Sharp hs_sharp = new HS_Sharp();
            WS_Flat ws_flat = new WS_Flat();
            HS_Flat hs_flat = new HS_Flat();


            // Find the new root for melodic minor scale used on for Lydian Dom V scale       
            // W 
            if (keyNote.Equals("d") || keyNote.Equals("e") || keyNote.Equals("a") || keyNote.Equals("c#") ||
             keyNote.Equals("d#") || keyNote.Equals("f#") || keyNote.Equals("g#") || keyNote.Equals("a#"))
            {

                //intervalli1 = "W";
                note1 = ws_sharp.getScales(keyNote);

                this.newRoot4MMScale = note1;

            }
            else if (keyNote.Equals("c") || keyNote.Equals("f") || keyNote.Equals("g") || keyNote.Equals("b") ||
            keyNote.Equals("db") || keyNote.Equals("eb") || keyNote.Equals("gb") || keyNote.Equals("ab") || keyNote.Equals("bb"))
            {

                //intervalli1 = "W";
                note1 = ws_flat.getScales(keyNote);


                this.newRoot4MMScale = note1;

            }
            else
            {

            }

        }
    }
}
