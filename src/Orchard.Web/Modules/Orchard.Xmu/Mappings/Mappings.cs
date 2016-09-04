﻿using Orchard.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Utility;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using Orchard.Xmu.Models;

namespace Orchard.Xmu.Mappings
{
    public class Mappings : ISessionConfigurationEvents
    {
        public void Building(global::NHibernate.Cfg.Configuration cfg)
        {

        }

        public void ComputingHash(Hash hash)
        {

        }

        public void Created(global::FluentNHibernate.Cfg.FluentConfiguration cfg, global::FluentNHibernate.Automapping.AutoPersistenceModel defaultModel)
        {
            defaultModel.Override<ENTeacherPartRecord>(x=>
            {
                x.HasManyToMany(y => y.RecordCourses)
                .Cascade.All()
                .Table("Orchard_Xmu_TeacherCourseRelationRecord");
            });

            defaultModel.Override<ENCoursesPartRecord>(x =>
            {
                x.HasManyToMany(y => y.RecordTeachers)
                .Cascade.All().Inverse()
                .Table("Orchard_Xmu_TeacherCourseRelationRecord");
            });



        }

        public void Finished(global::NHibernate.Cfg.Configuration cfg)
        {

        }

        public void Prepared(global::FluentNHibernate.Cfg.FluentConfiguration cfg)
        {

        }
    }
}