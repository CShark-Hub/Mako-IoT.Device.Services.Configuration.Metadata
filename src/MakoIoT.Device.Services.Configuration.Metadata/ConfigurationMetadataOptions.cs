using System.Collections;

namespace MakoIoT.Device.Services.Configuration.Metadata
{
    public class ConfigurationMetadataOptions
    {
        internal Hashtable Metadata = new Hashtable();
        internal string DeviceMetadata { get; private set; }

        /// <summary>
        /// Registers configuration section metadata.
        /// </summary>
        /// <param name="sectionName">Configuration section name</param>
        /// <param name="metadata">Configuration section metadata</param>
        public void AddMetadata(string sectionName, string metadata)
        {
            Metadata.Add(sectionName.ToLower(), metadata);
        }

        /// <summary>
        /// Registers device details (name, manufacturer, s/n)
        /// </summary>
        /// <param name="metadata">Device metadata</param>
        public void AddDeviceMetadata(string metadata)
        {
            DeviceMetadata = metadata;
        }

    }
}
