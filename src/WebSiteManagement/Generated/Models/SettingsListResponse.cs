// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;

namespace Microsoft.WindowsAzure.WebSitesExtensions.Models
{
    /// <summary>
    /// The list settings operation response.
    /// </summary>
    public partial class SettingsListResponse : OperationResponse
    {
        private IDictionary<string, string> _settings;
        
        /// <summary>
        /// The setting information.
        /// </summary>
        public IDictionary<string, string> Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SettingsListResponse class.
        /// </summary>
        public SettingsListResponse()
        {
            this._settings = new Dictionary<string, string>();
        }
    }
}
