/*
 * @author venyii
 */
using System;
using System.Collections;
using System.Linq;
using System.Xml.Linq;

namespace SimpleLogitechProfiler
{
	/// <summary>
	/// Description of Profile.
	/// </summary>
	public class Profile
	{
		public string id { get; set; }
		public string name { get; set; }
		
		public bool forceFeedbackEnable { get; set; }
		public bool combinedPedalsEnable { get; set; }
		public bool persistentSpringEnable { get; set; }
		public bool gameSettingsEnable { get; set; }
		
		public int operatingRange { get; set; }
		public int damperGainPercentage { get; set; }
		public int defaultSpringGainPercentage { get; set; }
		public int overallGainPercentage { get; set; }
		public int springGainPercentage { get; set; }
		
		public void loadFromXml(XElement profileNode)
		{
			this.id = profileNode.Attribute("id").Value;
			this.name = profileNode.Attribute("name").Value;

			this.forceFeedbackEnable = Convert.ToInt32(profileNode.Descendants("forceFeedbackEnable").First().Value) == 1;
			this.combinedPedalsEnable = Convert.ToInt32(profileNode.Descendants("combinedPedalsEnable").First().Value) == 1;
			this.persistentSpringEnable = Convert.ToInt32(profileNode.Descendants("persistentSpringEnable").First().Value) == 1;
			this.gameSettingsEnable = Convert.ToInt32(profileNode.Descendants("gameSettingsEnable").First().Value) == 1;

			this.operatingRange = Convert.ToInt32(profileNode.Descendants("operatingRange").First().Value);
			this.damperGainPercentage = Convert.ToInt32(profileNode.Descendants("damperGainPercentage").First().Value);
			this.defaultSpringGainPercentage = Convert.ToInt32(profileNode.Descendants("defaultSpringGainPercentage").First().Value);
			this.overallGainPercentage = Convert.ToInt32(profileNode.Descendants("overallGainPercentage").First().Value);
			this.springGainPercentage = Convert.ToInt32(profileNode.Descendants("springGainPercentage").First().Value);
		}
	}
}
