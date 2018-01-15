using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Core
{
	public abstract class Skill
	{
		// [0]=min Damage, [1]=max Damage in a rol
		private int id { get; set; }
		public long experience { get; set; }
		public string skillName { get; set; }

		public string description { get; set; }
		public char keyBind { get; set; }
		protected List<SkillKeyword> keywords { get; set; }
	}
}