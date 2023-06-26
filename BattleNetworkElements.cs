using BattleNetworkElements.Config;
using BattleNetworkElements.Elements;
using BattleNetworkElements.Utilities;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace BattleNetworkElements
{
    public class Paths
    {
        public const string FireElement = "Mods.BattleNetworkElements.Element.Fire";
        public const string AquaElement = "Mods.BattleNetworkElements.Element.Aqua";
        public const string ElectricElement = "Mods.BattleNetworkElements.Element.Electric";
        public const string WoodElement = "Mods.BattleNetworkElements.Element.Wood";
    }

    public static class Element
    {
        public const int Null = -1;
        public const int Fire = 0;
        public const int Aqua = 1;
        public const int Elec = 2;
        public const int Wood = 3;
    }

    public class BattleNetworkElements : Mod
    {
        public static ElementsClient Client;

        public override void Load()
        {
            Client = ModContent.GetInstance<ElementsClient>();
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
                                        elementItem.AddFire();
                                        break;
                                    case Element.Aqua:
                                        elementItem.AddAqua();
                                        break;
                                    case Element.Elec:
                                        elementItem.AddElec();
                                        break;
                                    case Element.Wood:
                                        elementItem.AddWood();
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
                                    case Element.Aqua:
                                        elementNPC.AddAqua();
                                        break;
                                    case Element.Elec:
                                        elementNPC.AddElec();
                                        break;
                                    case Element.Wood:
                                        elementNPC.AddWood();
                                        break;
                                }
                            }
                            else if (args[2] is float[] elements)
                            {
                                elementNPC.GetGlobalNPC<BNGlobalNPC>().elementMultipliers = elements;
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
                                    case Element.Aqua:
                                        elementProjectile.AddAqua();
                                        break;
                                    case Element.Elec:
                                        elementProjectile.AddElec();
                                        break;
                                    case Element.Wood:
                                        elementProjectile.AddWood();
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
                                        elementList = BNGlobalItem.Fire;
                                        break;
                                    case Element.Aqua:
                                        elementList = BNGlobalItem.Aqua;
                                        break;
                                    case Element.Elec:
                                        elementList = BNGlobalItem.Electric;
                                        break;
                                    case Element.Wood:
                                        elementList = BNGlobalItem.Wood;
                                        break;
                                }
                                return elementList.Contains(itemElement.type);
                            }
                            else if (args[2] is NPC elementNPC)
                            {
                                switch (elementID)
                                {
                                    case Element.Fire:
                                        elementList = BNGlobalNPC.Fire;
                                        break;
                                    case Element.Aqua:
                                        elementList = BNGlobalNPC.Aqua;
                                        break;
                                    case Element.Elec:
                                        elementList = BNGlobalItem.Electric;
                                        break;
                                    case Element.Wood:
                                        elementList = BNGlobalItem.Wood;
                                        break;
                                }
                                return elementList.Contains(elementNPC.type);
                            }
                            else if (args[2] is Projectile elementProjectile)
                            {
                                switch (elementID)
                                {
                                    case Element.Fire:
                                        elementList = BNGlobalProjectile.Fire;
                                        break;
                                    case Element.Aqua:
                                        elementList = BNGlobalProjectile.Aqua;
                                        break;
                                    case Element.Elec:
                                        elementList = BNGlobalProjectile.Elec;
                                        break;
                                    case Element.Wood:
                                        elementList = BNGlobalProjectile.Wood;
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
