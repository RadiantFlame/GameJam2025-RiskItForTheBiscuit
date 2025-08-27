using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SlotMachine : MonoBehaviour
{
    public UnityEngine.UI.Image[] Slots;
    public Sprite[] Ingredients;

    [SerializeField] private int Coins;
    public TMP_Text CoinText;

    private void Start()
    {
        Coins = 10;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CoinText.text = "Coins: " + Coins.ToString();
    }

    public void FullSpin()
    {
        if (Coins > 0)
        {
            Coins += 2;
            for (int i = 0; i < Slots.Length; i++)
            {
                SpinWheel(i);
            }
        }
    }

    public void SpinWheel(int WheelNo)
    {
        if (Coins > 0)
        {
            Slots[WheelNo].sprite = Ingredients[Random.Range(0, 4)];
            Coins -= 1;
        }
    }

}
