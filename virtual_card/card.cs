using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Card
    {
        private string fullName;
        private string validationDate;
        private long cardNumber;
        private int cvv;
        private uint moneyAmount;

        public Card(string fullName)
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

        public string ValidationDate
        {
            set
            {
                this.validationDate = value;
            }
            get
            {
                return this.validationDate;
            }
        }

        public int Cvv
        {
            set
            {
                this.cvv = value;
            }
        }

        public uint MoneyAmount
        {
            set
            {
                this.moneyAmount = value;
            }
            get
            {
                return this.moneyAmount;
            }
        }
        
    }
    
}
