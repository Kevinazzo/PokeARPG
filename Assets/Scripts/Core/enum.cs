using System.Collections;
using System.Collections.Generic;

namespace Game.Core
{
	public enum MajorAilment
	{
		Poison,
		Paralisis,
		Sleep,
		Burn,
		Freeze,
		Bleeding,
	}
	public enum BattleAilment
	{
		Confusion,
		Infatuation,
		Trapped,
		Flinched,
		Silence,
		Taunted,
		Planted,
		Levitate,
		Protection,
		Invulnerable
	}
	public enum Element
	{
		Normal = 0,
		Fight,
		Flying,
		Poison,
		Ground,
		Rock,
		Bug,
		Ghost,
		Steel,
		Fire,
		Water,
		Grass,
		Electric,
		Psychic,
		Ice,
		Dragon,
		Dark,
		Fairy
	}

	public enum SkillKeyword
	{
		AreaOfEffect,
		Self,
		Aimed,
		Channeling,
		Duration,
		Buff,
		Debuff,
		Aura,
		Chaining,
		Physical,
		Special,
		Status,
		Contact,
		Support,
		Restoration,
		Healing,
		Charging,
		Screen,
		Shield,
		Climate,
		Terrain,
		Resistance,
		Projectile,
		Movement,
		Trigger
	}
}