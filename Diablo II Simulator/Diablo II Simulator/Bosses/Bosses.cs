using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_II_Simulator
{
    public class Bosses
    {
        public abstract class Boss
        {
            #region Stats

            private int _hp;
            private int _strenght;
            private int _expirience;

            public int Expirience
            {
                get { return _expirience; }
                set { _expirience = value; }
            }


            public int Strenght
            {
                get { return _strenght; }
                set { _strenght = value; }
            }

            public int Hp
            {
                get { return _hp; }
                set { _hp = value; }
            }

            #endregion

            #region Abstract Methods

            public abstract void Boss_Name();

            #endregion
        }

        public class Andariel : Boss
        {
            #region Abstract Overrite Methods
            public override void Boss_Name()
            {
                Console.Write("\t Andariel");
            }
            #endregion

            #region Constructor
            public Andariel()
            {
                Hp = 200;
                Strenght = 50;
                Expirience = 600;
            }
            #endregion
        }

        public class Lilith : Boss
        {
            #region Abstract Overrite Methods
            public override void Boss_Name()
            {
                Console.Write("\t Lilith");
            }
            #endregion

            #region Constructor
            public Lilith()
            {
                Hp = 300;
                Strenght = 100;
                Expirience = 200;
            }
            #endregion
        }

        public class Duriel : Boss
        {
            #region Abstract Overrite Methods
            public override void Boss_Name()
            {
                Console.Write("\t Duriel");
            }
            #endregion

            #region Constructor
            public Duriel()
            {
                Hp = 400;
                Strenght = 150;
                Expirience = 300;
            }
            #endregion
        }

        public class Mefisto : Boss
        {
            #region Abstract Overrite Methods
            public override void Boss_Name()
            {
                Console.Write("\t Mefisto");
            }
            #endregion

            #region Constructor
            public Mefisto()
            {
                Hp = 500;
                Strenght = 200;
                Expirience = 400;
            }
            #endregion
        }

        public class Izual : Boss
        {
            #region Abstract Overrite Methods
            public override void Boss_Name()
            {
                Console.Write("\t Izual");
            }
            #endregion

            #region Constructor
            public Izual()
            {
                Hp = 500;
                Strenght = 250;
                Expirience = 500;
            }
            #endregion
        }

        public class Diablo : Boss
        {
            #region Abstract Overrite Methods
            public override void Boss_Name()
            {
                Console.Write("\t Diablo");
            }
            #endregion

            #region Constructor
            public Diablo()
            {
                Hp = 600;
                Strenght = 300;
                Expirience = 600;
            }
            #endregion
        }

        public class Ball : Boss
        {
            #region Abstract Overrite Methods
            public override void Boss_Name()
            {
                Console.Write("\t Ball");
            }
            #endregion

            #region Constructor
            public Ball()
            {
                Hp = 700;
                Strenght = 350;
                Expirience = 700;
            }
            #endregion
        }
    }
}
