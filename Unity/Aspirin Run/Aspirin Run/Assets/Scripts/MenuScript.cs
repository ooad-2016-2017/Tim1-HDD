using UnityEngine;

/// <summary>
/// Title screen script
/// </summary>
public class MenuScript : MonoBehaviour
{
	private GUISkin skin;

	void Start()
	{
		skin = Resources.Load("GUISkin") as GUISkin;
	}

	void OnGUI()
	{
		const int buttonWidth = 138;
		const int buttonHeight = 70;

		GUI.skin = skin;

		Rect buttonRect = new Rect(
			Screen.width / 3 - buttonWidth,
            (Screen.height) - (buttonHeight) - 100,
			buttonWidth,
			buttonHeight
		);
		Rect buttonRect3 = new Rect(
            Screen.width / 3 + buttonWidth,
			(Screen.height) - (buttonHeight )-100,
			buttonWidth,
			buttonHeight
		);

		if(GUI.Button(buttonRect,"START!"))
		{
			Application.LoadLevel("Stage1");

		}
		if(GUI.Button(buttonRect3,"Exit"))
		{
			Application.Quit();
		}
	}
	void Update() {
		if (Input.GetKey("escape"))
			Application.Quit();

	}
}