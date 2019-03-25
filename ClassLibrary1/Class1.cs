using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dal

{
    public class DAL
    {
        SqlConnection con;
        DataSet ds;
        SqlDataAdapter ada;


        public SqlConnection getconnection()
        {
            return (new SqlConnection(@"data source=LAPTOP-RPOKN7UD;initial catalog= addressbook; integrated security=true;"));
        }
        public DataSet sqlset()
        {
            return (new DataSet());

        }
        public SqlDataAdapter sqlada()
        {
            return (new SqlDataAdapter("select * from address", con));

        }
        void FillData()
        {
            con = getconnection();
            ds = sqlset();
            ada = sqlada();
            ada.Fill(ds);
        }
        public int insertaddress( string Firstname, string Lastname,String email,string phone)
        {
            FillData();
            SqlCommandBuilder cb = new SqlCommandBuilder(ada);

            foreach (DataRow d in ds.Tables[0].Rows)
            {
                if (addressid == d["addressid"].ToString())
                {
                    return 0;
                }

            }
            DataRow dr = ds.Tables[0].NewRow();
            dr["Firstname"] = Firstname;
            dr["Lastname"] = Lastname;
            dr["email"] = email;
            ds.Tables[0].Rows.Add(dr);
            ada.Update(ds);
            return 1;

        }

        public int updateaddress(int addressid, string Firstname, String Lastname, String email, String phone)
        {
            FillData();
            SqlCommandBuilder cb = new SqlCommandBuilder(ada);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (Convert.ToByte(dr["addressid"]) == addressid)
                {
                    dr["Firstname"] = Firstname;
                    dr["Lastname"] = Lastname;
                    dr["email"] = email;
                    dr["phone"] = phone;
                    ada.Update(ds);
                    return 1;
                }
            }
            return 0;
        }

        public DataTable readaddress(int addressid)
        {
            FillData();
            DataTable d = ds.Tables[0].Clone();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (Convert.ToByte(dr["addressid"]) == addressid)
                {
                    d.ImportRow(dr);
                }
            }
            return d;
        }
    }
}

