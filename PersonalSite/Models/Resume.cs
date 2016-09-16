using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalSite.Abstract;

namespace PersonalSite.Models
{
    public class DownloadResume
    {
        public string fileName { get; set; }
        public string typeOfFile { get; set; }
        public string fileDownloadName { get; set; }
    }
}