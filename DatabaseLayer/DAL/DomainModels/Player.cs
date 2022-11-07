using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Models;

namespace DatabaseLayer.DAL.DomainModels
{
	public class Player
	{
		public int PlayerId { get; set; }
		public string Name { get; set; }

		public string Email { get; set; }

		public List<Hand> Hands { get; set; }


	}
}
