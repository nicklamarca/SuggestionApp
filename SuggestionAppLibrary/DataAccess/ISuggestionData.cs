
namespace SuggestionAppLibrary.DataAccess
{
    public interface ISuggestionData
    {
        Task CreateSuggestion(SuggestionModel suggestion);
        Task<List<SuggestionModel>> GetAllAppovedSuggestions();
        Task<List<SuggestionModel>> GetAllSuggestions();
        Task<List<SuggestionModel>> GetAllSuggestionsWaitingForAppoval();
        Task<SuggestionModel> GetSuggestion(string id);
        Task UpdateSuggestion(SuggestionModel suggestion);
        Task UpVoteSuggestion(string suggestionId, string userId);
    }
}