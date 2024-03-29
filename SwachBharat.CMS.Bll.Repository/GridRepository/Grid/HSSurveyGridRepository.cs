﻿using SwachBharat.CMS.Bll.ViewModels.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SwachBharat.CMS.Bll.Repository.GridRepository.Grid
{
    public class HSSurveyGridRepository: IDataTableRepository
    {
        IEnumerable<SBASurveyFormDetailsGrid> dataset;

        DashBoardRepository objRep = new DashBoardRepository();

        public HSSurveyGridRepository(long wildcard, string SearchString, DateTime? fdate, DateTime? tdate, int userId, int appId, string sortColumn = "", string sortColumnDir = "", string draw = "", string length = "", string start = "")
        {
            dataset = objRep.GetHSSurveyData(wildcard, SearchString, fdate, tdate, userId, appId, sortColumn, sortColumnDir, draw, length, start);
        }

        public string GetDataTabelJson(string sortColumn, string sortColumnDir, string draw, string length, string searchValue, string start)
        {
            int recordsTotal = 0;
            if (dataset != null && dataset.Count() > 0)
            {
                recordsTotal = dataset.First().totalRowCount;
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;
            var result = serializer.Serialize(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = dataset });
            return result;
        }
    }
}
