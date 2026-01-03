using UnityEngine;
using System.Collections;

public class chestController : MonoBehaviour
{
    private Animator anim;
    private bool opened = false;

    public string skill;

    public GameObject getSkill;

    private Saves sv;

    void Awake()
    {
        anim = GetComponent<Animator>();
        sv = FindObjectOfType<Saves>();
        getSkill.SetActive(false);
    }
    public void Open()
    {
        if(opened) return;
        opened = true;
        anim.SetTrigger("OpenChest");
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            if(skill == "Hit")
            {
               if(sv.HitUnlocked == 1)
                {

                    getSkill.SetActive(false);
                } else
                {
                    Open();
                    StartCoroutine(chestdelay());
                }
            }
        }
    }
    IEnumerator chestdelay()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("Setting Active");
        getSkill.SetActive(true);
    }
}
