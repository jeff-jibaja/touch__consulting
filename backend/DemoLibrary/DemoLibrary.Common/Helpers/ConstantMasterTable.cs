namespace DemoLibrary.Common.Helpers
{
    public static class ConstantMasterTable
    {
        public static class Schema
        {
            public const string Cnfg = "Cnfg";
            public const string Demo = "Demo";
            public const string Env = "Env";
        }


        public static class Procedure
        {
            public const string ListMasterTable = "USP_LIST_MasterTable";
            public const string CreateAndUpdatePerson = "USP_CreateUpdatePerson";
            public const string EnvioHeaderMnt = "EnvioHeader_Mnt";
            public const string EnvioDetailMnt = "EnvioDetail_Mnt";
            public const string GuiaEnvioHeaderMnt = "GuiaEnvioHeader_Mnt";
            public const string GuiaEnvioDetailMnt = "GuiaEnvioDetail_Mnt";
            public const string DireccionesMnt = "Direcciones_Mnt";
            public const string MaeConductorMnt = "MaeConductor_Mnt";
            public const string WareHouseMasterMnt = "WareHouseMaster_Mnt";
            public const string CarrierMnt = "Transportista_Mnt";
            public const string CorrelativeMnt = "NextNumber_Mnt";
            public const string BookFilter = "FILTER_BOOK";
        }
        public static class UrlGenerales
        {
            public const string LogoAntamina = "00201";
        }
    }
}
