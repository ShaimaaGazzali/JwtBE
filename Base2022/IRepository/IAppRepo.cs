using Base2022.Data;
using Base2022.Data.Entities;
using System;
using System.Threading.Tasks;

namespace BE_Base2022.Repository
{
    public interface IAppRepo
    {

        Task CreateDepartment(Department dept);
        Task CreateTask(TaskK task);

    }
}
