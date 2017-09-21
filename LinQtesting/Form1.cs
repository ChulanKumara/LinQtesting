using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQtesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            // Create a datacontext
            LinQERDataContext con = new LinQERDataContext();

            // Select all statement
            //var LinQ = from d in con.dbo_MemberDetails select d;

            // Select certain columns
            //var LinQ = from d in con.dbo_MemberDetails select new {d.NAME, d.AGE, d.GENDER };

            // Where Clause
            //var LinQ = from d in con.dbo_MemberDetails where d.ID == 2 select d;

            // Where Clause with 2 arguments AND operator
            //var LinQ = from d in con.dbo_MemberDetails where d.ID == 2 && d.CITY == "NewJersey" select d;

            // Where Clause with 2 arguments OR operator
            //var LinQ = from d in con.dbo_MemberDetails where d.ID == 2 || d.CITY == "NewJersey" select d;

            // Order By Clause
            //var LinQ = from d in con.dbo_MemberDetails orderby d.NAME select d;

            // Order By Clause Descending
            //var LinQ = from d in con.dbo_MemberDetails orderby d.NAME descending select d;

            // Order By Clause with 2 variables
            //var LinQ = from d in con.dbo_MemberDetails orderby d.NAME, d.AGE select d;

            // Top result query
            //var LinQ = (from d in con.dbo_MemberDetails select d).Take(3);

            // Top result query for the first result
            //var LinQ = (from d in con.dbo_MemberDetails select d).Take(1);
            // OR
            //var LinQ = (from d in con.dbo_MemberDetails select d).First();

            // Distinct query
            //var LinQ = (from d in con.dbo_MemberDetails select new {d.POSTALCODE}).Distinct();
            //var LinQ = (from d in con.dbo_MemberDetails select d).Distinct();

            // Group by query
            //var LinQ = from d in con.dbo_MemberDetails group d by d.ID into e select new {ID = e.Key};
            // OR
            //var LinQ = from p in con.dbo_MemberDetails
            //           group p by p.GENDER into g
            //           select new
            //           {                                                
            //               GENDER = g.Select(h => h.GENDER).FirstOrDefault(),
            //               NAME = g.Select(h => h.NAME).FirstOrDefault()
            //           };

            // Union query
            var LinQ = (from d in con.dbo_MemberDetails where d.NAME == "John" select d).Union(
                from h in con.dbo_MemberDetails where h.NAME == "Mike" select h);

            // Display data onto datagrid
            dataGridView_Result.DataSource = LinQ;
        }
    }
}
