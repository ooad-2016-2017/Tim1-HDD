using UnityEngine;


public class GameOverScript : MonoBehaviour
{
	void OnGUI()
	{
		const int buttonWidth = 150;
		const int buttonHeight = 60;

		if (
			GUI.Button(
				new Rect(
					Screen.width / 2 - buttonWidth,
					Screen.height / 2,
					buttonWidth,
					buttonHeight
				),
				"Retry!"
			)
		)
		{
			if (Application.loadedLevelName == "Stage1")
			Application.LoadLevel ("Stage1");
		}

		if (
			GUI.Button(
				new Rect(
                    Screen.width / 2 + buttonWidth,
                    Screen.height / 2,
                    buttonWidth,
                    buttonHeight
                ),
				"Main Menu"
			)
		)
		{
			Application.LoadLevel("Menu");
		}
	}
}