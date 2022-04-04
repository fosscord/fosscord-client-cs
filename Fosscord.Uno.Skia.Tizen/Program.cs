using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Fosscord.Uno.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new Fosscord.Uno.App(), args);
		host.Run();
	}
}
}
