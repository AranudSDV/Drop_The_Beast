using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayTime : MonoBehaviour
{

    [SerializeField] private float ClickTime;
    [SerializeField] private float ClickCoolDown;
    [SerializeField] private float ClickWindow;

    [SerializeField] private GameObject TimingSphere;
    private float TimingSizeDivider;
    [SerializeField] private TMP_Text Result;
    [SerializeField] private TMP_Text TimingBool;

    private bool InTiming;


    // Start is called before the first frame update
    void Start()
    {
        ClickTime = ClickCoolDown;
    }

    // Update is called once per frame
    void Update()
    {
        TimingSizeDivider += Time.deltaTime;
        TimingBool.text = InTiming.ToString();

        TimingSphere.transform.localScale = new Vector3(1 - TimingSizeDivider,1 -TimingSizeDivider,1 -TimingSizeDivider) ;
        if (Time.time >= ClickTime)
        {
            ClickTime += ClickCoolDown;
            TimingSizeDivider = 0;
            InTiming = false;
        }
        else
        {
            if (Time.time >= ClickTime - ClickWindow && Time.time <= ClickTime + ClickWindow)
            {
                InTiming = true;
            }
         }

        if (Input.GetButtonDown("A"))
        {
            if (InTiming)
            {
                Result.text = "Succès !";
            }
            else
            {
                Result.text = "Échec ...";
            }
        }
    }


}