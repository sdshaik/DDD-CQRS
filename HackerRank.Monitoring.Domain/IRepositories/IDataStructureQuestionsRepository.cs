using HackerRank.Monitoring.Domain.Models;

namespace HackerRank.Monitoring.Domain.IRepositories
{
    public interface IDataStructureQuestionsRepository
    {
        Task<IList<DataStructure_Questions>> GetDataStructuresQuestions();
        Task<DataStructure_Questions> GetDataStructureQuestionsbyId(int id);
        Task PostDataStructureQuestions(DataStructure_Questions dataStructurequestions);
        Task UpdateDataStructureQuestions(int QId, DataStructure_Questions dataStructureQuestions);
        Task DeleteDataStructureQuestions(DataStructure_Questions dataStructureQuestions);
    }
}
