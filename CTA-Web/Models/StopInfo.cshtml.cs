using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace program.Pages
{
    public class StopInfoModel : PageModel
    {
        public List<Models.Stops> stopsList { get; set; }

        public string Input { get; set; }

        public Exception EX { get; set; }

        public void OnGet(string input)
        {
            stopsList = new List<Models.Stops>();

            Input = input;
            EX = null;

            try
            {
                if (input == null)
                {

                }
                else
                {
                    string sql;

                    sql = string.Format(@"SELECT Stops.StopID, Stops.Name, Stops.Direction, Stops.Latitude, Stops.Longitude, 
                    STRING_AGG(ISNULL(Lines.Color, ' '), ', ') WITHIN GROUP (ORDER BY Lines.Color ASC) AS Color, IIF(Stops.ADA = 1, 'yes', 'no') AS ADA
                    FROM Stops
                    LEFT JOIN Stations ON Stops.StationID = Stations.StationID
                    LEFT JOIN StopDetails ON Stops.StopID = StopDetails.StopID
                    LEFT JOIN Lines ON StopDetails.LineID = Lines.LineID
                    WHERE Stations.StationID = '{0}'
                    GROUP BY Stops.StopID, Stops.Name, Stops.Direction, Stops.Latitude, Stops.Longitude, Stops.ADA
                    ORDER BY Stops.Name ASC", input);

                    DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);
                   
                    foreach(DataRow row in ds.Tables[0].Rows)
                    {
                        Models.Stops s = new Models.Stops();

                        s.stopID = Convert.ToInt32(row["StopID"]);
                        s.stopName = Convert.ToString(row["Name"]);
                        s.direction = Convert.ToString(row["Direction"]);
                        s.latitude = Convert.ToDouble(row["Latitude"]);
                        s.longitude = Convert.ToDouble(row["Longitude"]);
                        s.color = Convert.ToString(row["Color"]);
                        s.ADA = Convert.ToString(row["ADA"]);

                        
                        

                        stopsList.Add(s);


                    }
                }
            }
            catch(Exception Ex)
            {
                EX = Ex;
            }
            finally
            {

            }

        }
    }
}
