using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFLib
{
    /// <summary>
    /// This class contains the definition for skills
    /// </summary>
    public class Skill
    {
        private string _name;
        private bool _isClassSkill;
        private int _skillRanksPurchased;

        /// <summary>
        /// Stores only the skill level pruchased
        /// </summary>
        public int SkillRanksPurchased
        {
            get { return _skillRanksPurchased; }
            set { _skillRanksPurchased = value; }
        }

        /// <summary>
        /// Is this a class skill?
        /// </summary>
        public bool IsClassSkill
        {
            get { return _isClassSkill; }
            set { _isClassSkill = value; }
        }

        /// <summary>
        /// Returns a string with the name of the skill
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        

    }
}
