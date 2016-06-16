using F_CodeFavorites.DB;
using F_CodeFavorites.DB.DataSetCodeFavoritesTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace F_CodeFavorites
{
    public partial class Index : System.Web.UI.Page
    {
        const string sessionDsName = "Index_DataSetCodeFavorites";
        DataSetCodeFavorites DataSetCodeFavoritesDS
        {
            set
            {
                Session[sessionDsName] = value;
            }
            get
            {
                DataSetCodeFavorites dscf;
                if (Session[sessionDsName] == null)
                {
                    Session[sessionDsName] = new DataSetCodeFavorites();
                }
                dscf = (DataSetCodeFavorites)Session[sessionDsName];
                return dscf;
            }
        }
        void SelectData()
        {
            using (CodeFavoritesTableAdapter cfa = new CodeFavoritesTableAdapter())
            {                
                cfa.Fill(this.DataSetCodeFavoritesDS.CodeFavorites);
                BindData();
            }
        }
        void BindData()
        {
            this.GridView1.DataSource = DataSetCodeFavoritesDS;
            this.GridView1.DataMember = DataSetCodeFavoritesDS.CodeFavorites.TableName;
            this.GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                SelectData();
            }
        }
    }
}