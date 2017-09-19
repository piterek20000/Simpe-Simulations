using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_II_Simulator
{
    public abstract class Characters
    {
        //Declaration of all characters stats
        #region Base Statystics

        private string _name;
        private int _lvl;
        private int _strenght;
        private int _agility;
        private int _vitality;
        private int _life;
        private int _stamina;
        private int _energy;
        private int _mana;
        private int _expirience;

        public int Expirience
        {
            get { return _expirience; }
            set { _expirience = value; }
        }

        private float _x; //Stats  modificator

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }

        public int Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }

        public int Stamina
        {
            get { return _stamina; }
            set { _stamina = value; }
        }

        public int Life
        {
            get { return _life; }
            set { _life = value; }
        }

        public int Vitality
        {
            get { return _vitality; }
            set { _vitality = value; }
        }

        public int Agility
        {
            get { return _agility; }
            set { _agility = value; }
        }

        public int Strenght
        {
            get { return _strenght; }
            set { _strenght = value; }
        }

        public int Lvl
        {
            get { return _lvl; }
            set { _lvl = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        //Virtual Method helping with saving to txt
        #region Virtual Convert Class Informations To string

        /// <summary>
        /// Method returns informations about class in string form
        /// </summary>
        public virtual string Convert_To_string()
        {
            return string.Format("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}#{9}",
                Name,
                Lvl,
                Strenght,
                Agility,
                Vitality,
                Life, Stamina,
                Energy,
                Mana,
                Expirience);
        }

        #endregion

        //Abstract Methods representing the current class
        #region Abstract Methods

        /// <summary>
        /// Method representing class
        /// </summary>
        public abstract void Class_Introduction();

        #endregion
    }


    //TODO: Add Expirience to all characters and adopted all methods!!!
    #region Amazonka
    public class Amazonka : Characters
    {
        #region Virtual Method Override

        /// <summary>
        /// Method used to convert Characters List to list collection
        /// </summary>
        /// <returns>Single Character stats in string chain</returns>
        public override string Convert_To_string()
        {
            return string.Format("Amazonka#" + base.Convert_To_string());
        }

        #endregion

        #region Abstrac Method Override

        public override void Class_Introduction()
        {
            Console.WriteLine("\tAmazonka: {0}, \tlvl: {1}", Name, Lvl);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Base stats constructor
        /// </summary>
        /// <param name="name">Pass Name</param>
        public Amazonka(string name)
        {
            Name = name;
            Lvl = 1;
            Strenght = 25;
            Agility = 20;
            Vitality = 20;
            Life = 100;
            Stamina = 84;
            Energy = 15;
            Mana = 15;
            Expirience = 0;
            X = 1.7F;
        }

        /// <summary>
        /// Constructor for helping load saves
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="lvl">lvl</param>
        /// <param name="str">strenght</param>
        /// <param name="agl">agility</param>
        /// <param name="vit">vitality</param>
        /// <param name="lif">life</param>
        /// <param name="sta">stamina</param>
        /// <param name="ene">energy</param>
        /// <param name="man">mana</param>
        /// <param name="exp">expirience</param>
        public Amazonka(string name, int lvl, int str, int agl, int vit, int lif, int sta, int ene, int man, int exp)
        {
            Name = name;
            Lvl = lvl;
            Strenght = str;
            Agility = agl;
            Vitality = vit;
            Life = lif;
            Stamina = sta;
            Energy = ene;
            Mana = man;
            Expirience = exp;
            X = 1.7F;
        }

        #endregion
    }
    #endregion

    #region Nekromanta
    public class Nekromanta : Characters
    {
        #region Virtual Method Override
        public override string Convert_To_string()
        {
            return string.Format("Nekromanta#" + base.Convert_To_string());
        }
        #endregion

        #region Abstrac Method Override

        public override void Class_Introduction()
        {
            Console.WriteLine("\tNekromanta: {0}, \tlvl: {1}", Name, Lvl);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Base stats constructor
        /// </summary>
        /// <param name="name">Pass Name</param>
        public Nekromanta(string name)
        {
            Name = name;
            Lvl = 1;
            Strenght = 15;
            Agility = 25;
            Vitality = 15;
            Life = 100;
            Stamina = 79;
            Energy = 25;
            Mana = 25;
            Expirience = 0;
            X = 1.7F;
        }

        /// <summary>
        /// Constructor for helping load saves
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="lvl">lvl</param>
        /// <param name="str">strenght</param>
        /// <param name="agl">agility</param>
        /// <param name="vit">vitality</param>
        /// <param name="lif">life</param>
        /// <param name="sta">stamina</param>
        /// <param name="ene">energy</param>
        /// <param name="man">mana</param>
        /// <param name="exp">expirience</param>
        public Nekromanta(string name, int lvl, int str, int agl, int vit, int lif, int sta, int ene, int man, int exp)
        {
            Name = name;
            Lvl = lvl;
            Strenght = str;
            Agility = agl;
            Vitality = vit;
            Life = lif;
            Stamina = sta;
            Energy = ene;
            Mana = man;
            Expirience = exp;
            X = 1.4F;
        }

        #endregion
    }
    #endregion

    #region Barbarzynca
    public class Barbarzynca : Characters
    {
        #region Virtual Method Override
        public override string Convert_To_string()
        {
            return string.Format("Barbarzynca#" + base.Convert_To_string());
        }
        #endregion

        #region Abstrac Method Override

        public override void Class_Introduction()
        {
            Console.WriteLine("\tBarbarzynca: {0}, \tlvl: {1}", Name, Lvl);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Base stats constructor
        /// </summary>
        /// <param name="name">Pass Name</param>
        public Barbarzynca(string name)
        {
            Name = name;
            Lvl = 1;
            Strenght = 30;
            Agility = 20;
            Vitality = 25;
            Life = 100;
            Stamina = 91;
            Energy = 10;
            Mana = 10;
            Expirience = 0;
            X = 1.7F;
        }

        /// <summary>
        /// Constructor for helping load saves
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="lvl">lvl</param>
        /// <param name="str">strenght</param>
        /// <param name="agl">agility</param>
        /// <param name="vit">vitality</param>
        /// <param name="lif">life</param>
        /// <param name="sta">stamina</param>
        /// <param name="ene">energy</param>
        /// <param name="man">mana</param>
        /// <param name="exp">expirience</param>
        public Barbarzynca(string name, int lvl, int str, int agl, int vit, int lif, int sta, int ene, int man, int exp)
        {
            Name = name;
            Lvl = lvl;
            Strenght = str;
            Agility = agl;
            Vitality = vit;
            Life = lif;
            Stamina = sta;
            Energy = ene;
            Mana = man;
            Expirience = exp;
            X = 1.9F;
        }

        #endregion
    }
    #endregion

    #region Paladyn
    public class Paladyn : Characters
    {
        #region Virtual Method Override
        public override string Convert_To_string()
        {
            return string.Format("Paladyn#" + base.Convert_To_string());
        }
        #endregion

        #region Abstrac Method Override

        public override void Class_Introduction()
        {
            Console.WriteLine("\tPaladyn: {0}, \tlvl: {1}", Name, Lvl);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Base stats constructor
        /// </summary>
        /// <param name="name">Pass Name</param>
        public Paladyn(string name)
        {
            Name = name;
            Lvl = 1;
            Strenght = 20;
            Agility = 25;
            Vitality = 20;
            Life = 100;
            Stamina = 89;
            Energy = 15;
            Mana = 15;
            Expirience = 0;
            X = 2.2F;
        }

        /// <summary>
        /// Constructor for helping load saves
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="lvl">lvl</param>
        /// <param name="str">strenght</param>
        /// <param name="agl">agility</param>
        /// <param name="vit">vitality</param>
        /// <param name="lif">life</param>
        /// <param name="sta">stamina</param>
        /// <param name="ene">energy</param>
        /// <param name="man">mana</param>
        /// <param name="exp">expirience</param>
        public Paladyn(string name, int lvl, int str, int agl, int vit, int lif, int sta, int ene, int man, int exp)
        {
            Name = name;
            Lvl = lvl;
            Strenght = str;
            Agility = agl;
            Vitality = vit;
            Life = lif;
            Stamina = sta;
            Energy = ene;
            Mana = man;
            Expirience = exp;
            X = 1.9F;
        }

        #endregion
    }
    #endregion

    #region Czarodziejka
    public class Czarodziejka : Characters
    {
        #region Virtual Method Override
        public override string Convert_To_string()
        {
            return string.Format("Czarodziejka#" + base.Convert_To_string());
        }
        #endregion

        #region Abstrac Method Override

        public override void Class_Introduction()
        {
            Console.WriteLine("\tCzarodziejka: {0}, \tlvl: {1}", Name, Lvl);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Base stats constructor
        /// </summary>
        /// <param name="name">Pass Name</param>
        public Czarodziejka(string name)
        {
            Name = name;
            Lvl = 1;
            Strenght = 10;
            Agility = 25;
            Vitality = 10;
            Life = 100;
            Stamina = 74;
            Energy = 35;
            Mana = 35;
            Expirience = 0;
            X = 2.3F;
        }

        /// <summary>
        /// Constructor for helping load saves
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="lvl">lvl</param>
        /// <param name="str">strenght</param>
        /// <param name="agl">agility</param>
        /// <param name="vit">vitality</param>
        /// <param name="lif">life</param>
        /// <param name="sta">stamina</param>
        /// <param name="ene">energy</param>
        /// <param name="man">mana</param>
        /// <param name="exp">expirience</param>
        public Czarodziejka(string name, int lvl, int str, int agl, int vit, int lif, int sta, int ene, int man, int exp)
        {
            Name = name;
            Lvl = lvl;
            Strenght = str;
            Agility = agl;
            Vitality = vit;
            Life = lif;
            Stamina = sta;
            Energy = ene;
            Mana = man;
            Expirience = exp;
            X = 1.9F;
        }

        #endregion
    }
    #endregion

    #region Zabojczyni
    public class Zabojczyni : Characters
    {
        #region Virtual Method Override
        public override string Convert_To_string()
        {
            return string.Format("Zabojczyni#" + base.Convert_To_string());
        }
        #endregion

        #region Abstrac Method Override

        public override void Class_Introduction()
        {
            Console.WriteLine("\tZabojczyni: {0}, \tlvl: {1}", Name, Lvl);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Base stats constructor
        /// </summary>
        /// <param name="name">Pass Name</param>
        public Zabojczyni(string name)
        {
            Name = name;
            Lvl = 1;
            Strenght = 20;
            Agility = 20;
            Vitality = 20;
            Life = 100;
            Stamina = 95;
            Energy = 25;
            Mana = 25;
            Expirience = 0;
            X = 1.8F;
        }

        /// <summary>
        /// Constructor for helping load saves
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="lvl">lvl</param>
        /// <param name="str">strenght</param>
        /// <param name="agl">agility</param>
        /// <param name="vit">vitality</param>
        /// <param name="lif">life</param>
        /// <param name="sta">stamina</param>
        /// <param name="ene">energy</param>
        /// <param name="man">mana</param>
        /// <param name="exp">expirience</param>
        public Zabojczyni(string name, int lvl, int str, int agl, int vit, int lif, int sta, int ene, int man, int exp)
        {
            Name = name;
            Lvl = lvl;
            Strenght = str;
            Agility = agl;
            Vitality = vit;
            Life = lif;
            Stamina = sta;
            Energy = ene;
            Mana = man;
            Expirience = exp;
            X = 1.9F;
        }

        #endregion
    }
    #endregion

    #region Druid
    public class Druid : Characters
    {
        #region Virtual Method Override
        public override string Convert_To_string()
        {
            return string.Format("Druid#" + base.Convert_To_string());
        }
        #endregion

        #region Abstrac Method Override

        public override void Class_Introduction()
        {
            Console.WriteLine("\tDruid: {0}, \tlvl: {1}", Name, Lvl);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Base stats constructor
        /// </summary>
        /// <param name="name">Pass Name</param>
        public Druid(string name)
        {
            Name = name;
            Lvl = 1;
            Strenght = 15;
            Agility = 20;
            Vitality = 25;
            Life = 100;
            Stamina = 84;
            Energy = 20;
            Mana = 20;
            Expirience = 0;
            X = 1.6F;
        }

        /// <summary>
        /// Constructor for helping load saves
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="lvl">lvl</param>
        /// <param name="str">strenght</param>
        /// <param name="agl">agility</param>
        /// <param name="vit">vitality</param>
        /// <param name="lif">life</param>
        /// <param name="sta">stamina</param>
        /// <param name="ene">energy</param>
        /// <param name="man">mana</param>
        /// <param name="exp">expirience</param>
        public Druid(string name, int lvl, int str, int agl, int vit, int lif, int sta, int ene, int man, int exp)
        {
            Name = name;
            Lvl = lvl;
            Strenght = str;
            Agility = agl;
            Vitality = vit;
            Life = lif;
            Stamina = sta;
            Energy = ene;
            Mana = man;
            Expirience = exp;
            X = 1.9F;
        }

        #endregion
    }
    #endregion
}
