using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronmanGeneratorLibrary.Core;
public class TeamGeneration
{
    public Team teamOne = new();
    public Team teamTwo = new();
    public List<Character> poolOfCharacters = new();
    public Random rand = new();
	public void AcceptCharacter()
    {

    }

	public void VetoCharacter()
    {

    }

	public void ReRollCharacter()
    {

    }

    public void GenerateTeams(int numOfCharacters)
    {
        teamOne = new();
        teamTwo = new();
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

    public string GetCharacterFromPool()
    {
        
        return poolOfCharacters[rand.Next(0, poolOfCharacters.Count)].CharacterName;
    }
}
