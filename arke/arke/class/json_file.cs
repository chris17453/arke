﻿using System;
using System.IO;
using Newtonsoft.Json;

namespace arke{
	public class JsonFile<T> where T : new() {
		private const string DEFAULT_FILENAME = "settings";
		private const string ext = ".json";
		public void Save(string fileName = DEFAULT_FILENAME) {
			File.WriteAllText(fileName + ext, JsonConvert.SerializeObject(this));
		}

		public static void Save(T pSettings, string fileName = DEFAULT_FILENAME) {
			File.WriteAllText(fileName + ext, JsonConvert.SerializeObject(pSettings));
		}

		public static T Load(string fileName = DEFAULT_FILENAME) {
			T t = new T();
			try{
				if (File.Exists(fileName + ext))
					t = JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName + ext));
			} catch (Exception ex) {
				var s = ex.Message;
			}
			return t;
		}
	}//end class
}//end namespace
