/*
 * @author venyii
 */
using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace SimpleLogitechProfiler
{
	/// <summary>
	/// Description of RegistryMap.
	/// </summary>
	public class RegistryMap
	{

		const string REGKEY_G27 = @"HKEY_CURRENT_USER\Software\Logitech\Gaming Software\GlobalDeviceSettings\G27\";

		public bool setActiveProfile(Profile profile)
		{
			if (profile == null) {
				return false;
			}

			Registry.SetValue(REGKEY_G27, "OperatingRange", profile.operatingRange);
			Registry.SetValue(REGKEY_G27, "DamperGainPercentage", profile.damperGainPercentage);
			Registry.SetValue(REGKEY_G27, "DefaultSpringGainPercentage", profile.defaultSpringGainPercentage);
			Registry.SetValue(REGKEY_G27, "OverallGainPercentage", profile.overallGainPercentage);
			Registry.SetValue(REGKEY_G27, "SpringGainPercentage", profile.springGainPercentage);

			Registry.SetValue(REGKEY_G27, "ForceFeedbackEnable", profile.forceFeedbackEnable ? 1 : 0);
			Registry.SetValue(REGKEY_G27, "CombinedPedalsEnable", profile.combinedPedalsEnable ? 1 : 0);
			Registry.SetValue(REGKEY_G27, "PersistentSpringEnable", profile.persistentSpringEnable ? 1 : 0);
			Registry.SetValue(REGKEY_G27, "GameSettingsEnable", profile.gameSettingsEnable ? 1 : 0);

			return true;
		}
	}
}