//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace PRI.DICore.SystemNetHttp
{
    
    
    /// <summary>
    /// Default implementation of <sealso cref="IMediaTypeWithQualityHeaderValue" />
    /// </summary>
    public sealed partial class MediaTypeWithQualityHeaderValue : IMediaTypeWithQualityHeaderValue
    {
        
        private System.Net.Http.Headers.MediaTypeWithQualityHeaderValue containedObject;
        
        public MediaTypeWithQualityHeaderValue(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue containedObject)
        {
            if ((containedObject == null))
            {
                throw new System.ArgumentNullException("containedObject");
            }
            this.containedObject = containedObject;
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Quality"/>
        /// </summary>
        public System.Nullable<double> Quality
        {
            get
            {
                return this.containedObject.Quality;
            }
            set
            {
                this.containedObject.Quality = value;
            }
        }
    }
}
