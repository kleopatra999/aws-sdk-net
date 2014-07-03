/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the result of a successful invocation of the <a>GetGroup</a> action.
    /// </summary>
    public partial class GetGroupResult
    {
        private Group _group;
        private bool? _isTruncated;
        private string _marker;
        private List<User> _users = new List<User>();


        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// Information about the group.
        /// </para>
        /// </summary>
        public Group Group
        {
            get { return this._group; }
            set { this._group = value; }
        }


        /// <summary>
        /// Sets the Group property
        /// </summary>
        /// <param name="group">The value to set for the Group property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetGroupResult WithGroup(Group group)
        {
            this._group = group;
            return this;
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }


        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more user names to list. If your results were            truncated,
        /// you can make a subsequent pagination request using the <code>Marker</code> request            parameter
        /// to retrieve more user names in the list.
        /// </para>
        /// </summary>
        public bool IsTruncated
        {
            get { return this._isTruncated.GetValueOrDefault(); }
            set { this._isTruncated = value; }
        }


        /// <summary>
        /// Sets the IsTruncated property
        /// </summary>
        /// <param name="isTruncated">The value to set for the IsTruncated property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetGroupResult WithIsTruncated(bool isTruncated)
        {
            this._isTruncated = isTruncated;
            return this;
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// If IsTruncated is <code>true</code>, then this element is present and contains the
        /// value to            use for the <code>Marker</code> parameter in a subsequent pagination request.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }


        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetGroupResult WithMarker(string marker)
        {
            this._marker = marker;
            return this;
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }


        /// <summary>
        /// Gets and sets the property Users. 
        /// <para>
        /// A list of users in the group.
        /// </para>
        /// </summary>
        public List<User> Users
        {
            get { return this._users; }
            set { this._users = value; }
        }

        /// <summary>
        /// Sets the Users property
        /// </summary>
        /// <param name="users">The values to add to the Users collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetGroupResult WithUsers(params User[] users)
        {
            foreach (var element in users)
            {
                this._users.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Users property
        /// </summary>
        /// <param name="users">The values to add to the Users collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetGroupResult WithUsers(IEnumerable<User> users)
        {
            foreach (var element in users)
            {
                this._users.Add(element);
            }
            return this;
        }
        // Check to see if Users property is set
        internal bool IsSetUsers()
        {
            return this._users != null && this._users.Count > 0; 
        }

    }
}