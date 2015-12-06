/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI.com by APIMATIC BETA v2.0 on 12/06/2015
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NeutrinoAPI.PCL;

namespace NeutrinoAPI.PCL.Models
{
    public class IPBlocklistResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private bool isBot;
        private bool isExploitBot;
        private bool isMalware;
        private bool isSpider;
        private bool isDshield;
        private int listCount;
        private bool isProxy;
        private bool isHijacked;
        private bool isTor;
        private bool isSpyware;
        private bool isSpamBot;
        private bool isListed;
        private bool isVpn;

        /// <summary>
        /// IP is hosting a malicious bot or is part of a botnet
        /// </summary>
        [JsonProperty("isBot")]
        public bool IsBot 
        { 
            get 
            {
                return this.isBot; 
            } 
            set 
            {
                this.isBot = value;
                onPropertyChanged("IsBot");
            }
        }

        /// <summary>
        /// IP is hosting an exploit finding bot or exploit scanning software
        /// </summary>
        [JsonProperty("isExploitBot")]
        public bool IsExploitBot 
        { 
            get 
            {
                return this.isExploitBot; 
            } 
            set 
            {
                this.isExploitBot = value;
                onPropertyChanged("IsExploitBot");
            }
        }

        /// <summary>
        /// IP is involved in distributing malware
        /// </summary>
        [JsonProperty("isMalware")]
        public bool IsMalware 
        { 
            get 
            {
                return this.isMalware; 
            } 
            set 
            {
                this.isMalware = value;
                onPropertyChanged("IsMalware");
            }
        }

        /// <summary>
        /// IP is a hostile spider or crawler
        /// </summary>
        [JsonProperty("isSpider")]
        public bool IsSpider 
        { 
            get 
            {
                return this.isSpider; 
            } 
            set 
            {
                this.isSpider = value;
                onPropertyChanged("IsSpider");
            }
        }

        /// <summary>
        /// IP has been flagged on DShield (dshield.org)
        /// </summary>
        [JsonProperty("isDshield")]
        public bool IsDshield 
        { 
            get 
            {
                return this.isDshield; 
            } 
            set 
            {
                this.isDshield = value;
                onPropertyChanged("IsDshield");
            }
        }

        /// <summary>
        /// The number of blocklists the IP is listed on
        /// </summary>
        [JsonProperty("listCount")]
        public int ListCount 
        { 
            get 
            {
                return this.listCount; 
            } 
            set 
            {
                this.listCount = value;
                onPropertyChanged("ListCount");
            }
        }

        /// <summary>
        /// IP has been detected as an anonymous web proxy or anonymous HTTP proxy
        /// </summary>
        [JsonProperty("isProxy")]
        public bool IsProxy 
        { 
            get 
            {
                return this.isProxy; 
            } 
            set 
            {
                this.isProxy = value;
                onPropertyChanged("IsProxy");
            }
        }

        /// <summary>
        /// hijacked netblocks or netblocks controlled by criminal organizations
        /// </summary>
        [JsonProperty("isHijacked")]
        public bool IsHijacked 
        { 
            get 
            {
                return this.isHijacked; 
            } 
            set 
            {
                this.isHijacked = value;
                onPropertyChanged("IsHijacked");
            }
        }

        /// <summary>
        /// IP is coming from a Tor node
        /// </summary>
        [JsonProperty("isTor")]
        public bool IsTor 
        { 
            get 
            {
                return this.isTor; 
            } 
            set 
            {
                this.isTor = value;
                onPropertyChanged("IsTor");
            }
        }

        /// <summary>
        /// IP is being used by spyware, malware, botnets or for other malicious activities
        /// </summary>
        [JsonProperty("isSpyware")]
        public bool IsSpyware 
        { 
            get 
            {
                return this.isSpyware; 
            } 
            set 
            {
                this.isSpyware = value;
                onPropertyChanged("IsSpyware");
            }
        }

        /// <summary>
        /// IP address is hosting a spam bot, comment spamming or other spamming software
        /// </summary>
        [JsonProperty("isSpamBot")]
        public bool IsSpamBot 
        { 
            get 
            {
                return this.isSpamBot; 
            } 
            set 
            {
                this.isSpamBot = value;
                onPropertyChanged("IsSpamBot");
            }
        }

        /// <summary>
        /// Is this IP on a blocklist
        /// </summary>
        [JsonProperty("isListed")]
        public bool IsListed 
        { 
            get 
            {
                return this.isListed; 
            } 
            set 
            {
                this.isListed = value;
                onPropertyChanged("IsListed");
            }
        }

        /// <summary>
        /// IP has been detected as coming from a VPN hosting provider
        /// </summary>
        [JsonProperty("isVpn")]
        public bool IsVpn 
        { 
            get 
            {
                return this.isVpn; 
            } 
            set 
            {
                this.isVpn = value;
                onPropertyChanged("IsVpn");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 