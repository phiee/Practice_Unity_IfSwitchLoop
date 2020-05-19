using UnityEngine;
using UnityEngine.UI;

public class Practice: MonoBehaviour
{
    //封裝欄位 1.私人欄位
    //定義血量封裝欄位與讀寫權限屬性
    private float hp;
    //2.屬性：讀寫或唯讀
    public float Hp { get => sliderHp.value; set => hp = value; }

    [Header("滑桿")]
    public Slider sliderHp;
    [Header("結果")]
    public Text result;

    [Header("輸入欄位")]
    public InputField inputField;
    [Header("輸入欄位結果")]
    public Text resultInputField;


    [Header("方塊")]
    public GameObject cube;

    private void Start()
    {
        #region
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < (i + 1); j++)
            {
                Vector3 pos = new Vector3(i * 2, j * 2, 25);
                Instantiate(cube, pos, Quaternion.identity);
            }
        }

        #endregion

    }

    private void Update()
    {
        #region 練習1

        if (Hp <= 30)
        {
            result.text = "危險";
        }

        else if (Hp <= 70)
        {
            result.text = "警告";
        }

        else
        {
            result.text = "安全";
        }

        #endregion

        #region 練習2

        resultInputField.text= inputField.text == "紅水" ? "恢復血量" : inputField.text == "藍水" ? "恢復魔力" : "";
        
        #endregion

    }
}
