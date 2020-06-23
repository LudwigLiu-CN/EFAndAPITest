using System;
using System.Collections.Generic;

namespace EFAndAPITest.Models
{
    public partial class RateGame
    {
        public int GameId { get; set; }
        public int UserId { get; set; }
        public int? Rate { get; set; }

        public virtual Games Game { get; set; }
        public virtual Users User { get; set; }
    }
}
