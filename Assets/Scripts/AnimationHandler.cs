using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject book;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowBook()
    {
        book.SetActive(true);
    }
    public void HideBook()
    {
        book.SetActive(false);
    }
}
