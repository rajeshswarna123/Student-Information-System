using SIS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Interfaces.Repositories
{
    public interface IClassRepository
    {
        Class GetClassByID(long classId);

        List<Class> GetClasses();
        
    }
}
