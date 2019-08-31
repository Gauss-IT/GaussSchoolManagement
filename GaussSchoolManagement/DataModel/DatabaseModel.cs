namespace GaussSchoolManagement.DataModel
{
    public static class DatabaseModel
    {
        private static GaussSchoolModel _instance;

        public static GaussSchoolModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GaussSchoolModel();
                return _instance;
            }
        }
    }
}
