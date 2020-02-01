using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace program.Pages
{
    public class StationInfoModel : PageModel
    {
        public List<Models.Station> StationList { get; set; }
        public string Input { get; set; }
        public Exception EX { get; set; }

        public void OnGet(string input)
        {

            StationList = new List<Models.Station>();

            // make input available to web page:
            Input = input;

            // clear exception:
            EX = null;

            try
            {
                //
                // Do we have an input argument?  If not, there's nothing to do:
                //
                if (input == null)
                {
                    //
                    // there's no page argument, perhaps user surfed to the page directly?  
                    // In this case, nothing to do.
                    //
                }
                else
                {

                    // 
                    // Lookup movie(s) based on input, which could be id or a partial name:
                    // 
                    string sql;

                    // lookup station(s) by partial name match:
                    input = input.Replace("'", "''");

                    sql = string.Format(@"
	                SELECT  Stations.StationID, Stations.Name, AVG(DailyTotal) AS AvgDailyRidership
                    FROM Stations
                    LEFT JOIN Riderships ON Stations.StationID = Riderships.StationID
                    LEFT JOIN Stops ON Stations.StationID = Stops.StationID
                    WHERE Stations.Name LIKE '%{0}%'
                    GROUP BY Stations.StationID, Stations.Name
                    ORDER BY Stations.Name ASC

                    SELECT  Stations.Name, ADA = Sum(Cast(case when Stops.ADA = 1 then 1 else 0 END as int)) ,
                    COUNT(Stops.StopID) As NumStoop 
                    FROM Stations
                    LEFT JOIN Stops ON Stations.StationID = Stops.StationID
                    WHERE Stations.Name LIKE '%{0}%'
                    GROUP BY Stations.Name 
                    ORDER BY Stations.Name asc", input);

                    DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);
                    List<String> adaL = new List<string>();
                    List<int> noOfstops = new List<int>();

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {


                        Models.Station s = new Models.Station();

                        s.StationID = Convert.ToInt32(row["StationID"]);
                        s.StationName = Convert.ToString(row["Name"]);
                       

                        foreach (DataRow row1 in ds.Tables[1].Rows)
                        {
                            string check;

                            s.numStop = Convert.ToInt32(row1["NumStoop"]);
                            s.stationADA = Convert.ToInt32(row1["ADA"]);


                            if ((row1["ADA"]).Equals(System.DBNull.Value))
                            {
                                check = "all";
                            }
                            else if(s.numStop == 0)
                            {
                                check = "all";
                            }
                            else if(s.numStop > 0 && s.stationADA == 0)
                            {
                                check = "none";
                            }
                            else if (s.numStop == s.stationADA)
                            {
                                check = "all";
                            }
                            else
                            {
                                check = "some";
                            }
                            adaL.Add(check);
                            noOfstops.Add(s.numStop);
                        }


                        // avg could be null if there is no ridership data:
                        if (row["AvgDailyRidership"] == System.DBNull.Value)
                            s.AvgDailyRidership = 0;
                        else
                            s.AvgDailyRidership = Convert.ToInt32(row["AvgDailyRidership"]);
                        StationList.Add(s);

                    }
                    int i = 0;
                    foreach(var item in StationList)
                    {
                        item.ada_info = Convert.ToString(adaL[i]);
                        item.numStop = Convert.ToInt32(noOfstops[i]);
                        i++;
                    }


                }//else
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