﻿using Orchard.ContentManagement.Drivers;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;

namespace Orchard.Xmu.Drivers
{
    public class AcademicPaperPartDriver: ContentPartDriver<AcademicPaperPart>
    {
        private readonly IOrchardServices _orchardServices;

        public AcademicPaperPartDriver(IOrchardServices orchardServices)
        {
            _orchardServices = orchardServices;

        }
        protected override DriverResult Editor(AcademicPaperPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            var oldTeachers = part.Record.RecordCNTeachers;

            updater.TryUpdateModel(part, Prefix, null, null);
            if (part.RelatedTeachers == null)
            {
                part.RelatedTeachers = new List<string>();
            }
            var teacherMaintained = Extension.Extensions.Maintains(oldTeachers, part.RelatedTeachers.Select(i => int.Parse(i)).ToList());
            foreach (var teacher in teacherMaintained.Item1)
            {
                part.Record.RecordCNTeachers.Remove(teacher);
            }

            foreach (var id in teacherMaintained.Item2)
            {
                var teacherPart = _orchardServices.ContentManager.Get<CNTeacherPart>(id, VersionOptions.Latest);
                if (teacherPart != null)
                {
                    part.Record.RecordCNTeachers.Add(teacherPart.Record);
                }
            }
            return Editor(part, shapeHelper);
        }


        protected override DriverResult Editor(AcademicPaperPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_AcademicPaperPart_Edit",
                         () => shapeHelper.EditorTemplate(
                             TemplateName: "Parts/AcademicPaperPart",
                              Model: part,
                              Prefix: Prefix));
        }
    }
}