/* 
 * Transport for London Unified API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// TflApiPresentationEntitiesLine
    /// </summary>
    [DataContract]
    public partial class TflApiPresentationEntitiesLine :  IEquatable<TflApiPresentationEntitiesLine>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TflApiPresentationEntitiesLine" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="modeName">modeName.</param>
        /// <param name="disruptions">disruptions.</param>
        /// <param name="created">created.</param>
        /// <param name="modified">modified.</param>
        /// <param name="lineStatuses">lineStatuses.</param>
        /// <param name="routeSections">routeSections.</param>
        /// <param name="serviceTypes">serviceTypes.</param>
        /// <param name="crowding">crowding.</param>
        public TflApiPresentationEntitiesLine(string id = default(string), string name = default(string), string modeName = default(string), List<TflApiPresentationEntitiesDisruption> disruptions = default(List<TflApiPresentationEntitiesDisruption>), DateTime? created = default(DateTime?), DateTime? modified = default(DateTime?), List<TflApiPresentationEntitiesLineStatus> lineStatuses = default(List<TflApiPresentationEntitiesLineStatus>), List<TflApiPresentationEntitiesMatchedRoute> routeSections = default(List<TflApiPresentationEntitiesMatchedRoute>), List<TflApiPresentationEntitiesLineServiceTypeInfo> serviceTypes = default(List<TflApiPresentationEntitiesLineServiceTypeInfo>), TflApiPresentationEntitiesCrowding crowding = default(TflApiPresentationEntitiesCrowding))
        {
            this.Id = id;
            this.Name = name;
            this.ModeName = modeName;
            this.Disruptions = disruptions;
            this.Created = created;
            this.Modified = modified;
            this.LineStatuses = lineStatuses;
            this.RouteSections = routeSections;
            this.ServiceTypes = serviceTypes;
            this.Crowding = crowding;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ModeName
        /// </summary>
        [DataMember(Name="modeName", EmitDefaultValue=false)]
        public string ModeName { get; set; }

        /// <summary>
        /// Gets or Sets Disruptions
        /// </summary>
        [DataMember(Name="disruptions", EmitDefaultValue=false)]
        public List<TflApiPresentationEntitiesDisruption> Disruptions { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Gets or Sets LineStatuses
        /// </summary>
        [DataMember(Name="lineStatuses", EmitDefaultValue=false)]
        public List<TflApiPresentationEntitiesLineStatus> LineStatuses { get; set; }

        /// <summary>
        /// Gets or Sets RouteSections
        /// </summary>
        [DataMember(Name="routeSections", EmitDefaultValue=false)]
        public List<TflApiPresentationEntitiesMatchedRoute> RouteSections { get; set; }

        /// <summary>
        /// Gets or Sets ServiceTypes
        /// </summary>
        [DataMember(Name="serviceTypes", EmitDefaultValue=false)]
        public List<TflApiPresentationEntitiesLineServiceTypeInfo> ServiceTypes { get; set; }

        /// <summary>
        /// Gets or Sets Crowding
        /// </summary>
        [DataMember(Name="crowding", EmitDefaultValue=false)]
        public TflApiPresentationEntitiesCrowding Crowding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TflApiPresentationEntitiesLine {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ModeName: ").Append(ModeName).Append("\n");
            sb.Append("  Disruptions: ").Append(Disruptions).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  LineStatuses: ").Append(LineStatuses).Append("\n");
            sb.Append("  RouteSections: ").Append(RouteSections).Append("\n");
            sb.Append("  ServiceTypes: ").Append(ServiceTypes).Append("\n");
            sb.Append("  Crowding: ").Append(Crowding).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TflApiPresentationEntitiesLine);
        }

        /// <summary>
        /// Returns true if TflApiPresentationEntitiesLine instances are equal
        /// </summary>
        /// <param name="input">Instance of TflApiPresentationEntitiesLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TflApiPresentationEntitiesLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ModeName == input.ModeName ||
                    (this.ModeName != null &&
                    this.ModeName.Equals(input.ModeName))
                ) && 
                (
                    this.Disruptions == input.Disruptions ||
                    this.Disruptions != null &&
                    this.Disruptions.SequenceEqual(input.Disruptions)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.LineStatuses == input.LineStatuses ||
                    this.LineStatuses != null &&
                    this.LineStatuses.SequenceEqual(input.LineStatuses)
                ) && 
                (
                    this.RouteSections == input.RouteSections ||
                    this.RouteSections != null &&
                    this.RouteSections.SequenceEqual(input.RouteSections)
                ) && 
                (
                    this.ServiceTypes == input.ServiceTypes ||
                    this.ServiceTypes != null &&
                    this.ServiceTypes.SequenceEqual(input.ServiceTypes)
                ) && 
                (
                    this.Crowding == input.Crowding ||
                    (this.Crowding != null &&
                    this.Crowding.Equals(input.Crowding))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ModeName != null)
                    hashCode = hashCode * 59 + this.ModeName.GetHashCode();
                if (this.Disruptions != null)
                    hashCode = hashCode * 59 + this.Disruptions.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.LineStatuses != null)
                    hashCode = hashCode * 59 + this.LineStatuses.GetHashCode();
                if (this.RouteSections != null)
                    hashCode = hashCode * 59 + this.RouteSections.GetHashCode();
                if (this.ServiceTypes != null)
                    hashCode = hashCode * 59 + this.ServiceTypes.GetHashCode();
                if (this.Crowding != null)
                    hashCode = hashCode * 59 + this.Crowding.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
