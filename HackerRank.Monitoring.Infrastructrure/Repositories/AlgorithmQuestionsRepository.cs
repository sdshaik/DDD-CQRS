using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using HackerRank.Monitoring.Infrastructrure.Dbcontexts;
using Microsoft.EntityFrameworkCore;

namespace HackerRank.Monitoring.Infrastructrure.Repositories
{
    public class AlgorithmQuestionsRepository : IAlgorithmQuestionsRepository
    {
        private readonly HRMonitaringDbContext _hRMonitaringDbContext;
        public AlgorithmQuestionsRepository(HRMonitaringDbContext hRMonitaringDbContext)
        {
            _hRMonitaringDbContext = hRMonitaringDbContext;
        }

        public async Task DeleteAlgorithmQuestions(Algorithm_Questions algorithmQuestions)
        {
            _hRMonitaringDbContext.algorithm_Questions.Remove(algorithmQuestions);
            await _hRMonitaringDbContext.SaveChangesAsync();
        }

        public async Task<IList<Algorithm_Questions>> GetAlgorithmQuestions()
        {
            return await _hRMonitaringDbContext.algorithm_Questions.ToListAsync();
        }

        public async Task<Algorithm_Questions> GetAlgorithmQuestionsbyId(int id)
        {
            return await _hRMonitaringDbContext.algorithm_Questions.FirstOrDefaultAsync(x => x.Qus_Id == id);
        }

        public async Task PostAlgorithmQuestions(Algorithm_Questions algorithmQuestions)
        {
            _hRMonitaringDbContext.algorithm_Questions.Add(algorithmQuestions);
            _hRMonitaringDbContext.SaveChanges();
            //var userEntity = await _hRMonitaringDbContext.algorithm_Questions.FirstOrDefaultAsync(x => x.Qus_Id == algorithmQuestions.Qus_Id);
            //    _hRMonitaringDbContext.algorithm_Questions.AddAsync(algorithmQuestions);
            //    _hRMonitaringDbContext.SaveChangesAsync();
        }

        public async Task UpdateAlgorithmQuestions(int QId, Algorithm_Questions algorithmQuestions)
        {
            try
            {
                _hRMonitaringDbContext.algorithm_Questions.Update(algorithmQuestions);
                await _hRMonitaringDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
