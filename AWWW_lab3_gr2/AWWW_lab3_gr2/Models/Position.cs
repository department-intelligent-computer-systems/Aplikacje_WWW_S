﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWWW_lab3_gr2.Models
{
	public class Position
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public virtual ICollection<Player>? Players { get; set; }

		public virtual ICollection<MatchPlayer>? MatchPlayers { get; set; }
	}
}