using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SobreCargas : MonoBehaviour
{
    [SerializeField] private int number;
    [SerializeField] private int number1;
    [SerializeField] private int number2;
    [SerializeField] private int number3;
    [Space(30)]
    [SerializeField] private int min;
    [SerializeField] private int max;
    [SerializeField] private List<int> excludeList = new List<int>();

    void Start()
    {
        excludeList.Add(number = Random.Range(min, max));
        excludeList.Add(number1 = ExcludeNumber(min, max, excludeList[0]));
        excludeList.Add(number2 = ExcludeNumber(min, max, excludeList));
        excludeList.Add(number3 = ExcludeNumber(min, max, excludeList));
    }


    private int ExcludeNumber(int min, int max, List<int> exludeList)
    {
        int result = Random.Range(min, max);
        bool exit = false;

        while (!exit)
        {
            for (int i = 0; i < exludeList.Count; i++)
            {
                if (result == exludeList[i])
                {
                    result = Random.Range(min, max);
                    break;
                }
                else if (i == (exludeList.Count - 1))
                {
                    exit = true;
                }
            }
        }

        return result;
    }

    private int ExcludeNumber(int min, int max, int excludeNumber)
    {
        int result = Random.Range(min, max);

        while (result == excludeNumber)
        {
            result = Random.Range(min, max);
        }

        return result;
    }

    void Update()
    {
        
    }
}
