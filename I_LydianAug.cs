using System;

namespace DesktopMelodicMinor4minor_II_V_I
{
    public class I_LydianAug
    {
        public String newRoot4MMScale;

        public I_LydianAug(String keyNote)
        {

            String note1, note2, note3, note4, note5, note6;

            WS_Sharp ws_sharp = new WS_Sharp();
            HS_Sharp hs_sharp = new HS_Sharp();
            WS_Flat ws_flat = new WS_Flat();
            HS_Flat hs_flat = new HS_Flat();

            // Find the new root for melodic minor scale used on for the Lydian Augmented scale       
            // W W H W W
            if (keyNote.Equals("d") || keyNote.Equals("e") || keyNote.Equals("a") || keyNote.Equals("c#") ||
               keyNote.Equals("d#") || keyNote.Equals("f#") || keyNote.Equals("g#") || keyNote.Equals("a#"))
            {
                note1 = keyNote;
                //intervalli1 = "W";
                note2 = ws_sharp.getScales(note1);
                //intervalli1 = "W";
                note3 = ws_sharp.getScales(note2);
                //intervalli1 = "H";
                note4 = hs_sharp.getScales(note3);
                //intervalli1 = "W";
                note5 = ws_sharp.getScales(note4);
                //intervalli1 = "W";
                note6 = ws_sharp.getScales(note5);
                this.newRoot4MMScale = note6;

            }
            else if (keyNote.Equals("c") || keyNote.Equals("f") || keyNote.Equals("g") || keyNote.Equals("b") ||
            keyNote.Equals("db") || keyNote.Equals("eb") || keyNote.Equals("gb") || keyNote.Equals("ab") || keyNote.Equals("bb"))
            {
                note1 = keyNote;
                //intervalli1 = "W";
                note2 = ws_flat.getScales(note1);
                //intervalli1 = "W";
                note3 = ws_flat.getScales(note2);
                //intervalli1 = "H";
                note4 = hs_flat.getScales(note3);
                //intervalli1 = "W";
                note5 = ws_flat.getScales(note4);
                //intervalli1 = "W";
                note6 = ws_flat.getScales(note5);
                this.newRoot4MMScale = note6;

            }
            else
            {

            }
        }
    }
}
