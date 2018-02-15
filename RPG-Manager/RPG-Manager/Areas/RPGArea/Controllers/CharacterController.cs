using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RPG_Manager.Areas.RPGArea.Models;

namespace RPG_Manager.Areas.RPGArea.Controllers
{
    [Area("RPGArea")]
    [Route("[area]/[controller]/[action]")]
    public class CharacterController : Controller
    {
        private readonly IRepository Repo;

        public CharacterController(IRepository repo) { Repo = repo; }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Characters")]
        public async Task<IActionResult> Characters()
        {
            return View(await Repo.List_Character());
        }

        public IActionResult CreateCharacter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCharacter(Character c)
        {
            if (ModelState.IsValid)
            {
                Repo.AddCharacter(c);
                return RedirectToAction("Characters", "Character", new { area = "RPGArea" });
            }
            
            return View(c);
        }

        public async Task<IActionResult> EditCharacter(int ID)
        {
            return View(await Repo.GetCharacter(ID));
        }

        [HttpPost]
        public IActionResult EditStudent(Character c)
        {
            if (ModelState.IsValid)
            {
                Repo.EditCharacter(c);
                return RedirectToAction("Characters", "Character", new { area = "RPGArea" });
            }

            return View(c);
        }

        public async Task<IActionResult> DetailCharacter(int ID)
        {
            return View(await Repo.GetCharacter(ID));
        }
        
        public IActionResult DeleteCharacter(int ID)
        {
            if (ModelState.IsValid)
            {
                Repo.DeleteCharacter(ID);
                return RedirectToAction("Characters", "Character", new { area = "RPGArea" });
            }

            return View();
        }
    }
}