using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using mysite.Data.FileManager;
using mysite.Data.Repository;
using mysite.Models;
using mysite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysite.Controllers
{
    [Authorize(Roles ="Admin")]
    public class PanelController : Controller
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public PanelController(IRepository repo, IFileManager fileManager)
        {
            _repo = repo;
            _fileManager = fileManager;
        }

        public IActionResult FrontPage() 
        {
            return View();
        }

    }
}
