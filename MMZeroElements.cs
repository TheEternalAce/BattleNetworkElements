using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace MMZeroElements
{
	public class Paths
	{
		public const string FireElement = "Mods.MMZeroElements.Element.Fire";
		public const string IceElement = "Mods.MMZeroElements.Element.Ice";
		public const string ElectricElement = "Mods.MMZeroElements.Element.Electric";
		public const string MetalElement = "Mods.MMZeroElements.Element.Metal";
	}

	public class MMZeroElements : Mod
	{
		const string COMMAND_ASSIGN_ELEMENT = "assignElement";
		const string COMMAND_GET_ELEMENT = "getElement";

		public override object Call(params object[] args)
		{
			if (args is null)
			{
				throw new ArgumentNullException(nameof(args), "Arguments cannot be null!");
			}

			if (args.Length == 0)
			{
				throw new ArgumentException("Arguments cannot be empty!");
			}

			if (args[0] is string command)
			{
				switch (command)
				{
					default:
						throw new ArgumentException("Unrecognized ModCall. Usable ModCalls for Elements of Terraria are as follows: " +
							$"{COMMAND_ASSIGN_ELEMENT} and {COMMAND_GET_ELEMENT}.");
					case COMMAND_ASSIGN_ELEMENT:
						if (args[1] is Item elementItem)
						{
							if (args[2] is int element)
							{
								switch (element)
								{
									case Element.Fire:
										WeaponElements.Fire.Add(elementItem.type);
										break;
									case Element.Ice:
										WeaponElements.Ice.Add(elementItem.type);
										break;
									case Element.Electric:
										WeaponElements.Electric.Add(elementItem.type);
										break;
									case Element.Metal:
										WeaponElements.Metal.Add(elementItem.type);
										break;
								}
							}
							else throw new ArgumentException("args[2] must be an int of either 0, 1, 2, or 3.");
						}
						else if (args[1] is NPC elementNPC)
						{
							if (args[2] is double[] elements)
							{
								elementNPC.GetGlobalNPC<NPCElements>().elementMultipliers = elements;
							}
							else throw new ArgumentException("args[2] must be a double array of length 4.");
						}
						else if (args[1] is Projectile elementProjectile)
						{
							if (args[2] is int element)
							{
								switch (element)
								{
									case Element.Fire:
										ProjectileElements.Fire.Add(elementProjectile.type);
										break;
									case Element.Ice:
										ProjectileElements.Ice.Add(elementProjectile.type);
										break;
									case Element.Electric:
										ProjectileElements.Electric.Add(elementProjectile.type);
										break;
									case Element.Metal:
										ProjectileElements.Metal.Add(elementProjectile.type);
										break;
								}
							}
							else throw new ArgumentException("args[2] must be an int of either 0, 1, 2, or 3.");
						}
						break;
					case COMMAND_GET_ELEMENT:
						if (args[1] is int elementID)
						{
							List<int> elementList = new List<int>();
							if (args[2] is Item itemElement)
							{
								switch (elementID)
								{
									case Element.Fire:
										elementList = WeaponElements.Fire;
										break;
									case Element.Ice:
										elementList = WeaponElements.Ice;
										break;
									case Element.Electric:
										elementList = WeaponElements.Electric;
										break;
									case Element.Metal:
										elementList = WeaponElements.Metal;
										break;
								}
								return elementList.Contains(itemElement.type);
							}
							else if (args[2] is NPC elementNPC)
							{
								switch (elementID)
								{
									case Element.Fire:
										elementList = NPCElements.Fire;
										break;
									case Element.Ice:
										elementList = NPCElements.Ice;
										break;
									case Element.Electric:
										elementList = WeaponElements.Electric;
										break;
									case Element.Metal:
										elementList = WeaponElements.Metal;
										break;
								}
								return elementList.Contains(elementNPC.type);
							}
							else if (args[2] is Projectile elementProjectile)
							{
								switch (elementID)
								{
									case Element.Fire:
										elementList = ProjectileElements.Fire;
										break;
									case Element.Ice:
										elementList = ProjectileElements.Ice;
										break;
									case Element.Electric:
										elementList = ProjectileElements.Electric;
										break;
									case Element.Metal:
										elementList = ProjectileElements.Metal;
										break;
								}
								return elementList.Contains(elementProjectile.type);
							}
						}
						break;
				}
			}
			return base.Call(args);
		}
	}
}