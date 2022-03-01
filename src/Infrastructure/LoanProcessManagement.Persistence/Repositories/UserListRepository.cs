﻿using LoanProcessManagement.Application.Contracts.Infrastructure;
using LoanProcessManagement.Application.Contracts.Persistence;
using LoanProcessManagement.Domain.CustomModels;
using LoanProcessManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProcessManagement.Persistence.Repositories
{
    public class UserListRepository : BaseRepository<IEnumerable<UserMasterListModel>>, IUserListRepository
    {
        private readonly ILogger _logger;
        private readonly IEmailService _emailService;
        public UserListRepository(ApplicationDbContext dbContext, ILogger<IEnumerable<UserMasterListModel>> logger, IEmailService emailService) : base(dbContext, logger, emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        #region Get All User List - Saif Khan - 30/10/2021
        /// <summary>
        /// 2021/10/30 -  Get All User List API Call
        /// Commented By Saif Khan
        /// </summary>
        /// <returns>UserListResponse</returns>
        public async Task<IEnumerable<UserMasterListModel>> GetUserList()
        {
            var result = (from A in _dbContext.LpmUserMasters
                          join B in _dbContext.LpmBranchMasters on A.BranchId equals B.Id

                          select new UserMasterListModel
                          {
                              Id = A.Id,
                              BranchId = A.BranchId,
                              LgId = A.LgId,
                              EmployeeId = A.EmployeeId,
                              Name = A.Name,
                              Email = A.Email,
                              BranchName = B.branchname,
                              PhoneNumber = A.PhoneNumber,
                              StaffType = A.StaffType,
                              IsActive = A.IsActive,
                              IsLocked = A.IsLocked
                          });
            var res = await result.OrderByDescending(x => x.Id).ToListAsync();

            return res;
        }
        #endregion

        #region Get All Locked User List - Pratiksha Poshe - 12/12/2021
        /// <summary>
        /// 12/12/2021 -  Get All Locked User List
        /// Commented By Pratiksha Poshe
        /// </summary>
        /// <returns>Locked User List Response</returns>
        public async Task<IEnumerable<UserMasterListModel>> GetLockedUserList()
        {
            var result = await (from A in _dbContext.LpmUserMasters
                                join B in _dbContext.LpmBranchMasters on A.BranchId equals B.Id
                                where A.IsLocked
                                select new UserMasterListModel
                                {
                                    Id = A.Id,
                                    BranchId = A.BranchId,
                                    LgId = A.LgId,
                                    EmployeeId = A.EmployeeId,
                                    Name = A.Name,
                                    Email = A.Email,
                                    BranchName = B.branchname,
                                    PhoneNumber = A.PhoneNumber,
                                    StaffType = A.StaffType,
                                    IsActive = A.IsActive,
                                    IsLocked = A.IsLocked
                                }).ToListAsync();
            return result;
        }
        #endregion
    }
}
