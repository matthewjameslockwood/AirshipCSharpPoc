using Newtonsoft.Json;
using System.Collections.Generic;

namespace Airship.Models
{
    public partial class Notification
    {
        [JsonProperty("alert")]
        public string Alert { get; set; }
        
        [JsonProperty("web")]
        public WebAlert Web { get; set; }

        [JsonProperty("actions")]
        public Actions Actions { get; set; }
        //[JsonProperty("ios")]
        //public NotificationAlert Ios { get; set; }

        //[JsonProperty("android")]
        //public NotificationAlert Android { get; set; }

        //[JsonProperty("amazon")]
        //public NotificationAlert Amazon { get; set; }

        //[JsonProperty("web")]
        //public NotificationAlert Web { get; set; }

        //[JsonProperty("email")]
        //public Email Email { get; set; }

        //[JsonProperty("wns")]
        //public NotificationAlert Wns { get; set; }

        //[JsonProperty("open::toaster")]
        //public NotificationAlert OpenToaster { get; set; }
    }

    public partial class WebAlert
    {
        [JsonProperty("alert")]
        [JsonRequired]
        public string Alert { get; set; }

        [JsonProperty("title")]
        [JsonRequired]
        public string  Title { get; set; }

        /// <summary>
        /// Providing this object allows a user to be sent an
        /// image inside a notification
        /// </summary>
        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("buttons")]
        public IList<Button> Buttons { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class Email
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("html_body")]
        public string HtmlBody { get; set; }

        [JsonProperty("plaintext_body")]
        public string PlaintextBody { get; set; }

        [JsonProperty("message_type")]
        public string MessageType { get; set; }

        [JsonProperty("sender_name")]
        public string SenderName { get; set; }

        [JsonProperty("sender_address")]
        public string SenderAddress { get; set; }

        [JsonProperty("reply_to")]
        public string ReplyTo { get; set; }
    }
}