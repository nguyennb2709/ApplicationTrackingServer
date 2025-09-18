using ApplicationTracking.DTOs;
using ApplicationTracking.Models;

namespace ApplicationTracking.Services.Interface;

public interface IJobApplicationService
{
    Task<PagedResult<JobApplication>> GetJobApplications(PaginationParameters paginationParameters);
    Task<JobApplication> GetJobApplicationById(string id);
    Task<JobApplication> CreateJobApplication(JobApplicationDTO jobApplication);
    Task<JobApplication> UpdateJobApplication(JobApplication jobApplication);
    Task<bool> DeleteJobApplication(string id);
}