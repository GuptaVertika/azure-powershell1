// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Quota.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Extensions;

    /// <summary>Quota request.</summary>
    public partial class QuotaRequestOneResourceProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.IQuotaRequestOneResourceProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.IQuotaRequestOneResourceProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.IQuotaRequestOneResourceProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject json ? new QuotaRequestOneResourceProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject into a new instance of <see cref="QuotaRequestOneResourceProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal QuotaRequestOneResourceProperties(Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_limit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject>("limit"), out var __jsonLimit) ? Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.LimitObject.FromJson(__jsonLimit) : _limit;}
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject>("name"), out var __jsonName) ? Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.ResourceName.FromJson(__jsonName) : _name;}
            {_error = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject>("error"), out var __jsonError) ? Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.ServiceErrorDetail.FromJson(__jsonError) : _error;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_message = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonString>("message"), out var __jsonMessage) ? (string)__jsonMessage : (string)_message;}
            {_requestSubmitTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonString>("requestSubmitTime"), out var __jsonRequestSubmitTime) ? global::System.DateTime.TryParse((string)__jsonRequestSubmitTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonRequestSubmitTimeValue) ? __jsonRequestSubmitTimeValue : _requestSubmitTime : _requestSubmitTime;}
            {_currentValue = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNumber>("currentValue"), out var __jsonCurrentValue) ? (int?)__jsonCurrentValue : _currentValue;}
            {_unit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonString>("unit"), out var __jsonUnit) ? (string)__jsonUnit : (string)_unit;}
            {_resourceType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonString>("resourceType"), out var __jsonResourceType) ? (string)__jsonResourceType : (string)_resourceType;}
            {_quotaPeriod = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonString>("quotaPeriod"), out var __jsonQuotaPeriod) ? (string)__jsonQuotaPeriod : (string)_quotaPeriod;}
            {_isQuotaApplicable = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonBoolean>("isQuotaApplicable"), out var __jsonIsQuotaApplicable) ? (bool?)__jsonIsQuotaApplicable : _isQuotaApplicable;}
            {_property = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject>("properties"), out var __jsonProperties) ? Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Any.FromJson(__jsonProperties) : _property;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="QuotaRequestOneResourceProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="QuotaRequestOneResourceProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._limit ? (Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode) this._limit.ToJson(null,serializationMode) : null, "limit" ,container.Add );
            AddIf( null != this._name ? (Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode) this._name.ToJson(null,serializationMode) : null, "name" ,container.Add );
            AddIf( null != this._error ? (Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode) this._error.ToJson(null,serializationMode) : null, "error" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._message)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonString(this._message.ToString()) : null, "message" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._requestSubmitTime ? (Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonString(this._requestSubmitTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "requestSubmitTime" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._currentValue ? (Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNumber((int)this._currentValue) : null, "currentValue" ,container.Add );
            }
            AddIf( null != (((object)this._unit)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonString(this._unit.ToString()) : null, "unit" ,container.Add );
            AddIf( null != (((object)this._resourceType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonString(this._resourceType.ToString()) : null, "resourceType" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._quotaPeriod)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonString(this._quotaPeriod.ToString()) : null, "quotaPeriod" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._isQuotaApplicable ? (Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonBoolean((bool)this._isQuotaApplicable) : null, "isQuotaApplicable" ,container.Add );
            }
            AddIf( null != this._property ? (Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode) this._property.ToJson(null,serializationMode) : null, "properties" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}