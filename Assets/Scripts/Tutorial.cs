using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{

    private bool InRange;
    public GameObject TutorialPanel;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && InRange)
        {
            if (TutorialPanel.activeInHierarchy)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    TutorialPanel.SetActive(false);
                }
            }
            else
            {
                TutorialPanel.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            InRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            InRange = false;
            if (TutorialPanel.activeInHierarchy)
            {
                TutorialPanel.SetActive(false);
            }
        }   
    }
}
