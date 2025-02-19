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
    /// TflApiPresentationEntitiesLineModeGroup
    /// </summary>
    [DataContract]
    public partial class TflApiPresentationEntitiesLineModeGroup :  IEquatable<TflApiPresentationEntitiesLineModeGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TflApiPresentationEntitiesLineModeGroup" /> class.
        /// </summary>
        /// <param name="modeName">modeName.</param>
        /// <param name="lineIdentifier">lineIdentifier.</param>
        public TflApiPresentationEntitiesLineModeGroup(string modeName = default(string), List<string> lineIdentifier = default(List<string>))
        {
            this.ModeName = modeName;
            this.LineIdentifier = lineIdentifier;
        }
        
        /// <summary>
        /// Gets or Sets ModeName
        /// </summary>
        [DataMember(Name="modeName", EmitDefaultValue=false)]
        public string ModeName { get; set; }

        /// <summary>
        /// Gets or Sets LineIdentifier
        /// </summary>
        [DataMember(Name="lineIdentifier", EmitDefaultValue=false)]
        public List<string> LineIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TflApiPresentationEntitiesLineModeGroup {\n");
            sb.Append("  ModeName: ").Append(ModeName).Append("\n");
            sb.Append("  LineIdentifier: ").Append(LineIdentifier).Append("\n");
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
            return this.Equals(input as TflApiPresentationEntitiesLineModeGroup);
        }

        /// <summary>
        /// Returns true if TflApiPresentationEntitiesLineModeGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of TflApiPresentationEntitiesLineModeGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TflApiPresentationEntitiesLineModeGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ModeName == input.ModeName ||
                    (this.ModeName != null &&
                    this.ModeName.Equals(input.ModeName))
                ) && 
                (
                    this.LineIdentifier == input.LineIdentifier ||
                    this.LineIdentifier != null &&
                    this.LineIdentifier.SequenceEqual(input.LineIdentifier)
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
                if (this.ModeName != null)
                    hashCode = hashCode * 59 + this.ModeName.GetHashCode();
                if (this.LineIdentifier != null)
                    hashCode = hashCode * 59 + this.LineIdentifier.GetHashCode();
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
