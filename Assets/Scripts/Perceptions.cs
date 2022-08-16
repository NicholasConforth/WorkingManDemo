using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Perceptions : MonoBehaviour
{
	public abstract GameObject[] getGameObjects();

	public static GameObject GetGameObjectFromTag(GameObject[] gameObjects, string tagName)
	{

		GameObject result = null;

        for (int i = 0; i < gameObjects.Length; i++)
        {
			if (gameObjects[i].CompareTag(tagName))
			{
				result = gameObjects[i];
				break;
			}
		}

		return result;
	}

}