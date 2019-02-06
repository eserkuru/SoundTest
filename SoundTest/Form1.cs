using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

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
            /*** Single Sound Play ***/
            //SoundPlayer soundPlayer = new SoundPlayer(note.ToString());
            //soundPlayer.Play();

            /*** Multiple Sounds Play ***/
            new System.Threading.Thread(() =>
            {
                var mediaPlayer = new System.Windows.Media.MediaPlayer();
                mediaPlayer.Open(new System.Uri(note.ToString()));
                mediaPlayer.Play();
            }).Start();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {

            MusicalNote musicalNote = new MusicalNote(cbxStretched.Checked);
            playSimpleSound(musicalNote.Do1);
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            MusicalNote musicalNote = new MusicalNote(cbxStretched.Checked);
            playSimpleSound(musicalNote.Re1);
        }

        private void btnMi_Click(object sender, EventArgs e)
        {
            MusicalNote musicalNote = new MusicalNote(cbxStretched.Checked);
            playSimpleSound(musicalNote.Mi1);
        }

        private void btnFa_Click(object sender, EventArgs e)
        {
            MusicalNote musicalNote = new MusicalNote(cbxStretched.Checked);
            playSimpleSound(musicalNote.Fa1);
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            MusicalNote musicalNote = new MusicalNote(cbxStretched.Checked);
            playSimpleSound(musicalNote.Sol1);
        }

        private void btnLa_Click(object sender, EventArgs e)
        {
            MusicalNote musicalNote = new MusicalNote(cbxStretched.Checked);
            playSimpleSound(musicalNote.La1);
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            MusicalNote musicalNote = new MusicalNote(cbxStretched.Checked);
            playSimpleSound(musicalNote.Si1);
        }

        private void btnDo_Octave_Click(object sender, EventArgs e)
        {
            MusicalNote musicalNote = new MusicalNote(cbxStretched.Checked);
            playSimpleSound(musicalNote.Do2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.A || e.KeyChar == 'a')
            {
                btnDo.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.S || e.KeyChar == 's')
            {
                btnRe.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D || e.KeyChar == 'd')
            {
                btnMi.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.F || e.KeyChar == 'f')
            {
                btnFa.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.G || e.KeyChar == 'g')
            {
                btnSol.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.H || e.KeyChar == 'h')
            {
                btnLa.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.J || e.KeyChar == 'j')
            {
                btnSi.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.K || e.KeyChar == 'k')
            {
                btnDo_Octave.PerformClick();
            }
        }
    }
}
