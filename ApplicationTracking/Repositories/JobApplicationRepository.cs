using ApplicationTracking.DTOs;
using ApplicationTracking.Models;
using ApplicationTracking.Repositories.Interface;

namespace ApplicationTracking.Repositories;

public class JobApplicationRepository : IJobApplicationRepository
{
    private readonly ApplicationDbContext _dbContext;

    public JobApplicationRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public Task<PagedResult<JobApplication>> GetJobApplications(PaginationParameters paginationParameters)
    {
        var totalApplications = _dbContext.JobApplications.AsQueryable();
        var totalItems = totalApplications.Count();
        var items = totalApplications
            .OrderByDescending(x => x.DateApplied)
            .Skip(paginationParameters.Offset)
            .Take(paginationParameters.Limit);

        return Task.FromResult(new PagedResult<JobApplication>
        {
            TotalCount = totalItems,
            Items = items
        });
    }

    public async Task<JobApplication> GetJobApplicationById(int id)
    {
        return await _dbContext.JobApplications.FindAsync(id);
    }

    public async Task<JobApplication> CreateJobApplication(JobApplication jobApplication)
    {
        _dbContext.JobApplications.Add(jobApplication);
        await _dbContext.SaveChangesAsync();
        return jobApplication;
    }

    public async Task<JobApplication> UpdateJobApplication(JobApplication jobApplication)
    {
        var existingJobApplication = await _dbContext.JobApplications.FindAsync(jobApplication.Id);
        if (existingJobApplication == null)
        {
            return null;
        }
        existingJobApplication.Company = jobApplication.Company;
        existingJobApplication.Position = jobApplication.Position;
        existingJobApplication.Status = jobApplication.Status;
        _dbContext.JobApplications.Update(jobApplication);
        await _dbContext.SaveChangesAsync();
        return jobApplication;
    }

    public async Task<bool> DeleteJobApplication(int id)
    {
        var existingJobApplication = await _dbContext.JobApplications.FindAsync(id);
        if (existingJobApplication == null)
        {
            return false;
        }
        _dbContext.JobApplications.Remove(new JobApplication { Id = id });
        await _dbContext.SaveChangesAsync();
        return true;
    }
}