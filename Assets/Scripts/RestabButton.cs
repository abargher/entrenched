using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestabButton : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager GM;
    public Sprite high;
    public Sprite low;
    public GameObject button;
    public RestabilizeGame boxGamePrefab;

    void Start()
    {
        GM = GameManager.instance;
    }
    public void onClickRestab()
    {
        // RestabilizeGame minigame = Instantiate(boxGamePrefab);
        // minigame.transform.position += new Vector3(0, 0, -3);
        GM.startRestab();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GM.stability <= 25) {
            button.GetComponent<Image>().sprite = low;
        } else {
            button.GetComponent<Image>().sprite = high;
        }
        
    }
}
