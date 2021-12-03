﻿using LoanProcessManagement.Application.Features.Branch.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanProcessManagement.Api.Controllers.v1
{
  
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly ILogger<BranchController> _logger;
        private readonly IMediator _mediator;

        public BranchController(ILogger<BranchController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }


        #region Api which will get all branches in db by - Akshay Pawar - 31/10/2021
        /// <summary>
        /// 31/10/2021 - Api which will get all branches in db
        //	commented by Akshay
        /// </summary>
        /// <returns>Response</returns>
        [HttpGet("GetBranches")]
        public async Task<ActionResult> GetBranches()
        {
            _logger.LogInformation("GetBranches Initiated");
            var dtos = await _mediator.Send(new GetAllBranchesQuery());
            _logger.LogInformation("GetBranches Completed");
            return Ok(dtos);
        } 
        #endregion
    }
}