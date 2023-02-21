using HackerRank.Monitoring.Domain.Models;

namespace HackerRank.Monitoring.Domain.IRepositories
{
    public interface IAlgorithmQuestionsRepository
    {
        Task<IList<Algorithm_Questions>> GetAlgorithmQuestions();
        Task<Algorithm_Questions> GetAlgorithmQuestionsbyId(int id);
        Task PostAlgorithmQuestions(Algorithm_Questions algorithmQuestions);
        Task UpdateAlgorithmQuestions(int QId, Algorithm_Questions algorithmQuestions);
        Task DeleteAlgorithmQuestions(Algorithm_Questions algorithmQuestions);
    }
}
