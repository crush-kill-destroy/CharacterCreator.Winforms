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

namespace CharacterCreator
{
    public partial class CreateCharacter : Form
    {
        public CreateCharacter()
        {
            InitializeComponent();
        }

        public Character character = new Character();

        public void OnLoad()
        {
            if (character != null)
            {
                _txtName.Text = character.Name;
                _comboProfession.Text = character.Profession;
                _comboRace.Text = character.Race;
                _richDescription.Text = character.Description;
                _txtBrains.Text = character.Brains.ToString();
                _txtBrawn.Text = character.Brawn.ToString();
                _txtLuck.Text = character.Luck.ToString();
                _txtMoxie.Text = character.Moxie.ToString();
                _txtSanity.Text = character.Sanity.ToString();
            }
        }

        private void Error(string error)
        {
            MessageBox.Show(this, error, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void _buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
                return;
            }

            var button = sender as Button;

            if (button == null)
                return;

            Int32.TryParse(_txtBrains.Text, out int _brains);
            Int32.TryParse(_txtBrawn.Text, out int _brawn);
            Int32.TryParse(_txtMoxie.Text, out int _moxie);
            Int32.TryParse(_txtLuck.Text, out int _luck);
            Int32.TryParse(_txtSanity.Text, out int _sanity);

            character.Name = _txtName.Text;
            character.Profession = _comboProfession.Text;
            character.Race =_comboRace.Text;
            character.Description = _richDescription.Text;
            character.Brains = _brains;
            character.Brawn = _brawn;
            character.Luck = _luck;
            character.Moxie = _moxie;
            character.Sanity = _sanity;
            var error = character.Validate();


            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(this, error, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void _buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            return;
        }

        private void OnValidateName(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Name is required!");
                e.Cancel = true;
            }

            else
            {
                _errors.SetError(control, "");
            }
        }

        private void OnValidatingDropDown(object sender, CancelEventArgs e)
        {
            var control = sender as ComboBox;
            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Name is required!");
                e.Cancel = true;
            }

            else
            {
                _errors.SetError(control, "");
            }
        }

        private void OnValidatingStats(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            var success = Int32.TryParse(control.Text, out int stat);

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Stats cannot be empty!");
                e.Cancel = true;
            }

            else
            {
                _errors.SetError(control, "");
            }
            
            if (!success)
            {
                _errors.SetError(control, "Numbers only!");
                e.Cancel = true;
            }

            else
            {
                _errors.SetError(control, "");
            }

            if (stat < 1 || stat > 100)
            {
                _errors.SetError(control, "Between 1 and 100!");
                e.Cancel = true;
            }

            else
            {
                _errors.SetError(control, "");
            }
        }

        private void OnValidatingBrains(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            var success = Int32.TryParse(control.Text, out int stat);

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Stats cannot be empty!");
                e.Cancel = true;
            }

            else
            {
                _errors.SetError(control, "");
            }

            if (!success)
            {
                _errors.SetError(control, "Numbers only!");
                e.Cancel = true;
            }

            else
            {
                _errors.SetError(control, "");
            }

            if (stat < -2000000 || stat > 100)
            {
                _errors.SetError(control, "Between -2,000,000 and 100!");
                e.Cancel = true;
            }

            else
            {
                _errors.SetError(control, "");
            }
        }
    }
}
