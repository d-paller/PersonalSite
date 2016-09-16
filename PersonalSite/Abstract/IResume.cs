using System.Web.Mvc;

namespace PersonalSite.Abstract
{
    public interface IResume
    {

        FilePathResult GetResume(string fileName, string type, string downloadName);
        
    }
}