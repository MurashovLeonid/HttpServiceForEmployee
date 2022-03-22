using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using xxXXXxxx.xxXXXxxx.ru.Models;

namespace xxXXXxxx.xxXXXxxx.ru.Context
{
    public partial class SupportWebContext : DbContext
    {
        public SupportWebContext()
        {
        }

        public SupportWebContext(DbContextOptions<SupportWebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Org> Orgs { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .IsClustered(false);

                entity.ToTable("Employee");

                entity.HasComment("Сотрудники");

                entity.HasIndex(e => e.EmpMail, "IX_Employee_emp_mail");

                entity.HasIndex(e => e.EmpName, "IX_Employee_emp_name");

                entity.HasIndex(e => e.EmpOrg, "IX_Employee_emp_org");

                entity.HasIndex(e => e.FlDeleted, "IX_Employee_fl_deleted");

                entity.HasIndex(e => new { e.FlDeleted, e.EmpId }, "IX_Employee_fl_deleted_emp_id");

                entity.HasIndex(e => new { e.FlDeleted, e.EmpName }, "IX_Employee_fl_deleted_emp_name");

                entity.HasIndex(e => new { e.FlDeleted, e.EmpOrg }, "IX_Employee_fl_deleted_emp_org");

                entity.HasIndex(e => new { e.FlDeleted, e.EmpLogon }, "IX_fl_deleted_emp_logon");

                entity.HasIndex(e => new { e.FlDeleted, e.EmpPrivate, e.EmpTitle }, "missing_index_2702856_2702855_Employee");

                entity.HasIndex(e => e.EmpName, "missing_index_2703294_2703293_Employee");

                entity.HasIndex(e => e.EmpLogin, "missing_index_2711219_2711218_Employee");

                entity.HasIndex(e => new { e.EmpTrainingsSync, e.EmpTrainingsSyncError, e.EmpFname, e.EmpLname, e.EmpMail }, "missing_index_4751_4750_Employee");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.EmpAdBlocked)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("emp_ad_blocked")
                    .IsFixedLength();

                entity.Property(e => e.EmpAdChanged)
                    .HasColumnType("datetime")
                    .HasColumnName("emp_ad_changed");

                entity.Property(e => e.EmpBeginnerWelcomeSended).HasColumnName("emp_beginner_welcome_sended");

                entity.Property(e => e.EmpBirthday)
                    .HasColumnType("datetime")
                    .HasColumnName("emp_birthday");

                entity.Property(e => e.EmpEmploymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("emp_employment_date");

                entity.Property(e => e.EmpFname)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("emp_fname");

                entity.Property(e => e.EmpHomepage)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("emp_homepage");

                entity.Property(e => e.EmpHostname)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("emp_hostname");

                entity.Property(e => e.EmpHostnameDate)
                    .HasColumnType("datetime")
                    .HasColumnName("emp_hostname_date");

                entity.Property(e => e.EmpInformationSecuritySent).HasColumnName("emp_information_security_sent");

                entity.Property(e => e.EmpLname)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("emp_lname");

                entity.Property(e => e.EmpLogin)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("emp_login");

                entity.Property(e => e.EmpLogon)
                    .HasColumnType("datetime")
                    .HasColumnName("emp_logon");

                entity.Property(e => e.EmpMail)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("emp_mail");

                entity.Property(e => e.EmpMainLevelHelpDesk).HasColumnName("emp_MainLevelHelpDesk");

                entity.Property(e => e.EmpMname)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("emp_mname");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpNeedWelcMess)
                    .IsRequired()
                    .HasColumnName("emp_need_welc_mess")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmpNewSupportPhoto)
                    .HasColumnType("image")
                    .HasColumnName("emp_new_support_photo");

                entity.Property(e => e.EmpNotShowBeginner).HasColumnName("emp_not_show_beginner");

                entity.Property(e => e.EmpOrg).HasColumnName("emp_org");

                

                entity.Property(e => e.EmpPriority)
                    .HasColumnName("emp_priority")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.EmpPrivate).HasColumnName("emp_private");

                entity.Property(e => e.EmpProfSync).HasColumnName("emp_profSync");

                entity.Property(e => e.EmpProfSyncError).HasColumnName("emp_profSyncError");

