using ClassLibrary1;
using ClassLibrary1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Persistance.Context
{
    public class ClassLibraryDbContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ClassLibraryDbContext(DbContextOptions<ClassLibraryDbContext> options) : base(options)
        {
            try
            {
                _httpContextAccessor = this.GetInfrastructure().GetRequiredService<IHttpContextAccessor>();
            }
            catch
            {
                _httpContextAccessor = new HttpContextAccessor();
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClassLibraryDbContext).Assembly);
        }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupPerson> GroupPersons { get; set; }
        public virtual DbSet<Path> Paths { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonAddress> PersonAddresss { get; set; }
        public virtual DbSet<PersonAddressType> PersonAddressTypes { get; set; }
        public virtual DbSet<PersonBankAccount> PersonBankAccounts { get; set; }
        public virtual DbSet<PersonContact> PersonContacts { get; set; }
        public virtual DbSet<PersonContactType> PersonContactTypes { get; set; }
        public virtual DbSet<PersonPersonStatus> PersonPersonStatuses { get; set; }
        public virtual DbSet<PersonSchedule> PersonSchedules { get; set; }
        public virtual DbSet<PersonStatus> PersonStatuses { get; set; }
        public virtual DbSet<PersonType> PersonTypes { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<SchedulePerson> SchedulePersons { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<SubjectSchedule> SubjectSchedules { get; set; }

        public IDbContextTransaction ContextTransaction
        {
            get { return Database.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted); }
            set { throw new NotImplementedException(); }
        }

        //public override int SaveChanges()
        //{
        //    AddTimestamps();
        //    return base.SaveChanges();
        //}
        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        //{
        //    AddTimestamps();
        //    return base.SaveChangesAsync(cancellationToken);
        //}
        //private void AddTimestamps()
        //{
        //    var entities = ChangeTracker.Entries().Where(x => x.Entity is Base && (x.State == EntityState.Added || x.State == EntityState.Modified));
        //    var currentUser = _httpContextAccessor?.HttpContext?.User ?? null;
        //    var currentApplicationId = currentUser?.Claims?.FirstOrDefault(x => x.Type == "client_id")?.Value ?? string.Empty;
        //    var currentUserId = currentUser?.Claims?.FirstOrDefault(x => x.Type == "sub")?.Value ?? string.Empty;
        //    int? currentCustomerId = null;
        //    if (currentUserId != null && currentUserId != string.Empty)
        //        currentCustomerId = Customers.FirstOrDefault(x => x.UserId == currentUserId)?.Id;
        //    foreach (var entity in entities)
        //    {
        //        if (entity.State == EntityState.Added)
        //        {
        //            ((Base)entity.Entity).CreateDate = DateTime.Now;
        //            ((Base)entity.Entity).CreateAppId = currentApplicationId;
        //            ((Base)entity.Entity).CreateCustomerId = currentCustomerId;
        //        }
        //        else
        //        {
        //            ((Base)entity.Entity).LastModifiedDate = DateTime.Now;
        //            ((Base)entity.Entity).LastModifiedAppId = currentApplicationId;
        //            ((Base)entity.Entity).LastModifiedCustomerId = currentCustomerId;
        //        }
        //    }
        //}
    }
}
