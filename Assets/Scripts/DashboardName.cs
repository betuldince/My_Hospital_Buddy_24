using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;


public class DashboardName : MonoBehaviour, IPointerClickHandler
{
    public TMP_Text textMeshProWeek;
    public TMP_Text textMeshProPage;
    private string nameObj;
    public GameObject ARview;
    public void OnPointerClick(PointerEventData eventData)
    {
        
        textMeshProWeek.text = name + ". Hafta";
        int page = int.Parse(nameObj);
        textMeshProPage.text = "İda’yı görmek için telefonu " + page*10 + ".sayfadaki İda’nın üzerine getir!";
        transform.parent.gameObject.SetActive(false);
        ARview.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {

        nameObj = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
