using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Sender.UniOne.ApiClient.Common;
using Sender.UniOne.ApiClient.Domain;
using Sender.UniOne.ApiClient.Email;
using Sender.UniOne.ApiClient.EventDump;
using Sender.UniOne.ApiClient.Infrastructure.Exceptions;
using Sender.UniOne.ApiClient.Infrastructure.Extensions;
using Sender.UniOne.ApiClient.Infrastructure.Helpers;
using Sender.UniOne.ApiClient.Project;
using Sender.UniOne.ApiClient.Suppression;
using Sender.UniOne.ApiClient.System;
using Sender.UniOne.ApiClient.Tag;
using Sender.UniOne.ApiClient.Template;
using Sender.UniOne.ApiClient.Unsubscribe;
using Sender.UniOne.ApiClient.Webhook;
using Sender.UniOne.ApiClient.Webhook.Models;

namespace Sender.UniOne.ApiClient
{
    /// <summary>
    /// Uni one API client
    /// </summary>
    public class UniOneClient
    {
        private readonly HttpClient _httpClient;
        private readonly UniOneSettings _settings;

        public UniOneClient(UniOneSettings settings)
        {
            _settings = settings;
            _httpClient = new HttpClient();
            var language = EnumHelper.GetEnumMemberValue(settings.DefaultLanguage);
            _httpClient.BaseAddress = new Uri(new Uri(settings.Endpoint), language + "/");
            //_httpClient.DefaultRequestHeaders.Add("X-API-KEY", settings.ApiKey);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #region Email

        /// <summary>
        /// Sends an email or a bunch of emails
        /// While sending you can provide substitutions (merge tags), use a template, turn on read or click tracking, etc.
        /// </summary>
        /// <param name="message">Email message object</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<EmailMessageResponse> EmailSendAsync(EmailMessage message)
        {
            var request = new EmailMessageRequest(message);
            return GetResponseAsync<EmailMessageResponse>(request);
        }

        /// <summary>
        /// Sends an email with (re)subscribe link
        /// </summary>
        /// <param name="subscribe">Subscribe object</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<EmailSubscribeResponse> EmailSubscribeAsync(Subscribe subscribe)
        {
            var request = new EmailSubscribeRequest(subscribe);
            return GetResponseAsync<EmailSubscribeResponse>(request);
        }

        #endregion

        #region Template

        /// <summary>
        /// Gets template properties by it’s id
        /// </summary>
        /// <param name="templateId">Template identifier</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<TemplateGetResponse> TemplateGetAsync(string templateId)
        {
            var request = new TemplateGetRequest(templateId);
            return GetResponseAsync<TemplateGetResponse>(request);
        }

        /// <summary>
        /// Creates or updates an email template
        /// </summary>
        /// <param name="template">Template object</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<TemplateSetResponse> TemplateSetAsync(TemplateMessage template)
        {
            var request = new TemplateSetRequest(template);
            return GetResponseAsync<TemplateSetResponse>(request);
        }

        /// <summary>
        /// Deletes a template by id
        /// </summary>
        /// <param name="templateId">Template identifier</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<TemplateDeleteResponse> TemplateDeleteAsync(string templateId)
        {
            var request = new TemplateDeleteRequest(templateId);
            return GetResponseAsync<TemplateDeleteResponse>(request);
        }

        /// <summary>
        /// Returns the list of all or some templates of the account
        /// </summary>
        /// <param name="page">Page</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<TemplateListResponse> TemplateListAsync(Page page)
        {
            var request = new TemplateListRequest(page);
            return GetResponseAsync<TemplateListResponse>(request);
        }

        #endregion

        #region Webhook

        /// <summary>
        /// Gets properties of a webhook
        /// </summary>
        /// <param name="url">Webhook URL</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<WebhookGetResponse> WebhookGetAsync(string url)
        {
            return GetResponseAsync<WebhookGetResponse>(new WebhookGetRequest(url));
        }

        /// <summary>
        /// Sets or edits a webhook, i.e. an event notification handler
        /// </summary>
        /// <param name="webhookSet">Webhook object</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<WebhookSetResponse> WebhookSetAsync(WebhookSet webhookSet)
        {
            return GetResponseAsync<WebhookSetResponse>(new WebhookSetRequest(webhookSet));
        }

        /// <summary>
        /// List all or some webhooks (event notification handlers) of a user or a project
        /// </summary>
        /// <param name="page">Page</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<WebhookListResponse> WebhookListAsync(Page page)
        {
            return GetResponseAsync<WebhookListResponse>(new WebhookListRequest(page));
        }

        /// <summary>
        /// Deletes an event notification handler
        /// You can also temporarily deactivate webhook without deleting it by setting it’s status to “disabled” in webhook/set method.
        /// </summary>
        /// <param name="url">Webhook URL</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<WebhookDeleteResponse> WebhookDeleteAsync(string url)
        {
            return GetResponseAsync<WebhookDeleteResponse>(new WebhookDeleteRequest(url));
        }

        #endregion

        #region Unsubscribed

        /// <summary>
        /// Registers a new unsubscribed email
        /// </summary>
        /// <param name="email">Email to be unsubscribed</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<UnsubscribedSetResponse> UnsubscribedSetAsync(string email)
        {
            var request = new UnsubscribedSetRequest(email);
            return GetResponseAsync<UnsubscribedSetResponse>(request);
        }

        /// <summary>
        /// Checks if an email is unsubscribed
        /// </summary>
        /// <param name="email">Email to check</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<UnsubscribedCheckResponse> UnsubscribedCheckAsync(string email)
        {
            var request = new UnsubscribedCheckRequest(email);
            return GetResponseAsync<UnsubscribedCheckResponse>(request);
        }

        /// <summary>
        /// Returns a list of all unsubscribed emails since provided date
        /// </summary>
        /// <param name="startDate">Date to get all unsubscribed emails from the “date_from” to the present day. If the parameter is not specified, the default period is today (from 00:00 UTC).</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
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
        /// <param name="email">Email to get suppression details for</param>
        /// <param name="allProjects">If a user has projects functionality enabled, he/she can pass all_projects=true to search in all projects’ data.</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
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
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<SuppressionDeleteResponse> SuppressionDeleteAsync(string email)
        {
            var request = new SuppressionDeleteRequest
            {
                Email = email
            };

            return GetResponseAsync<SuppressionDeleteResponse>(request);
        }

        /// <summary>
        /// Adds an email address to the suppression list. You can always remove this address from the suppression list later using the suppression/delete method
        /// </summary>
        /// <param name="email">Required. Email to add in suppression list.</param>
        /// <param name="cause">Required. Cause of email being suppressed</param>
        /// <param name="createDate">When suppression was created, in UTC timezone</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<SuppressionSetResponse> SuppressionSetAsync(string email, SuppressionCause cause, DateTime? createDate)
        {
            var request = new SuppressionSetRequest
            {
                Email = email,
                Cause = cause,
                Created = createDate
            };

            return GetResponseAsync<SuppressionSetResponse>(request);
        }

        /// <summary>
        /// Returns a suppression list since provided date.
        /// </summary>
        /// <param name="filter">Filter object</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<SuppressionListResponse> SuppressionListAsync(SuppressionList filter)
        {
            var request = new SuppressionListRequest
            {
                StartTime = filter.StartTime,
                Limit = filter.Limit,
                Cause = filter.Cause,
                Cursor = filter.Cursor,
                Source = filter.Source
            };

            return GetResponseAsync<SuppressionListResponse>(request);
        }

        #endregion

        #region Domain

        /// <summary>
        /// Returns info on domain DNS setup for using with UniOne.
        /// </summary>
        /// <param name="domain">Domain to get DNS records for.</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
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
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
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
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
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
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<DomainListResponse> DomainListAsync(string domain, Page page)
        {
            var request = new DomainListRequest(domain, page);
            return GetResponseAsync<DomainListResponse>(request);
        }

        #endregion

        #region Project

        /// <summary>
        /// Creates a new project
        /// </summary>
        /// <param name="project">Object with project properties</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<ProjectCreateResponse> ProjectCreateAsync(ProjectInfo project)
        {
            var request = new ProjectCreateRequest(project);
            return GetResponseAsync<ProjectCreateResponse>(request);
        }

        /// <summary>
        /// Updates a project
        /// </summary>
        /// <param name="identifier">Project identifier</param>
        /// <param name="project"></param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<ProjectUpdateResponse> ProjectUpdateAsync(ProjectIdentifier identifier, ProjectInfo project)
        {
            var request = new ProjectUpdateRequest(identifier, project);
            return GetResponseAsync<ProjectUpdateResponse>(request);
        }

        /// <summary>
        /// Deletes a project
        /// </summary>
        /// <param name="projectIdentifier">Project identifier</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<ProjectDeleteResponse> ProjectDeleteAsync(ProjectIdentifier projectIdentifier)
        {
            var request = new ProjectDeleteRequest(projectIdentifier);
            return GetResponseAsync<ProjectDeleteResponse>(request);
        }

        /// <summary>
        /// Lists projects
        /// </summary>
        /// <param name="projectIdentifier"></param>
        /// <exception>Occurs when there is an HttpStatusCode 50x <see cref="HttpStatusCode"/></exception>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<ProjectListResponse> ProjectListAsync(ProjectIdentifier projectIdentifier)
        {
            var request = new ProjectListRequest(projectIdentifier);
            return GetResponseAsync<ProjectListResponse>(request);
        }

        #endregion

        #region System

        /// <summary>
        /// Gets user or project info by API key
        /// </summary>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns>User or project info</returns>
        public Task<SystemInfoResponse> SystemInfoAsync()
        {
            var request = new SystemInfoRequest();
            return GetResponseAsync<SystemInfoResponse>(request);
        }

        #endregion

        #region Event dump

        /// <summary>
        /// This asynchronous method initiates the preparation of data dump in CSV format. The number of dump files created or stored is limited to 10; to order more files, you have to delete one of the previous ones or wait until they will be deleted automatically. A newly created dump file is kept for 8 hours
        /// </summary>
        ///  <param name="eventDump">Dump detail</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<EventDumpCreateResponse> EventDumpCreateAsync(EventDumpCreate eventDump)
        {
            var request = new EventDumpCreateRequest
            {
                Limit = eventDump.Limit,
                AllProjects = eventDump.AllProjects,
                Delimiter = eventDump.Delimiter,
                EndTime = eventDump.EndTime,
                Format = eventDump.Format,
                StartTime = eventDump.StartTime,
                Filter = eventDump.Filter ?? new EventDumpFilter()
            };
            return GetResponseAsync<EventDumpCreateResponse>(request);
        }

        /// <summary>
        /// Returns dump properties for a given identifier
        /// </summary>
        /// <param name="dumpId">Dump identifier</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<EventDumpGetResponse> EventDumpGetAsync(string dumpId)
        {
            var request = new EventDumpGetRequest(dumpId);
            return GetResponseAsync<EventDumpGetResponse>(request);
        }

        /// <summary>
        ///This method does not require any parameters; returns the full list of existing dumps.
        /// </summary>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<EventDumpListResponse> EventDumpListAsync()
        {
            var request = new EventDumpListRequest();
            return GetResponseAsync<EventDumpListResponse>(request);
        }

        /// <summary>
        /// Removes dump from queue or storage.
        /// </summary>
        /// <param name="dumpId">Dump identifier</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<EventDumpDeleteResponse> EventDumpDeleteAsync(string dumpId)
        {
            var request = new EventDumpDeleteRequest(dumpId);
            return GetResponseAsync<EventDumpDeleteResponse>(request);
        }

        #endregion

        #region Tag

        /// <summary>
        /// This method returns the full list of user-defined tags
        /// </summary>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<TagListResponse> TagListAsync()
        {
            var request = new TagListRequest();
            return GetResponseAsync<TagListResponse>(request);
        }

        /// <summary>
        /// Removes tag
        /// </summary>
        /// <param name="tagId">Tag identifier</param>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        public Task<TagDeleteResponse> TagDeleteAsync(int tagId)
        {
            var request = new TagDeleteRequest(tagId);
            return GetResponseAsync<TagDeleteResponse>(request);
        }

        #endregion

        /// <summary>
        /// Get response 
        /// </summary>
        /// <typeparam name="T">Response object</typeparam>
        /// <param name="request">Request object</param>
        /// <exception>Occurs when there is an HttpStatusCode 50x <see cref="HttpStatusCode"/></exception>
        /// <exception cref="UniOneClientValidationException">Occurs when <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> is true</exception>
        /// <returns></returns>
        private async Task<T> GetResponseAsync<T>(BaseRequest request) where T : BaseResponse, new()
        {
            request.ApiKey = _settings.ApiKey;

            if (_settings.IsNeedValidatingRequestBeforeSending)
            {
                request.Validate();
            }

            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(request.ApiEndpoint.Uri, UriKind.Relative),
                Content = new StringContent(request.ToString(), Encoding.UTF8, "application/json")
            };

            var response = await _httpClient.SendAsync(httpRequest);
            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return content.FromJson<T>();
            }

            if (response.StatusCode >= HttpStatusCode.BadRequest &&
                response.StatusCode <= HttpStatusCode.InternalServerError)
            {
                var failure = content.FromJson<FailureResponse>();
                if (failure.Code == 0)
                {
                    failure.Code = (int)response.StatusCode;
                }

                return new T { Failure = failure };
            }

            var message = response.StatusCode > HttpStatusCode.InternalServerError
                ? "We had a problem with server (might be 500, 502, 503 etc.). Please try again later"
                : $"Unknown error. Details: HTTP StatusCode = {(int)response.StatusCode}, Content = {content}";

            return new T
            {
                Failure = new FailureResponse((int)response.StatusCode, message)
            };
        }
    }
}
