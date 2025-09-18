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

    [HttpPost("All")]
    public async Task<IActionResult> GetApplications([FromBody] PaginationParameters dto)
    {
        return Ok(await _jobApplicationService.GetJobApplications(dto));
    }
    [HttpPost()]
    public async Task<IActionResult> AddApplications([FromBody] JobApplicationDTO dto)
    {
        return Ok(await _jobApplicationService.CreateJobApplication(dto));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetApplicationById(string id)
    {
       return Ok( await _jobApplicationService.GetJobApplicationById(id));
    }

    [HttpPut]
    public async Task<IActionResult> UpdateApplication(JobApplication jobApplication)
    {
        return Ok(await _jobApplicationService.UpdateJobApplication(jobApplication));
    }
}