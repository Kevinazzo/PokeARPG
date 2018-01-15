using System.Collections;
using System.Collections.Generic;
using Vector2lib;

namespace Game.Core
{
	public interface ISkillAreaOfEffect
	{
		int origin { get; set; }
		//int baseRadius { get; set; }
		int aoeModifier { get; set; }
		float[] areaOfEffect { get; set; }
		float[] computeAOE();
	}

	public interface ISkillAimedTarget
	{
		int range { get; set; }
		Vector2 objective { get; set; }
	}

	public interface ISkillDuration
	{
		int msDuration { get; set; }
	}

	public interface ISkillChanneling
	{
		void onStartChanneling();
		void onChanneling();
		void onReleaseChanneling();
	}

	public interface ISkillMovement
	{
		Vector2 origin { get; set; }
		Vector2 end { get; set; }
	}

	public interface ISkillPhysical
	{
		int[] baseDamage{get;set;}
		void onhit();
	}

	public interface ISkillSpecial
	{
		int[] baseDamage{get;set;}
		void onHit();
	}
	
	public interface ISkillChaining
	{
		int chainDistance {get;set;}
		int maxTargets {get;set;}
	}
	public interface ISkillProjectile
	{
		int quantity{get;set;}
		float projectileWidth{get;set;}
		float projectileSpeed{get;set;}
		float projectileLifeTime{get;set;} // ms
		void onHit();
	}
}