using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public class AIMovement : MonoBehaviour {

    public AICharacterControl selectedCharacterController;
    public Transform Target;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray,out hit))
            {
                Target.position = hit.point;
                selectedCharacterController.SetTarget(Target);
            }
        }
	}
}
