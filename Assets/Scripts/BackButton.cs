using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject [] imageTargets;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CloseAllImageTargets()
    {
        foreach (GameObject obj in imageTargets)
        {
            obj.SetActive(false);
        }
    }
}
