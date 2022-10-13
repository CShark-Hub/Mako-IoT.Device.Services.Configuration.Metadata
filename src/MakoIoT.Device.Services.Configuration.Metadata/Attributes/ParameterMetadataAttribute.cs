using System;

namespace MakoIoT.Device.Services.Configuration.Metadata.Attributes
{
    public class ParameterMetadataAttribute : Attribute
    {
        public string Type { get; set; }
        public string Label { get; set; }
        public bool IsHidden { get; set; }
        public bool IsSecret { get; set; }

        public ParameterMetadataAttribute(string label, string type = "", bool isHidden = false, bool isSecret = false)
        {
            Type = type;
            Label = label;
            IsHidden = isHidden;
            IsSecret = isSecret;
        }
    }
}
