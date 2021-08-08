using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Bugs.Uno.Skia.WPF.XamlExtensionBug.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new Bugs.Uno.Skia.WPF.XamlExtensionBug.App(), args);
		host.Run();
	}
}
}
