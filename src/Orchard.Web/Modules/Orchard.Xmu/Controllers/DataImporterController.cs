﻿using Orchard.Xmu.Service.DataImport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{
    public class DataImporterController : Controller
    {
        private IDataImporter _dataImporter;
        public DataImporterController(
             IDataImporter dataImporter

            )
        {
            _dataImporter = dataImporter;
        }

        /// <summary>
        /// 学院新闻
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportCollegeNews()
        {
            _dataImporter.ImportCollegeNews();
            return View("Index");

        }

        /// <summary>
        /// 院务通知
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportCollegeAffairsNotify()
        {
            _dataImporter.ImportCollegeAffairsNoti();
            return View("Index");
        }

        /// <summary>
        /// 本科生教务
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportUndergraduateAffairs()
        {
            _dataImporter.ImportUndergraduateAffairs();
            return View("Index");

        }
        /// <summary>
        /// 研究生教务 
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportGraduateAffairs()
        {
            _dataImporter.ImportGraduateAffairs();
            return View("Index");
        }

        /// <summary>
        /// 学生资讯
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportStudentInfo()
        {
            _dataImporter.ImportStudentInfo();
            return View("Index");

        }

        /// <summary>
        /// 党院教务公开
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportPartyCollegeAffairs()
        {

            _dataImporter.ImportPartyCollegeAffairs();
            return View("Index");

        }
    }
}