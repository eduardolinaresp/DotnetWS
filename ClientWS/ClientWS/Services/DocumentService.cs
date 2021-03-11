using ClientWS.Models;
using ClientWS.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ClientWS.Services
{
    public class DocumentService
    {
        private string response = string.Empty;
        private string contenido_archivo = string.Empty;

        public DocumentService()
        {
           
        }

        public bool call_web_service()
        {
            bool logico = false;
            WebService1SoapClient ws = new WebService1SoapClient();

            Authentication log = new Authentication();
            log.user = Base64Encode("USER");
            log.password = Base64Encode("PASSWORD");

            Document document = fill_document();

            contenido_archivo = ToXML(document);

            try
            {
               response = ws.CustomXML(Base64Encode(contenido_archivo));
               logico = true;
            }
            catch (Exception ex)
            {

                response = ex.Message.ToString();
            }

            return logico;

        }

       
        private string ToXML(Document doc)
        {
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(doc.GetType());
                serializer.Serialize(stringwriter, doc);
                return stringwriter.ToString();
            }
        }

        private Document fill_document()
        {
            Document doc = new Document();

            doc.Header = getHeader();

            doc.Items = getItems();

            return doc;

        }

        public Header getHeader() 
        {
            Header _head = new Header();
            _head.date = new DateTime().ToString();
            _head.client = "1-9";

            return _head;
        }

        public List<Items> getItems()
        {
            List<Items> list = new List<Items>();

            Items _items = new Items();
            _items.Item = new Item {  ItemType = "1" , ItemValue = "20"};
            _items.ItemQty = "10";
            _items.LineNumber = "1";
            _items.PrcItem = "1000";
            list.Add(_items);
            return list;
        }

        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }


    }
}