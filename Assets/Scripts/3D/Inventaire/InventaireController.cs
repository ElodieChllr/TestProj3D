using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InventaireController : MonoBehaviour
{
    float time = 0;

    [Header("Info Panel")]
    Coroutine dislpayInfo;
    [SerializeField] RectTransform RecPnlInfo;
    bool inventaireActif;

    PlayerInput playerInputRef;
    public GameObject player;
    void Start()
    {
        playerInputRef = player.GetComponent<PlayerInput>();
    }
    // Update is called once per frame
    void Update()
    {
        if (playerInputRef.actions["Inventaire"].IsPressed())
        {
            OnDisplayInfoPanel(true);
        }

        if (inventaireActif == true && playerInputRef.actions["Inventaire"].IsPressed())
        {
            Debug.Log("J'appuie la");

            OnDisplayInfoPanel(false);
        }
            
    }
    void OnDisplayInfoPanel(bool display)
    {
        if (dislpayInfo != null)
            StopCoroutine(dislpayInfo);


        dislpayInfo = StartCoroutine(DisplayInfo(display));


        IEnumerator DisplayInfo(bool display)
        {

            Vector2 startPos = new Vector2(RecPnlInfo.sizeDelta.x + 250 ,RecPnlInfo.anchoredPosition.y);
            Vector2 endPos = new Vector2(0, RecPnlInfo.anchoredPosition.y);


            if (display)
            {
                while (time < 1)
                {
                    //img_Info.enabled = true;
                    RecPnlInfo.anchoredPosition = Vector2.Lerp(startPos, endPos, time);
                    time += Time.deltaTime;
                    yield return null;
                    inventaireActif = true;
                }

                time = 1;
                RecPnlInfo.anchoredPosition = endPos;
                Debug.Log("end");
            }
            else
            {
                while (time > 0)
                {
                    RecPnlInfo.anchoredPosition = Vector2.Lerp(startPos, endPos, time);
                    time -= Time.deltaTime;
                    yield return null;
                    inventaireActif = false;
                }
                time = 0;
                RecPnlInfo.anchoredPosition = startPos;
                Debug.Log("start");
            }

            time = display ? 1 : 0;
            RecPnlInfo.anchoredPosition = display ? endPos : startPos;


            //RecPnlInfo.anchoredPosition = display ? endPos : startPos;
        }
    }
}
