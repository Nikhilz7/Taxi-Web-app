﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taxi.Driver
{
	public partial class WebForm4 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		protected void LinkButton1_Click1(object sender, EventArgs e)
		{
			Session["d_email"] = "";
			Response.Redirect("login.aspx");
		}

	}
}