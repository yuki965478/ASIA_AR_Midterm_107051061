
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("雛菊")]
    public Transform Deiji;

    [Header("可可")]
    public Transform Coco;

    [Header("虛擬搖桿")]
    public FixedJoystick joystick;

    [Header("縮放"), Range(0f, 5f)]
    public float size = 0.3f;

    [Header("旋轉速度"), Range(0.1f, 20f)]
    public float turn = 1.5f;

    [Header("雛菊動畫元件")]
    public Animator aniDeiji;
    [Header("可可動畫元件")]
    public Animator aniCoco;


    private void Start()
    {
        print("開始事件");
    }
    //public float test = 1;
    //public float test2 = 1;

    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);

        Deiji.Rotate(0, joystick.Horizontal * turn, 0);
        Coco.Rotate(0, joystick.Horizontal * turn, 0);

        Deiji.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
        Coco.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;

        Coco.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(Coco.localScale.x, 0.5f, 3.5f);
        Deiji.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(Deiji.localScale.x, 0.5f, 3.5f);
       //test= Mathf.Clamp(test, 0.5f, 9.9f);
       //print(Mathf.Clamp(test2, 0, 10));
    }
    public void Fall()
    {
        print("跌倒");
        aniDeiji.SetTrigger("跌倒觸發");
        aniCoco.SetTrigger("跌倒觸發");
    }
    public void PlayAnimution(string aniName)
    {
        print(aniName);
        aniDeiji.SetTrigger(aniName);
        aniCoco.SetTrigger(aniName);
    }

}