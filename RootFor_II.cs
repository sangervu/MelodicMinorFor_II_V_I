
namespace DesktopMelodicMinor4minor_II_V_I
{
    class RootFor_II
    {
        public string newRoot4II;

        public RootFor_II(string keyNote)
        {

            string note2;

            WS_Sharp ws_sharp = new WS_Sharp();
            //HS_Sharp hs_sharp = new HS_Sharp();
            WS_Flat ws_flat = new WS_Flat();
            //HS_Flat hs_flat = new HS_Flat();

            // Find the root for the II degree       
            // W
            if (keyNote.Equals("d") || keyNote.Equals("e") || keyNote.Equals("a") || keyNote.Equals("c#") ||
               keyNote.Equals("d#") || keyNote.Equals("f#") || keyNote.Equals("g#") || keyNote.Equals("a#"))
            {

                //intervalli1 = "W";
                note2 = ws_sharp.getScales(keyNote);

                this.newRoot4II = note2;

            }
            else if (keyNote.Equals("c") || keyNote.Equals("f") || keyNote.Equals("g") || keyNote.Equals("b") ||
             keyNote.Equals("db") || keyNote.Equals("eb") || keyNote.Equals("gb") || keyNote.Equals("ab") || keyNote.Equals("bb"))
            {

                //intervalli1 = "W";
                note2 = ws_flat.getScales(keyNote);

                this.newRoot4II = note2;
            }
            else
            {

            }
        }
    }
}
