﻿using Roster_Builder.Genestealer_Cults;
using Roster_Builder.Space_Marines;
using Roster_Builder.Space_Marines.Ultramarines;
using Roster_Builder.Space_Marines.Salamanders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Roster_Builder.Space_Marines
{
    public class SpaceMarines : Faction
    {
        public SpaceMarines()
        {
            subFactionName = "<Chapter>";
            currentSubFaction = string.Empty;
            factionUpgradeName = "Masters of the Chapter";
            StratagemList.AddRange(new string[]
            {
                "Stratagem: Hero of the Chapter",
                "Stratagem: Relic of the Chapter"
            });
        }

        public override List<string> GetCustomSubfactionList1()
        {
            return new List<string>()
            {
                "Bolter Fusillades",
                "Born Heroes",
                "Duellists",
                "Fearsome Aspect",
                "Hungry for Battle",
                "Indomitable",
                "Knowledge is Power",
                "Long-range Marksmen",
                "Master Artisans",
                "Preferred Enemy",
                "Rapid Assault",
                "Scions of the Forge",
                "Stalwart",
                "Stealthy",
                "Stoic",
                "Tactical Withdrawal",
                "Warded",
                "Whirlwind of Rage"
            };
        }

        public override List<string> GetCustomSubfactionList2()
        {
            return new List<string>()
            {
                "Bolter Fusillades",
                "Born Heroes",
                "Duellists",
                "Fearsome Aspect",
                "Hungry for Battle",
                "Indomitable",
                "Knowledge is Power",
                "Long-range Marksmen",
                "Master Artisans",
                "Preferred Enemy",
                "Rapid Assault",
                "Scions of the Forge",
                "Stalwart",
                "Stealthy",
                "Stoic",
                "Tactical Withdrawal",
                "Warded",
                "Whirlwind of Rage"
            };
        }

        public override List<Datasheets> GetDatasheets()
        {
            var datasheets = new List<Datasheets>()
            {
                //---------- HQ ----------
                new PrimarisCaptain(),
                new GravisHeavyCaptain(),
                new PhobosCaptain(),
                new GravisCaptain(),
                new TerminatorCaptain(),
                new Captain(),
                new BikeCaptain(),
                new PrimarisLieutenant(),
                new ReiverLieutenant(),
                new Lieutenant(),
                new PhobosLieutenant(),
                new PrimarisLibrarian(),
                new Librarian(),
                new PhobosLibrarian(),
                new TerminatorLibrarian(),
                new PrimarisChaplain(),
                new PrimarisBikeChaplain(),
                new TerminatorChaplain(),
                new Chaplain(),
                new PrimarisTechmarine(),
                new Servitors(),
                new Techmarine(),   //[21]
                //---------- Troops ----------
                new Intercessors(),
                new AssaultIntercessors(),
                new HeavyIntercessors(),
                new Infiltrators(),
                new Incursors(),
                new TacticalSquad(),
                //---------- Elites ----------
                new CompanyChampion(),
                new ScoutSquad(),
                new PrimarisApothecary(),
                new Apothecary(),
                new CompanyAncient(),
                new PrimarisAncient(),
                new BladeguardAncient(),
                new TerminatorAncient(),
                new VeteranIntercessors(),
                new BladeguardVeterans(),
                new Veterans(),
                new VanguardVeterans(),
                new SternguardVeterans(),
                new Judiciar(),
                new Reivers(),
                new Aggressors(),
                new AssaultTerminators(),
                new Terminators(),
                new RelicTerminators(),
                new CenturionAssault(),
                new Invictor(),
                new Dreadnought(),
                new ContemptorDreadnought(),
                new VenerableDreadnought(),
                new IroncladDreadnought(),
                new RedemptorDreadnought(), //[53]
                //---------- Fast Attack ----------
                new AssaultSquad(),
                new Outriders(),
                new InvaderATVs(),
                new BikeSquad(),
                new ScoutBikeSquad(),
                new AttackBikeSquad(),
                new Suppressors(),
                new Inceptors(),
                new StormSpeederHailstrike(),
                new StormSpeederThunderstrike(),
                new StormSpeederHammerstrike(),
                new LandSpeeders(),
                new LandSpeederTornadoes(),
                new LandSpeederTyphoons(),
                //---------- Heavy Support ----------
                new Hellblasters(),
                new Eliminators(),
                new CenturionDevastators(),
                new Eradicators(),
                new Devastators(),
                new Thunderfire(),
                new FirestrikeTurret(),
                new Hunter(),
                new Stalker(),
                new Whirlwind(),
                new PredatorDestructor(),
                new PredatorAnnihilator(),
                new GladiatorLancer(),
                new GladiatorReaper(),
                new GladiatorValiant(),
                new Vindicator(),
                new LandRaider(),
                new LandRaiderCrusader(),
                new LandRaiderRedeemer(),
                new Repulsor(),
                new RepulsorExecutioner(),
                //---------- Transport ----------
                new Rhino(),
                new Razorback(),
                new Impulsor(),
                new DropPod(),
                new LandSpeederStorm(),
                //---------- Flyers ----------
                new StormhawkInterceptor(),
                new StormtalonGunship(),
                new StormravenGunship(),
                //---------- Lords of War ----------
                new RobouteGuilliman(),
                new LionElJonson(),
                //---------- Fortification ----------
                new HammerfallBunker()
            };

            if(currentSubFaction == "Ultramarines")
            {
                datasheets.Insert(22, new MarneusCalgar()); //Marneus Calgar
                datasheets.Insert(55, new VictrixGuard()); //Victrix Guard
                datasheets.Insert(23, new ChiefLibrarianTigurius()); //Tigurius
                datasheets.Insert(24, new ChaplainCassius()); //Cassius
                datasheets.Insert(25, new CaptainSicarius()); //Sicarius
                datasheets.Insert(26, new SergeantTelion()); //Telion
                datasheets.Insert(27, new SergeantChronus()); //Chronus
                datasheets.Insert(61, new ChapterAncient()); //Chapter Ancient
                datasheets.Insert(62, new ChapterChampion()); //Chapter Champion
                datasheets.Insert(63, new HonourGuard()); //Honour Guard
                datasheets.Insert(64, new TyrannicVeterans()); //Tyrannic War Veterans
            }
            else if(currentSubFaction == "Salamanders")
            {
                datasheets.Insert(22, new VulkanHestan());
                datasheets.Insert(23, new AdraxAgatone());
            }

            return datasheets;
        }

        public override int GetFactionUpgradePoints(string upgrade)
        {
            int points = 0;

            string[] forty = new string[]
            {
                "Chapter Master (+35 pts)"
            };

            string[] twentyfive = new string[]
            {
                "Master of Sanctity (+20 pts)",
                "Chief Librarian (+20 pts)"
            };

            string[] twenty = new string[]
            {
                "Master of the Forge (+15 pts)",
                "Chapter Ancient (+15 pts)"
            };

            string[] fifteen = new string[]
            {
                "Chief Apothecary (+30 pts)",
                "Chapter Champion (+10 pts)"
            };

            if (forty.Contains(upgrade))
            {
                points = 40;
            }

            if (twenty.Contains(upgrade))
            {
                points = 20;
            }

            if (twentyfive.Contains(upgrade))
            {
                points = 25;
            }

            if (fifteen.Contains(upgrade))
            {
                points = 15;
            }

            return points;
        }

        public override List<string> GetFactionUpgrades(List<string> keywords)
        {
            List<string> upgrades = new List<string>() { "(None)" };

            if (keywords.Contains("CAPTAIN"))
            {
                upgrades.Add("Chapter Master (+35 pts)");
            }

            if (keywords.Contains("CHAPLAIN"))
            {
                upgrades.Add("Master of Sanctity (+20 pts)");
            }

            if (keywords.Contains("TECHMARINE"))
            {
                upgrades.Add("Master of the Forge (+15 pts)");
            }

            if (keywords.Contains("LIBRARIAN"))
            {
                upgrades.Add("Chief Librarian (+20 pts)");
            }

            if (keywords.Contains("APOTHECARY") || keywords.Contains("PRIMARIS APOTHECARY"))
            {
                upgrades.Add("Chief Apothecary (+30 pts)");
            }

            if (keywords.Contains("ANCIENT"))
            {
                upgrades.Add("Chapter Ancient (+15 pts)");
            }

            if (keywords.Contains("COMPANY CHAMPION"))
            {
                upgrades.Add("Chapter Champion (+10 pts)");
            }

            return upgrades;
        }

        public override bool GetIfEnabled(int index)
        {
            /*
            if (StratagemCount[index] < StratagemLimit[index])
            {
                return true;
            }

            return false;
            */
            return true;
        }

        public override List<string> GetPsykerPowers(string keywords)
        {
            List<string> PsychicPowers = new List<string>();

            if(keywords == "Librarius")
            {
                PsychicPowers.AddRange(new string[]
                {
                    "Veil of Time",
                    "Might of Heroes",
                    "Null Zone",
                    "Psychic Scourge",
                    "Fury of the Ancients",
                    "Psychic Fortress"
                });
            }

            if(keywords == "Obscuration")
            {
                PsychicPowers.AddRange(new string[]
                {
                    "Shrouding",
                    "Soul Sight",
                    "Mind Raid",
                    "Hallucination",
                    "Tenebrous Curse",
                    "Temporal Corridor"
                });
            }

            if (keywords == "Litanies")
            {
                PsychicPowers.AddRange(new string[]
                {
                    "Litany of Faith",
                    "Catechism of Fire",
                    "Exhortation of Rage",
                    "Mantra of Strength",
                    "Recitation of Focus",
                    "Canticle of Hate"
                });
            }

            if(keywords == "Indomitus")
            {
                PsychicPowers.AddRange(new string[]
                {
                    "Precognition",
                    "Scryer's Gaze",
                    "Telepathic Assault",
                    "Storm of the Emperor's Wrath",
                    "Psychic Shackles",
                    "Empyric Channelling"
                });
            }

            return PsychicPowers;
        }

        public override List<string> GetRelics(List<string> keywords)
        {
            List<string> relics = new List<string>();

            relics.Add("(None)");

            relics.Add("The Armour Indomitus");

            if ((keywords.Contains("CAPTAIN") && !(keywords.Contains("PHOBOS") || keywords.Contains("MK X GRAVIS"))) ||
                ((keywords.Contains("LIEUTENANT") && keywords.Contains("PRIMARIS")) && !keywords.Contains("PHOBOS")) ||
                (keywords.Contains("TERMINATOR") && keywords.Contains("ANCIENT") && currentSubFaction == "Dark Angels")) {
                relics.Add("The Shield Eternal");
            }

            if (keywords.Contains("ANCIENT"))
            {
                relics.Add("Standard of the Emperor Ascendant");
            }

            if ((keywords.Contains("CAPTAIN") && !(keywords.Contains("PRIMARIS") || keywords.Contains("TERMINATOR"))) ||
                (keywords.Contains("LIEUTENANT") && !keywords.Contains("PRIMARIS")) ||
                (keywords.Contains("APOTHECARY") && !keywords.Contains("PRIMARIS")) ||
                keywords.Contains("ANCIENT") && keywords.Contains("COMMAND SQUAD"))
            {
                relics.Add("The Teeth of Terra");
            }

            if ((keywords.Contains("CAPTAIN") && !(keywords.Contains("PHOBOS") || keywords.Contains("MK X GRAVIS") || keywords.Contains("TERMINATOR")) && currentSubFaction == "Dark Angels") ||
                (keywords.Contains("LIEUTENANT") && !keywords.Contains("PHOBOS") && currentSubFaction == "Space Wolves") ||
                (keywords.Contains("LIBRARIAN") && !(keywords.Contains("TERMINATOR") || keywords.Contains("PRIMARIS"))) ||
                (keywords.Contains("CHAPLAIN") && !(keywords.Contains("PRIMARIS") || keywords.Contains("TERMINATOR"))) ||
                (keywords.Contains("TECHMARINE") && !keywords.Contains("PRIMARIS")) ||
                keywords.Contains("ANCIENT") && keywords.Contains("COMMAND SQUAD"))
            {
                relics.Add("Primarch's Wrath");
            }

            if ((keywords.Contains("CAPTAIN") && !keywords.Contains("PHOBOS")) ||
                (keywords.Contains("LIEUTENANT") && !keywords.Contains("PHOBOS")) ||
                (keywords.Contains("TECHMARINE") && !keywords.Contains("PRIMARIS")) ||
                keywords.Contains("COMPANY CHAMPION") || keywords.Contains("COMPANY ANCIENT") ||
                keywords.Contains("CHAPTER ANCIENT") || keywords.Contains("CHAPTER CHAMPION") || 
                keywords.Contains("ANCIENT") && keywords.Contains("PRIMARIS"))
            {
                relics.Add("The Burning Blade");
            }

            if (!keywords.Contains("TERMINATOR") || keywords.Contains("MK X GRAVIS") || (keywords.Contains("TECHMARINE") && keywords.Contains("PRIMARIS")))
            {
                relics.Add("Purgatorus");
            }

            if (keywords.Contains("PRIMARIS"))
            {
                relics.Add("Reliquary of Gathalamor");
            }

            if (keywords.Contains("PRIMARIS") && (keywords.Contains("LIEUTENANT") || keywords.Contains("CAPTAIN")) &&
                !(keywords.Contains("MK X GRAVIS") || keywords.Contains("PHOBOS")))
            {
                relics.Add("Bellicos Bolt Rifle");
            }

            if (keywords.Contains("PRIMARIS") && (keywords.Contains("LIEUTENANT") || keywords.Contains("CAPTAIN")) &&
                !(keywords.Contains("MK X GRAVIS") || keywords.Contains("PHOBOS")))
            {
                relics.Add("Lament");
            }

            if (keywords.Contains("PHOBOS") && (keywords.Contains("LIBRARIAN") || keywords.Contains("CAPTAIN")))
            {
                relics.Add("Ghostweave Cloak");
            }

            if (keywords.Contains("LIBRARIAN"))
            {
                relics.Add("The Vox Espiritum");
            }

            if (keywords.Contains("CHAPLAIN"))
            {
                relics.Add("The Vox Espiritum");
            }

            relics.Add("The Honour Vehement");

            if (keywords.Contains("PRIMARIS"))
            {
                relics.Add("The Vox Espiritum");
            }

            #region Ultramarines Relics
            if (currentSubFaction == "Ultramarines")
            {
                if (keywords.Contains("CAPTAIN") ||
                    keywords.Contains("LIEUTENANT") ||
                    (keywords.Contains("TECHMARINE") && !keywords.Contains("PRIMARIS")) ||
                    keywords.Contains("COMPANY CHAMPION") || keywords.Contains("CHAPTER CHAMPION") ||
                    (keywords.Contains("ANCIENT") && !(keywords.Contains("BLADEGUARD") || keywords.Contains("TERMINATOR"))))
                {
                    relics.Add("Soldier's Blade");
                }

                if(keywords.Contains("CAPTAIN"))
                {
                    relics.Add("The Sanctic Halo");
                }

                if(keywords.Contains("ANCIENT"))
                {
                    relics.Add("The Standard of Macragge Inviolate");
                }

                if(keywords.Contains("TERMINATOR"))
                {
                    relics.Add("Armour of Konor");
                }

                relics.Add("Helm of Censure");

                if((keywords.Contains("CAPTAIN") && !keywords.Contains("PRIMARIS")) ||
                    (keywords.Contains("CHAPLAIN") && !keywords.Contains("PRIMARIS")) ||
                    (keywords.Contains("LIBRARIAN") && !keywords.Contains("PRIMARIS")) ||
                    (keywords.Contains("LIEUTENANT") && !keywords.Contains("PRIMARIS")) ||
                    (keywords.Contains("TECHMARINE") && !keywords.Contains("PRIMARIS")) ||
                    (keywords.Contains("ANCIENT") && !keywords.Contains("PRIMARIS"))) 
                {
                    relics.Add("Vengeance of Ultramar"); //Firstborn only
                }

                relics.Add("Tarentian Cloak");
                relics.Add("Adamantine Mantle");
                relics.Add("Artificer Armour");
                relics.Add("Master-crafted Weapon");
                relics.Add("Digital Weapons");
                relics.Add("Reliquary of Vengeance");
                relics.Add("Seal of Oath");
                relics.Add("Hellfury Bolts");

                if((keywords.Contains("CAPTAIN") && !(keywords.Contains("GRAVIS") || keywords.Contains("PHOBOS"))) ||
                    (keywords.Contains("CHAPLAIN") && !(keywords.Contains("PRIMARIS") || keywords.Contains("TERMINATOR"))) ||
                    keywords.Contains("COMPANY ANCIENT") ||
                    (keywords.Contains("LIBRARIAN") && !(keywords.Contains("PHOBOS") || keywords.Contains("TERMINATOR"))) ||
                    (keywords.Contains("LIEUTENANT") && !keywords.Contains("PRIMARIS")) ||
                    (keywords.Contains("TECHMARINE") && !keywords.Contains("PRIMARIS"))
                    )
                {
                    relics.Add("Sunwrath Pistol");
                }
            }
            #endregion

            return relics;
        }

        public override List<string> GetSubFactions()
        {
            return new List<string>()
            {
                "Dark Angels",
                "White Scars",
                "Space Wolves",
                "Imperial Fists",
                "Crimson Fists",
                "Black Templars",
                "Blood Angels",
                "Flesh Tearers",
                "Iron Hands",
                "Ultramarines",
                "Salamanders",
                "Raven Guard",
                "Deathwatch",
                "<Custom>"
            };
        }

        public override List<string> GetWarlordTraits(string keyword)
        {
            List<string> traits = new List<string>();

            if(keyword == "Phobos")
            {
                traits.AddRange(new string[]
                {
                    "Shoot and Fade",
                    "Lord of Deciet",
                    "Master of the Vanguard",
                    "Stealth Adept",
                    "Target Priority",
                    "Master Marksman"
                });
            }
            else
            {
                traits.AddRange(new string[]
                {
                    "Fear Made Manifest",
                    "The Imperium's Sword",
                    "Iron Resolve",
                    "Champion of Humanity",
                    "Storm of Fire",
                    "Rites of War"
                });
            }

            if (currentSubFaction == "Dark Angels") { traits.Add("Brilliant Strategist"); }
            else if (currentSubFaction == "White Scars") { traits.Add("Deadly Hunter"); }
            else if (currentSubFaction == "Space Wolves") { traits.Add("Beastslayer"); }
            else if (currentSubFaction == "Imperial Fists") { traits.Add("Architect of War"); }
            else if (currentSubFaction == "Crimson Fists") { traits.Add("Refuse to Die"); }
            else if (currentSubFaction == "Black Templars") { traits.Add("Oathkeeper"); }
            else if (currentSubFaction == "Blood Angels") { traits.Add("Speed of the Primarch"); }
            else if (currentSubFaction == "Flesh Tearers") { traits.Add("Merciless Butcher"); }
            else if (currentSubFaction == "Iron Hands") { traits.Add("Adept of the Omnissiah"); }
            else if (currentSubFaction == "Ultramarines") 
            { 
                traits.Add("Adept of the Codex");
                traits.Add("Master of Stratgey");
                traits.Add("Calm Under Fire");
                traits.Add("Paragon of War");
                traits.Add("Nobility Made Manifest");
                traits.Add("Warden of Macragge");
            }
            else if (currentSubFaction == "Salamanders") 
            { 
                traits.Add("Anvil of Strength");
                traits.Add("Miraculous Constitution");
                traits.Add("Never Give Up");
                traits.Add("Forge Master");
                traits.Add("Lord of Fire");
                traits.Add("Patient and Determined");
            }
            else if (currentSubFaction == "Raven Guard") { traits.Add("Echo of the Ravenspire"); }
            else if (currentSubFaction == "Deathwatch") { traits.Add("Vigilance Incarnate"); }

            return traits;
        }

        public override void SetPoints(int points)
        {
            StratagemCount = new int[] { 0, 0 };
            StratagemLimit = new int[] { points / 1000, points / 1000 };

            if (points < 1000)
            {
                StratagemLimit[0] = 1;
                StratagemLimit[1] = 1;
            }
        }

        public override string ToString()
        {
            return "Space Marines";
        }
    }
}
