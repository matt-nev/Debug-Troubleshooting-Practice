using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExceptionsInAspNet
{
  public partial class _Default : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      var books = new List<string>();
      books.Add("HLSL and Pixel Shaders for XAML Developers");

      string bookName = books[5]; // try to access an non-existent item
    }
  }
}