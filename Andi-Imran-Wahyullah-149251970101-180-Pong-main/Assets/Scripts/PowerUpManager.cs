using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    [SerializeField] private Transform spawnArea;
    [SerializeField] private int maxPowerUpAmount;
    [SerializeField] private Vector2 powerUpAreaMin;
    [SerializeField] private Vector2 powerUpAreaMax;
    [SerializeField] private List<GameObject> powerUpTemplateList;

    private List<GameObject> powerUpList;

    private float timer = 0f;
    [SerializeField] private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        powerUpList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    { 
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0;
            GenerateRandomPowerUp();
        }
    }

    public void GenerateRandomPowerUp()
    {
        GenerateRandomPowerUp(new Vector2(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), Random.Range(powerUpAreaMin.y, powerUpAreaMax.y)));
    }

    public void GenerateRandomPowerUp(Vector2 position)
    {
        if (powerUpList.Count >= maxPowerUpAmount)
            return;

        if (position.x < powerUpAreaMin.x ||
            position.x > powerUpAreaMax.x||
            position.y < powerUpAreaMin.y||
            position.y > powerUpAreaMax.y)
        {
            return;
        }

        int randomIndex = Random.Range(0, powerUpTemplateList.Count);

        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], position, Quaternion.identity, spawnArea);
        powerUp.SetActive(true);

        powerUpList.Add(powerUp);
    }

    public void RemovePowerUp(GameObject powerUp)
    {
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp()
    {
        while (powerUpList.Count > 0)
        {
            RemovePowerUp(powerUpList[0]);
        }
    }
}
