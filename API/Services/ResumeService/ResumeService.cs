using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnetResume.Data;
using dotnetResume.Dtos.Resume;
using dotnetResume.Models;
using dotnetResume.Services;
using Microsoft.EntityFrameworkCore;

namespace dotnetResume.Services.ResumeService
{
    public class ResumeService : IResumeService
    {
        private List<Responsibility> Responsibilities = new List<Responsibility>();
        private List<Job> Jobs = new List<Job>{
            new Job{
                Id = 1,
                Title = "Big Data Engineer",
                Company = "Allstate",
                StartDate = Convert.ToDateTime("04/27/2018"),
                EndDate = Convert.ToDateTime("07/03/2020")
            },
            new Job{
                Id = 2,
                Title = "Full Stack Engineer",
                Company = "Allstate",
                StartDate = Convert.ToDateTime("12/27/2015"),
                EndDate = Convert.ToDateTime("04/27/2018")
            }
        };
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
            Job job = _mapper.Map<Job>(newJob);
            await _context.Jobs.AddAsync(job);
            await _context.SaveChangesAsync();
            response.Data = _context.Jobs.Select(j => _mapper.Map<GetJobDto>(j)).ToList();
            return response;
        }

        public async Task<ServiceResponse<List<Responsibility>>> AddResponsibility(Responsibility newResponsibility)
        {
            ServiceResponse<List<Responsibility>> response = new ServiceResponse<List<Responsibility>>();
            Responsibility responsibility = _mapper.Map<Responsibility>(newResponsibility);
            await _context.Responsibilities.AddAsync(newResponsibility);
            await _context.SaveChangesAsync();
            response.Data = Responsibilities;
            return response;
        }

        public async Task<ServiceResponse<List<GetJobDto>>> DeleteJob(int id)
        {
            ServiceResponse<List<GetJobDto>> response = new ServiceResponse<List<GetJobDto>>();
            try
            {
                Job job = Jobs.FirstOrDefault(j => j.Id == id);
                Jobs.Remove(job);
                response.Data = Jobs.Select(j => _mapper.Map<GetJobDto>(j)).ToList();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<Responsibility>>> DeleteResponsibilty(int id)
        {
            ServiceResponse<List<Responsibility>> response = new ServiceResponse<List<Responsibility>>();
            Responsibility responsibility = Responsibilities.FirstOrDefault(r => r.Id == id);
            Responsibilities.Remove(responsibility);
            response.Data = Responsibilities;
            return response;
        }

        public async Task<ServiceResponse<List<GetJobDto>>> GetAllJobs()
        {
            ServiceResponse<List<GetJobDto>> response = new ServiceResponse<List<GetJobDto>>();
            List<Job> Jobs = await _context.Jobs.ToListAsync();
            response.Data = (Jobs.Select(j => _mapper.Map<GetJobDto>(j))).ToList();
            return response;
        }

        public async Task<ServiceResponse<GetJobDto>> GetJobById(int id)
        {
            ServiceResponse<GetJobDto> response = new ServiceResponse<GetJobDto>();
            response.Data = _mapper.Map<GetJobDto>(Jobs.First(j => j.Id == id));
            return response;
        }

        public async Task<ServiceResponse<List<Responsibility>>> GetJobResponsibilities(int jobId)
        {
            ServiceResponse<List<Responsibility>> response = new ServiceResponse<List<Responsibility>>();
            response.Data = Responsibilities;
            return response;
        }

        public async Task<ServiceResponse<Responsibility>> GetResponsibilityById(int id)
        {
            ServiceResponse<Responsibility> response = new ServiceResponse<Responsibility>();
            Responsibility responsibility = Responsibilities.FirstOrDefault(r => r.Id == id);
            response.Data = responsibility;
            return response;
        }

        public async Task<ServiceResponse<GetJobDto>> UpdateJob(UpdateJobDto updatedJob)
        {
            ServiceResponse<GetJobDto> response = new ServiceResponse<GetJobDto>();
            try
            {
                Job job = Jobs.FirstOrDefault(j => j.Id == updatedJob.Id);
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

        public async Task<ServiceResponse<Responsibility>> UpdateResponsibility(Responsibility updatedResponsibility)
        {
            ServiceResponse<Responsibility> response = new ServiceResponse<Responsibility>();
            response.Success = false;
            response.Message = "Method not yet implemented.";
            return response;
        }
    }
}