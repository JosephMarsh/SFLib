﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFLib
{
    /// <summary>
    /// This class is used to store Strings to populate info boxes.
    /// </summary>
    public class Information
    {


        /// <summary>Ability score discription</summary>
        public readonly string strengthStat = "Strength is useful for melee and Thrown attacks, damage rolls for melee and thrown weapons, Athletics skill checks, Strength checks for things like breaking stuff and forcing things open and your character’s carrying capacity.\r\rIf Commit is grayed out, make sure none of your stat rows have the same attribute assigned to them.";
        /// <summary>Ability score discription</summary>
        public readonly string dexterityStat = "Dexterity is useful for agile characters. It aids in Ranged Attack and Projectile rolls as well as some spells. It can increase Entergy Armor Class, Reflex saving throws, Acrobatics, Sleight of Hand, Piloting, and Stealth.\r\rIf Commit is grayed out, make sure none of your stat rows have the same attribute assigned to them.";
        /// <summary>Ability score discription</summary>
        public readonly string consitutionStat = "Constitution is a measure of how tough your character is. It aids in fortitude saves and stamina points. \r\rIf Commit is grayed out, make sure none of your stat rows have the same attribute assigned to them.";
        /// <summary>Ability score discription</summary>
        public readonly string intellienceStat = "Intelligence aids in number of bonus languages your character speaks as well as the number of skill ranks she possess.  It aids in skills such as Computers, Culture, Engineering, Life Science, Medicine, Physical Science, and some Professions.\r\rIf Commit is grayed out, make sure none of your stat rows have the same attribute assigned to them.";
        /// <summary>Ability score discription</summary>
        public readonly string wisdomStat = "Wisdom aids in Willpower saving throws as well as skills like Mysticism, Perception, Sense Motive, Survival, and some Professions. It can also grant bonus Mystic Spells and controls the level of spell you can eventually cast.\r\rIf Commit is grayed out, make sure none of your stat rows have the same attribute assigned to them.";
        /// <summary>Ability score discription</summary>
        public readonly string charismaStat = "Charisma is useful for playing characters with powerful personalities. It aids in skill checks like Bluff, Diplomacy, Disguise, Intimidate, and some Professions. Extremely useful for Envoy’s and people choosing the Icon theme.\r\rIf Commit is grayed out, make sure none of your stat rows have the same attribute assigned to them.";

        /// <summary>Stat Generation Method, Description</summary>
        public readonly string rollModeStandard = "Roll 4d6, discard the lowest die result, and add the three remaining results together. Then, use the \"Assign Your Stats\" Box to put the stat name next to the number you want to assign to it. You can roll as many times as you like untill you get a result you like. Once you're done, press \"Commit\"";
        /// <summary>Stat Generation Method, Description</summary>
        public readonly string rollModeClassic = "Roll 3d6 and add the dice together.  Then, use the \"Assign Your Stats\" Box to put the stat name next to the nuber you want to assign to it.  You can roll as many times as you like untill you get a result you like. Once you're done, press \"Commit\"";
        /// <summary>Stat Generation Method, Description</summary>
        public readonly string rollModeHeroic = "Roll 2d6 and add 6 to the sum of the dice. Then, use the \"Assign Your Stats\" Box to put the stat name next to the nuber you want to assign to it.  You can roll as many times as you like untill you get a result you like. Once you're done, press \"Commit\"";
        /// <summary>Stat Generation Method, Description</summary>
        public readonly string rollModeDicePool = "Roll 24d6 in a pool, then assign three to each stat, starting with Strength and working your way down.  You can roll as many times as you like untill you get a result you like.  You can press clear to put all your selected dice back into your pool and try again. Once you're done, press \"Commit\"";
        /// <summary>Stat Generation Method, Description</summary>
        public readonly string rollModepointBuy = "No dice to roll on this option.  Just select the stats you want using the up and down buttons in number boxes or type them in."+ cr() +"All the math is done for you but incase you want to know, the costs are as follows:\rScore:\tPoints:\r7\t-4\r8\t-2\r9\t-1\r10\t0\r11\t1\r12\t2\r13\t3\r14\t5\r15\t7\r16\t10\r17\t13\r18\t17";
        /// <summary>Stat Generation Method, Description</summary>
        public readonly string rollModeGod = "This is pretty much Point Buy mode but without limits. Just select the stats you want using the up and down buttons in number boxes or type them in. \r\rWarning: The Point Buy Scale doesn't go above 18 or below 7, so it will not show an accurate cost for your scores beyond that threshold... Like you care... Cheater! \rMust be in Point-Buy mode to take advatage of this setting.";
        /// <summary>Stat Generation Method, Description</summary>
        public readonly string rollModeCore = "This is how Starfinder is meant to be played. All Ability Scores will be set to 10 for now.  Later, in step 5, you’ll have the option to do a modified version of a point buy where you get 10 points to spend on a one-for-one basis.  You’ll also get your theme and race modifiers in steps two and three to add to these. Or you can skip step 5 by choosing one of the other options. Paizo warns that these options may make the game unbalanced but does mention that if you want to get around this unbalancing, don’t let your stats go over 18 even after theme and race mods are applied.";

        /// <summary>Instruction Set for Concept</summary>
        public readonly string step1 = "Chose a concept for your character. Get an idea for their personality.  Start thinking about their past and where their choices have led them.  What major struggles have they had to overcome and what skills have they developed to, or from, overcoming them?  Do they have a job or profession?  What languages do they speak? What race are they?  Note that you will choose their Languages and Racial Architype in the later steps but their race will inform their past, present and future, so it can’t be overlooked yet.";
        /// <summary>Instruction Set for Race Selection</summary>
        public readonly string step2 = "In this step, you choose your Race. Select from the list in the dropdown from the available races, or chose the custom race for anything that doesn’t fit a pre-built race. Your ability scores will be adjusted according to your race and you may get the option to choose from a selection of Racial skills.";
        /// <summary>Instruction Set for Theme Selection</summary>
        public readonly string step3 = "In this step, you choose your Theme. Select from the list in the dropdown from the available themes, or chose Themeless for anything that doesn’t fit. Your ability scores will be adjusted according to your theme and details for your selected theme will replace this text.";
        /// <summary>Instruction Set</summary>
        public readonly string step2GodMode = "This setting allows you to change the ability scores any way you want.  Use this mode if the default Race types don’t fit your custom built.  You can add templates later as well so don’t add those here.";
        /// <summary>Instruction Set</summary>
        public readonly string afterCommitPressed = "Your starting stats have been chosen, begin step 1 or write down your stats and have a nice day!.";
        /// <summary>Instruction Set</summary>
        public readonly string afterCommitPressedCore = "Your stats have been set to 10 for now. In Step 5, after you have modified them with your Race and Theme selections, you will have a chance to alter them.";
        /// <summary>Instruction Set</summary>
        public readonly string briefConcept = "This should be short and sweet, the main word or idea that captures the essence of your character.  If could be anything from homeless bum to interstellar rock star.  Use the notes section to capture the finer details as they pop into your head. ";

        /// <summary>Theme Discription</summary>
        public readonly string acePilot = "Ace Pilot" + cr() +"Theme Knowledge [1st Level]" + cr() + "This knowledge reduces the DC on culture checks to Identify ships and vehicles, parts, and famous pilots by 5.  You gain piloting as a class skill and if your class already gains this as a class skill you gain an additional +1 bonus to Piloting skill checks." + cr() + cr() + "Lone Wolf [6th Level]" + cr() + "You can treat half your ranks in Piloting as the appropriate skill required for ship repair and maintenance both in and out of combat and you are considered trained in that skill." + cr() + cr() + "Need For Speed [12th Level]" + cr() + "-1 difficulty to piloting checks when taking double maneuver action during vehicle chases. Further, if there is a penalty for failing a Pilot check by 5 or more, you only receive that penalty if you fail by 10 or more." + cr() + cr() + "Master Pilot [18th Level]" + cr() + "Twice per day, if you succeed in a chase (escape or catch some one) or defeat a significant opponent in Starship Combat, you recover a resolve point.";
        /// <summary>Theme Discription</summary>
        public readonly string bountyHunter = "Bounty Hunter" + cr() + "Theme Knowledge [1st Level]" + cr() + "Identify a mark and reduce the DC of Culture or Profession Bounty Hunter checks by 5 to recall knowledge about that mark. Additionally, reduce the DC by 5 for Knowledge checks about Law Enforcement individuals and practices. This only works with the identities for your Mark that you are aware of.  Survival is a class skill for you and if your class already gains this as a class skill, you gain an additional +1 bonus to Survival skill checks. " + cr() + cr() + "Swift Hunter [6th Level]" + cr() + "You take half as much time as normal to gather info about specific individuals while making Diplomacy checks. There is also no penalty for Survival checks due to following tracks at full speed. " + cr() + cr() + "Relentless [12th Level] " + cr() + "You can walk or perform activities for 12 hrs instead of 8 before you need a Constitution check.  You can Hustle for 2 hrs overland instead of 1. -10 to the penalty for Survival and Following Tracks at double speed. " + cr() + cr() + "Master Hunter [18th Level] " + cr() + "You can spend 10 minutes to review current information about your mark, once per day to regain 1 point of Resolve. If you defeat a mark, you gain 1 additional point of Resolve.";
        /// <summary>Theme Discription</summary>
        public readonly string icon = "Icon" + cr() + "Theme Knowledge [1st Level]" + cr() + "For 1 Profession skill, when attempting a Profession or Culture check to recall knowledge about people of your profession or details about its cultural aspects, reduce the DC by 5. You gain Culture as a class skill and if your class already gains this as a class skill, you gain an additional +1 bonus to Culture skill and knowledge checks " + cr() + cr() + "Celebrity [6th Level]" + cr() + "it is now a DC10 Culture check to recognize your name and a DC 20 to recognize you out of context from your appearance alone. It takes 2D4 hours to find a helpful fan who can provide a desired service and they will likely grant you that service at a reduce fee or for free.  This doesn’t apply to goods." + cr() + cr() + "Mega-Celebrity [12th Level] " + cr() + "DC for culture checks to identify you is now 5 or 10 out of context. It takes 1D4 hours to find a helpful fan who can provide a desired service or goods and they will likely grant you that service at a reduce fee or for free. Additionally, fans will give you a 10% discount on purchased goods." + cr() + cr() + "Master Icon [18th Level] " + cr() + "When interacting with the pubic in regards to your chosen profession, for at least 10 minutes, recover 1 point of Resolve. You can do this up to twice per day.";
        /// <summary>Theme Discription</summary>
        public readonly string mercenary = "Mercenary" + cr() + "Theme Knowledge [1stLevel]" + cr() + "-5 DC knowledge check for Culture and Profession (Merc) to recall information about hierarchies, practices personnel etc., regarding military groups. Athletics is a class skill." + cr() + cr() + "Grunt [6th Level]" + cr() + "Treat Strength as 1 point higher for calculating bulk limit" + cr() + cr() + "Squad Leader [12th Level] " + cr() + "Automatically success in any skill check to aid another if you are capable of attempting it." + cr() + cr() + "Commander [18th Level] " + cr() + "recover 1 Resolve Point for every 3 battles per day, limit 2 points per day;";
        /// <summary>Theme Discription</summary>
        public readonly string outlaw = "Outlaw" + cr() + "Theme Knowledge [1st Level]" + cr() + "-5 DC for Culture checks regarding the Criminal Underworld. Sleight of Hand is a class skill, additionally if it is already a class skill, you gain a +1 bonus in it." + cr() + cr() + "Legal Corruption [6th Level]" + cr() + "You can pay to get yourself out of just about any legal issues you find yourself in. costs will vary by player level and severity of the crime." + cr() + cr() + "Black Market Connections [12th Level]" + cr() + "You can sell goods at their normal price, even if they are illegal or too luxurious for locals to be able to afford. You can also purchase goods to be delivered at a drop off point for a 10% markup, anywhere in a solar system of a familiar city." + cr() + cr() + "Master Outlaw [18th Level]" + cr() + "IF you spend at least 10 minute planning a Heist, Caper of other crime, and successfully complete at least 1 action toward that plan, you regain 1 Resolve point. You can do this twice per day.";
        /// <summary>Theme Discription</summary>
        public readonly string priest = "Priest" + cr() + "Theme Knowledge [1st Level]" + cr() + "-5 DC on Culture checks and Mysticism checks for knowledge about religions and their leaders, symbols and traditions. Mysticism is a class skill for you and if you already have it as a class skill, you gain a +1 in it." + cr() + cr() + "Mantle of the Clergy [6th Level]" + cr() + "Followers of your religion know you and have a starting attitude of helpful toward you.  Gain a +2 Diplomacy and Intimidation toward lower level members of your religion." + cr() + cr() + "Divine Boon [12th Level]" + cr() + "Pick a 1st Level spell that is related to your deity in some way. You gain one level on mystic spell per day and that spell is added to your list of spells known. Or you can use the spell once per day as a spell like ability." + cr() + cr() + "True Communion [18th Level]" + cr() + "After performing an action that is strongly aligned with your dogma, spend 10 minutes in meditation to gain 1 point of Resolve. You can do this up to 2 times per day.";
        /// <summary>Theme Discription</summary>
        public readonly string scholar = "Scolar" + cr() + "Theme Knowledge [1st Level]" + cr() + "Choose Life or Physical Science.  Then pick a specialty.  Life Science: Bioengineering, Biology, Botany, Ecology, Genetics, Xenobiology, Zoology or another filed if biological science. Physical Science: Astronomy, Chemistry, Climatology, Geology, Geography, Meteorology, Oceanography, Physics or other field of physical science. -5 DC to recall knowledge about your chosen specialty.  Additionally your chosen skill is a class skill for you.  If it is already a class skill you gain a +1 bonus in it." + cr() + cr() + "Tip of the Tongue [6th Level]" + cr() + "After rolling but before learning if it was successful you can re-roll any skill check.  You must use the second roll even if it’s worse and you can only do this once per day." + cr() + cr() + "Research Maven [12th Level]" + cr() + "Research takes ¼ the normal amount of time and you can take 20 to recall knowledge in 5 rounds." + cr() + cr() + "Master Scholar [18th Level]" + cr() + "If you find yourself in a situation where your knowledge is useful, you can spend 10 minutes in deep contemplation to recover 1 Resolve point as well as being able to use Recall Knowledge.  You can do this twice per day.";
        /// <summary>Theme Discription</summary>
        public readonly string spacefarer = "Spacefarer" + cr() + "Theme Knowledge [1st Level]" + cr() + "-5 DC for Physical Science checks to recall knowledge pertaining to strange new worlds or space features. Physical Science is a class skill and if it is already a class skill, you gain a +1 in it." + cr() + cr() + "Eager Dabbler [6th Level]" + cr() + "+2 Bonus to attempt skill checks you don’t have any ranks in.  This ability only be used on skill you can attempt untrained." + cr() + cr() + "Jack of all Trades [12th Level]" + cr() + "You can use all skills untrained. Additionally, if you roll a natural twenty on skills that you can perform untrained your Eager Dabbler bonus becomes a +4 for that check." + cr() + cr() + "Master Explorer [18th Level]" + cr() + "While on an unexplored planet, you can spend 10 minutes exploring, mapping and documenting a feature to recover 1 resolve point.  You can do this twice per day.";
        /// <summary>Theme Discription</summary>
        public readonly string xenoSeeker = "Xenoseeker" + cr() + "Theme Knowledge [1st Level]" + cr() + "-5 DC to identify a rare creature using Life Science.  Life Science is a class skill for you and if you already have it as a class skill you gain a +1 bonus in it." + cr() + cr() + "Quick Pidgin [6th Level]" + cr() + "If you spend 10 minutes with an alien you don’t share a language with, you can attempt a DC 25 Culture check to formulate a simple pidgin language that will allow you basic communication.  You can only use this on these specific individuals but you gain a +2 on future culture checks to do this again with other members of this species." + cr() + cr() + "First Contact [12th Level]" + cr() + "All races that have never seen a member of your, or your companion’s races are treated as Indifferent instead of Unfriendly. This has no effect on creatures that would ordinarily be Hostile, Indifferent, Friendly or Helpful" + cr() + cr() + "Brilliant Discovery [18th Level]" + cr() + "if you spend 10 minutes on an unknown planet or 1d4 hours on a known world documenting a new species of flora or fauna you gain 1 point of Resolve.  You can do this up to twice per day.";
        /// <summary>Theme Discription</summary>
        public readonly string themeless = "Themeless" + cr() + "General Knowledge [1st Level]" + cr() + "Gain a class skill of your choice." + cr() + cr() + "Certainty [6th Level]" + cr() + "Gain a +2 on any skill check, once per day, before rolling." + cr() + cr() + "Extensive Studies[12th Level] " + cr() + "Pick a class skill, once per day, after rolling but before discovering if the roll was successful, you can reroll a skill check.You must accept the second result, even if it’s worse." + cr() + cr() + "Steely Determination [18th Level] " + cr() + "increase your maximum resolve pool by 1.";


        //Coppied from https://starfinderwiki.com
        /// <summary>Race Discription</summary>
        public readonly string androidDiscription = "Size and Type" + cr() + "Androids are Medium sized creatures that start with a base HP of 4 and have the Android subtype" + cr() + cr() + "Construct Subtype" + cr() + "Androids count as both Constructs and Humanoids and receive whichever effect is worse. They get a +2 Racial bonus to save against Disease, Mind-Affecting Effects, Poison, and Sleep unless the effect specifically targets Constructs.They also don’t need to breath, nor do they suffer from normal effects when in a vacuum." + cr() + cr() + "Low-Light and Dark Vision" + cr() + "Androids can see in low light as if it were normal light can have Dark Vision in black and white up to 60Ft." + cr() + cr() + "Socially Awkward" + cr() + "Androids take a -2 on Sense Motive checks but gain a +2 to the DC on Sense Motive checks against them. " + cr() + cr() + "Can be Upgraded" + cr() + "Androids have a slot for a single Armor Upgrade in their bodies even if they are not wearing physical armor. This is limited to upgrades that could be installed into light armor.";
        /// <summary>Race Discription</summary>
        public readonly string humanDiscription = "Size and Type" + cr() + "Humans are Medium sized creatures that start with a base HP of 4 and have the Human subtype" + cr() + cr() + "Bonus Feat" + cr() + "Humans can select 1 extra feat at 1st Level" + cr() + cr() + "Skilled" + cr() + "Humans gain an additional skill rank at 1st level and each level thereafter.";
        /// <summary>Race Discription</summary>
        public readonly string kasathasDiscription = "Size and Type" + cr() + "Kasathas are Medium sized creatures that start with a base HP of 4 and have the Kasatha subtype" + cr() + cr() + "Desert Stride" + cr() + "The Kasathas move through non-magical Difficult Terrain in deserts, hills and mountains at their normal speed." + cr() + cr() + "Four Arms" + cr() + "As a Kasatha, you can hold up to four hands worth of weapons and equipment. This increase the number of possibilities in combat but doesn’t increase the number of attacks you can make." + cr() + cr() + "Historians" + cr() + "Kasathas gain a +2 Racial bonus to Culture checks." + cr() + cr() + "Natural Grace" + cr() + "Kasathas gain a +2 Racial bonus in Acrobatics and Athletics checks.";
        /// <summary>Race Discription</summary>
        public readonly string lashuntasDiscription = "Size and Type" + cr() + "Lashuntas are Medium sized creatures that start with a base HP of 4 and have the Lashunta subtype" + cr() + cr() + "Dimorphic" + cr() + "The Lashunta come in two flavors: Korasha and Damaya. Korasha tend to be more muscular brash and unobservant, whereas Damaya tend to be more clever and well-spoken but less hardy." + cr() + cr() + "Lashunta Magic" + cr() + "all Lashunta gain the following Spell-Like Abilities:" + cr() + "At will: Daze, Psychokinetic Hand" + cr() + "Once per day: Detect Thoughts" + cr() + "The caster level for these effects is equal to the lashunta’s level" + cr() + cr() + "Limited Telepathy" + cr() + "If they share a language in common, a Lashunta can communicate with any creature within 30 feet." + cr() + cr() + "Student" + cr() + "Lashunta gain a +2 Racial bonus in two skills of your choice.";
        /// <summary>Race Discription</summary>
        public readonly string shirrensDiscription = "Size and Type" + cr() + "Shirrens are Medium sized creatures that start with a base HP of 6 and have the Shirren subtype" + cr() + cr() + "Blindesense" + cr() + "A Shirren’s antenna grant is Blindsense(Vibration) to within 30 Ft.  Within this range, a Shirren ignores all bonuses to stealth from visible camouflage, invisibility or any other form of visual concealment. A shirren is still considered flat footed against attacks from creatures it can’t see." + cr() + cr() + "Communalism" + cr() + "If there is an ally within 10 Ft A Shirren can roll a single attack or skill check twice and take the higher of the two results." + cr() + cr() + "Limited Telepathy" + cr() + "If they share a language in common, a Shirren can communicate with any creature within 30 feet." + cr() + cr() + "Cultural Fascination" + cr() + "Shirrens gain a +2 Racial bonus in Culture and Diplomacy.";
        /// <summary>Race Discription</summary>
        public readonly string veskDiscription = "Size and Type" + cr() + "Vesk are Medium sized creatures that start with a base HP of 6 and have the Vesk subtype" + cr() + cr() + "Armor Savant" + cr() + "When wearing armor, The Vesk receive a +1 racial bonus to that armor and in heavy armor they reduce the check penalty by 1." + cr() + cr() + "Fearless" + cr() + "+2 racial bonus on saves VS fear." + cr() + cr() + "Low-Light Vision" + cr() + "Vesk can see in low light as if it were normal light." + cr() + cr() + "Natural Weapons" + cr() + "Vesk are always considered armed and can deal 1D3 lethal damage with unarmed strikes. These attacks do not count as Archaic.  Vesk Gain a unique weapon specialization with their natural weapons at level 3.  This allows them to add 1.5 X character level to the damage rolls for their natural weapons, instead of the normal flat character level.";
        /// <summary>Race Discription</summary>
        public readonly string yoskiDiscription = "Size and Type" + cr() + "Yoski are Small sized creatures that start with a base HP of 3 and have the Yoski subtype" + cr() + cr() + "Cheek Pouches" + cr() + "Yoski can carry 1 cubic foot weighing up to 1 bulk in their cheek pouches.  Additionally, as a Swift action they transfer this object from mouth to hand.  Without provoking an attack of opportunity, a Yoski can transfer the entire contents of his/her pouch as a Full-Round action." + cr() + cr() + "Dark Vision" + cr() + "Yoski can see up to 60 Ft in the dark." + cr() + cr() + "Moxi" + cr() + "A Yoski can stand from prone as a Swift action. If Off-Kilter, a Yoski doesn’t take attack penalties or gain the flat footed condition. They also gain a +5 Racial bonus on the DC to tumble through the square of an opponent alt least on size category larger.";
        /// <summary>Race Discription</summary>
        public readonly string customRaceDiscription = "Select a Stat bunus and two skill bonuses." + cr() + cr() + "Alternatively, you could opt for God mode and add and subtract ability scores according to your whim.  In order to keep it balanced, anything above a +2 should be accompanied by an equally negative ability adjustment.  For example you could go with a +2 in Str, Dex, and Con and a -2 in Int and Wis. Making the net positive a +2.";

        /// <summary>Class Discription</summary>
        public readonly string envoyDiscription = "Envoy Class" + cr() + "Envoys are charismatic and inspirational. They are a good Support classe and have many useful skills and abilites toward that end." + cr() + cr() + "Primary Stat" + cr() + "Charisma" + cr() + cr() + "Secondary" + cr() + "Intelligence: for extra skill points" + cr() + "Dexterity: for ranged combat" + cr() + cr() + "Stamina Points / HP" + cr() + "6 + Constitution Modifier / 6 HP" + cr() + cr() + "Skill Ranks per Level" + cr() + "8 plus Intelligence Modifier" + cr() + cr() + "Class Skills:";
        /// <summary>Class Discription</summary>
        public readonly string mechDiscription = "Mechanic Class" + cr() + "Mechanics are Ingenious and Crafty. They are good hackers, engineers and ship roboticists" + cr() + cr() + "Primary Stat" + cr() + "Intelligence" + cr() + cr() + "Secondary" + cr() + "Dexterity: For better ranged attacks" + cr() + cr() + "Stamina Points / HP" + cr() + "6 + Constitution Modifier / 6 HP" + cr() + cr() + "Skill Ranks per Level" + cr() + "4 plus Intelligence Modifier" + cr() + cr() + "Class Skills:";
        /// <summary>Class Discription</summary>
        public readonly string mysticDiscription = "Mystic Class" + cr() + "Mystics are wielders of unseen powers.  They are capable of casting spells and investigating the mysteries of the universe, both arcane and mundane." + cr() + cr() + "Primary Stat" + cr() + "Wisdom" + cr() + cr() + "Secondary" + cr() + "Charisma: For better social interations" + cr() + cr() + "Stamina Points / HP" + cr() + "6 + Constitution Modifier / 6 HP" + cr() + cr() + "Skill Ranks per Level" + cr() + "6 plus Intelligence Modifier" + cr() + cr() + "Class Skills:";
        /// <summary>Class Discription</summary>
        public readonly string operativeDiscription = "Operative Class" + cr() + "Operatives are elite warriors and spies. What Solders do with bruit force and intimidation, operatives do with fineness and guile. " + cr() + cr() + "Primary Stat" + cr() + "Dexterity" + cr() + cr() + "Secondary" + cr() + "Intelligence: For more skill ponts" + cr() + cr() + "Stamina Points / HP" + cr() + "6 + Constitution Modifier / 6 HP" + cr() + cr() + "Skill Ranks per Level" + cr() + "8 plus Intelligence Modifier" + cr() + cr() + "Class Skills:";
        /// <summary>Class Discription</summary>
        public readonly string solarianDiscription = "Solrian Class" + cr() + "Solarians are matial warriors and wielders of the scorching fire of the sun and the crushing forces of gravity." + cr() + cr() + "Primary Stat" + cr() + "Charisma" + cr() + cr() + "Secondary" + cr() + "Strength: For more effective attacks" + cr() + cr() + "Stamina Points / HP" + cr() + "7 + Constitution Modifier / 7 HP" + cr() + cr() + "Skill Ranks per Level" + cr() + "4 plus Intelligence Modifier" + cr() + cr() + "Class Skills:";
        /// <summary>Class Discription</summary>
        public readonly string soldierDiscription = "";
        /// <summary>Class Discription</summary>
        public readonly string techDiscription = "";
        /// <summary>Class Discription</summary>
        private string[] classDiscriptions;
        /// <summary>An Array of Deities and their Alignments</summary>
        public readonly string[] CoreDeities = { "Hylax [LG]", "Iomedae [LG]", "Sarenrae [NG]", "Yaraesa [NG]", "Desna [CG]", "Weydan [CG]", "Abadar [LN]", "Talavet [LN]", "Eloritu [N]", "Ibra [N]", "Pharasma [N]", "Triune [N]", "Besmara [CN]", "Oras [CN]", "Damoritosh[LE]", "Zon-Kuthon [LE]", "Lau Shu Po [NE]", "Urgathoa [NE]", "The Devourer [CE]", "Nyarlathotep [CE]" };


        /// <summary>
        /// produces a read only array of Class Names
        /// </summary>
        public string[] ClassDiscriptions
        {
            get
            {
                classDiscriptions = new string[] 
                {
                    envoyDiscription,
                    mechDiscription,
                    mysticDiscription,
                    operativeDiscription,
                    solarianDiscription,
                    soldierDiscription,
                    techDiscription
                };
                return classDiscriptions;
            }
        }

        /// <summary>Retruns a read only array of Race Descriptions</summary>
        public string[] RaceDiscriptions
        {
            get
            {
                return new string[]
                {
                    androidDiscription,
                    humanDiscription,
                    kasathasDiscription,
                    lashuntasDiscription,
                    lashuntasDiscription,
                    shirrensDiscription,
                    veskDiscription,
                    yoskiDiscription,
                    customRaceDiscription
                };
            }
        }

        //For Rich text formats where \r does't work.
        private static string cr()
        {
            return Environment.NewLine;
        }
    }
}
