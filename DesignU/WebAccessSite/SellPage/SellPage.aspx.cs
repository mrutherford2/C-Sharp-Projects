﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAccessSite.SellPage
{
    public partial class SellPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Server.Transfer("~/Account/MyStorefront.aspx");
        }
    }
}