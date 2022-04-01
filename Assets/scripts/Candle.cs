using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{

    public GameObject Light;
    public GameObject Flame;

    [SerializeField] private Animator Closet = null;
    // Start is called before the first frame update
    void Start()
    {
        Light.SetActive(true);
        Flame.SetActive(true);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                var selection = hit.transform;
               

                if (selection.CompareTag("hit")) // Tag on the gameobject - Note the gameobject also needs a box collider
                {
                    Debug.Log("puzzle solved");
                    Light.SetActive(false);
                    Flame.SetActive(false);
                    Closet.Play("closet", 0, 0.0f);
                    var selectionRender = selection.GetComponent<Renderer>();
                    if (selectionRender != null)
                    {
                        
                    }
                }

            }
        }
    }
}
