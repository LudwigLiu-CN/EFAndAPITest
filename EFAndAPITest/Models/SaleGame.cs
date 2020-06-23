using System;
using System.Collections.Generic;

namespace EFAndAPITest.Models
{
    public partial class SaleGame
    {
        public int PublisherId { get; set; }
        public int GameId { get; set; }

        public virtual Games Game { get; set; }
        public virtual Publishers Publisher { get; set; }
    }
}
