using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;

namespace EntrySystem.DataLayer
{

    public abstract class Base
    {
        string strConnectionstring = ConfigurationManager.ConnectionStrings["conApplication"].ConnectionString;
        public string ConnectionString
        {
            get
            {
                return strConnectionstring;
            }
        }
    }

}
