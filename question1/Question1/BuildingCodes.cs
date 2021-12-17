namespace question1
{
    public class BuildingCodes
    {
        public int BuildingID { get; set; }

        public string BuildingLocation { get; set; }

        private string buildingCode;

        public string GetBuildingCode()
        {
            return buildingCode;
        }

        public void SetBuildingCode(string value)
        {
            buildingCode = value;
        }

        public BuildingCodes(int _buildingID, string _buidlingLocation, string _buildingCode)
        {
            BuildingID = _buildingID;
            BuildingLocation = _buidlingLocation;
            SetBuildingCode(_buildingCode);
        }

        public BuildingCodes()
        { }
    }
}
