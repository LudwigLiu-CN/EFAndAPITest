using System;
using System.Collections.Generic;

namespace EFAndAPITest.Models
{
    public partial class PlayedOn
    {
        public int GameId { get; set; }
        public int ConsoleId { get; set; }

        public virtual Consoles Console { get; set; }
        public virtual Games Game { get; set; }
    }
}
