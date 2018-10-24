using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public List<GameObject> models;
    private int index = 0;

    public void Start()
    {
        for (int i=0; i<models.Count; i++)
        {
            models[i].SetActive(i == 0);
        }
    }

    public void previous()
    {
        models[index].SetActive(false);
        if (index == 0)
        {
            index = models.Count - 1;
        } else
        {
            index--;
        }
        models[index].SetActive(true);
    }

    public void next()
    {
        models[index].SetActive(false);
        if (index == models.Count - 1)
        {
            index = 0;
        } else
        {
            index++;
        }
        models[index].SetActive(true);
    }
}
