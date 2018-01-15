using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Game.Core
{
	public class Pokemon
	{
		#region baseStats
		private int b_HP { get; set; }      // base pokemon health value
		private int b_atk { get; set; }     // base physical attack value for a pokemon 
		private int b_def { get; set; }     // base resistance to physical based Attacks
		private int b_spA { get; set; }     // base special attack value for a pokemon "Spell"
		private int b_spD { get; set; }     // base resistance to special Attacks || "spells"
		private int b_spe { get; set; }     // Speed is now Evaluated as "movement speed" can be increased or decreased

		#endregion
		#region effortValues
		// in case we use Effort values as core game series
		//private int ev_HP { get; set; }
		//private int ev_atk { get; set; }
		//private int ev_def { get; set; }
		//private int ev_spA { get; set; }
		//private int ev_spD { get; set; }
		//private int ev_spe { get; set; }

		#endregion
		#region totalStats
		public int HP { get; set; }
		public int atk { get; set; }
		public int def { get; set; }
		public int spA { get; set; }
		public int spD { get; set; }
		public int spe { get; set; }
		#endregion
		#region currentStats
		public int curHP { get; set; }
		public int curAtk { get; set; }
		public int curDef { get; set; }
		public int curSpA { get; set; }
		public int curSpD { get; set; }
		public int curSpe { get; set; }


		#endregion

		public float weight { get; set; }
		public List<Skill> skills { get; set; }

		#region threading

		#endregion
	}
}