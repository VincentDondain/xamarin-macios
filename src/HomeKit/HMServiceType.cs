using System;
using XamCore.ObjCRuntime;
using XamCore.Foundation;

namespace XamCore.HomeKit {

	[Introduced (PlatformName.iOS, 8,0)]
	[Introduced (PlatformName.TvOS, 10,0)]
	static public partial class HMServiceTypeExtensions {
		static IntPtr[] values = new IntPtr [39];

		[Field ("HMServiceTypeLightbulb", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeLightbulb {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeLightbulb", storage);
			}
		}

		[Field ("HMServiceTypeSwitch", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeSwitch {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeSwitch", storage);
			}
		}

		[Field ("HMServiceTypeThermostat", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeThermostat {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeThermostat", storage);
			}
		}

		[Field ("HMServiceTypeGarageDoorOpener", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeGarageDoorOpener {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeGarageDoorOpener", storage);
			}
		}

		[Field ("HMServiceTypeAccessoryInformation", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeAccessoryInformation {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeAccessoryInformation", storage);
			}
		}

		[Field ("HMServiceTypeFan", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeFan {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeFan", storage);
			}
		}

		[Field ("HMServiceTypeOutlet", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeOutlet {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeOutlet", storage);
			}
		}

		[Field ("HMServiceTypeLockMechanism", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeLockMechanism {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeLockMechanism", storage);
			}
		}

		[Field ("HMServiceTypeLockManagement", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeLockManagement {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeLockManagement", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeAirQualitySensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeAirQualitySensor {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeAirQualitySensor", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeBattery", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeBattery {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeBattery", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeCarbonDioxideSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeCarbonDioxideSensor {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeCarbonDioxideSensor", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeCarbonMonoxideSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeCarbonMonoxideSensor {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeCarbonMonoxideSensor", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeContactSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeContactSensor {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeContactSensor", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeDoor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeDoor {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeDoor", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeHumiditySensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeHumiditySensor {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeHumiditySensor", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeLeakSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeLeakSensor {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeLeakSensor", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeLightSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeLightSensor {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeLightSensor", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeMotionSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeMotionSensor {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeMotionSensor", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeOccupancySensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeOccupancySensor {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeOccupancySensor", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeSecuritySystem", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeSecuritySystem {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeSecuritySystem", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeStatefulProgrammableSwitch", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeStatefulProgrammableSwitch {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeStatefulProgrammableSwitch", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeStatelessProgrammableSwitch", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeStatelessProgrammableSwitch {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeStatelessProgrammableSwitch", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeSmokeSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeSmokeSensor {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeSmokeSensor", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeTemperatureSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeTemperatureSensor {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeTemperatureSensor", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeWindow", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeWindow {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeWindow", storage);
			}
		}

		[Introduced (PlatformName.iOS, 9,0)]
		[Field ("HMServiceTypeWindowCovering", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeWindowCovering {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeWindowCovering", storage);
			}
		}

		[Introduced (PlatformName.iOS, 10,0)]
		[Introduced (PlatformName.WatchOS, 3,0)]
		[Field ("HMServiceTypeCameraRTPStreamManagement", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeCameraRTPStreamManagement {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeCameraRTPStreamManagement", storage);
			}
		}

		[Introduced (PlatformName.iOS, 10,0)]
		[Introduced (PlatformName.WatchOS, 3,0)]
		[Field ("HMServiceTypeCameraControl", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeCameraControl {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeCameraControl", storage);
			}
		}

		[Introduced (PlatformName.iOS, 10,0)]
		[Introduced (PlatformName.WatchOS, 3,0)]
		[Field ("HMServiceTypeMicrophone", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeMicrophone {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeMicrophone", storage);
			}
		}

		[Introduced (PlatformName.iOS, 10,0)]
		[Introduced (PlatformName.WatchOS, 3,0)]
		[Field ("HMServiceTypeSpeaker", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeSpeaker {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeSpeaker", storage);
			}
		}

		[Introduced (PlatformName.iOS, 10,0)]
		[Introduced (PlatformName.WatchOS, 3,0)]
		[Field ("HMServiceTypeDoorbell", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeDoorbell {
			get {
				fixed (IntPtr *storage = &values [31])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeDoorbell", storage);
			}
		}

		[Introduced (PlatformName.WatchOS, 3,1,1)]
		[Introduced (PlatformName.iOS, 10,2)]
		[Introduced (PlatformName.TvOS, 10,1)]
		[Field ("HMServiceTypeAirPurifier", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeAirPurifier {
			get {
				fixed (IntPtr *storage = &values [32])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeAirPurifier", storage);
			}
		}

		[Introduced (PlatformName.WatchOS, 3,1,1)]
		[Introduced (PlatformName.iOS, 10,2)]
		[Introduced (PlatformName.TvOS, 10,1)]
		[Field ("HMServiceTypeVentilationFan", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeVentilationFan {
			get {
				fixed (IntPtr *storage = &values [33])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeVentilationFan", storage);
			}
		}

		[Introduced (PlatformName.WatchOS, 3,1,1)]
		[Introduced (PlatformName.iOS, 10,2)]
		[Introduced (PlatformName.TvOS, 10,1)]
		[Field ("HMServiceTypeFilterMaintenance", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeFilterMaintenance {
			get {
				fixed (IntPtr *storage = &values [34])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeFilterMaintenance", storage);
			}
		}

		[Introduced (PlatformName.WatchOS, 3,1,1)]
		[Introduced (PlatformName.iOS, 10,2)]
		[Introduced (PlatformName.TvOS, 10,1)]
		[Field ("HMServiceTypeHeaterCooler", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeHeaterCooler {
			get {
				fixed (IntPtr *storage = &values [35])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeHeaterCooler", storage);
			}
		}

		[Introduced (PlatformName.WatchOS, 3,1,1)]
		[Introduced (PlatformName.iOS, 10,2)]
		[Introduced (PlatformName.TvOS, 10,1)]
		[Field ("HMServiceTypeHumidifierDehumidifier", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeHumidifierDehumidifier {
			get {
				fixed (IntPtr *storage = &values [36])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeHumidifierDehumidifier", storage);
			}
		}

		[Introduced (PlatformName.WatchOS, 3,1,1)]
		[Introduced (PlatformName.iOS, 10,2)]
		[Introduced (PlatformName.TvOS, 10,1)]
		[Field ("HMServiceTypeSlats", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeSlats {
			get {
				fixed (IntPtr *storage = &values [37])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeSlats", storage);
			}
		}

		[Introduced (PlatformName.iOS, 10,3)]
		[Introduced (PlatformName.WatchOS, 3,2)]
		[Introduced (PlatformName.TvOS, 10,2)]
		[Field ("HMServiceTypeLabel", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeLabel {
			get {
				fixed (IntPtr *storage = &values [38])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeLabel", storage);
			}
		}

		public static NSString GetConstant (this HMServiceType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // HMServiceType.LightBulb
				ptr = HMServiceTypeLightbulb;
				break;
			case 2: // HMServiceType.Switch
				ptr = HMServiceTypeSwitch;
				break;
			case 3: // HMServiceType.Thermostat
				ptr = HMServiceTypeThermostat;
				break;
			case 4: // HMServiceType.GarageDoorOpener
				ptr = HMServiceTypeGarageDoorOpener;
				break;
			case 5: // HMServiceType.AccessoryInformation
				ptr = HMServiceTypeAccessoryInformation;
				break;
			case 6: // HMServiceType.Fan
				ptr = HMServiceTypeFan;
				break;
			case 7: // HMServiceType.Outlet
				ptr = HMServiceTypeOutlet;
				break;
			case 8: // HMServiceType.LockMechanism
				ptr = HMServiceTypeLockMechanism;
				break;
			case 9: // HMServiceType.LockManagement
				ptr = HMServiceTypeLockManagement;
				break;
			case 10: // HMServiceType.AirQualitySensor
				ptr = HMServiceTypeAirQualitySensor;
				break;
			case 11: // HMServiceType.Battery
				ptr = HMServiceTypeBattery;
				break;
			case 12: // HMServiceType.CarbonDioxideSensor
				ptr = HMServiceTypeCarbonDioxideSensor;
				break;
			case 13: // HMServiceType.CarbonMonoxideSensor
				ptr = HMServiceTypeCarbonMonoxideSensor;
				break;
			case 14: // HMServiceType.ContactSensor
				ptr = HMServiceTypeContactSensor;
				break;
			case 15: // HMServiceType.Door
				ptr = HMServiceTypeDoor;
				break;
			case 16: // HMServiceType.HumiditySensor
				ptr = HMServiceTypeHumiditySensor;
				break;
			case 17: // HMServiceType.LeakSensor
				ptr = HMServiceTypeLeakSensor;
				break;
			case 18: // HMServiceType.LightSensor
				ptr = HMServiceTypeLightSensor;
				break;
			case 19: // HMServiceType.MotionSensor
				ptr = HMServiceTypeMotionSensor;
				break;
			case 20: // HMServiceType.OccupancySensor
				ptr = HMServiceTypeOccupancySensor;
				break;
			case 21: // HMServiceType.SecuritySystem
				ptr = HMServiceTypeSecuritySystem;
				break;
			case 22: // HMServiceType.StatefulProgrammableSwitch
				ptr = HMServiceTypeStatefulProgrammableSwitch;
				break;
			case 23: // HMServiceType.StatelessProgrammableSwitch
				ptr = HMServiceTypeStatelessProgrammableSwitch;
				break;
			case 24: // HMServiceType.SmokeSensor
				ptr = HMServiceTypeSmokeSensor;
				break;
			case 25: // HMServiceType.TemperatureSensor
				ptr = HMServiceTypeTemperatureSensor;
				break;
			case 26: // HMServiceType.Window
				ptr = HMServiceTypeWindow;
				break;
			case 27: // HMServiceType.WindowCovering
				ptr = HMServiceTypeWindowCovering;
				break;
			case 28: // HMServiceType.CameraRtpStreamManagement
				ptr = HMServiceTypeCameraRTPStreamManagement;
				break;
			case 29: // HMServiceType.CameraControl
				ptr = HMServiceTypeCameraControl;
				break;
			case 30: // HMServiceType.Microphone
				ptr = HMServiceTypeMicrophone;
				break;
			case 31: // HMServiceType.Speaker
				ptr = HMServiceTypeSpeaker;
				break;
			case 32: // HMServiceType.Doorbell
				ptr = HMServiceTypeDoorbell;
				break;
			case 33: // HMServiceType.AirPurifier
				ptr = HMServiceTypeAirPurifier;
				break;
			case 34: // HMServiceType.VentilationFan
				ptr = HMServiceTypeVentilationFan;
				break;
			case 35: // HMServiceType.FilterMaintenance
				ptr = HMServiceTypeFilterMaintenance;
				break;
			case 36: // HMServiceType.HeaterCooler
				ptr = HMServiceTypeHeaterCooler;
				break;
			case 37: // HMServiceType.HumidifierDehumidifier
				ptr = HMServiceTypeHumidifierDehumidifier;
				break;
			case 38: // HMServiceType.Slats
				ptr = HMServiceTypeSlats;
				break;
			case 39: // HMServiceType.Label
				ptr = HMServiceTypeLabel;
				break;
			}
			return (NSString) Runtime.GetNSObject (ptr);
		}

		public static HMServiceType GetValue (NSString constant)
		{
			if (constant == null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (HMServiceTypeLightbulb))
				return HMServiceType.LightBulb;
			if (constant.IsEqualTo (HMServiceTypeSwitch))
				return HMServiceType.Switch;
			if (constant.IsEqualTo (HMServiceTypeThermostat))
				return HMServiceType.Thermostat;
			if (constant.IsEqualTo (HMServiceTypeGarageDoorOpener))
				return HMServiceType.GarageDoorOpener;
			if (constant.IsEqualTo (HMServiceTypeAccessoryInformation))
				return HMServiceType.AccessoryInformation;
			if (constant.IsEqualTo (HMServiceTypeFan))
				return HMServiceType.Fan;
			if (constant.IsEqualTo (HMServiceTypeOutlet))
				return HMServiceType.Outlet;
			if (constant.IsEqualTo (HMServiceTypeLockMechanism))
				return HMServiceType.LockMechanism;
			if (constant.IsEqualTo (HMServiceTypeLockManagement))
				return HMServiceType.LockManagement;
			if (constant.IsEqualTo (HMServiceTypeAirQualitySensor))
				return HMServiceType.AirQualitySensor;
			if (constant.IsEqualTo (HMServiceTypeBattery))
				return HMServiceType.Battery;
			if (constant.IsEqualTo (HMServiceTypeCarbonDioxideSensor))
				return HMServiceType.CarbonDioxideSensor;
			if (constant.IsEqualTo (HMServiceTypeCarbonMonoxideSensor))
				return HMServiceType.CarbonMonoxideSensor;
			if (constant.IsEqualTo (HMServiceTypeContactSensor))
				return HMServiceType.ContactSensor;
			if (constant.IsEqualTo (HMServiceTypeDoor))
				return HMServiceType.Door;
			if (constant.IsEqualTo (HMServiceTypeHumiditySensor))
				return HMServiceType.HumiditySensor;
			if (constant.IsEqualTo (HMServiceTypeLeakSensor))
				return HMServiceType.LeakSensor;
			if (constant.IsEqualTo (HMServiceTypeLightSensor))
				return HMServiceType.LightSensor;
			if (constant.IsEqualTo (HMServiceTypeMotionSensor))
				return HMServiceType.MotionSensor;
			if (constant.IsEqualTo (HMServiceTypeOccupancySensor))
				return HMServiceType.OccupancySensor;
			if (constant.IsEqualTo (HMServiceTypeSecuritySystem))
				return HMServiceType.SecuritySystem;
			if (constant.IsEqualTo (HMServiceTypeStatefulProgrammableSwitch))
				return HMServiceType.StatefulProgrammableSwitch;
			if (constant.IsEqualTo (HMServiceTypeStatelessProgrammableSwitch))
				return HMServiceType.StatelessProgrammableSwitch;
			if (constant.IsEqualTo (HMServiceTypeSmokeSensor))
				return HMServiceType.SmokeSensor;
			if (constant.IsEqualTo (HMServiceTypeTemperatureSensor))
				return HMServiceType.TemperatureSensor;
			if (constant.IsEqualTo (HMServiceTypeWindow))
				return HMServiceType.Window;
			if (constant.IsEqualTo (HMServiceTypeWindowCovering))
				return HMServiceType.WindowCovering;
			if (constant.IsEqualTo (HMServiceTypeCameraRTPStreamManagement))
				return HMServiceType.CameraRtpStreamManagement;
			if (constant.IsEqualTo (HMServiceTypeCameraControl))
				return HMServiceType.CameraControl;
			if (constant.IsEqualTo (HMServiceTypeMicrophone))
				return HMServiceType.Microphone;
			if (constant.IsEqualTo (HMServiceTypeSpeaker))
				return HMServiceType.Speaker;
			if (constant.IsEqualTo (HMServiceTypeDoorbell))
				return HMServiceType.Doorbell;
			if (constant.IsEqualTo (HMServiceTypeAirPurifier))
				return HMServiceType.AirPurifier;
			if (constant.IsEqualTo (HMServiceTypeVentilationFan))
				return HMServiceType.VentilationFan;
			if (constant.IsEqualTo (HMServiceTypeFilterMaintenance))
				return HMServiceType.FilterMaintenance;
			if (constant.IsEqualTo (HMServiceTypeHeaterCooler))
				return HMServiceType.HeaterCooler;
			if (constant.IsEqualTo (HMServiceTypeHumidifierDehumidifier))
				return HMServiceType.HumidifierDehumidifier;
			if (constant.IsEqualTo (HMServiceTypeSlats))
				return HMServiceType.Slats;
			if (constant.IsEqualTo (HMServiceTypeLabel))
				return HMServiceType.Label;
			return HMServiceType.Custom;
		}
	}
}