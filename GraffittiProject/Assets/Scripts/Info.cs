using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Info : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject mark;
    [SerializeField] Transform camera;

    // Start is called before the first frame update
    void Awake()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //track player movements
        mark.transform.LookAt(camera.position);
        Vector3 rot = mark.transform.rotation.eulerAngles;
        rot.x = 0; rot.z = 0; rot.y += 180;
        mark.transform.rotation = Quaternion.Euler(rot);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("enter");
        //set mark text to "" and panel active

        panel.SetActive(true);
        mark.GetComponent<TMP_Text>().text = "";
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("exit");
        //set mark text to "?" and panel inactive

        panel.SetActive(false);
        mark.GetComponent<TMP_Text>().text = "?";
    }
}
