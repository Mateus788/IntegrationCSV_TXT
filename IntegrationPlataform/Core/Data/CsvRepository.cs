using CsvHelper.Configuration.Attributes;

namespace Core.Data;

public class CsvRepository : Repository
{
    public async void CsvAdd(string gENERO, string cATEGORIA, string mIDIA, string tIPO_MIDIA, int cLASSIFICACAO, string pARTICIPANTE)
    {
        string query = $"INSERT INTO legado (genero, categoria,  midia, tipo_midia, classificacao, participante) VALUES ({gENERO},{cATEGORIA},{mIDIA},{tIPO_MIDIA},{cLASSIFICACAO},{pARTICIPANTE})";

    }

}
