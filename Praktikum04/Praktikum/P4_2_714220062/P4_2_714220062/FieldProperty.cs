using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220062
{
    public class FieldProperty
    {
        public class ToyStory
        {

            private string mainCharacter;
            private int releaseTahun;

            public string MainCharacter
            {
                get
                {
                    return mainCharacter;
                }
                set
                {
                    mainCharacter = value;
                }
            }

            public int ReleaseYear
            {
                get
                {
                    return releaseTahun;
                }
                set
                {
                    releaseTahun = value;
                }
            }
        }


    }

}
   
