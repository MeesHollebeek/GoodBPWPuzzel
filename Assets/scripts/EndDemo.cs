using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndDemo : MonoBehaviour
{
    public GameObject player;
    public GameObject look;
    [SerializeField] private Image  _noteImage;
    void start()
    {
        player.GetComponent<PlayerMovement>().enabled = true;
        look.GetComponent<MouseLook>().enabled = true;
    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        player.GetComponent<PlayerMovement>().enabled = false;
        look.GetComponent<MouseLook>().enabled = false;

            _noteImage.enabled = true;

    }

}
