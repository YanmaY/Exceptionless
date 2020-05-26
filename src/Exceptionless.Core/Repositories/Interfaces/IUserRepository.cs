﻿using System.Threading.Tasks;
using Exceptionless.Core.Models;
using Foundatio.Repositories;
using Foundatio.Repositories.Models;

namespace Exceptionless.Core.Repositories {
    public interface IUserRepository : IQueryableRepository<User> {
        Task<User> GetByEmailAddressAsync(string emailAddress);
        Task<User> GetByPasswordResetTokenAsync(string token);
        Task<User> GetUserByOAuthProviderAsync(string provider, string providerUserId);
        Task<User> GetByVerifyEmailAddressTokenAsync(string token);
        Task<QueryResults<User>> GetByOrganizationIdAsync(string organizationId, CommandOptionsDescriptor<User> options = null);
    }
}