namespace MakoIoT.Device.Services.Configuration.Metadata.Services
{
    public interface IConfigurationMetadataService
    {
        string GetSectionMetadata(string sectionName);
        string GetDeviceMetadata();
    }
}