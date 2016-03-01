using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ASPNETGruppArbete.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNETGruppArbete.Controllers
{
    public class AlbumsController : Controller
    {
        // GET: /<controller>/action/ID
        //[HttpGet("{id:int}")]
        public IActionResult Index(int id)
        {
            DataManager dataManager = new DataManager();
            var albums = dataManager.GetBandAlbums(id);
            return View(albums);
        }
        public IActionResult Details(int id)
        {
            DataManager dataManager = new DataManager();
            var details = dataManager.GetAlbumDetails(id);
            return View(details);
        }

    }
}
