using System;
using System.Collections.Generic;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopMelodicMinor4minor_II_V_I
{
    public partial class Form1 : Form

    {
        private string postFix;
        private string keyNote;
        private string newRootForI;
        private string newRootForII;
        private string newRootForV;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cboState.Items.Clear();
            List<RootNotes> list = new List<RootNotes>();
            list.Add(new RootNotes() { ID = "01", Name = "c" });
            list.Add(new RootNotes() { ID = "02", Name = "d" });
            list.Add(new RootNotes() { ID = "03", Name = "e" });
            list.Add(new RootNotes() { ID = "04", Name = "f" });
            list.Add(new RootNotes() { ID = "05", Name = "g" });
            list.Add(new RootNotes() { ID = "06", Name = "a" });
            list.Add(new RootNotes() { ID = "07", Name = "b" });
            cboState.DataSource = list;
            cboState.ValueMember = "ID";
            cboState.DisplayMember = "name";
            cboState.SelectedIndex = 4;
        }

        private void isSharp_CheckedChanged(object sender, EventArgs e)
        {
            if (isSharp.Checked)
            {
                this.postFix = "#";
                this.keyNote = cboState.Text + postFix;
            }
        }

        private void isFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (isFlat.Checked)
            {
                this.postFix = "b";
                this.keyNote = cboState.Text + postFix;
            }
        }

        private void isNone_CheckedChanged(object sender, EventArgs e)
        {
            if (isNone.Checked)
            {
                this.postFix = "";
                this.keyNote = cboState.Text + postFix;
            }
        }
        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {

            RootNotes obj = cboState.SelectedItem as RootNotes;
            if (obj != null)
            {
                this.keyNote = cboState.Text + postFix;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            key.Text = keyNote;

            Scale_I.Text = "I (mi Ma7): Melodic minor";
            Scale_II.Text = "II (mi7b5): Half Diminished";
            Scale_V.Text = "V (7): Diminished Whole Tone";

            Intervals_I.Text = "W H W W W W H";
            Intervals_II.Text = "W H W W W W H";
            Intervals_V.Text = "W H W W W W H";

            //define the key notes for I, II and V

            //root for I is the key note!
            II_HalfDim dim_II = new II_HalfDim(keyNote);
            V_Altered alt_V = new V_Altered(keyNote);

            string newRootForMmII = dim_II.newRoot4MMScale;
            string newRootForMmV = alt_V.newRoot4MMScaleV;

            //Print the new scale roots on the Form
            melodicMinorFor_I.Text = keyNote;
            melodicMinorFor_II.Text = newRootForMmII;
            melodicMinorFor_V.Text = newRootForMmV;

            //define the melodic minor scale root notes for I, II and V

            // root for I is the keyNote!
            RootFor_II root_II = new RootFor_II(keyNote);
            RootFor_V root_V = new RootFor_V(keyNote);
            newRootForII = root_II.newRoot4II;
            newRootForV = root_V.newRoot4V;

            //define the new scales used for I, II and V based on the melodic minor scales and the root notes
            MelodicMinor melodicMinor = new MelodicMinor(keyNote);
            HalfDiminished halfDim = new HalfDiminished();
            Altered altered = new Altered();

            halfDim.setKey(newRootForII);
            altered.setKey(newRootForV);

            ScaleNotesFor_I.Text = melodicMinor.new_MM_Scale;
            ScaleNotesFor_II.Text = halfDim.new_MM_Scale_II;
            ScaleNotesFor_V.Text = altered.new_MM_Scale;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Scale_I.Text = "I (mi Ma7): Melodic minor";
            Scale_II.Text = "II (mi7): Dorian b2";
            Scale_V.Text = "V (7): Aeolian Dom";

            Intervals_I.Text = "W H W W W W H";
            Intervals_II.Text = "H W W W W H W";
            Intervals_V.Text = "W W H W H W W";

            //define the key notes for the melodic minor scales for I, II and V

            //root for I is the key note!
            II_Dorianb2 dorb2_II = new II_Dorianb2(keyNote);
            V_AeolianDom aeolianDom_V = new V_AeolianDom(keyNote);

            string newRootForMmII = dorb2_II.newRoot4MMScale;
            string newRootForMmV = aeolianDom_V.newRoot4MMScale;

            //Print the new scale roots on the Form
            melodicMinorFor_I.Text = keyNote;
            melodicMinorFor_II.Text = newRootForMmII;
            melodicMinorFor_V.Text = newRootForMmV;

            //define the new MM scale root notes for I, II and V
            //RootFor_I root_I= new RootFor_I(keyNote);
            RootFor_II root_II = new RootFor_II(keyNote);
            RootFor_V root_V = new RootFor_V(keyNote);

            newRootForI = keyNote;
            newRootForII = root_II.newRoot4II;
            newRootForV = root_V.newRoot4V;

            MelodicMinor melodicMinor = new MelodicMinor(keyNote);
            Dorianb2 dorb2 = new Dorianb2(newRootForII);
            AeolianDom aeolianDom = new AeolianDom(newRootForV);


            ScaleNotesFor_I.Text = melodicMinor.new_MM_Scale;
            ScaleNotesFor_II.Text = dorb2.newMmScaleFor_II;
            ScaleNotesFor_V.Text = aeolianDom.newMmScaleFor_V;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            Scale_I.Text = "I (Ma7#5): Lydian Aug";
            Scale_II.Text = "II (mi7): Dorian b2";
            Scale_V.Text = "V (7): Lydian Dom";

            Intervals_I.Text = "W W W W H W H";
            Intervals_II.Text = "H W W W W H W";
            Intervals_V.Text = "W W W H W H W";

            //define the key notes for the melodic minor scales for I, II and V

            I_LydianAug lydianAug_I = new I_LydianAug(keyNote);
            II_Dorianb2 dorb2_II = new II_Dorianb2(keyNote);
            V_LydianDom lydianDom_V = new V_LydianDom(keyNote);

            string newRootForMmI = lydianAug_I.newRoot4MMScale;
            string newRootForMmII = dorb2_II.newRoot4MMScale;
            string newRootForMmV = lydianDom_V.newRoot4MMScale;

            //Print the new scale roots on the Form
            melodicMinorFor_I.Text = newRootForMmI;
            melodicMinorFor_II.Text = newRootForMmII;
            melodicMinorFor_V.Text = newRootForMmV;

            //define the new MM scale root notes for I, II and V
            //RootFor_I root_I= new RootFor_I(keyNote);
            RootFor_II root_II = new RootFor_II(keyNote);
            RootFor_V root_V = new RootFor_V(keyNote);

            newRootForI = keyNote;
            newRootForII = root_II.newRoot4II;
            newRootForV = root_V.newRoot4V;

            LydianAug lydianAug = new LydianAug(newRootForI);
            Dorianb2 dorb2 = new Dorianb2(newRootForII);
            LydianDom lydianDom = new LydianDom(newRootForV);

            ScaleNotesFor_I.Text = lydianAug.newMmScaleFor_I;
            ScaleNotesFor_II.Text = dorb2.newMmScaleFor_II;
            ScaleNotesFor_V.Text = lydianDom.newMmScaleFor_V;

        }
    }
}
