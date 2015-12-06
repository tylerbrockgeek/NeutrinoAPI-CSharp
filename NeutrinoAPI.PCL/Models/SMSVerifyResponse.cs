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
    public class SMSVerifyResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private bool numberValid;
        private string securityCode;
        private bool sent;

        /// <summary>
        /// Is this a valid phone number
        /// </summary>
        [JsonProperty("numberValid")]
        public bool NumberValid 
        { 
            get 
            {
                return this.numberValid; 
            } 
            set 
            {
                this.numberValid = value;
                onPropertyChanged("NumberValid");
            }
        }

        /// <summary>
        /// The security code generated, you can save this code to perform your own verification or you can use the Verify Security Code API
        /// </summary>
        [JsonProperty("securityCode")]
        public string SecurityCode 
        { 
            get 
            {
                return this.securityCode; 
            } 
            set 
            {
                this.securityCode = value;
                onPropertyChanged("SecurityCode");
            }
        }

        /// <summary>
        /// True if the SMS has been sent
        /// </summary>
        [JsonProperty("sent")]
        public bool Sent 
        { 
            get 
            {
                return this.sent; 
            } 
            set 
            {
                this.sent = value;
                onPropertyChanged("Sent");
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