﻿using LoanProcessManagement.Application.Contracts.Infrastructure;
using LoanProcessManagement.Application.Contracts.Persistence;
using LoanProcessManagement.Application.Features.MailService.Query;
using LoanProcessManagement.Application.Models.Mail;
using LoanProcessManagement.Domain.CustomModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProcessManagement.Persistence.Repositories
{
    class MailServiceRepository : IMailServiceRepository
    {
        private readonly IEmailService _emailService;
        private readonly ApplicationDbContext _dbContext;

        public MailServiceRepository(ApplicationDbContext dbContext, IEmailService emailService)
        {
            _emailService = emailService;
            _dbContext = dbContext;
        }
        public async Task<bool> SendMail(SendMailServiceQuery data)
        {
           // var userDetails = await _dbContext.LpmLeadMasters.Where(x => x.FormNo == data.FormNo).FirstOrDefaultAsync();
            var results = from a in _dbContext.LpmLeadMasters 
                         join b in _dbContext.LpmLeadProcessCycles 
                         on a.Id equals b.lead_Id 
                         where (a.FormNo == data.FormNo && a.CurrentStatus == b.CurrentStatus)
                         select new
                         {
                             Email = a.CustomerEmail,
                             LoanAmount = b.LoanAmount.ToString(),
                             Name = a.FirstName + " " + a.LastName,
                             FormNo = a.FormNo

                         };
            var result = results.FirstOrDefault();
            var templates = new List<EmailTemplate>(2)
            {
               new EmailTemplate
               {
                   TemplateTypeId = 1,
                   Subject = "Added Lead",
                   Body ="Dear {0},<br><br>Loan application has been added successfully in LOS system. Please use File no. {1} for future references.<br><br>Thanks & Regards,<br>LOS Team."
               },
                new EmailTemplate
               {
                   TemplateTypeId = 2,
                   Subject = "Disbursed Lead",
                   Body ="Dear {0},<br><br>For application ref. file no {1}, Loan amount Rs. {2} has been disbursed. Please check or visit your respective branch office.<br><br>Thanks & Regards,<br>LOS Team."
               }
            };
            var details = new EmailTemplate();
         
            if (data.MailTypeId == 2)
            {
                details = templates.Where(x => x.TemplateTypeId ==2).FirstOrDefault();
               
                details.Body = details.Body.Replace("{0}", result.Name);
                details.Body = details.Body.Replace("{1}", result.FormNo);
                details.Body = details.Body.Replace("{2}", result.LoanAmount);
            }
            else if(data.MailTypeId == 1)
            {
                details = templates.Where(x => x.TemplateTypeId == 1).FirstOrDefault();
                details.Body = details.Body.Replace("{0}", result.Name);
                details.Body = details.Body.Replace("{1}", result.FormNo);
            }
            var SendEmail = new Email()
            {
                To = result.Email,
                Subject = details.Subject,
                Body = details.Body
            };
            var email =  _emailService.SendEmail(SendEmail);
            
            if (email.Result == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



    }
}