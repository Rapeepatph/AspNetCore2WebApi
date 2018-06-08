using System;
using System.Collections.Generic;

namespace ATSEFAPI.DBModels
{
    public partial class FlightProfile
    {
        public uint Id { get; set; }
        public string Callsign { get; set; }
        public string Squawk { get; set; }
        public string Aircraft { get; set; }
        public string Tagname { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string DeptTma { get; set; }
        public string DestTma { get; set; }
        public double? StartRadian { get; set; }
        public double? EndRadian { get; set; }
        public string AccSectors { get; set; }
        public int? FlightType { get; set; }
        public double? FirstX { get; set; }
        public double? FirstY { get; set; }
        public int? FirstLevel { get; set; }
        public DateTimeOffset? FirstTime { get; set; }
        public double? LastX { get; set; }
        public double? LastY { get; set; }
        public int? LastLevel { get; set; }
        public DateTimeOffset? LastTime { get; set; }
        public string Waypoints { get; set; }
        public double? DirectDistance { get; set; }
        public double? FirstExitX { get; set; }
        public double? FirstExitY { get; set; }
        public int? FirstExitLevel { get; set; }
        public DateTimeOffset? FirstExitTime { get; set; }
        public double? FirstEntX { get; set; }
        public double? FirstEntY { get; set; }
        public int? FirstEntLevel { get; set; }
        public DateTimeOffset? FirstEntTime { get; set; }
        public double? SecondEntX { get; set; }
        public double? SecondEntY { get; set; }
        public int? SecondEntLevel { get; set; }
        public DateTimeOffset? SecondEntTime { get; set; }
        public double? FirstEnrDistance { get; set; }
        public long? FirstEnrTime { get; set; }
        public double? SecondEnrDistance { get; set; }
        public long? SecondEnrTime { get; set; }
        public double? StateEntX { get; set; }
        public double? StateEntY { get; set; }
        public int? StateEntLevel { get; set; }
        public double? StateExitX { get; set; }
        public double? StateExitY { get; set; }
        public int? StateExitLevel { get; set; }
        public double? FirstRefRadian { get; set; }
        public double? FirstEntRefRadian { get; set; }
        public double? SecondEntRefRadian { get; set; }
        public string RunwayHeading { get; set; }
        public long? FirstEntAppDuration { get; set; }
        public long? SecondEntAppDuration { get; set; }
        public uint? DepartureFlag { get; set; }
        public uint? DestinationFlag { get; set; }
        public uint? UnknownFlag { get; set; }
        public double? FirstAchievedDistance { get; set; }
        public double? SecondAchievedDistance { get; set; }
        public double? FirstActualDistance { get; set; }
        public double? SecondActualDistance { get; set; }
        public double? Kpi05A1 { get; set; }
        public double? Kpi05A2 { get; set; }
        public double? Kpi05B1 { get; set; }
        public double? Kpi05B2 { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public int? FlightplanId { get; set; }
    }
}
