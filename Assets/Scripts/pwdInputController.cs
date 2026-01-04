using UnityEngine;
using TMPro;


public class pwdInputController : MonoBehaviour
{
    public TMP_InputField pwd;

    private string id;

    public WebSocketClient w;

    public void showInputPassword(string id){
        gameObject.SetActive(true);
        this.id = id;
    }

    public void sendPwd(){
        string t = pwd.text;
        if(t.Length <  2|| t.Length > 12)
        {
            t = "Random"+Random.Range(1, 1000);
        }
        w.joinByAddress(id, t);
        gameObject.SetActive(false);
    }

}
