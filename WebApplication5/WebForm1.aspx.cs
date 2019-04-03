using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;
using Bal;
using ClassLibrary2;
using System.Data;

namespace WebApplication5

{
    public partial class WebForm1 : System.Web.UI.Page
    {
        property p = new property();
        BussinessAL bal = new BussinessAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void inserttxt_Click(object sender, EventArgs e)
        {
            {
                int flag = 0;

                p.addressid = Convert.ToByte(Txtadressid.Text);
                p.Firstname = Textfirstname.Text;
                p.Lastname = Textlastname.Text;
                p.email = Textemail.Text;
                p.phone = Textphone.Text;

                flag = bal.insertaddress(p);
                if (flag == 1)
                {
                    TextBox1.Text = "record inserted";
                }
                else TextBox2.Text = "record already present";

            }

        }

        //protected void deletetxt_Click(object sender, EventArgs e)
        //{
        //    p.id = Convert.ToByte(TextBox1.Text);
        //    int flag = bal.deleteaddress(p);
        //    if (flag == 1)
        //    {
        //        TextBox2.Text = "record deleted";
        //    }
        //    else TextBox2.Text = "record not present";
        //}

        protected void readtxt_Click(object sender, EventArgs e)
        {
            p.addressid = Convert.ToByte(TextBox1.Text);
            DataTable d = bal.readaddress(p);
            Txtadressid.Text = d.ToString();

            foreach (DataRow dr in d.Rows)
            {

                Textfirstname.Text = dr["firstname"].ToString();
                Textlastname.Text = dr["lastname"].ToString();
                Textemail.Text = dr["email"].ToString();
                Textphone.Text = dr["phone"].ToString();


            }
        }

        protected void updatetxt_Click(object sender, EventArgs e)
        {
            p.addressid = Convert.ToByte(Txtadressid.Text);
            bal.updateaddress(p);
        }
    }
}