using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void playSimpleSound(string note)
        {
            SoundPlayer soundPlayer = new SoundPlayer(note.ToString());
            soundPlayer.Play();
        }

        public bool CheckStretched()
        {
            bool stretched = false;
            if (cbxStretched.Checked)
            {
                stretched = true;
            }
            return stretched;
        }

        private void btnDo_Click(object sender, EventArgs e)
        {

            MusicalNote musicalNote = new MusicalNote(CheckStretched());
            playSimpleSound(musicalNote.Do1);
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            MusicalNote musicalNote = new MusicalNote(CheckStretched());
            playSimpleSound(musicalNote.Re1);
        }

        private void btnMi_Click(object sender, EventArgs e)
        {
            MusicalNote musicalNote = new MusicalNote(CheckStretched());
            playSimpleSound(musicalNote.Mi1);
        }

        private void btnFa_Click(object sender, EventArgs e)
        {
            MusicalNote musicalNote = new MusicalNote(CheckStretched());
            playSimpleSound(musicalNote.Fa1);
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            MusicalNote musicalNote = new MusicalNote(CheckStretched());
            playSimpleSound(musicalNote.Sol1);
        }

        private void btnLa_Click(object sender, EventArgs e)
        {
            MusicalNote musicalNote = new MusicalNote(CheckStretched());
            playSimpleSound(musicalNote.La1);
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            MusicalNote musicalNote = new MusicalNote(CheckStretched());
            playSimpleSound(musicalNote.Si1);
        }

        private void btnDo_Octave_Click(object sender, EventArgs e)
        {
            MusicalNote musicalNote = new MusicalNote(CheckStretched());
            playSimpleSound(musicalNote.Do2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.A)
            {
                btnDo.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.S)
            {
                btnRe.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D)
            {
                btnMi.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.F)
            {
                btnFa.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.G)
            {
                btnSol.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.H)
            {
                btnLa.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.J)
            {
                btnSi.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.K)
            {
                btnDo_Octave.PerformClick();
            }
        }



    }


}
