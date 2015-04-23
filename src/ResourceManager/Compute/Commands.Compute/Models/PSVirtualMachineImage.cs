﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Management.Compute.Models;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Compute.Models
{
    public class PSVirtualMachineImageBase : PSOperationContext
    {
        public string Id { get; set; }

        public string Location { get; set; }
    }

    public class PSVirtualMachineImagePublisher : PSVirtualMachineImageBase
    {

        public string PublisherName { get; set; }
    }

    public class PSVirtualMachineImageOffer : PSVirtualMachineImagePublisher
    {
        public string Offer { get; set; }
    }

    public class PSVirtualMachineImageSku : PSVirtualMachineImageOffer
    {
        public string Skus { get; set; }
    }

    public class PSVirtualMachineImage : PSVirtualMachineImageSku
    {
        public string Version { get; set; }

        public string FilterExpression { get; set; }
    }

    public class PSVirtualMachineImageDetail : PSVirtualMachineImage
    {
        public string Name { get; set; }

        public OSDiskImage OSDiskImage { get; set; }

        public PurchasePlan PurchasePlan { get; set; }

        public IList<DataDiskImage> DataDiskImages { get; set; }
    }
}
