using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using HackerRank.Monitoring.Infrastructrure.Dbcontexts;
using Microsoft.EntityFrameworkCore;

namespace HackerRank.Monitoring.Infrastructrure.Repositories
{
    public class DataStructureQuestionsRepository : IDataStructureQuestionsRepository
    {
        private readonly HRMonitaringDbContext _hRMonitaringDbContext;
        public DataStructureQuestionsRepository(HRMonitaringDbContext hRMonitaringDbContext)
        {
            _hRMonitaringDbContext = hRMonitaringDbContext;
        }

        public async Task DeleteDataStructureQuestions(DataStructure_Questions dataStructureQuestions)
        {
            _hRMonitaringDbContext.dataStructure_Questions.Remove(dataStructureQuestions);
            _hRMonitaringDbContext.SaveChangesAsync();
        }

        public async Task<IList<DataStructure_Questions>> GetDataStructuresQuestions()
        {
            return await _hRMonitaringDbContext.dataStructure_Questions.ToListAsync();
        }

        public async Task<DataStructure_Questions> GetDataStructureQuestionsbyId(int id)
        {
            return await _hRMonitaringDbContext.dataStructure_Questions.FirstOrDefaultAsync(x => x.Qus_Id == id);
        }

        public async Task PostDataStructureQuestions(DataStructure_Questions dataStructureQuestions)
        {
            _hRMonitaringDbContext.dataStructure_Questions.Add(dataStructureQuestions);
            _hRMonitaringDbContext.SaveChanges();
        }

        public async Task UpdateDataStructureQuestions(int QId, DataStructure_Questions dataStructureQuestions)
        {
            try
            {
                _hRMonitaringDbContext.dataStructure_Questions.Update(dataStructureQuestions);
                await _hRMonitaringDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
