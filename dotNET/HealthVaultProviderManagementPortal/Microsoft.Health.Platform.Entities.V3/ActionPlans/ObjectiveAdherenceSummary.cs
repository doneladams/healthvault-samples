﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace Microsoft.Health.Platform.Entities.V3.ActionPlans
{
    using System;
    using System.Collections.ObjectModel;

    /// <summary>
    /// An action plan objective for the purpose of the adherence report
    /// </summary>
    public class ObjectiveAdherenceSummary
    {
        /// <summary>
        /// The unique identifier of the instance of the objective
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the objective
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The name of the associated outcome
        /// </summary>
        public string OutcomeName { get; set; }

        /// <summary>
        /// The Tasks associated with this plan
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "Set needed for serialization.")]
        public Collection<ActionPlanTaskAdherenceSummary> AssociatedTasks { get; set; }
    }
}