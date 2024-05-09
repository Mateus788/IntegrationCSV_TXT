using CsvHelper.Configuration.Attributes;

namespace Core.Models;

public class DataModel
{
    [Name("ID")]
    public int ID { get; set; }
    [Name("GENERO")]
    public string GENERO { get; set; }
    [Name("CATEGORIA")]
    public string CATEGORIA { get; set; }
    [Name("MIDIA")]
    public string MIDIA { get; set; }
    [Name("TIPO_MIDIA")]
    public string TIPO_MIDIA { get; set; }
    [Name("CLASSIFICACAO")]
    public string CLASSIFICACAO { get; set; }
    [Name("PARTICIPANTE")]
    public string PARTICIPANTE { get; set; }
}
