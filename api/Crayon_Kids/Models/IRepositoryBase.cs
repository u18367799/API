using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crayon_Kids.Models
{
    public interface IRepositoryBase
    {

        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();
        Task<Allergy[]> GetAllAllergies();
        Task<Allergy[]> GetAllAllergiesAsync(string Allergy_Details);
        /////////////////////////////////////////////////////////////
        
        Task<Assessment[]> GetAllAssessments();
        Task<Assessment[]> GetAllAssessmentsAsync(string Assessment_Detailss);
        ///////////////////////////////////////////////////////////////
        ///
        Task<Class_Type[]> GetAllClass_Types();
        Task<Class_Type[]> GetAllClass_TypesAsync(int Grade);
        ///////////////////////////////////////////////////////////////
        ///
        Task<Employee[]> GetAllEmployees();
        Task<Employee[]> GetAllEmployeesAsync(string Name, string Surname );
        ///////////////////////////////////////////////////////////////
        ///
        Task<Employee_Type[]> GetAllEmployee_Types();
        Task<Employee_Type[]> GetAllEmployee_TypesAsync(string Teacher, string Cook, string Gardener, string Administrator, string Principal);

    }
}
