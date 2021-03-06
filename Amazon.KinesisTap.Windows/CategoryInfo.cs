/*
 * Copyright 2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.KinesisTap.Windows
{
    public class CategoryInfo
    {
        public CategoryInfo(string categoryName, string[] instances, string[] counters, string instanceRegex)
        {
            this.CategoryName = categoryName;
            this.InstanceFilters = instances;
            this.CounterFilters = counters;
            this.InstanceRegex = instanceRegex;
        }

        public string CategoryName { get; private set; }
        public string[] InstanceFilters { get; private set; }
        public  string[] CounterFilters { get; private set; }
        public string InstanceRegex { get; private set; }
    }
}
