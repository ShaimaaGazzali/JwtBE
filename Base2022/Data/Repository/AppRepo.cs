using Base2022.Data;
using Base2022.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BE_Base2022.Repository
{
    public class AppRepo: IAppRepo
    {
        private readonly AppDbContext _context;
        public AppRepo(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task CreateDepartment(Department dept)
        {
           await _context.Departments.AddAsync(dept);
            await _context.SaveChangesAsync();
        }

        public async Task CreateTask(TaskK task)
        {
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TaskK>> GetTasks()
        {
            return  _context.Tasks.Include(x=>x.Employee).ToList();
        }
    }
}
