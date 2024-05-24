﻿using Module06.Model;
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Threading.Tasks;

namespace Module06.ViewModel
{
   
    class EmployeeViewModel
    {
       //  public EmployeeModel EmployeeModelSet { get; set; }

    //    public EmployeeViewModel()
      //  {
      //      EmployeeModelSet = new EmployeeModel
       //     {
       //         Id = 1,
        //        Name = "Jedlan Perz",
        //        Email = "perz.jedlan@auf.edu.ph",
       //        Address = "Angeles City"
       //     };
      //  }

        private Services.DatabaseContext getContext()
        {
            return new Services.DatabaseContext();
        }
        public  int InsertEmployee(EmployeeModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Employees.Add(obj);
            int c = _dbContext.SaveChanges();
            return c;
        }

        public async Task<List<EmployeeModel>> GetAllEmployees()
        {
            var _dbContext = getContext();
            var res = await _dbContext.Employees.ToListAsync();
            return res;
        }
        public async Task<int> UpdateEmployee(EmployeeModel obj)
        {
            var _dbContext = getContext();

            _dbContext.Employees.Update(obj);
            int c = await _dbContext.SaveChangesAsync();
            return c;

        }
        public int DeleteEmployee(EmployeeModel obj) 
        {
            var _dbContext = getContext();
            _dbContext.Employees.Remove(obj);
            int c = _dbContext.SaveChanges();
            return c; 

        }
    }
}
