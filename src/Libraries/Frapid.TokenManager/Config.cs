﻿using System.IO;
using System.Text;
using System.Web.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Frapid.TokenManager
{
    public static class Config
    {
        public static JObject Get()
        {
            string path = "~/Resources/Configs/JwtConfig.json";
            path = HostingEnvironment.MapPath(path);

            if (string.IsNullOrWhiteSpace(path) ||
                !File.Exists(path))
            {
                return new JObject();
            }

            string contents = File.ReadAllText(path, Encoding.UTF8);
            return JsonConvert.DeserializeObject<JObject>(contents);
        }
    }
}