using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SlotMachine : MonoBehaviour
{
    [SerializeField] private GameObject Wheel;
    [SerializeField] private GameObject WheelSpace;

    public List<UnityEngine.UI.Image> Slots;
    public List<UnityEngine.UI.Image> Order;
    public List<Sprite> OrderComponents;
    public Sprite[] Ingredients;

    [SerializeField] private int Coins;
    public TMP_Text CoinText;

    [SerializeField] private int Score = 0;


    private void Start()
    {
        Coins = 10;
        NewOrder();
        for (int i = 0; i < 3; i++) {
            AddWheel();
        }
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
            for (int i = 0; i < Slots.Count; i++)
            {
                SpinWheel(i);
            }
        }
    }

    public void SubmitOrder()
    {
        for (int i = 0; i < Slots.Count; i++)
        {
            for (int j = 0; j < OrderComponents.Count; j++)
            {
                if (Slots[i].sprite == OrderComponents[j])
                {
                    OrderComponents.RemoveAt(j);
                    Score += 1;
                    break;
                }
            }
        }
        Coins += Score;
        Score = 0;
        NewOrder();
    }

    public void NewOrder()
    {
        for (int i = 0; i < Order.Count; i++)
        {
            Order[i].sprite = Ingredients[Random.Range(0, Ingredients.Length - 1)];
            OrderComponents.Add(Order[i].sprite);
        }
    }

    public void SpinWheel(int WheelNo)
    {
        if (Coins > 0)
        {
            Slots[WheelNo].sprite = Ingredients[Random.Range(0, Ingredients.Length - 1)];
            Coins -= 1;
        }
    }

    public void AddWheel()
    {
        GameObject NewWheel = Instantiate(Wheel, WheelSpace.transform);
        int SlotNo = Slots.Count;
        NewWheel.transform.Find("Respin").GetComponent<UnityEngine.UI.Button>().onClick.AddListener(delegate { SpinWheel(SlotNo); });
        UnityEngine.UI.Image SlotPicture = NewWheel.transform.Find("Image").GetComponent<UnityEngine.UI.Image>();
        Slots.Add(SlotPicture);

    }
}
