using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Diccionarios : MonoBehaviour
{
    [SerializeField] private Dictionary<string, bool> gameobjects = new Dictionary<string, bool>();
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private List<GameObject> gameObjectsScene = new List<GameObject>();
    private void Start()
    {
        AssignDictionary();
    }

    public void AssignDictionary()
    {
        gameObjectsScene.AddRange(FindObjectsOfType<GameObject>());

        List<GameObject> tempList = new List<GameObject>();
        for (int i = 0; i < gameObjectsScene.Count; i++)
        {
            if (gameObjectsScene[i].transform.parent != null)
            {
                tempList.Add(gameObjectsScene[i]);
            }
        }

        for (int i = 0; i < tempList.Count; i++)
        {
            gameObjectsScene.Remove(tempList[i]);
        }

        foreach (var item in gameObjectsScene)
        {
            gameobjects.Add(item.name, item.activeSelf);
            Debug.Log($"el item {item.name} esta activado? {gameobjects[item.name]}");
        }
        Debug.Log($"tamaño del diccionario: {gameobjects.Count}");


    }

    public void CheckItem(string objeto)
    {
        if (gameobjects.TryGetValue(objeto, out bool b))
        {
            int temporalIndex = 0;
            for (int i = 0; i < gameObjectsScene.Count; i++)
            {
                if (gameObjectsScene[i].name == objeto)
                    temporalIndex = i;
            }
            gameObjectsScene[temporalIndex].SetActive(!gameobjects[objeto]);
            gameobjects[objeto] = gameObjectsScene[temporalIndex].activeSelf;

            text.text = $"el objeto {objeto} existe en el diccionario y su valor es {gameobjects[objeto]}";
        }
        else
        {
            text.text = $"el objeto {objeto} NO existe en el diccionario";
        }
    }
}
