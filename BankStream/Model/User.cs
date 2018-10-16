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

        }

        #endregion

        #region Methods
        #endregion
    }
}
