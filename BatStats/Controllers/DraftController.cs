using BatStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BatStats.Controllers
{
    public class DraftController : Controller
    {
        private BatStatsDb db = new BatStatsDb();

        // GET: Draft
        public ActionResult Index()
        {
            var model = new PlayerPositionViewModel();

            var picks = db.DraftEntries.ToList();

            if (picks == null)
            {
                return RedirectToAction("Index", "Home");
            }
           
            model.Picks = picks;

            return View(model);
        }

        public ActionResult DeleteDraftEntry(string playerName)
        {
            var pickToDelete = db.DraftEntries.Where(x => x.PlayerName == playerName).FirstOrDefault();

            db.DraftEntries.Remove(pickToDelete);

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}