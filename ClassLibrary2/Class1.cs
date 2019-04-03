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

        public int insertaddress(property p)
        {
            return (d.insertaddress( p.addressid,p.Firstname, p.Lastname,p.email,p.phone));
        }
       
        public DataTable readaddress(property p)
        {
            return (d.readaddress(p.addressid));
        }
        public int updateaddress(property p)
        {
            return (d.updateaddress(p.addressid, p.Firstname,p.Lastname,p.email,p.phone));
        }
    }
}
