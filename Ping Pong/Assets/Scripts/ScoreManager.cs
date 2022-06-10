using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private Text gawangKiriText;
    [SerializeField] private Text gawangKananText;

    private int skorKiri;
    private int skorKanan;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gawangKananText.text = skorKanan.ToString();
        gawangKiriText.text = skorKiri.ToString();
    }

    public void CetakGoal(bool kiriGawang)
    {
        if (kiriGawang)
        {
            skorKiri++;
            return;
        }

        skorKanan++;
    }
}
