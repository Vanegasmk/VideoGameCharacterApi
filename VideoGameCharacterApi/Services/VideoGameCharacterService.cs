using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services
{
    public class VideoGameCharacterService : IVideoGameCharacterService
    {

        static List<Character> characters = new List<Character>
        {
            new Character { Id = 1, Name = "Mario", Game = "Super Mario Bros.", Role = "Hero" },
            new Character { Id = 1, Name = "Link", Game = "Zelda.", Role = "Hero" },
            new Character { Id = 1, Name = "Venom", Game = "Spider Man.", Role = "Villain" },
        };

        public Task<List<Character>> AddCharactersAsync(Character character)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCharacterAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Character>> GetAllCharactersAsync()
            => await Task.FromResult(characters);

        public async Task<Character?> GetCharactersByIdAsync(int id)
        {
            var result = characters.FirstOrDefault(c => c.Id == id);
            return await Task.FromResult(result);
        }

        public Task<bool> UpdateCharacterAsync(int id, Character character)
        {
            throw new NotImplementedException();
        }
    }
}
