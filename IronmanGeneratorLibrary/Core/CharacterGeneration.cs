﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronmanGeneratorLibrary.Core;
public class CharacterGeneration
{
	public static string[] baseGameCharacterNames =
	{
		"Mario", "Donkey Kong", "Link", "Samus", "Dark Samus", "Yoshi",
		"Kirby", "Fox", "Pikachu", "Luigi", "Ness", "Captain Falcon",
		"Jigglypuff", "Peach", "Daisy", "Bowser", "Ice Climbers", "Shiek",
		"Zelda", "Dr. Mario", "Pichu", "Falco", "Marth", "Lucina",
		"Young Link", "Ganondorf", "Mewtwo", "Roy", "Chrom", "Mr. Game & Watch",
		"Meta Knight", "Pit", "Dark Pit", "Zero Suit Samus", "Wario",
		"Snake", "Ike", "Pokemon Trainer", "Diddy Kong", "Lucas", "Sonic",
		"King Dedede", "Olimar", "Lucario", "R.O.B", "Toon Link", "Wolf",
		"Villager", "Mega Man", "Wii Fit Trainer", "Rosalina & Luma",
		"Little Mac", "Greninja", "Mii Brawler", "Mii Swordfighter",
		"Mii Gunner", "Palutena", "Pacman", "Robin", "Shulk", "Bowser Jr.",
		"Duck Hunt", "Ryu", "Ken", "Cloud", "Corrin", "Bayonetta", "Inkling",
		"Ridley", "Simon", "Richter", "King K. Rool", "Isabelle", "Incineroar"
	};

	public static string[] DlcCharacterNames =
	{
		"Joker", "Hero", "Terry", "Steve"
	};

	static Random rand = new Random();

	public static string GetRandomCharacterName()
	{
		return baseGameCharacterNames[rand.Next(0, baseGameCharacterNames.Length)];
	}

}
