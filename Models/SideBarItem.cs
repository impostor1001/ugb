using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace Ugb.Models
{
    public class SideBarItem
    {
        public string icon;
        public string texto;
        public string urlLink;

        public SideBarItem(string iconString,string textoString, string urlLinkString)
        {
            this.icon = iconString;
            this.texto = textoString;
            this.urlLink = urlLinkString;
        }
    }
}