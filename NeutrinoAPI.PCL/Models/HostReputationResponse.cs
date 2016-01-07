/*
 * NeutrinoAPI.PCL
 *
 * This file was automatically generated for NeutrinoAPI.com by APIMATIC BETA v2.0 on 01/07/2016
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
    public class HostReputationResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private bool isListed;
        private List<Blacklist> lists;
        private int listCount;

        /// <summary>
        /// Is this host blacklisted
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
        /// An array of objects for each DNSBL checked
        /// </summary>
        [JsonProperty("lists")]
        public List<Blacklist> Lists 
        { 
            get 
            {
                return this.lists; 
            } 
            set 
            {
                this.lists = value;
                onPropertyChanged("Lists");
            }
        }

        /// <summary>
        /// The number of DNSBL's the host is listed on
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