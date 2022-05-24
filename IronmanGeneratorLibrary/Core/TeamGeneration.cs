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

	public void ReRollCharacter()
    {

    }

    public void GenerateTeam(int numOfCharacters)
    {
        team = new();
    }

    public void FillPool(bool DLC)
    {
        poolOfCharacters.Clear();
        foreach (string c in CharacterGeneration.baseGameCharacterNames)
        {
            poolOfCharacters.Add(new Character { CharacterName = c });
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
