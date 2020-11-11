
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

    [Header("旋轉速度"),Range(0.1f,20f)]
    public float turn = 1.5f;

    [Header("雛菊動畫元件")]
    public Animator aniDeiji;
    [Header("可可動畫元件")]
    public Animator aniCoco;


    private void Start()
    {
        print("開始事件");
    }

    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);

        Deiji.Rotate(0, joystick.Horizontal*turn, 0);
        Coco.Rotate(0, joystick.Horizontal*turn, 0);

        Deiji.localScale += new Vector3(1, 1, 1) * joystick.Vertical*size;
        Coco.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;

    }
}
