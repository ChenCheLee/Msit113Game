using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameMVC.Models;

namespace GameMVC.ViewModel
{
    public class GameCardViewModel
    {
        public IEnumerable<tGame> game { get; set; }
        public tGameFile gameFile { get; set; }
    }
}