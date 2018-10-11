
namespace DesktopMelodicMinor4minor_II_V_I
{
    class HalfDiminished
    {
        public string new_MM_Scale_II;

        public void setKey(string keyNote = "c")
        {

            string note1, note2, note3, note4, note5, note6, note7, note8;

            WS_Sharp ws_sharp = new WS_Sharp();
            HS_Sharp hs_sharp = new HS_Sharp();
            WS_Flat ws_flat = new WS_Flat();
            HS_Flat hs_flat = new HS_Flat();

            if (keyNote.Equals("d") || keyNote.Equals("e") || keyNote.Equals("a") || keyNote.Equals("c#") ||
            keyNote.Equals("d#") || keyNote.Equals("f#") || keyNote.Equals("g#") || keyNote.Equals("a#"))
            {

                //System.out.println("Half diminished scale for II cord (mi7b5)");
                //System.out.println(" W H W H W W W ");

                note1 = keyNote;

                //intervalli1 = "W";
                note2 = ws_sharp.getScales(note1);

                //intervalli2 = "H";
                note3 = hs_sharp.getScales(note2);

                //intervalli3 = "W";
                note4 = ws_sharp.getScales(note3);

                //intervalli4 = "H";
                note5 = hs_sharp.getScales(note4);

                //intervalli5 = "W";
                note6 = ws_sharp.getScales(note5);

                //intervalli6 = "W";
                note7 = ws_sharp.getScales(note6);

                //intervalli7 = "W";
                note8 = ws_sharp.getScales(note7);

                this.new_MM_Scale_II = keyNote + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;

            }
            else if (keyNote.Equals("c") || keyNote.Equals("f") || keyNote.Equals("g") || keyNote.Equals("b") ||
                keyNote.Equals("db") || keyNote.Equals("eb") || keyNote.Equals("gb") || keyNote.Equals("ab") || keyNote.Equals("bb"))
            {

                // System.out.println("Half diminished scale for II cord (mi7b5)");
                //System.out.println(" W H W H W W W ");
                note1 = keyNote;

                //intervalli1 = "W";
                note2 = ws_flat.getScales(note1);

                //intervalli2 = "H";
                note3 = hs_flat.getScales(note2);

                //intervalli3 = "W";
                note4 = ws_flat.getScales(note3);

                //intervalli4 = "H";
                note5 = hs_flat.getScales(note4);

                //intervalli5 = "W";
                note6 = ws_flat.getScales(note5);

                //intervalli6 = "W";
                note7 = ws_flat.getScales(note6);

                //intervalli7 = "W";
                note8 = ws_flat.getScales(note7);

                this.new_MM_Scale_II = keyNote + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;

            }
            else
            {

            }


        }

    }
}
