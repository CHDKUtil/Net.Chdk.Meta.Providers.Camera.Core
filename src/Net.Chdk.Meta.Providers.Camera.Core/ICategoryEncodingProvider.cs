using Net.Chdk.Meta.Model.Camera;

namespace Net.Chdk.Meta.Providers.Camera
{
    public interface ICategoryEncodingProvider : ICategoryNameProvider
    {
        EncodingData GetEncoding(uint version);
    }
}
