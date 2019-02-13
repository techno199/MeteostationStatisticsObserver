using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteostationStatisticsObserver
{
    public class Constants
    {
        public const string DomainAddress = "https://localhost:5001/api/";
        public const string ApiGetUsers = "statistics/getusers";
        public const string ApiGetStats = "statistics/getstats";

        public const string ApiDateTimeFormat = "yyyyMMddHHmmss";

        public const string FormDataKeyStartTime = "startTime";
        public const string FormDataKeyEndTime = "endTime";
        public const string FormDataKeyRowsCount = "rowsCount";
        public const string FormDataKeyUserName = "userName";
        public const string FormDataKetSampleSize = "sampleSize";
    }
}
