using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public interface IExamRepository
    {
        IEnumerable<Exam> GetAllExam(int branchId, int year);
        IEnumerable<Exam> GetExamtypeWiseAllExam(int branchId, int year, string examType);
        Exam getExam(int id);
        public Task<Exam> DeleteExam(int id);
        public Task<Exam> AddNewExam(Exam exam);
    }
}
