using UnityEngine;

public class Buttons : MonoBehaviour
{

    private static int frameCounter;    //переменная для счета кадров(увеличени кнопок при наведении)
    

    private void OnMouseOver() {
        if(frameCounter < 5 && gameObject.name == "play_icon"){
            transform.localScale += new Vector3(0.05f, 0.05f, 0);
            frameCounter++;
        }else if(frameCounter < 4 && gameObject.name == "settings_icon"){
            transform.localScale += new Vector3(0.05f, 0.05f, 0);
            frameCounter++;
        } else if(frameCounter < 4 && gameObject.name == "question_icon"){
            transform.localScale += new Vector3(0.05f, 0.05f, 0);
            frameCounter++;
        }
        
    }
    private void OnMouseExit() {
        if(gameObject.name == "play_icon"){
            transform.localScale += new Vector3(-0.2f, -0.2f, 0);
        }else{
            transform.localScale += new Vector3(-0.2f, -0.2f, 0);
        }
        frameCounter = 0;
    }

    private void OnMouseUpAsButton() {
        
        switch (gameObject.name) {               
            case "play_icon":
                Application.LoadLevel("Play");
                break;
            
            case "settings_icon":
                Application.LoadLevel("Settings");
                break;
            
            case "question_icon":
                Application.OpenURL("https://www.youtube.com/watch?v=-4_Kr_fKEls");
                break;
        }

    }

}