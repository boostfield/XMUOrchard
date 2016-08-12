﻿using Orchard.Security.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Environment.Extensions.Models;

namespace Orchard.Xmu
{
    public class Permissions : IPermissionProvider
    {
        public static readonly Permission ManageCollegeNews = new Permission
        {
            Description = XmContentType.CollegeNews.PermissionDesc,
            Name = string.Format("Manage{0}",XmContentType.CollegeNews.ContentTypeName)
        };


        public static readonly Permission ManageCollegeAffairsNotify = new Permission
        {
            Description = XmContentType.CollegeAffairsNotify.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.CollegeAffairsNotify.ContentTypeName)
        };


        public static readonly Permission ManageUndergraduateAffairs = new Permission
        {
            Description = XmContentType.UndergraduateAffairs.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.UndergraduateAffairs.ContentTypeName)
        };


        public static readonly Permission ManageGraduateAffairs = new Permission
        {
            Description = XmContentType.GraduateAffairs.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.GraduateAffairs.ContentTypeName)
        };


        public static readonly Permission ManageStudentInfo = new Permission
        {
            Description = XmContentType.StudentInfo.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.StudentInfo.ContentTypeName)
        };


        public static readonly Permission ManagePublicPartyCollegeAffairs = new Permission
        {
            Description = XmContentType.PublicPartyCollegeAffairs.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.PublicPartyCollegeAffairs.ContentTypeName)
        };


        public static readonly Permission ManageRecruitInfo = new Permission
        {
            Description = XmContentType.RecruitInfo.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.RecruitInfo.ContentTypeName)
        };


        public static readonly Permission ManageLectureInfo = new Permission
        {
            Description = XmContentType.LectureInfo.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.LectureInfo.ContentTypeName)
        };
        public virtual Feature Feature { get; set; }


        public IEnumerable<PermissionStereotype> GetDefaultStereotypes()
        {
            return new[] {
                new PermissionStereotype {
                    Name = "Administrator",
                    Permissions = new[] { ManageCollegeNews,
                        ManageCollegeAffairsNotify,
                    ManageUndergraduateAffairs,
                    ManageGraduateAffairs,
                    ManageStudentInfo,
                    ManagePublicPartyCollegeAffairs,
                    ManageRecruitInfo,
                    ManageLectureInfo,



                    }
                },
                new PermissionStereotype {
                    Name = "Editor",
                    Permissions = new[] { ManageCollegeNews, ManageCollegeAffairsNotify,
                    ManageUndergraduateAffairs,
                                        ManageGraduateAffairs,
                    ManageStudentInfo,
                    ManagePublicPartyCollegeAffairs,
                    ManageRecruitInfo,
                    ManageLectureInfo,
                    }
                },
                new PermissionStereotype {
                    Name = "Moderator",
                    Permissions = new[] { ManageCollegeNews, ManageCollegeAffairsNotify,
                    ManageUndergraduateAffairs,
                                        ManageGraduateAffairs,
                    ManageStudentInfo,
                    ManagePublicPartyCollegeAffairs,
                    ManageRecruitInfo,
                    ManageLectureInfo,
                    }
                },
                new PermissionStereotype {
                    Name = "Author",
                },
                new PermissionStereotype {
                    Name = "Contributor",
                },
            };
        }

        public IEnumerable<Permission> GetPermissions()
        {
            return new[]
            {
               ManageCollegeNews, ManageCollegeAffairsNotify,
                    ManageUndergraduateAffairs,
                                        ManageGraduateAffairs,
                    ManageStudentInfo,
                    ManagePublicPartyCollegeAffairs,
                    ManageRecruitInfo,
            };
        }
    }
}
