/*
 * ProvisioningAPI.PCL
 *
 * This file was automatically generated by APIMATIC BETA v2.0 on 01/26/2015
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
using ProvisioningAPI.PCL;

namespace ProvisioningAPI.PCL.Models
{
    public class Peer : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private bool? t38Enabled;
        private string dtmf;
        private bool? dtmfInbandMute;
        private string codecs;

        /// <summary>
        /// Indicates whether a DID is T.38 enabled. It can be configured per DID in the configuration module using the applyConfiguration method
        /// </summary>
        [JsonProperty("t38Enabled")]
        public bool? T38Enabled 
        { 
            get 
            {
                return this.t38Enabled; 
            } 
            set 
            {
                this.t38Enabled = value;
                onPropertyChanged("T38Enabled");
            }
        }

        /// <summary>
        /// dtmf and dtmfInbandMute indicate the current DMTF configuration for the calls on a given DID. The possible values for dtmf are INBAND, INFO, RFC2833, RFC2833_INFO, RFC2833_INBAND. For the last two values, the system will automatically choose between RFC2833 and INFO or INBAND. The standard way to carry out-of-band DTMF via SIP is as RTP payload (see RFC 2833). It has the advantage that it provides accurate timing and alignment with the speech RTP packets.
        /// </summary>
        [JsonProperty("dtmf")]
        public string Dtmf 
        { 
            get 
            {
                return this.dtmf; 
            } 
            set 
            {
                this.dtmf = value;
                onPropertyChanged("Dtmf");
            }
        }

        /// <summary>
        /// By activating dtmfInbandMute on a number, the inband DTMF tones are removed from the audio stream. This is recommended when you add inband DTMF tones yourself to the audio stream afterwards (which can be the case for example when the call is sent back to the PSTN).
        /// </summary>
        [JsonProperty("dtmfInbandMute")]
        public bool? DtmfInbandMute 
        { 
            get 
            {
                return this.dtmfInbandMute; 
            } 
            set 
            {
                this.dtmfInbandMute = value;
                onPropertyChanged("DtmfInbandMute");
            }
        }

        /// <summary>
        /// List of codecs that are supported for the calls on a given DID. The possible values are: G711A, G711U, G729, G723.
        /// </summary>
        [JsonProperty("codecs")]
        public string Codecs 
        { 
            get 
            {
                return this.codecs; 
            } 
            set 
            {
                this.codecs = value;
                onPropertyChanged("Codecs");
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