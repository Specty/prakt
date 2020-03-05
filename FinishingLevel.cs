using System;
using UnityEngine;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{
    public GameObject menu;
    public Rigidbody2D rb;
    private float speed;
    private bool isShowing;
    private void OnTriggerStay(Collider other)
    {
        speed = transform.Find("Player").GetComponent<HittingObstacles>().speed;
        if (speed < 2.0)
        {
            Text txt = transform.Find("dmgCounter").GetComponent<Text>();
            txt.text = Convert.ToString(transform.Find("Player").GetComponent<HittingObstacles>().totalDMG);
            isShowing = !isShowing;
            menu.SetActive(isShowing);
        }
    }
}
