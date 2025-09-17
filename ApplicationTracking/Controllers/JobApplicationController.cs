using ApplicationTracking.DTOs;
using ApplicationTracking.Models;
using ApplicationTracking.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTracking.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobApplicationController : ControllerBase
{
    private readonly IJobApplicationService _jobApplicationService;

    public JobApplicationController(IJobApplicationService jobApplicationService)
    {
        _jobApplicationService = jobApplicationService;   
    }

    [HttpPost]
    public async Task<IActionResult> GetApplications([FromBody] PaginationParameters dto)
    {
        return Ok(await _jobApplicationService.GetJobApplications(dto));
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetApplicationById(int id)
    {
       return Ok( await _jobApplicationService.GetJobApplicationById(id));
    }

    [HttpPut]
    public async Task<IActionResult> UpdateApplication(JobApplication jobApplication)
    {
        return Ok(await _jobApplicationService.UpdateJobApplication(jobApplication));
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteApplication(int id)
    {
        return Ok(await _jobApplicationService.DeleteJobApplication(id));
    }
    
}