using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class multiplayerFill : MonoBehaviour
{
    private string id;
    private multiplayerSaves spmm;

    public TMP_InputField inputName;
    public TMP_InputField inputPwd;

    public void changeName(string id, multiplayerSaves spmm){
        gameObject.SetActive(true);
        this.id = id;
        this.spmm = spmm;
    }
    public void onOkPressed(){
        Saves sv = FindObjectOfType<Saves>();
        string nameText = inputName.text+"          ";
        string pwdText = inputPwd.text+"          ";
        if(nameText.Length < 2 || nameText.Length > 12)
        {
            nameText = "Random"+Random.Range(1, 1000);
        }
        if(pwdText.Length < 2 || pwdText.Length > 12)
        {
            pwdText = "Random"+Random.Range(1, 1000);
        }
        sv.saveRoom(nameText.Substring(0,9).Replace(" ", ""), pwdText.Substring(0, 9).Replace(" ", ""), id, "-");
        spmm.showDetails();
        gameObject.SetActive(false);
    }
}
