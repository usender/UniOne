using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Sender.UniOne.ApiClient.Common;
using Sender.UniOne.ApiClient.Domain;
using Sender.UniOne.ApiClient.Email;
using Sender.UniOne.ApiClient.Infrastructure.Exceptions;
using Sender.UniOne.ApiClient.Infrastructure.Extensions;
using Sender.UniOne.ApiClient.Project;
using Sender.UniOne.ApiClient.Suppression;
using Sender.UniOne.ApiClient.System;
using Sender.UniOne.ApiClient.Template;
using Sender.UniOne.ApiClient.Unsubscribe;
using Sender.UniOne.ApiClient.Webhook;
using Sender.UniOne.ApiClient.Webhook.Models;

namespace Sender.UniOne.ApiClient
{
    public class UniOneClient
    {
        private readonly HttpClient _httpClient;
        private readonly UniOneSettings _settings;

        public UniOneClient(UniOneSettings settings)
        {
            _settings = settings;

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(settings.Host);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #region Email

        public Task<MessageResponse> EmailSendAsync(EmailMessage message)
        {
            var request = new MessageRequest(message);
            return GetResponseAsync<MessageResponse>(request);
        }

        public Task<EmailSubscribeResponse> EmailSubscribeAsync(Subscribe subscribe)
        {
            var request = new EmailSubscribeRequest(subscribe);
            return GetResponseAsync<EmailSubscribeResponse>(request);
        }

        #endregion

        #region Template

        public Task<TemplateGetResponse> TemplateGetAsync(string templateId)
        {
            var request = new TemplateGetRequest(templateId);
            return GetResponseAsync<TemplateGetResponse>(request);
        }

        public Task<TemplateSetResponse> TemplateSetAsync(TemplateMessage template)
        {
            var request = new TemplateSetRequest(template);
            return GetResponseAsync<TemplateSetResponse>(request);
        }

        public Task<TemplateDeleteResponse> TemplateDeleteAsync(string templateId)
        {
            var request = new TemplateDeleteRequest(templateId);
            return GetResponseAsync<TemplateDeleteResponse>(request);
        }

        public Task<TemplateListResponse> TemplateListAsync(Page page)
        {
            var request = new TemplateListRequest(page);
            return GetResponseAsync<TemplateListResponse>(request);
        }

        #endregion

        #region Webhook

        public Task<WebhookGetResponse> WebhookGetAsync(string url)
        {
            return GetResponseAsync<WebhookGetResponse>(new WebhookGetRequest(url));
        }

        public Task<WebhookSetResponse> WebhookSetAsync(WebhookSet webhookSet)
        {
            return GetResponseAsync<WebhookSetResponse>(new WebhookSetRequest(webhookSet));
        }

        public Task<WebhookListResponse> WebhookListAsync(Page page)
        {
            return GetResponseAsync<WebhookListResponse>(new WebhookListRequest(page));
        }

        public Task<WebhookDeleteResponse> WebhookDeleteAsync(string url)
        {
            return GetResponseAsync<WebhookDeleteResponse>(new WebhookDeleteRequest(url));
        }

        #endregion

        #region Unsubscribed

        public Task<UnsubscribedSetResponse> UnsubscribedSetAsync(string email)
        {
            var request = new UnsubscribedSetRequest(email);
            return GetResponseAsync<UnsubscribedSetResponse>(request);
        }

        public Task<UnsubscribedCheckResponse> UnsubscribedCheckAsync(string email)
        {
            var request = new UnsubscribedCheckRequest(email);
            return GetResponseAsync<UnsubscribedCheckResponse>(request);
        }

        public Task<UnsubscribedListResponse> UnsubscribedListAsync(DateTime startDate)
        {
            var request = new UnsubscribedListRequest(startDate);
            return GetResponseAsync<UnsubscribedListResponse>(request);
        }

        #endregion

        #region Suppression

        /// <summary>
        /// Gets a reason and date of email suppression
        /// </summary>
        /// <param name="email">Email to get suppression details fo</param>
        /// <param name="allProjects">If a user has projects functionality enabled, he/she can pass all_projects=true to search in all projects’ data.</param>
        /// <returns></returns>
        public Task<SuppressionGetResponse> SuppressionGetAsync(string email, bool allProjects)
        {
            var request = new SuppressionGetRequest
            {
                Email = email,
                AllProjects = allProjects
            };

            return GetResponseAsync<SuppressionGetResponse>(request);
        }

        /// <summary>
        /// Deletes an email from suppression list (only records with is_deletable=true). If there are no entries of this email in the suppression list, API error 3003 is returned. If such entries exist but no one can be deleted, API error 3004 is returned. If daily limit of deletes exceeded, API error 906 is returned
        /// </summary>
        /// <param name="email">An email to delete from suppression list</param>
        /// <returns></returns>
        public Task<SuppressionDeleteResponse> SuppressionDeleteAsync(string email)
        {
            var request = new SuppressionDeleteRequest()
            {
                Email = email
            };

            return GetResponseAsync<SuppressionDeleteResponse>(request);
        }

        #endregion

        #region Domain

        /// <summary>
        /// Returns info on domain DNS setup for using with UniOne.
        /// </summary>
        /// <param name="domain">Domain to get DNS records for.</param>
        /// <returns></returns>
        public Task<GetDnsRecordResponse> DomainGetDnsAsync(string domain)
        {
            var request = new GetDnsRecordRequest(domain);
            return GetResponseAsync<GetDnsRecordResponse>(request);
        }

        /// <summary>
        /// Triggers verification record validation for domain.
        /// </summary>
        /// <param name="domain">Domain to validate verification record for.</param>
        /// <returns></returns>
        public Task<ValidateVerificationResponse> DomainValidateVerificationAsync(string domain)
        {
            var request = new ValidateVerificationRequest(domain);
            return GetResponseAsync<ValidateVerificationResponse>(request);
        }

        /// <summary>
        /// Validates DKIM record for domain.
        /// </summary>
        /// <param name="domain">Domain to validate DKIM record for.</param>
        /// <returns></returns>
        public Task<ValidateDkimResponse> DomainValidateDkimAsync(string domain)
        {
            var request = new ValidateDkimRequest(domain);
            return GetResponseAsync<ValidateDkimResponse>(request);
        }

        /// <summary>
        /// Returns a list of all registered domains for user or project, together with statuses of last validations.
        /// </summary>
        /// <param name="domain">Optional domain name if you want to get the status of single domain only</param>
        /// <param name="page">Page of entries</param>
        /// <returns></returns>
        public Task<DomainListResponse> DomainListAsync(string domain, Page page)
        {
            var request = new DomainListRequest(domain, page);

            return GetResponseAsync<DomainListResponse>(request);
        }

        #endregion

        #region Project

        public Task<ProjectCreateResponse> ProjectCreateAsync(ProjectInfo project)
        {
            var request = new ProjectCreateRequest(project);
            return GetResponseAsync<ProjectCreateResponse>(request);
        }

        public Task<ProjectUpdateResponse> ProjectUpdateAsync(ProjectIdentifier identifier, ProjectInfo project)
        {
            var request = new ProjectUpdateRequest(identifier, project);
            return GetResponseAsync<ProjectUpdateResponse>(request);
        }

        public Task<ProjectDeleteResponse> ProjectDeleteAsync(ProjectIdentifier projectIdentifier)
        {
            var request = new ProjectDeleteRequest(projectIdentifier);
            return GetResponseAsync<ProjectDeleteResponse>(request);
        }

        public Task<ProjectListResponse> ProjectListAsync(ProjectIdentifier projectIdentifier)
        {
            var request = new ProjectListRequest(projectIdentifier);
            return GetResponseAsync<ProjectListResponse>(request);
        }

        #endregion

        #region System

        /// <summary>
        /// System information
        /// </summary>
        /// <returns>User or project info</returns>
        public Task<SystemInfoResponse> SystemInfoAsync()
        {
            var request = new SystemInfoRequest();
            return GetResponseAsync<SystemInfoResponse>(request);
        }

        #endregion

        private async Task<T> GetResponseAsync<T>(BaseRequest request) where T : BaseResponse, new()
        {
            if (_settings.IsNeedValidateRequestBeforeSending)
            {
                request.Validate();
            }

            request.ApiKey = _settings.ApiKey;
            var requestMessage = request.ToString();

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, request.ApiAction.Uri)
            {
                Content = new StringContent(requestMessage, Encoding.UTF8, "application/json")
            };

            var response = await _httpClient.SendAsync(httpRequest);
            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return content.FromJson<T>();
            }

            if (response.StatusCode >= HttpStatusCode.BadRequest &&
                response.StatusCode < HttpStatusCode.InternalServerError)
            {
                return new T
                {
                    Failure = content.FromJson<FailureResponse>()
                };
            }

            if (response.StatusCode >= HttpStatusCode.InternalServerError)
            {
                throw new UniOneClientException(response.StatusCode, "We had a problem with our server (might be 500, 502, 503 etc.). Please try again later");
            }

            throw new UniOneClientException(response.StatusCode, "Unknown error");
        }
    }
}
