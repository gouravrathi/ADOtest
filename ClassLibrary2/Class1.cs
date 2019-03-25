using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using ClassLibrary2;

namespace Bal
{
    public class BussinessAL
    {
        DAL d = new DAL();
        property p = new property();

        public int insertaddress(property t)
        {
            return (d.insertaddress(t.addressid, t.Firstname, t.Lastname,t.email,t.phone));
        }
       
        public DataTable readaddress(property p)
        {
            return (d.readaddress(p.addressid));
        }
        public int updateaddress(property p)
        {
            return (d.updateaddress(p.addressid, p.Firstname,p.lastname,p.email,p.phone));
        }
    }
}
