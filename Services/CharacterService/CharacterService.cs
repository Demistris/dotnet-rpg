using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> _characters = new List<Character>
        {
            new Character(),
            new Character { Id = 1, Name = "Triss"}
        };

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            _characters.Add(newCharacter);
            return _characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return _characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            var character = _characters.FirstOrDefault(c => c.Id == id);

            if(character is not null)
            {
                return character;
            }

            throw new Exception("Character not found");
        }
    }
}