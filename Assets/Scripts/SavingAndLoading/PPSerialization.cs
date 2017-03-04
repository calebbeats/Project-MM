using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class PPSerialization {

	public static BinaryFormatter binaryFormatter = new BinaryFormatter();

	public static void Save(string saveTag, object obj)
	{
		// Converts a object obj to a string of 1s and 0s. To save information.
		MemoryStream memoryStream = new MemoryStream ();
		binaryFormatter.Serialize (memoryStream, obj);
		string temp = System.Convert.ToBase64String (memoryStream.ToArray ());
		PlayerPrefs.SetString (saveTag, temp);
	}

	public static object Load(string saveTag)
	{
		//Send to saveTag to temp.
		string temp = PlayerPrefs.GetString(saveTag);
		// Checks value to see if its empty.
		if (temp == string.Empty) {
			return null;
		}
		// Prepares memoryStream and deserializes string.
		MemoryStream memoryStream = new MemoryStream (System.Convert.FromBase64String(temp));
		return binaryFormatter.Deserialize (memoryStream);
	}
}
