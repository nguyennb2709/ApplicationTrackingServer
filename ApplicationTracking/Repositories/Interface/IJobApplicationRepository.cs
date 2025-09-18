using ApplicationTracking.DTOs;
using ApplicationTracking.Models;

namespace ApplicationTracking.Repositories.Interface;

public interface IJobApplicationRepository
{
    Task<PagedResult<JobApplication>> GetJobApplications(PaginationParameters paginationParameters);
    Task<JobApplication> GetJobApplicationById(string id);
    Task<JobApplication> CreateJobApplication(JobApplicationDTO jobApplication);
    Task<JobApplication> UpdateJobApplication(JobApplication jobApplication);
}