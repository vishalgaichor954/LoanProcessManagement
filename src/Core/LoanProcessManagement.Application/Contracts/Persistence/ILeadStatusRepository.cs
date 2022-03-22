﻿using LoanProcessManagement.Application.Features.LeadStatus.Commands.CreateLeadStatus;
using LoanProcessManagement.Application.Features.LeadStatus.Commands.DeleteLeadStatus;
using LoanProcessManagement.Application.Features.LeadStatus.Commands.UpdateLeadStatus;
using LoanProcessManagement.Application.Features.LeadStatus.Queries;
using LoanProcessManagement.Application.Features.LeadStatus.Queries.GetHOSanctionListQuery;
using LoanProcessManagement.Application.Features.LeadStatus.Queries.GetPerformanceSummary;
using LoanProcessManagement.Application.Features.LineChart.Queries.GetLoanByCurrentStatus;
using LoanProcessManagement.Domain.CustomModels;
using LoanProcessManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanProcessManagement.Application.Contracts.Persistence
{
    public interface ILeadStatusRepository
    {
        Task<IEnumerable<LpmLeadStatusMaster>> GetLeadStatus(string role);
        Task<GetLeadStatusCountDto> GetLeadStatusCount(GetLeadStatusCountQuery req);
        Task<List<ProcessModel>> GetInPrincipleSanctionLists(GetInPrincipleSanctionListQuery req);
        Task<List<GetPerformanceSummaryQueryDTO>> PerformanceSummary(GetPerformanceSummaryQuery req);
        Task<List<ProcessModel>> GetHOSanctionLists(GetHOSanctionListQuery req);
        Task<List<long?>> GetLoanAmount(GetLoanByCurrentStatusQuery request);

        Task<LeadStatusDto> CreateLeadStatusCommand(LpmLeadStatusMaster request);
        Task<DeleteLeadStatusDto> DeleteLeadStatus(long id);
        Task<UpdateLeadStatusDto> UpdateLeadStatus(LpmLeadStatusMaster req);

        Task<LpmLeadStatusMaster> GetLeadStatusById(long id);

        Task<IEnumerable<LpmLeadStatusMaster>> GetAllLeadStatus();

    }
}
