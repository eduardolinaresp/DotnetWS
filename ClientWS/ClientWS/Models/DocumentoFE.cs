using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ClientWS.Models
{
    [XmlRoot("Documento")]
    public class DocumentoFE
    {
        [XmlElement("Encabezado")]
        public Encabezado Encabezado { get; set; }
        [XmlElement("Detalle")]
        public List<Detalle> Detalle { get; set; }
        [XmlElement("Adicional")]
        public Adicional Adicional { get; set; }

    }

    public class Encabezado
    {
        [XmlElement("IdDoc")]
        public IdDoc IdDoc { get; set; }

        [XmlElement("Emisor")]
        public Emisor Emisor { get; set; }

        [XmlElement("Receptor")]
        public Receptor Receptor { get; set; }

        [XmlElement("Totales")]
        public Totales Totales { get; set; }
    }

    public class IdDoc
    {
        [XmlElement("TipoDTE")]
        public string TipoDTE { get; set; }

        [XmlElement("Folio")]
        public string Folio { get; set; }

        [XmlElement("FchEmis")]
        public string FchEmis { get; set; }

    }

    public class Emisor
    {
        [XmlElement("RUTEmisor")]
        public string RUTEmisor { get; set; }

        [XmlElement("RznSoc")]
        public string RznSoc { get; set; }

        [XmlElement("GiroEmis")]
        public string GiroEmis { get; set; }

        [XmlElement("Acteco")]
        public string Acteco { get; set; }

        [XmlElement("DirOrigen")]
        public string DirOrigen { get; set; }

        [XmlElement("CmnaOrigen")]
        public string CmnaOrigen { get; set; }

        [XmlElement("CiudadOrigen")]
        public string CiudadOrigen { get; set; }
    }
    public class Receptor
    {
        [XmlElement("RUTRecep")]
        public string RUTRecep { get; set; }

        [XmlElement("CdgIntRecep")]
        public string CdgIntRecep { get; set; }

        [XmlElement("RznSocRecep")]
        public string RznSocRecep { get; set; }

        [XmlElement("GiroRecep")]
        public string GiroRecep { get; set; }

        [XmlElement("DirRecep")]
        public string DirRecep { get; set; }

        [XmlElement("CmnaRecep")]
        public string CmnaRecep { get; set; }

        [XmlElement("CiudadRecep")]
        public string CiudadRecep { get; set; }

    }

    public class Totales
    {
        [XmlElement("MntNeto")]
        public string MntNeto { get; set; }
        [XmlElement("TasaIVA")]
        public string TasaIVA { get; set; }
        [XmlElement("IVA")]
        public string IVA { get; set; }
        [XmlElement("MntTotal")]
        public string MntTotal { get; set; }

    }

    public class Detalle
    {
        [XmlElement("NroLinDet")]
        public string NroLinDet { get; set; }
        [XmlElement("CdgItem")]
        public CdgItem CdgItem { get; set; }

        [XmlElement("NmbItem")]
        public string NmbItem { get; set; }

        [XmlElement("DscItem")]
        public string DscItem { get; set; }

        [XmlElement("QtyItem")]
        public string QtyItem { get; set; }
        [XmlElement("UnmdItem")]
        public string UnmdItem { get; set; }

        [XmlElement("PrcItem")]
        public string PrcItem { get; set; }

        [XmlElement("MontoItem")]
        public string MontoItem { get; set; }

    }

    public class CdgItem
    {
        [XmlElement("TpoCodigo")]
        public string TpoCodigo { get; set; }

        [XmlElement("VlrCodigo")]
        public string VlrCodigo { get; set; }

    }

    public class Adicional
    {
        [XmlElement("NodosA")]
        public NodosA NodosA { get; set; }

    }

    public class NodosA
    {
        [XmlElement("A1")]
        public string A1 { get; set; }
        [XmlElement("A2")]
        public string A2 { get; set; }
        [XmlElement("A3")]
        public string A3 { get; set; }
        [XmlElement("A4")]
        public string A4 { get; set; }
        [XmlElement("A5")]
        public string A5 { get; set; }
        [XmlElement("A6")]
        public string A6 { get; set; }
    }
}