/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for ListHostedZones operation
    /// </summary>
    internal class ListHostedZonesResponseUnmarshaller : IResponseUnmarshaller<ListHostedZonesResponse, UnmarshallerContext> {

        public ListHostedZonesResponse Unmarshall(UnmarshallerContext context) 
        {
            ListHostedZonesResponse response = new ListHostedZonesResponse();

            
            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    response.ListHostedZonesResult = ListHostedZonesResultUnmarshaller.GetInstance().Unmarshall(context);
                    break;
                }
            }
                 
                        
            return response;
        }
        
        
        public AmazonServiceException UnmarshallException(UnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidInput"))
            {
                return new InvalidInputException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonRoute53Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static ListHostedZonesResponseUnmarshaller instance;

        public static ListHostedZonesResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new ListHostedZonesResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
