

using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Crayon_Kids.Models
{
    public class RepositoryBase : IRepositoryBase
    {

        private AppDbContext _appDbContext;
        public RepositoryBase(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Add<T>(T entity) where T : class
        {
            _appDbContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _appDbContext.Remove(entity);
        }

        public async Task<Allergy[]> GetAllAllergies()
        {
            IQueryable<Allergy> query = _appDbContext.Allergies;
            return await query.ToArrayAsync();
        }

        public Task<Allergy[]> GetAllAllergiesAsync(string Allergy_Details)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Assessment[]> GetAllAssessments()
        {
            IQueryable<Assessment> query = _appDbContext.Assessments;
            return await query.ToArrayAsync();
        }

        public async Task<Assessment[]> GetAllAssessmentsAsync(string Assessment_Detailss)
        {
            IQueryable<Assessment> query = _appDbContext.Assessments.Where(c => c.Assessment_Details == Assessment_Detailss);
                return await query.FirstOrDefaultAsync();
        }

        public Task<Class_Type[]> GetAllClass_Types()
        {
            throw new System.NotImplementedException();
        }

        public Task<Class_Type[]> GetAllClass_TypesAsync(int Grade)
        {
            throw new System.NotImplementedException();
        }

        public Task<Employee[]> GetAllEmployees()
        {
            throw new System.NotImplementedException();
        }

        public Task<Employee[]> GetAllEmployeesAsync(string Name, string Surname)
        {
            throw new System.NotImplementedException();
        }

        public Task<Employee_Type[]> GetAllEmployee_Types()
        {
            throw new System.NotImplementedException();
        }

        public Task<Employee_Type[]> GetAllEmployee_TypesAsync(string Teacher, string Cook, string Gardener, string Administrator, string Principal)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }
    }
}
