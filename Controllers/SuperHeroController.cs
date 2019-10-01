using SuperHeroes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Documents;

namespace SuperHeroes.Controllers
{
    public class SuperHeroController : Controller
    {
        private ApplicationDbContext dbContext;
        public SuperHeroController()
        {
            dbContext = new ApplicationDbContext();
        }
        //database goes here
        // GET: SuperHero
        public ActionResult Index()
        {
            List<SuperHero> allSuperHeroes = dbContext.SuperHeroes.ToList();
            return View(allSuperHeroes); //allstudents
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int id)
        {
            var superhero = new SuperHero();
            superhero.Id = id;
            superhero = dbContext.SuperHeroes.Where(s => s.Id == id).SingleOrDefault();
            return View(superhero);
        }

        // GET: SuperHero/Create
        public ActionResult Create() //students
        {
            SuperHero superHero = new SuperHero();
            return View(superHero);
        }

        // POST: SuperHero/Create
        [HttpPost]
        public ActionResult Create(SuperHero superhero)
        {
            SuperHero newSuperHero = new SuperHero();
            newSuperHero.AlterEgoFirstName = superhero.AlterEgoFirstName;
            newSuperHero.AlterEgoLastName = superhero.AlterEgoLastName;
            newSuperHero.SuperHeroName = superhero.SuperHeroName;
            newSuperHero.PrimaryAbility = superhero.PrimaryAbility;
            newSuperHero.SecondaryAbility = superhero.SecondaryAbility;
            newSuperHero.CatchPhrase = superhero.CatchPhrase;
            superhero = newSuperHero;
            dbContext.SuperHeroes.Add(superhero);

            try
            {
               

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHero superHeroFromDb = new SuperHero();
            superHeroFromDb.Id = id;
            superHeroFromDb = dbContext.SuperHeroes.Where(m => m.Id == superHeroFromDb.Id).SingleOrDefault();
            return View(superHeroFromDb);
        }

   
        /// view is between GET and POST
       
        // POST: SuperHero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SuperHero superhero)
        {
            

            try
            {
                SuperHero EditSuperHero = new SuperHero();
                EditSuperHero.Id = id;
                EditSuperHero.AlterEgoFirstName = superhero.AlterEgoFirstName;
                EditSuperHero.AlterEgoLastName = superhero.AlterEgoLastName;
                EditSuperHero.SuperHeroName = superhero.SuperHeroName;
                EditSuperHero.PrimaryAbility = superhero.PrimaryAbility;
                EditSuperHero.SecondaryAbility = superhero.SecondaryAbility;
                EditSuperHero.CatchPhrase = superhero.CatchPhrase;
                superhero = EditSuperHero;
                superhero = dbContext.SuperHeroes.Where(s => s.Id == EditSuperHero.Id).SingleOrDefault();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int id)
        {
           // Super
            return View();
        }

        // POST: SuperHero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
