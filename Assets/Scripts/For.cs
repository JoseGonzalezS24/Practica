using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class For : MonoBehaviour
{
    [SerializeField] private List<GameObject> gameObjects = new List<GameObject>();
    [SerializeField] private GameObject actualGameObject;
    [SerializeField] private TextMeshProUGUI text;

    public void FindGameobjectFor(GameObject gameobjectToFind)
    {
        text.text = "";
        for (int i = 0; i < gameObjects.Count; i++)
        {
            if (gameObjects[i] == gameobjectToFind)
            {
                gameObjects.Remove(gameObjects[i]);
                text.text = "el gameobject existe en la lista";
            }
            else if (i == (gameObjects.Count - 1) && text.text == "")
                text.text = "no se encontró el gameobject";
        }
    }

    public void FindGameobjectForEach(GameObject gameobjectToFind)
    {
        text.text = "no se encontró el gameobject";
        actualGameObject = null;
        foreach (GameObject item in gameObjects)
        {
            if (gameobjectToFind == item)
            {
                actualGameObject = item;
                text.text = "el gameobject existe en la lista";
            }
        }
    }
}
