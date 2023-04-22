using MMZeroElements.Config;
using MMZeroElements.Elements;
using MMZeroElements.SetElements.NPCs;
using MMZeroElements.SetElements.Projectiles;
using MMZeroElements.SetElements.Weapons;
using MMZeroElements.Utilities;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace MMZeroElements
{
    public class Paths
    {
        public const string FireElement = "Mods.MMZeroElements.Element.Fire";
        public const string AquaElement = "Mods.MMZeroElements.Element.Aqua";
        public const string IceElement = "Mods.MMZeroElements.Element.Ice";
        public const string ElectricElement = "Mods.MMZeroElements.Element.Electric";
        public const string WoodElement = "Mods.MMZeroElements.Element.Wood";
    }

    public static class Element
    {
        public const int Null = -1;
        public const int Fire = 0;
        public const int IceAqua = 1; // /Aqua
        public const int Elec = 2;
        public const int Wood = 3;
    }

    public class MMZeroElements : Mod
    {
        public static ElementsClient Client;
        public static ElementsServer Server;

        public override void Load()
        {
            Client = ModContent.GetInstance<ElementsClient>();
            Server = ModContent.GetInstance<ElementsServer>();
        }

        public override void PostSetupContent()
        {
            if (Server.legacySystem)
            {
                WeaponElements.Fire.AddRange(WoodWeapons.poison);
                ProjectileElements.Fire.AddRange(WoodProjectiles.poison);
                NPCElements.Fire.AddRange(WoodNPCs.poison);

                WeaponElements.Wood.Clear();
                ProjectileElements.Wood.Clear();
                NPCElements.Wood.Clear();
            }
        }

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
                                        elementItem.AddFireDefault();
                                        break;
                                    case Element.IceAqua:
                                        elementItem.AddIceDefault();
                                        break;
                                    case Element.Elec:
                                        elementItem.AddElecDefault();
                                        break;
                                }
                            }
                            else throw new ArgumentException("args[2] must be an int of either 0, 1, or 2.");
                        }
                        else if (args[1] is NPC elementNPC)
                        {
                            if (args[3] is int element)
                            {
                                switch (element)
                                {
                                    case Element.Fire:
                                        elementNPC.AddFire();
                                        break;
                                    case Element.IceAqua:
                                        elementNPC.AddIce();
                                        break;
                                    case Element.Elec:
                                        elementNPC.AddElec();
                                        break;
                                }
                            }
                            else if (args[2] is float[] elements)
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
                                        elementProjectile.AddFire();
                                        break;
                                    case Element.IceAqua:
                                        elementProjectile.AddElec();
                                        break;
                                    case Element.Elec:
                                        elementProjectile.AddElec();
                                        break;
                                }
                            }
                            else throw new ArgumentException("args[2] must be an int of either 0, 1, or 2.");
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
                                    case Element.IceAqua:
                                        elementList = WeaponElements.Ice;
                                        break;
                                    case Element.Elec:
                                        elementList = WeaponElements.Electric;
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
                                    case Element.IceAqua:
                                        elementList = NPCElements.IceAqua;
                                        break;
                                    case Element.Elec:
                                        elementList = WeaponElements.Electric;
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
                                    case Element.IceAqua:
                                        elementList = ProjectileElements.IceAqua;
                                        break;
                                    case Element.Elec:
                                        elementList = ProjectileElements.Elec;
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
