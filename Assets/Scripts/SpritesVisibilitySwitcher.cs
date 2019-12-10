using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpritesVisibilitySwitcher : MonoBehaviour
{
	public enum CurVisible
	{
		Single_sRGB_ON,
		Packed_sRGB_ON,
		Single_sRGB_OFF,
		Packed_sRGB_OFF
	}

	public static readonly Color ColorActive = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	public static readonly Color ColorInactive = new Color(1.0f, 1.0f, 1.0f, 0.2f);

	public Text m_Title_Single_sRGB_ON;
	public Text m_Title_Packed_sRGB_ON;
	public Text m_Title_Single_sRGB_OFF;
	public Text m_Title_Packed_sRGB_OFF;
	
	public GameObject m_Sprite_Single_sRGB_ON;
	public GameObject m_Sprite_Packed_sRGB_ON;
	public GameObject m_Sprite_Single_sRGB_OFF;
	public GameObject m_Sprite_Packed_sRGB_OFF;


	// Start is called before the first frame update
	void Start()
	{
		UpdateVisibility(CurVisible.Single_sRGB_ON);
	}


	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1) == true || Input.GetKeyDown(KeyCode.Keypad1) == true)
		{
			UpdateVisibility(CurVisible.Single_sRGB_ON);
		}
		
		if (Input.GetKeyDown(KeyCode.Alpha2) == true || Input.GetKeyDown(KeyCode.Keypad2) == true)
		{
			UpdateVisibility(CurVisible.Packed_sRGB_ON);
		}
		
		if (Input.GetKeyDown(KeyCode.Alpha3) == true || Input.GetKeyDown(KeyCode.Keypad3) == true)
		{
			UpdateVisibility(CurVisible.Single_sRGB_OFF);
		}
		
		if (Input.GetKeyDown(KeyCode.Alpha4) == true || Input.GetKeyDown(KeyCode.Keypad4) == true)
		{
			UpdateVisibility(CurVisible.Packed_sRGB_OFF);
		}		
		
	}


	private void UpdateVisibility(CurVisible a_CurVisible)
	{
		m_Title_Single_sRGB_ON.color = ColorInactive;
		m_Title_Packed_sRGB_ON.color = ColorInactive;
		m_Title_Single_sRGB_OFF.color = ColorInactive;
		m_Title_Packed_sRGB_OFF.color = ColorInactive;
		
		m_Sprite_Single_sRGB_ON.SetActive(false);
		m_Sprite_Packed_sRGB_ON.SetActive(false);
		m_Sprite_Single_sRGB_OFF.SetActive(false);
		m_Sprite_Packed_sRGB_OFF.SetActive(false);
		
		switch (a_CurVisible)
		{
			case CurVisible.Single_sRGB_ON:
				m_Sprite_Single_sRGB_ON.SetActive(true);
				m_Title_Single_sRGB_ON.color = ColorActive;
				break;

			case CurVisible.Packed_sRGB_ON:
				m_Sprite_Packed_sRGB_ON.SetActive(true);
				m_Title_Packed_sRGB_ON.color = ColorActive;
				break;

			case CurVisible.Single_sRGB_OFF:
				m_Sprite_Single_sRGB_OFF.SetActive(true);
				m_Title_Single_sRGB_OFF.color = ColorActive;
				break;
			
			case CurVisible.Packed_sRGB_OFF:
				m_Sprite_Packed_sRGB_OFF.SetActive(true);
				m_Title_Packed_sRGB_OFF.color = ColorActive;
				break;
		}
	}
}