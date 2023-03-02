using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Project
{
    internal class ProjectListRequest : ProjectIdentifierRequest
    {
        internal ProjectListRequest(ProjectIdentifier project)
            : base(project)
        { }

        internal override ApiEndpoint Endpoint => ApiEndpoint.Project.List;
    }
}
