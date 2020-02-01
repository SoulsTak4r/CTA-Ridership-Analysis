//
// One CTA Station
//

namespace program.Models
{

    public class Station
    {

        // data members with auto-generated getters and setters:
        public int StationID { get; set; }
        public string StationName { get; set; }
        public int AvgDailyRidership { get; set; }

        public int riderShip { get; set; }

        public int numStop { get; set; }

        public int stationADA { get; set; }

        public string ada_info { get; set; }
	
		// default constructor:
		public Station()
		{ }
		
		// constructor:
		public Station(int id, string name, int avgDailyRidership, int RiderShip, int numstop, int handicap, string ada)
		{
			StationID = id;
			StationName = name;
			AvgDailyRidership = avgDailyRidership;
            riderShip = RiderShip;
            numStop = numstop;
            stationADA = handicap;
            ada_info = ada;

		}
		
	}//class

}//namespace