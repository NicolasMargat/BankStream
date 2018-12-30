using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStream.Model
{
    class User
    {
        #region Fields

        public String Name { get; set; }
        public IList<Account> AccountsList { get; set; }

        #endregion

        #region Constructors

        public User()
        {
            Name = null;
            AccountsList = null;
        }

        public User(String pName)
        {
            Name = pName;
        }

        public User(String pName, IList<Account> pAccountsList)
        {
            Name = pName;
            AccountsList = pAccountsList;
        }

        #endregion

        #region Methods
        #endregion
    }
}
