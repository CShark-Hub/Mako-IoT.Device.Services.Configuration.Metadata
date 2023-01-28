using MakoIoT.Device.Services.Configuration.Metadata.Services;
using MakoIoT.Device.Services.Interface;
using nanoFramework.DependencyInjection;

namespace MakoIoT.Device.Services.Configuration.Metadata.Extensions
{
    public delegate void ConfigurationMetadataDelegate(ConfigurationMetadataOptions options);

    public static class DeviceBuilderExtension
    {
        public static IDeviceBuilder AddConfigurationMetadata(this IDeviceBuilder builder, ConfigurationMetadataDelegate configureMetadataAction)
        {
            builder.Services.AddSingleton(typeof(IConfigurationMetadataService), typeof(ConfigurationMetadataService));
            var options = new ConfigurationMetadataOptions();
            configureMetadataAction(options);
            builder.Services.AddSingleton(typeof(ConfigurationMetadataOptions), options);

            return builder;
        }
    }
}
