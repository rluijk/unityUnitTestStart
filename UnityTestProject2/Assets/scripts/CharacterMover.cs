using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMover : MonoBehaviour, ICharacterMover
{
    private CharacterController CharacterController;
   
    [SerializeField]
    public int Health { get;  set; }
    
    private void Awake()
    {
        CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //Debug.Log("move horizontal " + horizontal.ToString());
        //Debug.Log("move vertical" + vertical.ToString());
        CharacterController.Move(new Vector3(horizontal, 0, vertical));

    }
}