                entity.Property(e => e.EmpRemoteComment)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("emp_remote_comment")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpRemoteConnect)
                    .HasColumnName("emp_remote_connect")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpRemoteError)
                    .HasColumnName("emp_remote_error")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpRemoteFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("emp_remote_from");

                entity.Property(e => e.EmpRemoteQuery)
                    .HasColumnName("emp_remote_query")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpRemoteReady)
                    .HasColumnName("emp_remote_ready")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpRemoteRights)
                    .HasColumnName("emp_remote_rights")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpRemoteTill)
                    .HasColumnType("datetime")
                    .HasColumnName("emp_remote_till");

                entity.Property(e => e.EmpSentWelcMess).HasColumnName("emp_sent_welc_mess");

                entity.Property(e => e.EmpSex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("emp_sex")
                    .IsFixedLength();

                entity.Property(e => e.EmpTabNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("emp_tab_number");

                entity.Property(e => e.EmpTitle)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("emp_title");

                entity.Property(e => e.EmpTrainingsSync).HasColumnName("emp_trainingsSync");

                entity.Property(e => e.EmpTrainingsSyncError).HasColumnName("emp_trainingsSyncError");

                entity.Property(e => e.FlChanged)
                    .HasColumnType("datetime")
                    .HasColumnName("fl_changed");

                entity.Property(e => e.FlCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("fl_created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlDeleted)
                    .HasColumnType("datetime")
                    .HasColumnName("fl_deleted");

               

                entity.HasOne(d => d.EmpOrgNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmpOrg)
                    .HasConstraintName("FK_Employee_Orgs");
            });

            modelBuilder.Entity<Org>(entity =>
            {
                entity.HasKey(e => e.OrgId)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.FlDeleted, e.OrgHidden }, "IX_Orgs_fl_deleted_org_hidden");

                entity.HasIndex(e => new { e.FlDeleted, e.OrgName }, "IX_Orgs_fl_deleted_org_name");

                entity.HasIndex(e => e.OrgId, "IX_Orgs_org_id");

                entity.HasIndex(e => e.OrgName, "IX_Orgs_org_name");

                entity.HasIndex(e => e.OrgName, "IX_Orgs_org_name1");

                entity.HasIndex(e => e.OrgSname, "IX_Orgs_org_sname");

                entity.HasIndex(e => e.OrgParentOrgId, "IX_org_parent_org_id")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FlDeleted)
                    .HasColumnType("datetime")
                    .HasColumnName("fl_deleted");

                entity.Property(e => e.FlUpdated)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("fl_updated");

                entity.Property(e => e.OrgBoss).HasColumnName("org_boss");

                entity.Property(e => e.OrgCode)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("org_code");

                entity.Property(e => e.OrgDescription)
                    .IsUnicode(false)
                    .HasColumnName("org_description");

                entity.Property(e => e.OrgGroupId)
                    .HasColumnName("org_group_id")
                    .HasComment("иерархия отделов по группам");

                entity.Property(e => e.OrgHidden).HasColumnName("org_hidden");

                entity.Property(e => e.OrgName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("org_name")
                    .HasComment("Название отдела");

                entity.Property(e => e.OrgOrder).HasColumnName("org_order");

                entity.Property(e => e.OrgParentDepId)
                    .HasColumnName("org_parent_dep_id")
                    .HasComment("иерархия департаментов");

                entity.Property(e => e.OrgParentOrgId)
                    .HasColumnName("org_parent_org_id")
                    .HasComment("иерархия отделов");

                entity.Property(e => e.OrgSkipCode).HasColumnName("org_skip_code");

                entity.Property(e => e.OrgSname)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("org_sname");

                entity.Property(e => e.OrgTabNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("org_tab_number");

                entity.Property(e => e.OrgTitle)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("org_title");

                entity.HasOne(d => d.OrgBossNavigation)
                    .WithMany(p => p.Orgs)
                    .HasForeignKey(d => d.OrgBoss)
                    .HasConstraintName("FK_Orgs_Boss");

                entity.HasOne(d => d.OrgParentDep)
                    .WithMany(p => p.InverseOrgParentDep)
                    .HasForeignKey(d => d.OrgParentDepId)
                    .HasConstraintName("FK_Orgs_Deps");

                entity.HasOne(d => d.OrgParentOrg)
                    .WithMany(p => p.InverseOrgParentOrg)
                    .HasForeignKey(d => d.OrgParentOrgId)
                    .HasConstraintName("FK_Orgs_Orgs");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
