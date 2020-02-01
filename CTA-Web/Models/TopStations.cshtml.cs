using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace program.Pages
{
    public class TopStationsModel : PageModel
    {
        public List<Models.Station> StationList { get; set; }
        
        public Exception EX { get; set; }

        public void OnGet()
        {
            StationList = new List<Models.Station>();

            EX = null;


            try
            {
                string sql = string.Format(@"
Select top 10 Stations.Name, sum(DailyTotal) AS TotalRidership
FROM Stations
INNER Join Riderships On Riderships.StationID = Stations.StationID
GROUP by Stations.Name
ORDER By TotalRidership DESC
");

                DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Models.Station s = new Models.Station();
                    s.StationName = Convert.ToString(row["Name"]);
                    s.riderShip = Convert.ToInt32(row["TotalRidership"]);

                    if (row["TotalRidership"] == System.DBNull.Value)
                        s.AvgDailyRidership = 0;
                    else
                        s.AvgDailyRidership = Convert.ToInt32(row["TotalRidership"]);

                    StationList.Add(s);

                }
            }
            catch (Exception ex)
            {
                EX = ex;
            }
            finally
            {
                // nothing at the moment
            }
        }

    }//class
}//namespace