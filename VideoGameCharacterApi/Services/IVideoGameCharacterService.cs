using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services
{
    public interface IVideoGameCharacterService
    {
        Task<List<Character>> GetAllCharactersAsync();
        Task<Character?> GetCharactersByIdAsync(int id);
        Task<List<Character>> AddCharactersAsync(Character character);
        Task<bool> UpdateCharacterAsync(int id, Character character);
        Task<bool> DeleteCharacterAsync(int id);
    }
}
