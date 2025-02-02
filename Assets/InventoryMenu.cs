using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryMenu : MonoBehaviour
{

    [SerializeField] private GameObject Inventory;

    private bool IsInven;
    private bool key;


    private void Update()
    {
        key = Input.GetKeyDown(KeyCode.E);
        if (key && !IsInven)
        {
            Inven();
            IsInven = true;
        }
        else if (key && IsInven)
        {
            ExitInven();
            IsInven = false;
        }
    }

    public void ExitInven()
    {
        Inventory.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Inven()
    {
        Inventory.SetActive(true);
      
    }

}