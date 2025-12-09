using UnityEngine;

public class move_script : MonoBehaviour
{
    [SerializeField]
    float speed;

    void Update(){
        if(Input.GetKey(KeyCode.W)){
            transform.position+=transform.forward*speed*Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S)){
            transform.position-=transform.forward*speed*Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A)){
            transform.position-=transform.right*speed*Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D)){
            transform.position+=transform.right*speed*Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.Space)){
            transform.position+=transform.up*speed*Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.LeftControl)){
            transform.position-=transform.up*speed*Time.deltaTime;
        }
    }
}