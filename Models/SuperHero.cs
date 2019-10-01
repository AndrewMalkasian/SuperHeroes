using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroes.Models
{
    public class SuperHero
    {
        [Key]
        public int Id { get; set; }
        public string AlterEgoFirstName { get; set; }
        public string AlterEgoLastName { get; set; }
        public string SuperHeroName { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string CatchPhrase { get; set; }

        ///  primary superhero ability, secondary superhero ability, and catchphrase
        /// 




    }
}