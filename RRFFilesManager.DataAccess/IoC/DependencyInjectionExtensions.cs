using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection RegisterDataAccessServices(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>();
            
            services.AddTransient<IMatterTypeRepository, MatterTypeRepository>();
            services.AddTransient<IFileRepository, FileRepository>();
            services.AddTransient<IIntakeRepository, IntakeRepository>();
            services.AddTransient<IHearAboutUsRepository, HearAboutUsRepository>();
            services.AddTransient<ILawyerRepository, LawyerRepository>();
            services.AddTransient<IMatterSubTypeRepository, MatterSubTypeRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IDisabilityInsuranceCompanyRepository, DisabilityInsuranceCompanyRepository>();
            services.AddTransient<IMobileCarrierRepository, MobileCarrierRepository>();
            services.AddTransient<IProvinceRepository, ProvinceRepository>();
            services.AddTransient<ITemplateRepository, TemplateRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<ICompanyRepository, CompanyRepository>();
            services.AddTransient<IArchiveRepository, ArchiveRepository>();
            services.AddTransient<IGroupRepository, GroupRepository>();
            services.AddTransient<IPositionRepository, PositionRepository>();
            services.AddTransient<IDocumentGroupRepository, DocumentGroupRepository>();
            services.AddTransient<IDocumentCategoryRepository, DocumentCategoryRepository>();
            services.AddTransient<IDocumentTypeRepository, DocumentTypeRepository>();
            services.AddTransient<IUploadArchivesSettingsRepository, UploadArchivesSettingsRepository>();
            services.AddTransient<IComissionCalculatorRepository, ComissionCalculatorRepository>();
            services.AddTransient<IPharmacyRepository, PharmacyRepository>();
            services.AddTransient<IDrugRepository, DrugRepository>();
            services.AddTransient<IOutOfPocketHealthCareExpRepository, OutOfPocketHealthCareExpRepository>();
            services.AddTransient<IMedicalSummaryRepository, MedicalSummaryRepository>();
            services.AddTransient<IGenericRepository<ComissionSubType>, ComissionSubTypeRepository>();
            services.AddTransient<IFileReviewRepository, FileReviewRepository>();
            return services;
        }
    }
}
