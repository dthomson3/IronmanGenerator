using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronmanGeneratorLibrary.Core;
public class TeamGeneration
{
    public Team team = new();
    public List<Character> poolOfCharacters = new();
    public Random rand = new();
    public Character generatedCharacter = new();
    public int Vetoes = 0;
    public int ReRolls = 0;
    public int charsLeftToGenerate = 0;

	public string VetoCharacter()
    {
        if (Vetoes <= 0)
        {
            return "No Vetoes";
        }
        if (charsLeftToGenerate == poolOfCharacters.Count)
        {
            return "Not Enough Characters";
        }
        else
        {
            Vetoes--;

            RemoveCharacterFromPool(generatedCharacter);
            return "success";
        }
    }

	public string ReRollCharacter()
    {
        if (ReRolls <= 0)
        {
            return "No ReRolls";
        }
        if (charsLeftToGenerate == poolOfCharacters.Count)
        {
            return "Not Enough Characters";
        }
        else
        {
            ReRolls--;

            RemoveCharacterFromPool(generatedCharacter);
            return "success";
        }
    }

    public void GenerateTeam(int numOfCharacters)
    {
        team = new();
        charsLeftToGenerate = numOfCharacters;
    }

    public void FillPool()
    {
        poolOfCharacters.Clear();
        foreach (string c in CharacterGeneration.CharacterNames)
        {
            poolOfCharacters.Add(new Character { CharacterName = c, ImageFileName = "images/" + c + ".png" });
        }
        Console.WriteLine(poolOfCharacters.Count);
    }

    public Character GetCharacterFromPool()
    {
        
        return poolOfCharacters[rand.Next(0, poolOfCharacters.Count)];
    }

    public void GenerateCharacter()
    {
        generatedCharacter = poolOfCharacters[rand.Next(0, poolOfCharacters.Count)];
    }

    public void RemoveCharacterFromPool(Character c)
    {
        poolOfCharacters.Remove(c);
    }
}
