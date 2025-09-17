using ApplicationTracking.DTOs;
using ApplicationTracking.Models;
using ApplicationTracking.Repositories.Interface;

namespace ApplicationTracking.Services;

public class JobApplicationService : IJobApplicationRepository
{
    private readonly IJobApplicationRepository _jobApplicationRepository;

    public JobApplicationService(IJobApplicationRepository jobApplicationRepository)
    {
        _jobApplicationRepository = jobApplicationRepository;
    }
    public async Task<PagedResult<JobApplication>> GetJobApplications(PaginationParameters paginationParameters)
    {
        return await _jobApplicationRepository.GetJobApplications(paginationParameters);
    }

    public async Task<JobApplication> GetJobApplicationById(int id)
    {
        return await _jobApplicationRepository.GetJobApplicationById(id);
    }

    public async Task<JobApplication> CreateJobApplication(JobApplication jobApplication)
    {
        return await _jobApplicationRepository.CreateJobApplication(jobApplication);
    }

    public async Task<JobApplication> UpdateJobApplication(JobApplication jobApplication)
    {
        return await _jobApplicationRepository.UpdateJobApplication(jobApplication);
    }

    public async Task<bool> DeleteJobApplication(int id)
    {
        return await _jobApplicationRepository.DeleteJobApplication(id);
    }
}