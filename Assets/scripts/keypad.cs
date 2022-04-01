

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keypad : MonoBehaviour
{

    // Object to be enabled 
    public GameObject objectToEnable;
    //player movement disable
    public GameObject player;
    public GameObject look;
    public GameObject deur;

    [Header("Keypad Settings")]
    public string curPassword = "123";
    public string input;
    public Text displayText;
    public AudioSource audioData;

    //Local private variables
    private bool keypadScreen;
    private float btnClicked = 0;
    private float numOfGuesses;
   [SerializeField] private Animator door = null;
    // Start is called before the first frame update
    void Start()
    {

        btnClicked = 0; 
        numOfGuesses = curPassword.Length; 

    }


    // Update is called once per frame
    void Update()
    {
        if (btnClicked == numOfGuesses)
        {
            if (input == curPassword)
            {             
    
                
                Debug.Log("Correct Password!");
                door.Play("Door_open", 0, 0.0f);
             
                input = ""; 
                btnClicked = 0;

            }
            else
            {
               
                input = "";
                displayText.text = input.ToString();
                audioData.Play();
                btnClicked = 0;
            }

        }

    }

   
    void OnGUI()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                var selection = hit.transform;

                if (selection.CompareTag("keypad")) 
                {
                    keypadScreen = true;

                    var selectionRender = selection.GetComponent<Renderer>();
                    if (selectionRender != null)
                    {
                        keypadScreen = true;
                    }
                }

            }
        }
        player.GetComponent<PlayerMovement>().enabled = true;
        look.GetComponent<MouseLook>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
      
        if (keypadScreen)
        {
            objectToEnable.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            //player movement disable
            player.GetComponent<PlayerMovement>().enabled = false;
            look.GetComponent<MouseLook>().enabled = false;
        }

    }

    public void ValueEntered(string valueEntered)
    {
        switch (valueEntered)
        {
            case "Q": // QUIT
                objectToEnable.SetActive(false);
                btnClicked = 0;
                keypadScreen = false;
                input = "";
                displayText.text = input.ToString();
                break;

            case "C": //CLEAR
                input = "";
                btnClicked = 0;// Clear Guess Count
                displayText.text = input.ToString();
                break;

            default: // Buton clicked add a variable
                btnClicked++; // Add a guess
                input += valueEntered;
                displayText.text = input.ToString();
                break;
        }


    }
}
