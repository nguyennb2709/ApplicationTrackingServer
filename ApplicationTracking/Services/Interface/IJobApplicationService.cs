using ApplicationTracking.DTOs;
using ApplicationTracking.Models;

namespace ApplicationTracking.Services.Interface;

public interface IJobApplicationService
{
    Task<PagedResult<JobApplication>> GetJobApplications(PaginationParameters paginationParameters);
    Task<JobApplication> GetJobApplicationById(int id);
    Task<JobApplication> CreateJobApplication(JobApplication jobApplication);
    Task<JobApplication> UpdateJobApplication(JobApplication jobApplication);
    Task<bool> DeleteJobApplication(int id);
}