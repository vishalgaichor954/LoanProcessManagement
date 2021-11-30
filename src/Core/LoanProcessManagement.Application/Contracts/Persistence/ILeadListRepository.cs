﻿using LoanProcessManagement.Application.Features.LeadList.Commands.AddLead;
using LoanProcessManagement.Application.Features.LeadList.Query.LeadHistory;
using LoanProcessManagement.Application.Features.LeadList.Commands.UpdateLead;
using LoanProcessManagement.Application.Features.LeadList.Queries;
using LoanProcessManagement.Application.Responses;
using LoanProcessManagement.Domain.CustomModels;
using LoanProcessManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanProcessManagement.Application.Contracts.Persistence
{
    public interface ILeadListRepository 
    {
        Task<IEnumerable<LeadListModel>> GetAllLeadList();
        Task<IEnumerable<LeadHistoryQueryVm>> GetLeadhistory(string lead_id);
        Task<AddLeadDto> AddLeadAsync(LpmLeadMaster request);
        Task<GetLeadByLeadIdDto> GetLeadByLeadId(string lead_id);
        Task<UpdateLeadDto> ModifyLead(UpdateLeadCommand request);


    }
}
