using Net.Chdk.Meta.Model.CameraList;
using Net.Chdk.Meta.Model.CameraTree;

namespace Net.Chdk.Meta.Providers
{
    public interface ICameraModelValidator
    {
        void Validate(string platform, ListPlatformData list, TreePlatformData tree);
    }
}
