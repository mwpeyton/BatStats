using BatStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BatStats.Controllers
{
    public class HomeController : Controller
    {
        private BatStatsDb db = new BatStatsDb();

        [HttpGet]
        public ActionResult Index()
        {
            var model = new PlayerPositionViewModel();

            var positions = db.Positions.Select(x => new SelectListItem()
                                                    {
                                                        Text = x.PositionName,
                                                        Value = x.PositionId.ToString()
                                                    }).ToList();
            model.Positions = positions;

            var players = db.Players.ToList();

            model.Players = players;

            return View(model);
        }

        [HttpGet]
        public ActionResult GetPlayersByPosition(string position)
        {
            var model = new PlayerPositionViewModel();

            if (position == "All")
            {
                var allPlayers = db.Players.ToList();
                model.Players = allPlayers;
            }
            else
            {
                var players = db.Players.Where(x => x.Position == position).ToList();

                model.Players = players;
            }

            return PartialView(model);
        }

        [HttpGet]
        public ActionResult GetStatsByPlayer(string playerName)
        {
            var model = new PlayerPositionViewModel();

            var stats = db.PlayerStats.Where(x => x.PlayerName == playerName).ToList();

            model.PlayerStats = stats;

            return PartialView(model);
        }

        [HttpPost]
        public ActionResult DraftPlayer(string playerName)
        {
            if (playerName != null)
            {  
                var playerInfo = db.Players.FirstOrDefault(x => x.PlayerName == playerName);

                var picks = db.DraftEntries.FirstOrDefault(x => x.PlayerName == playerName);

                if (picks == null)
                {
                    var newPick = new DraftEntry()
                    {
                        Position  = playerInfo.Position,
                        PlayerName = playerName,
                        TeamName = playerInfo.TeamName
                    };

                    db.DraftEntries.Add(newPick);

                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index", "Draft");
        }
    }
}