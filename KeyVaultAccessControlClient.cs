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

        // The optional $filter parameter accepts the roleName property.
        public Pageable<RoleDefinition> GetRoleDefinitions(RoleDefinitionFilter? filter = default, CancellationToken cancellationToken = default) => null;
        public AsyncPageable<RoleDefinition> GetRoleDefinitionsAsync(RoleDefinitionFilter? filter = default, CancellationToken cancellationToken = default) => null;

        // The optional $filter parameter accepts the principalId property.
        public Pageable<RoleAssignment> GetRoleAssignments(RoleAssignmentFilter? filter = default, CancellationToken cancellationToken = default) => null;
        public AsyncPageable<RoleAssignment> GetRoleAssignmentsAsync(RoleAssignmentFilter? filter = default, CancellationToken cancellationToken = default) => null;

        // The role assignment name will be created automatically. The swagger specification reads, "The name of the role assignment to create. It can be any valid GUID."
        public Response<RoleAssignment> CreateRoleAssignment(RoleAssignmentProperties properties, CancellationToken cancellationToken = default) => null;
        public Task<Response<RoleAssignment>> CreateRoleAssignmentAsync(RoleAssignmentProperties properties, CancellationToken cancellationToken = default) => null;

        public Response<RoleAssignment> GetRoleAssignment(string name, CancellationToken cancellationToken = default) => null;
        public Task<Response<RoleAssignment>> GetRoleAssignmentAsync(string name, CancellationToken cancellation = default) => null;

        public Response<RoleAssignment> DeleteRoleAssignment(string name, CancellationToken cancellationToken = default) => null;
        public Task<Response<RoleAssignment>> DeleteRoleAssignmentAsync(string name, CancellationToken cancellation = default) => null;
    }
}
