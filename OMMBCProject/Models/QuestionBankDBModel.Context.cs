﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OMMBCProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OMMBCEntities : DbContext
    {
        public OMMBCEntities()
            : base("name=OMMBCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupStudent> GroupStudents { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<ProblemAnswer> ProblemAnswers { get; set; }
        public virtual DbSet<Problem> Problems { get; set; }
        public virtual DbSet<ProblemSolution> ProblemSolutions { get; set; }
        public virtual DbSet<StudentLevel> StudentLevels { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<Tutor> Tutors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}