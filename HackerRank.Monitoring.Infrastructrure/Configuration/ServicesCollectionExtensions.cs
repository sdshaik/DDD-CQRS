using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Infrastructrure.Dbcontexts;
using HackerRank.Monitoring.Infrastructrure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HackerRank.Monitoring.Infrastructrure.Configuration
{
    public static class ServicesCollectionExtensions
    {
        public static void AddHRMonitaringRepositories(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddDbContext<HRMonitaringDbContext>(opts => opts.UseSqlServer(configuration["ConnectingString"]));
            services.AddScoped<IHackerRankProfileRepository, HackerRankProfileRepository>();
            services.AddScoped<ITopicsRepository, TopicsRepository>();
            services.AddScoped<IDataStructureQuestionsRepository, DataStructureQuestionsRepository>();
            services.AddScoped<IAlgorithmQuestionsRepository, AlgorithmQuestionsRepository>();
            services.AddScoped<IRatingsRepository, RatingsRepository>();
        }
    }
}