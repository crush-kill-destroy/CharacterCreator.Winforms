/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 02
 */
using System;

namespace CharacterCreator
{
    public class Character
    {
        public const int MaxNameLength = 20;
        public const int MaxDescriptionLength = 250;
        private string _name;
        public int Brawn { get; set; }
        public int Brains { get; set; }
        public int Moxie { get; set; }
        public int Luck { get; set; }
        public int Sanity { get; set; }
        private string _description;
        private string _profession;
        private string _race;

        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }

        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value; }
        }

        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }

        public int ConvertStat(string stat)
        {
            Int32.TryParse(stat, out var result);
            return result;
        }

        public string Validate()
        {
            string high = " must be less than 100!";
            string low = " must be more than 0!";
            string lowBrain = " must be more than -2,000,000!";

            if (String.IsNullOrEmpty(Name))
                return "Name is required!";

            if (Name.Length > MaxNameLength)
                return "Name is too long!";

            if (Description.Length > MaxDescriptionLength)
                return "Description is too long!";

            if (Brawn > 100)
                return "Brawn" + high;
 
            if (Brains > 100)
                return "Brains" + high;

            if (Moxie > 100)
                return "Moxie" + high;

            if (Luck > 100)
                return "Luck" + high;

            if (Sanity > 100)
                return "Sanity" + high;

            if (Moxie < 1)
                return "Moxie" + low;

            if (Sanity < 1)
                return "Sanity" + low;

            if (Brawn < 1)
                return "Brawn" + low;

            if (Luck < 1)
                return "Luck" + low;

            if (Brains < -2000000)
                return "Brains" + lowBrain;

            if (String.IsNullOrEmpty(Profession))
                return "Get a job!";

            if (String.IsNullOrEmpty(Race))
                return "Can't leave race empty!";

            return null;
        }

        public string ValidateStat(int stat)
        {
            var validation = ValidateStat(stat, 1);
            return validation;
        }

        public string ValidateStat(int stat, int min)
        {
            if (stat >= min || stat <= 100)
                return "Your stats are out of bounds!";
            return null;
        }
    }
}