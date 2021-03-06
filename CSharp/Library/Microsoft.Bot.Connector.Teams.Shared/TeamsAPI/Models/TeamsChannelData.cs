// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Linq;

    /// <summary>
    /// Channel data specific to messages received in Microsoft Teams
    /// </summary>
    public partial class TeamsChannelData
    {
        /// <summary>
        /// Initializes a new instance of the TeamsChannelData class.
        /// </summary>
        public TeamsChannelData() { }

        /// <summary>
        /// Initializes a new instance of the TeamsChannelData class.
        /// </summary>
        /// <param name="channel">Information about the channel in which the
        /// message was sent</param>
        /// <param name="eventType">Type of event.</param>
        /// <param name="team">Information about the team in which the message
        /// was sent</param>
        /// <param name="notification">Notification settings for the
        /// message</param>
        /// <param name="tenant">Information about the tenant in which the
        /// message was sent</param>
        public TeamsChannelData(ChannelInfo channel = default(ChannelInfo), string eventType = default(string), TeamInfo team = default(TeamInfo), NotificationInfo notification = default(NotificationInfo), TenantInfo tenant = default(TenantInfo))
        {
            Channel = channel;
            EventType = eventType;
            Team = team;
            Notification = notification;
            Tenant = tenant;
        }

        /// <summary>
        /// Gets or sets information about the channel in which the message
        /// was sent
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "channel")]
        public ChannelInfo Channel { get; set; }

        /// <summary>
        /// Gets or sets type of event.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or sets information about the team in which the message was
        /// sent
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "team")]
        public TeamInfo Team { get; set; }

        /// <summary>
        /// Gets or sets notification settings for the message
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "notification")]
        public NotificationInfo Notification { get; set; }

        /// <summary>
        /// Gets or sets information about the tenant in which the message was
        /// sent
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tenant")]
        public TenantInfo Tenant { get; set; }

    }
}
