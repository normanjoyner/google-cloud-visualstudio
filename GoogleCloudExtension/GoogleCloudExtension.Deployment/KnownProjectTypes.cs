﻿// Copyright 2017 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace GoogleCloudExtension.Deployment
{
    /// <summary>
    /// The type of projects supported.
    /// </summary>
    public enum KnownProjectTypes
    {
        /// <summary>
        /// The unknown project.
        /// </summary>
        None,

        /// <summary>
        /// An ASP.NET 4.x app.
        /// </summary>
        WebApplication,

        /// <summary>
        /// An ASP.NET Core 1.0 app
        /// </summary>
        NetCoreWebApplication1_0,

        /// <summary>
        /// An ASP.NET Core 1.1 app
        /// </summary>
        NetCoreWebApplication1_1,

        /// <summary>
        /// An ASP.NET Core 2.0 app
        /// </summary>
        NetCoreWebApplication2_0,
    }
}