using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CarbonFootprintService
{
    /// <summary>
    /// Summary description for CarbonService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CarbonService : System.Web.Services.WebService
    {

        [WebMethod]
        public double CalculateEnergyFootprint(double energyKWh, double emissionFactor)
        {
            return energyKWh * emissionFactor;
        }

        [WebMethod]
        public double CalculateTransportFootprint(double distanceKm, double emissionFactor)
        {
            return distanceKm * emissionFactor;
        }

        [WebMethod]
        public double CalculateWasteFootprint(double wasteTonnes, double emissionFactor)
        {
            return wasteTonnes * emissionFactor;
        }

        [WebMethod]
        public double CalculateTotalFootprint(double energy, double transport, double waste)
        {
            return energy + transport + waste;
        }
    }
}
