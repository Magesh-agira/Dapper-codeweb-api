﻿using Dapper.Contract;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepo;

        public CompaniesController(ICompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
          
                var companies = await _companyRepo.GetCompanies();
                return Ok(companies);

        }
    }
}
