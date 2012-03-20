using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Javascript.Controllers
{
    public class TagEditorController : Controller
    {
        private readonly string[] _allTags = new[]
                                                 {
                                                     "Ada",
                                                     "Basic",
                                                     "C",
                                                     "C++",
                                                     "C#",
                                                     "D",
                                                     "Delphi",
                                                     "Effiel",
                                                     "Effiel.Net",
                                                     "F#",
                                                     "Go",
                                                     "Haskell",
                                                     "Java",
                                                     "Javascript",
                                                     "Lua",
                                                     "Lisp",
                                                     "Python",
                                                     "PHP",
                                                     "Pascal",
                                                     "Ruby",
                                                     "Smalltalk",
                                                     "Scala",
                                                     "Visual Basic",
                                                     "Visual FoxPro",
                                                 };

        [HttpPost]
        public ActionResult Tags(string start)
        {
            var tags = _allTags.Where(x => x.StartsWith(start, StringComparison.OrdinalIgnoreCase))
                .ToList();
            return Json(tags);
        }
    }
}
