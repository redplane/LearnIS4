﻿using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4.Stores;

namespace Is4Server.Services.Implementations
{
    public class Is4PersistedGrantStore : IPersistedGrantStore
    {
        public Task StoreAsync(PersistedGrant grant)
        {
            throw new System.NotImplementedException();
        }

        public Task<PersistedGrant> GetAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<PersistedGrant>> GetAllAsync(string subjectId)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveAllAsync(string subjectId, string clientId)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveAllAsync(string subjectId, string clientId, string type)
        {
            throw new System.NotImplementedException();
        }
    }
}