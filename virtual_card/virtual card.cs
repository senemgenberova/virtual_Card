using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cards;

namespace Virtual
{
    class Virtual_card
    {
        private string fullName;

        public Virtual_card(string fullName)
        {
            this.fullName = fullName;
        }
        public string FullName
        {
            set
            {
                this.fullName = value;
            }
            get
            {
                return this.fullName;
            }
        }
    }
}
