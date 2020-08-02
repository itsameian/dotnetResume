using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using API.Data;
using API.Dtos.Resume;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Services.ResumeService
{
    public class ResumeService : IResumeService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        public ResumeService(IMapper mapper, DataContext context)
        {
            this._context = context;
            this._mapper = mapper;

        }
        public async Task<ServiceResponse<List<GetJobDto>>> AddJob(AddJobDto newJob)
        {
            ServiceResponse<List<GetJobDto>> response = new ServiceResponse<List<GetJobDto>>();
            try
            {
                Job job = _mapper.Map<Job>(newJob);
                await _context.Jobs.AddAsync(job);
                await _context.SaveChangesAsync();
                response.Data = _context.Jobs.Select(j => _mapper.Map<GetJobDto>(j)).ToList();
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetResponsibilityDto>>> AddResponsibility(AddResponsibilityDto newResponsibility)
        {
            ServiceResponse<List<GetResponsibilityDto>> response = new ServiceResponse<List<GetResponsibilityDto>>();
            try
            {
                Responsibility responsibility = _mapper.Map<Responsibility>(newResponsibility);
                await _context.Responsibilities.AddAsync(responsibility);
                await _context.SaveChangesAsync();
                response.Data = await _context.Responsibilities.Select(r => _mapper.Map<GetResponsibilityDto>(r)).ToListAsync();
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetJobDto>>> DeleteJob(int id)
        {
            ServiceResponse<List<GetJobDto>> response = new ServiceResponse<List<GetJobDto>>();
            try
            {
                Job job = await _context.Jobs.FirstOrDefaultAsync(j => j.Id == id);
                _context.Jobs.Remove(job);
                await _context.SaveChangesAsync();
                response.Data = await _context.Jobs.Select(j => _mapper.Map<GetJobDto>(j)).ToListAsync();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetResponsibilityDto>>> DeleteResponsibilty(int id)
        {
            ServiceResponse<List<GetResponsibilityDto>> response = new ServiceResponse<List<GetResponsibilityDto>>();
            try
            {
                Responsibility responsibility = await _context.Responsibilities.FirstOrDefaultAsync(r => r.Id == id);
                _context.Responsibilities.Remove(responsibility);
                await _context.SaveChangesAsync();
                response.Data = await _context.Responsibilities.Select(r => _mapper.Map<GetResponsibilityDto>(r)).ToListAsync();
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetJobDto>>> GetAllJobs()
        {
            ServiceResponse<List<GetJobDto>> response = new ServiceResponse<List<GetJobDto>>();
            response.Data = await _context.Jobs.Select(j => _mapper.Map<GetJobDto>(j)).ToListAsync();
            return response;
        }

        public async Task<ServiceResponse<GetJobDto>> GetJobById(int id)
        {
            ServiceResponse<GetJobDto> response = new ServiceResponse<GetJobDto>();
            try
            {
                Job job = await _context.Jobs.FirstOrDefaultAsync(j => j.Id == id);
                await _context.Jobs.AddAsync(job);
                await _context.SaveChangesAsync();
                response.Data = _mapper.Map<GetJobDto>(job);
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetResponsibilityDto>>> GetJobResponsibilities(int jobId)
        {
            ServiceResponse<List<GetResponsibilityDto>> response = new ServiceResponse<List<GetResponsibilityDto>>();
            response.Data = await _context.Responsibilities.Select(r => _mapper.Map<GetResponsibilityDto>(r)).ToListAsync();
            return response;
        }

        public async Task<ServiceResponse<GetResponsibilityDto>> GetResponsibilityById(int id)
        {
            ServiceResponse<GetResponsibilityDto> response = new ServiceResponse<GetResponsibilityDto>();
            try
            {
                Responsibility responsibility = await _context.Responsibilities.FirstOrDefaultAsync(r => r.Id == id);
                response.Data = _mapper.Map<GetResponsibilityDto>(responsibility);
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<GetJobDto>> UpdateJob(UpdateJobDto updatedJob)
        {
            ServiceResponse<GetJobDto> response = new ServiceResponse<GetJobDto>();
            try
            {
                Job job = await _context.Jobs.FirstOrDefaultAsync(j => j.Id == updatedJob.Id);
                job.Company = updatedJob.Company;
                job.Title = updatedJob.Title;
                job.StartDate = updatedJob.StartDate;
                job.EndDate = updatedJob.EndDate;

                response.Data = _mapper.Map<GetJobDto>(job);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<GetResponsibilityDto>> UpdateResponsibility(UpdateResponsibilityDto updatedResponsibility)
        {
            ServiceResponse<GetResponsibilityDto> response = new ServiceResponse<GetResponsibilityDto>();
            response.Success = false;
            response.Message = "Method not yet implemented.";
            return response;
        }
    }
}