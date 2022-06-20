using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private Text gawangKiriText;
    [SerializeField] private Text gawangKananText;

    private int skorKiri;
    private int skorKanan;

    [SerializeField] private int maxScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gawangKananText.text = skorKanan.ToString();
        gawangKiriText.text = skorKiri.ToString();

        if ((skorKanan >= maxScore) || (skorKiri >= maxScore))
        {
            SceneManager.LoadScene("Main Menu");
        }
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
