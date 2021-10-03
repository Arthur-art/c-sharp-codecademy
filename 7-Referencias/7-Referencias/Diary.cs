using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Referencias
{
    class Diary : Book, IFlippable
    {
        public Diary(int page) : base()
        {
            CurrentPage = page;
        }

        public int CurrentPage { get; set; }

        public void Flip()
        {
            CurrentPage++;
        }

        public string SpillSecret()
        {
            return "OMG kerry loves kris <3";
        }

        public override string Stringfy()
        {
            return "This is a Diary object!";
        }
    }
}
