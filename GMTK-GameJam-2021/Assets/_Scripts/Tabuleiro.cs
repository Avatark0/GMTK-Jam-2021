using System;
using UnityEngine;

public class Tabuleiro : MonoBehaviour
{
    private bool rotateLeft;
    private bool rotateRight;
    private float rotation;
    private float rotationStep = 50;
    private float vel = 0.001f;

    private void Start(){
        rotation = transform.eulerAngles.z;
    }

    private void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("rotation = "+rotation);
            Debug.Log("transform euler = "+transform.eulerAngles.z);
        }
        
        if(rotateLeft){
            if(transform.eulerAngles.z < rotation){
                transform.Rotate(0,0,rotationStep*vel);
                if(rotation>=360 && transform.eulerAngles.z < 270){
                    rotation=0;
                    rotateLeft = false;
                    RoundZ();
                }
            }
            else{
                rotateLeft = false;
                RoundZ();
            }
        }
        if(rotateRight){
            if(transform.eulerAngles.z > rotation || (transform.eulerAngles.z==0)){
                transform.Rotate(0,0,-1*rotationStep*vel);
                if(rotation==0 && transform.eulerAngles.z > 90){
                    rotateRight = false;
                    RoundZ();
                }
            }
            else{
                rotateRight = false;
                RoundZ();
            }
        }
    }

    public void RotateLeft(){
        if(!rotateRight && !rotateLeft){
            rotation=transform.eulerAngles.z+90;
            RoundZ();
            rotateLeft = true;
        }
    }

    public void RotateRight(){
        if(!rotateRight && !rotateLeft){
            rotation=transform.eulerAngles.z-90;
            RoundZ();
            if(rotation < 0)rotation=270;
            rotateRight = true;
        }
    }

    private void RoundZ(){
        rotation = (float)Math.Round(rotation);
        if(rotation == Math.Round(transform.eulerAngles.z) || Math.Round(transform.eulerAngles.z) == 360){
            Vector3 rot = new Vector3(0,0,rotation);
            transform.eulerAngles=rot;
        }
    }
}
