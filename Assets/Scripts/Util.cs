using UnityEngine;

namespace Util
{
	// class Util
	// {
	// 	public static string GetFormattedTime(float time)
	// 	{
	// 		var mins = Mathf.Floor(time / 60);
	// 		var secs = time % 60;
	// 		return string.Format("{0:00} :  {1:00} ", mins, secs);
	// 	}
	// }

	class Controller
	{
		public static bool Jump()
		{
			// if (GameManager.instance.UseController)
			// {
			// 	return Input.GetButtonDown("A");
			// }
			// else
			// {
				return Input.GetKeyDown(KeyCode.Space);
			// }
		}

		public static bool IsGravityChange()
		{
			return Input.GetMouseButtonUp(0);
		}

		public static Vector3 GetInputGracityChange()
		{
			return Input.mousePosition;
		}

		// public static bool GetB()
		// {
		// 	if (GameManager.instance.UseController)
		// 	{
		// 		return Input.GetButtonDown("B");
		// 	}
		// 	else
		// 	{
		// 		return Input.GetKeyDown("e");
		// 	}
		// }

		public static float GetVertical()
		{
			return Input.GetAxis("Horizontal");
			// if (GameManager.instance.UseController)
			// {
			// 	return Input.GetButtonDown("X");
			// }
			// else
			// {
			// 	return Input.GetKeyDown("x");
			// }
		}

		public static float GetHorizontal()
		{
			return Input.GetAxis("Vertical");
			// if (GameManager.instance.UseController)
			// {
			// 	return Input.GetButtonDown("Y");
			// }
			// else
			// {
			// 	return Input.GetKeyDown("y");
			// }
		}


		// public static float GetXAxis()
		// {
		// 	if (GameManager.instance.UseController)
		// 	{
		// 		return Input.GetAxis("LeftJoystickX");
		// 	}
		// 	else
		// 	{
		// 		return Input.GetAxis("Horizontal");
		// 	}
		// }

		// public static float GetYAxis()
		// {
		// 	if (GameManager.instance.UseController)
		// 	{
		// 		return -Input.GetAxis("LeftJoystickY");
		// 	}
		// 	else
		// 	{
		// 		return Input.GetAxis("Vertical");
		// 	}
		// }

		// public static float GetCamXAxis()
		// {
		// 	if (GameManager.instance.UseController)
		// 	{
		// 		return Input.GetAxis("RightJoystickX");
		// 	}
		// 	else
		// 	{
		// 		return Input.GetAxis("Mouse X");
		// 	}
		// }

		// public static float GetCamYAxis()
		// {
		// 	if (GameManager.instance.UseController)
		// 		return Input.GetAxis("RightJoystickY");
		// 	else
		// 		return Input.GetAxis("Mouse Y");
		// }
	}

	// class MyLayers
	// {
	// 	static private string breakableMaskName = "Breakable";
	// 	static private string knockableMaskName = "Knockable";
	// 	static private string toolsMaskName = "Tools";
	// 	static private string interactableMaskName = "Interactable";

	// 	static public int breakableMask = 1 << LayerMask.NameToLayer(breakableMaskName);
	// 	static public int knockableMask = 1 << LayerMask.NameToLayer(knockableMaskName);
	// 	static public int toolsMask = 1 << LayerMask.NameToLayer(toolsMaskName);
	// 	static public int interactableMask = 1 << LayerMask.NameToLayer(interactableMaskName);
	// }

}