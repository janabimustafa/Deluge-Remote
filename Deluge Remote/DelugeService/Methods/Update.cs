﻿using DelugeService.Data;
using DelugeService.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelugeService
{
    public partial class DelugeService
    {
        public async Task<DelugeUpdateResult> Update()
        {            
            var response = await client.SendMessage(RpcConstants.RPC_METHOD_GET, new object[] { RpcConstants.RPC_FIELDS_ARRAY, new object() });
            DelugeUpdateResult result = response.Result.ToObject<DelugeUpdateResult>();
            foreach(string key in result.torrents.Keys)
            {
                result.torrents[key].unique_id = key;
            }
            return result;
        }
    }
}
