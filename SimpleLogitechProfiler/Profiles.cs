/*
 * @author venyii
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;

namespace SimpleLogitechProfiler
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Profiles
	{
		
		public List<Profile> profiles = new List<Profile>();
		public string profileXml;
		
		public Profiles()
		{
			this.profileXml = System.Environment.CurrentDirectory + System.IO.Path.DirectorySeparatorChar + "profiles.xml";
		}
		
		public bool existsProfileXml()
		{
			return System.IO.File.Exists(this.profileXml);
		}
		
		public List<Profile> getProfiles()
		{
			return this.profiles;
		}
		
		public void loadProfilesFromFile()
		{
			XDocument doc = XDocument.Load(this.profileXml);

			foreach (var profileNode in doc.Descendants("profile"))
			{
				Profile p = new Profile();
				p.loadFromXml(profileNode);

				this.profiles.Add(p);
			}
		}
		
		public List<Profile> buildDataSource()
		{
			var dataSource = new List<Profile>();
			
			foreach (var profile in this.profiles)
			{
				dataSource.Add(profile);
			}
			
			return dataSource;
		}
		
		public Profile getById(string id)
		{
			foreach (var profile in this.profiles)
			{
				if (profile.id == id) {
					return profile;
				}
			}
			
			return null;
		}
	}
}
