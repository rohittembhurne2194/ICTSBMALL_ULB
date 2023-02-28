using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwachBharat.CMS.Bll.Repository.GridRepository.Grid
{
    public class HSALLULBDetailsGridRepository : IDataTableRepository
    {
        IEnumerable<SBAAllULBDetails> dataset;

        DashBoardRepository objRep = new DashBoardRepository();

        public HSALLULBDetailsGridRepository(long wildcard, string SearchString,  int appId)
        {
            dataset = objRep.GetHSALLULBData(wildcard, SearchString, appId);
        }

        public string GetDataTabelJson(string sortColumn, string sortColumnDir, string draw, string length, string searchValue, string start)
        {
            var json = dataset.GetDataTableJson(sortColumn, sortColumnDir, draw, length, searchValue, start);
            return json;
        }
    }

   
}
