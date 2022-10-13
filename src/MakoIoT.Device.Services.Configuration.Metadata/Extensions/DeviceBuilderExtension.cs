using MakoIoT.Device.Services.Configuration.Metadata.Services;
using MakoIoT.Device.Services.DependencyInjection;
using MakoIoT.Device.Services.Interface;

namespace MakoIoT.Device.Services.Configuration.Metadata.Extensions
{
    public delegate void ConfigurationMetadataDelegate(ConfigurationMetadataOptions options);

    public static class DeviceBuilderExtension
    {
        public static IDeviceBuilder AddConfigurationMetadata(this IDeviceBuilder builder, ConfigurationMetadataDelegate configureMetadataAction)
        {
            DI.RegisterSingleton(typeof(IConfigurationMetadataService), typeof(ConfigurationMetadataService));
            var options = new ConfigurationMetadataOptions();
            configureMetadataAction(options);
            DI.RegisterInstance(typeof(ConfigurationMetadataOptions), options);

            return builder;
        }
    }
}
