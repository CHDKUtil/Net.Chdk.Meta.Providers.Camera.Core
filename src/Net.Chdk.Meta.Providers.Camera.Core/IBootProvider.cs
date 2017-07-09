using Net.Chdk.Meta.Model.Camera;

namespace Net.Chdk.Meta.Providers.Camera
{
    public interface IBootProvider
    {
        BootData GetBoot(uint modelId);
    }
}
