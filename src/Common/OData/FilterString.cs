﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Microsoft.WindowsAzure.Common.OData
{
    /// <summary>
    /// Handles OData filter generation.
    /// </summary>
    public class FilterString
    {
        /// <summary>
        /// Generates an OData filter from a specified class combining properties
        /// via AND operator. Properties set as null will be omitted.
        /// </summary>
        /// <typeparam name="T">Filter type</typeparam>
        /// <param name="filter">Entity to use for filter generation</param>
        /// <returns></returns>
        public static string Generate<T>(T filter)
        {
            var filterBuilder = new List<string>();
            var properties = typeof (T).GetProperties();
            foreach (var property in properties)
            {
                var nameAttribute = GetPropertyName(property);
                var value = property.GetValue(filter, null);
                if (value != null)
                {
                    filterBuilder.Add(string.Format("{0} eq {1}"))
                }
            }
            return "";
        }

        private static string GetPropertyName(PropertyInfo property)
        {
            foreach (var attribute in property.GetCustomAttributes(true))
            {
                var parameterAttribute = attribute as FilterParameterAttribute;
                if (parameterAttribute != null && !string.IsNullOrEmpty(parameterAttribute.Name))
                {
                    return parameterAttribute.Name;
                }
            }
            return property.Name;
        }
    }
}
