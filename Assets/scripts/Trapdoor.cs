using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapdoor : MonoBehaviour
{

    [SerializeField] private Animator Hatch = null;
    // Start is called before the first frame update
    void Start()
    {
        
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


                if (selection.CompareTag("Hatch")) // Tag on the gameobject - Note the gameobject also needs a box collider
                {
                    Debug.Log("puzzle solved");
                    Hatch.Play("Hatch_Open", 0, 0.0f);
                    var selectionRender = selection.GetComponent<Renderer>();
                    if (selectionRender != null)
                    {

                    }
                }

            }
        }
    }

}
