using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour
{
    Animator anim;
    GameObject cam;

    CharacterController controller;

    public float velocidad = 5;

    void Start()
    {
        anim = GetComponent<Animator>();
        //anim.CrosFade("idle_01", 0.25f);
        cam = GameObject.FindWithTag("MainCamera");
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fwd = transform.position - cam.transform.position;
        fwd.y = 0;
        fwd.Normalize();
        if (Input.GetKey(KeyCode.UpArrow)) {
            controller.Move(fwd * Time.deltaTime * velocidad);
            //transform.rotation = Quaternion.LookRotation(fwd);
        }else if(Input.GetKey(KeyCode.DownArrow)){
            controller.Move(-fwd * Time.deltaTime * velocidad);
        }
    }
}
