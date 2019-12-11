using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.U2D;

[ExecuteInEditMode]
public class SpriteAtlasDetailsLogger : MonoBehaviour
{
	public List<SpriteAtlas> m_AtlasesToLog;

	public List<Sprite> m_SpritesToLog;

	
	//Logging happens here, when entering the Play Mode
	void Start()
	{
		//atlases
		if (m_AtlasesToLog != null)
		{
			foreach (var atlas in m_AtlasesToLog)
			{
				Log("Details for a SpriteAtlas: " + atlas.name);

				Log("   sRGB state: " + atlas.GetTextureSettings().sRGB);

				Log("   packing.padding:      " + atlas.GetPackingSettings().padding);
				Log("   packing.block offset: " + atlas.GetPackingSettings().blockOffset);
				
				Log("   ------   ");
				
			}
		}
		
		//sprites
		if (m_SpritesToLog != null)
		{
			foreach (var sprite in m_SpritesToLog)
			{
				Log("Details for a sprite: " + sprite.name);

				Log("   is packed: " + sprite.packed);
				
				Log("   graphics format: " + sprite.texture.graphicsFormat);
				
				Log("   texture format: " + sprite.texture.format);
				
				Log("   filter mode: " + sprite.texture.filterMode);
				
				
				Log("   ------   ");
			}
		}


	}


	private void Log(string text)
	{
		if (EditorApplication.isPlaying == true)
		{
			Debug.Log(text);
		}
		else
		{
			Debug.Log("<color=grey>" + text + "</color>");
		}
	}
	
}