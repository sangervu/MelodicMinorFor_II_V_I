using System;

namespace DesktopMelodicMinor4minor_II_V_I
{
    public class LydianDom
    {

        public String newMmScaleFor_V;

        public LydianDom(String keyNote)
        {

            String note1, note2, note3, note4, note5, note6, note7, note8;

            WS_Sharp ws_sharp = new WS_Sharp();
            HS_Sharp hs_sharp = new HS_Sharp();
            WS_Flat ws_flat = new WS_Flat();
            HS_Flat hs_flat = new HS_Flat();

            if (keyNote.Equals("d") || keyNote.Equals("e") || keyNote.Equals("a") || keyNote.Equals("c#") ||
            keyNote.Equals("d#") || keyNote.Equals("f#") || keyNote.Equals("g#") || keyNote.Equals("a#"))
            {

                //System.out.println("Lydian dominant/Acoustic scale for V cord (7)");
                //System.out.println(" W W W H W H W ");

                note1 = keyNote;

                //intervalli1 = "W";
                note2 = ws_sharp.getScales(keyNote);

                //intervalli2 = "W";
                note3 = ws_sharp.getScales(note2);

                //intervalli3 = "W";
                note4 = ws_sharp.getScales(note3);

                //intervalli4 = "H";
                note5 = hs_sharp.getScales(note4);

                //intervalli5 = "W";
                note6 = ws_sharp.getScales(note5);

                //intervalli6 = "H";
                note7 = hs_sharp.getScales(note6);

                //intervalli7 = "W";
                note8 = ws_sharp.getScales(note7);

                this.newMmScaleFor_V = keyNote + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;

            }
            else if (keyNote.Equals("c") || keyNote.Equals("f") || keyNote.Equals("g") || keyNote.Equals("b") ||
                  keyNote.Equals("db") || keyNote.Equals("eb") || keyNote.Equals("gb") || keyNote.Equals("ab") || keyNote.Equals("bb"))
            {

                //System.out.println("Lydian dominant/Acoustic scale for V cord (7)");
                //System.out.println(" W W W H W H W ");

                note1 = keyNote;

                //intervalli1 = "W";
                note2 = ws_flat.getScales(note1);

                //intervalli2 = "W";
                note3 = ws_flat.getScales(note2);

                //intervalli3 = "W";
                note4 = ws_flat.getScales(note3);

                //intervalli4 = "H";
                note5 = hs_flat.getScales(note4);

                //intervalli5 = "W";
                note6 = ws_flat.getScales(note5);

                //intervalli6 = "H";
                note7 = hs_flat.getScales(note6);

                //intervalli7 = "W";
                note8 = ws_flat.getScales(note7);

                this.newMmScaleFor_V = note1 + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;

            }
            else
            {

            }
        }

    }
}
