using System;
using System.Data;
using SDC.DAL.DataSets;
namespace SDC.DAL.DataSets
{
    public interface IFormDesignDataSets
    {
        DataTable dtGetFormDesign(decimal versionCkey);
        DataTable dtGetFormDesignSSP(decimal versionCkey);
        DataTable dtGetFormDesignMetadata(decimal versionCkey);
        DataTable dtGetFormDesignMetadataSSP(decimal versionCkey);

        DataTable dtGetTemplateList(decimal versionCkey);
        //DataTable dtGetHeader(decimal versionCkey);
        //DataTable dtGetBody(decimal versionCkey);
        //DataTable dtGetFooter(decimal versionCkey);

    }
}
