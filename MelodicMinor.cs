/*
* @author Sakari Angervuori
*/

namespace DesktopMelodicMinor4minor_II_V_I
{
    public class MelodicMinor
    {
        public string new_MM_Scale;

        public MelodicMinor(string minorKey)
        {

            string note2, note3, note4, note5, note6, note7, note8;

            WS_Sharp ws_sharp = new WS_Sharp();
            HS_Sharp hs_sharp = new HS_Sharp();
            WS_Flat ws_flat = new WS_Flat();
            HS_Flat hs_flat = new HS_Flat();

            if (minorKey.Equals("d") || minorKey.Equals("e") || minorKey.Equals("a") || minorKey.Equals("c#") ||
                minorKey.Equals("d#") || minorKey.Equals("f#") || minorKey.Equals("g#") || minorKey.Equals("a#"))
            {

                //System.out.println(" W H W W W W H ");
                //intervalli1 = "W";
                note2 = ws_sharp.getScales(minorKey);

                //intervalli2 = "H";
                note3 = hs_sharp.getScales(note2);

                //intervalli3 = "W";
                note4 = ws_sharp.getScales(note3);

                //intervalli4 = "W";
                note5 = ws_sharp.getScales(note4);

                //intervalli5 = "W";
                note6 = ws_sharp.getScales(note5);

                //intervalli6 = "W";
                note7 = ws_sharp.getScales(note6);

                //intervalli7 = "H";
                note8 = hs_sharp.getScales(note7);

                this.new_MM_Scale = minorKey + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;

            }
            else if (minorKey.Equals("c") || minorKey.Equals("f") || minorKey.Equals("g") || minorKey.Equals("b") ||
                minorKey.Equals("db") || minorKey.Equals("eb") || minorKey.Equals("gb") || minorKey.Equals("ab") || minorKey.Equals("bb"))
            {

                //System.out.println(" W H W W W W H ");
                //intervalli1 = "W";
                note2 = ws_flat.getScales(minorKey);

                //intervalli2 = "H";
                note3 = hs_flat.getScales(note2);

                //intervalli3 = "W";
                note4 = ws_flat.getScales(note3);

                //intervalli4 = "W";
                note5 = ws_flat.getScales(note4);

                //intervalli5 = "W";
                note6 = ws_flat.getScales(note5);

                //intervalli6 = "W";
                note7 = ws_flat.getScales(note6);

                //intervalli7 = "H";
                note8 = hs_flat.getScales(note7);

                this.new_MM_Scale = minorKey + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;

            }
            else
            {                 

            }
        }

    }
}
