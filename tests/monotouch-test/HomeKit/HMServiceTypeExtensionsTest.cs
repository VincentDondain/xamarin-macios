//
// Unit tests for HMServiceTypeExtensionsTest
//
// Authors:
//	Vincent Dondain <vidondai@microsoft.com>
//
//
// Copyright 2017 Microsoft. All rights reserved.
//

using System;
using NUnit.Framework;

using Foundation;
using HomeKit;

namespace MonoTouchFixtures.HomeKit {
	[TestFixture]
	[Preserve (AllMembers = true)]
	public class HMServiceTypeExtensionsTest {

		const string ServiceTypeLightbulb = "00000043-0000-1000-8000-0026BB765291"; // Lightbulb UUID
		const string ServiceTypeCustom = "5B92BE50-B952-493A-9E59-C1C822580DD1"; // Custom UUID

		[SetUp]
		public void Setup ()
		{
			TestRuntime.AssertXcodeVersion (6, 0);
		}

		[Test]
		public void ServiceTypeLightbulbTest ()
		{
			using (var obj = new HMServiceTypeLightbulbPoker ()) {
				Assert.AreEqual (HMServiceType.LightBulb, obj.ServiceType, "Lightbulb");
				Assert.AreEqual (new NSString (ServiceTypeLightbulb), obj.ServiceType.GetConstant (), "GetConstant");
			}
		}

		[Test]
		public void ServiceTypeCustomTest ()
		{
			using (var obj = new HMServiceTypeCustomPoker ()) {
				Assert.AreEqual (HMServiceType.Custom, obj.ServiceType, "Custom");
				Assert.AreEqual (new NSString (ServiceTypeCustom), obj.ServiceType.GetConstant (), "GetConstant");
			}
		}

		class HMServiceTypeLightbulbPoker : HMService {
			public override NSString WeakServiceType => new NSString (ServiceTypeLightbulb);
		}

		class HMServiceTypeCustomPoker : HMService {
			public override NSString WeakServiceType => new NSString (ServiceTypeCustom);
		}
	}
}
