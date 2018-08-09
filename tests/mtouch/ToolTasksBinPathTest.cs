using System;
using System.Diagnostics;
using NUnit.Framework;

namespace AppleSdkSettings {

	public static class XcodeVersion {
		public static int Major = 10;
	}
}

namespace Xamarin.MacDev.Tasks {

	public abstract class MetalTaskBase {

		protected abstract string OperatingSystem {
			get;
		}

		protected abstract string DevicePlatformBinDir {
			get;
		}

		protected string SdkDevPath {
			get { return ""; }
		}
	}
}

namespace Xamarin.Mac.Tasks {
	public class MetalPoker : Metal {

		public new string DevicePlatformBinDir {
			get { return base.DevicePlatformBinDir; }
		}
	}

	[TestFixture]
	public class ToolTasksBinPathTest {

		MetalPoker Task;

		[SetUp]
		public void Setup ()
		{
			Task = new MetalPoker ();
		}

		[Test]
		public void MetalBinPathTest ()
		{
			var psi = new ProcessStartInfo ("xcrun") {
				Arguments = "-f metal",
				UseShellExecute = false,
				CreateNoWindow = true,
				RedirectStandardOutput = true,
			};
			var proc = Process.Start (psi);

			string output = proc.StandardOutput.ReadToEnd ();
			Console.WriteLine (output);

			var contains = output.Contains (Task.DevicePlatformBinDir);

			Assert.True (contains);
		}
	}
}
