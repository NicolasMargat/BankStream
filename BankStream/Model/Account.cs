using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStream.Model
{
    class Account
    {
        #region Fields

        public String Name { get; set;}
        public String Bank { get; set; }
        public IList<Card> CarsList { get; set; }
        public IList<Operation> OperationsList { get; set; }

        #endregion

        #region Constructors

        public Account()
        {

        }

        #endregion

        #region Methods
        #endregion
    }
}
