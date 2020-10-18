/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 02
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterCreator;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            _miExit.Click += OnExit;
            _miNewCharacter.Click += OnNewCharacter;
            _miAbout.Click += OnAbout;
        }

        public MainForm(Character character) : this()
        {
        }

        public Character _character = new Character();

        private void OnNewCharacter(object sender, EventArgs e)
        {
            var form = new CreateCharacter();
            var result = form.ShowDialog(this);
            
            if (result == DialogResult.Cancel)
                return;
            
            _character = form.character;
            _listName.Text = _character.Name;
            _richDescription.Text = _character.Description;
            _labBrawn.Text = _character.Brawn.ToString();
            _labBrains.Text = _character.Brains.ToString();
            _labMoxie.Text = _character.Moxie.ToString();
            _labLuck.Text = _character.Luck.ToString();
            _labSanity.Text = _character.Sanity.ToString();
            _labProfession.Text = _character.Profession;
            _labRace.Text = _character.Race;

        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void OnAbout(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog(this);
        }
        
        private void OnSave(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;

            var character = new Character();
            character.Name = _listName.Text;
            character.Description = _richDescription.Text;
            character.Brawn = character.ConvertStat(_labBrawn.Text);
            character.Brains = character.ConvertStat(_labBrains.Text);
            character.Moxie = character.ConvertStat(_labMoxie.Text);
            character.Luck = character.ConvertStat(_labLuck.Text);
            character.Sanity = character.ConvertStat(_labSanity.Text);
            character.Profession = _labProfession.Text;
            character.Race = _labRace.Text;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LLLL(object sender, EventArgs e)
        {

        }


        private void rtrtrtrt(object sender, EventArgs e)
        {

        }

        private void lsdklf_Click(object sender, EventArgs e)
        {

        }
    }
}
