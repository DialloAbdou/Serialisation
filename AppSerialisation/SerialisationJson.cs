﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppSerialisation
{
    public class SerialisationJson
    {
        public static string createSerialisationObjet( Youtubeur youtubeur)
        {
          
            var json =  JsonSerializer.Serialize(youtubeur, new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            });

            return json;
        }

    }
}
