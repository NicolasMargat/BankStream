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
            this.Name = null;
            this.AccountsList = null;
        }

        public User(String pName)
        {
            this.Name = pName;
        }

        public User(String pName, IList<Account> pAccountsList)
        {
            this.Name = pName;
            this.AccountsList = pAccountsList;
        }

        #endregion

        #region Methods
        #endregion
    }
}
