namespace MakoIoT.Device.Services.Configuration.Metadata.Services
{
    public class ConfigurationMetadataService : IConfigurationMetadataService
    {
        private readonly ConfigurationMetadataOptions _options;

        public ConfigurationMetadataService(ConfigurationMetadataOptions options)
        {
            _options = options;
        }

        public string GetSectionMetadata(string sectionName)
        {
            sectionName = sectionName.ToLower();
            if (_options.Metadata.Contains(sectionName))
                return (string)_options.Metadata[sectionName];

            return null;
        }

        public string GetDeviceMetadata()
        {
            return _options.DeviceMetadata;
        }
    }
}
