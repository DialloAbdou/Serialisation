using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppSerialisation
{
    public class EcritureJson
    {
        public static void writeJson()
        {
            using var memoStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoStream);
            writer.WriteStartObject();
            writer.WritePropertyName("Nom");
            writer.WriteStringValue("Diallo");
            writer.WritePropertyName("Prenom");
            writer.WriteStringValue("Abdou");
            writer.WritePropertyName("Age");
            writer.WriteNumberValue(36);
            writer.WriteEndObject();
            writer.Flush();
            memoStream.Position = 0;
            System.Console.Write(Encoding.UTF8.GetString(memoStream.ToArray()));
        }

    }
}
