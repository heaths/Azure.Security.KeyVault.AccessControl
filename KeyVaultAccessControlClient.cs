using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.Security.KeyVault.AccessControl
{
    public class KeyVaultAccessControlClient
    {
        public KeyVaultAccessControlClient(Uri vaultUri, TokenCredential credential)
        {
            VaultUri = vaultUri;
        }

        public KeyVaultAccessControlClient(Uri vaultUri, TokenCredential credential, KeyVaultAccessControlClientOptions options)
        {
            VaultUri = vaultUri;
        }

        public Uri VaultUri { get; }

        public Pageable<RoleDefinition> GetRoleDefinitions(Uri scope, CancellationToken cancellationToken = default) => null;
        public Pageable<RoleDefinition> GetRoleDefinitions(string scope, CancellationToken cancellationToken = default) => null;
        public AsyncPageable<RoleDefinition> GetRoleDefinitionsAsync(Uri scope, CancellationToken cancellationToken = default) => null;
        public AsyncPageable<RoleDefinition> GetRoleDefinitionsAsync(string scope, CancellationToken cancellationToken = default) => null;

        public Pageable<RoleAssignment> GetRoleAssignments(Uri scope, CancellationToken cancellationToken = default) => null;
        public Pageable<RoleAssignment> GetRoleAssignments(string scope, CancellationToken cancellationToken = default) => null;
        public AsyncPageable<RoleAssignment> GetRoleAssignmentsAsync(Uri scope, CancellationToken cancellationToken = default) => null;
        public AsyncPageable<RoleAssignment> GetRoleAssignmentsAsync(string scope, CancellationToken cancellationToken = default) => null;

        // The role assignment name will be created automatically. The swagger specification reads, "The name of the role assignment to create. It can be any valid GUID."
        public Response<RoleAssignment> CreateRoleAssignment(Uri scope, RoleAssignmentProperties properties, CancellationToken cancellationToken = default) => null;
        public Response<RoleAssignment> CreateRoleAssignment(string scope, RoleAssignmentProperties properties, CancellationToken cancellationToken = default) => null;
        public Task<Response<RoleAssignment>> CreateRoleAssignmentAsync(Uri scope, RoleAssignmentProperties properties, CancellationToken cancellationToken = default) => null;
        public Task<Response<RoleAssignment>> CreateRoleAssignmentAsync(string scope, RoleAssignmentProperties properties, CancellationToken cancellationToken = default) => null;

        public Response<RoleAssignment> GetRoleAssignment(string name, CancellationToken cancellationToken = default) => null;
        public Task<Response<RoleAssignment>> GetRoleAssignmentAsync(string name, CancellationToken cancellation = default) => null;

        public Response<RoleAssignment> DeleteRoleAssignment(string name, CancellationToken cancellationToken = default) => null;
        public Task<Response<RoleAssignment>> DeleteRoleAssignmentAsync(string name, CancellationToken cancellation = default) => null;
    }
}
