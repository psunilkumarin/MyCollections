﻿using Newtonsoft.Json;
using PaymentechCore.Models.RequestModels.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentechCore.Models.RequestModels
{
    public class FlexCacheType : flexCacheType
    {
        public flexCacheType CopyToBase()
        {
            string json = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<flexCacheType>(json);
        }
    }
}