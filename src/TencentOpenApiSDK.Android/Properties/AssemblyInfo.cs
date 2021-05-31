using System.Reflection;
using System.Runtime.CompilerServices;
using static System.Properties.TencentOpenApiSDKAssembly;

#if __IOS__
[assembly: AssemblyMetadata("IsTrimmable", "True")]
#endif
[assembly: SuppressIldasm]
[assembly: AssemblyTitle("Tencent Open Platform/QQ Connect SDK for Xamarin Binding Library")]
[assembly: AssemblyFileVersion(Version)]
[assembly: AssemblyVersion(Version)]
namespace System.Properties
{
    public static partial class TencentOpenApiSDKAssembly
    {
        public const string Version =
#if __IOS__
            "3.5.3.62"
#else
            "3.5.4.11"
#endif
            ;
    }
}