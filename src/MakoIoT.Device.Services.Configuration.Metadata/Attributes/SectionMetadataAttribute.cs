
using System;

namespace MakoIoT.Device.Services.Configuration.Metadata.Attributes
{
    public class SectionMetadataAttribute : Attribute
    {
        public string Label { get; }
        public bool IsHidden { get; }
        public SectionMetadataAttribute(string label, bool isHidden = false)
        {
            Label = label;
            IsHidden = isHidden;
        }
    }
}
