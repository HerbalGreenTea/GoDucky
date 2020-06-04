using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBg : MonoBehaviour
{
    public GameObject nowBackGround, instBg;
    private GameObject newBackGround;

    private void Update()
    {
        if (StartGame.isStart)
        {
            if (nowBackGround.transform.position.x <= -1f && newBackGround == null)
                CreateNewBg();
            else if (newBackGround != null && newBackGround.transform.position.x < -1f)
                CreateNewBg();
        }
    }

    private void CreateNewBg()
    {
        if (nowBackGround.transform.position.x < -10f)
        {
            Destroy(nowBackGround);
            nowBackGround = newBackGround;
        }

        newBackGround = Instantiate(instBg, new Vector2(11.5f, -1.41f), Quaternion.identity) as GameObject;
    }
}
