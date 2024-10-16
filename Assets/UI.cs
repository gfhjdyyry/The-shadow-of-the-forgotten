using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public bool isActive = false;
    public GameObject inventory;
    
    // Start is called before the first frame update
    void Start()
    {
    StartCoroutine(CheckForButtonPress());
    }
    IEnumerator CheckForButtonPress()
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.Tab)) // «десь можно заменить на нужную клавишу
            {
                inventory.SetActive(!inventory.active);
            }
            yield return null; // ∆дем один кадр
        }
    }
    // Update is called once per frame
    void Update()
    {
 
    }
}
