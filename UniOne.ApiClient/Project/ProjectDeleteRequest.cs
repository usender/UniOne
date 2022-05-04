using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Project
{
    internal class ProjectDeleteRequest : ProjectIdentifierRequest
    {
        internal ProjectDeleteRequest(ProjectIdentifier project)
            : base(project)
        { }

        internal override ApiAction ApiAction => ApiAction.Project.Delete;
    }
}
