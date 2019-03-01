
using System.Collections.Generic;

namespace NetCoreWebApp_1.Models
{
    public interface ISamochodRepository
    {
        IEnumerable<Samochod> PobierzWszystkieSamochody();

        Samochod PobierzSamochodOID(int SamochodID);
    }
}
